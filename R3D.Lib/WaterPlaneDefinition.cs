using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTV3D65;

namespace R3D.Lib
{
    [Serializable] public class WaterPlaneDefinition
    {

        private string _volumeTexture;
        private string _WaterAlpha;
        private float _waterHeight;

        // Height of the water plane
        public float WATER_HEIGHT = 30f;
        // Fix for reflection glitches where water hits the land
        public float FIX_DISTANCE = 10f;

        [NonSerialized]
        public TVShader waterShader_withAlpha;
        [NonSerialized]
        public TVShader waterShader;
        [NonSerialized]
        public TVMesh near_water;
        [NonSerialized]
        public TVMesh distant_water0;
        [NonSerialized]
        public TVMesh distant_water1;
        [NonSerialized]
        public TVMesh distant_water2;
        [NonSerialized]
        public TVMesh distant_water3;
        [NonSerialized]
        public TV_3DMATRIX reflectMat = new TV_3DMATRIX();
        [NonSerialized]
        public TV_3DVECTOR waterVec;
        [NonSerialized]
        public TV_PLANE waterPlane;
        [NonSerialized]
        public TVRenderSurface reflectRS;




        public WaterPlaneDefinition() { }

        public void CreateWaterPlane(ref TVTextureFactory TexFact, ref TVScene Scene, ref TVCamera Camera, ref TVMathLibrary Maths, ref TVGlobals Globals)
        {

            // Load related textures for the 1st time
            // Comment/uncomment the right texture depending on the method you use
            TexFact.LoadVolumeTexture("Media\\\\Textures\\\\Water\\\\VolumeNormalMap.dds", "WaterVolume", CONST_TV_COLORKEY.TV_COLORKEY_USE_ALPHA_CHANNEL, true);
            //TexFact.LoadTexture("Media\\Textures\\Water\\DualLookupNormalMap.dds", "WaterDual")
            TexFact.LoadTexture("Media\\\\Textures\\\\Water\\\\islandalpha1.dds", "WaterAlpha1");

            waterPlane = new TV_PLANE(new TV_3DVECTOR(0, 1, 0), -WATER_HEIGHT);

            // Rendersurfaces init
            reflectRS = Scene.CreateRenderSurface(384, 384, true, CONST_TV_RENDERSURFACEFORMAT.TV_TEXTUREFORMAT_X8R8G8B8);
            reflectRS.SetNewCamera(Camera);

            // Water init
            near_water = Scene.CreateMeshBuilder("WaterNear");
            // The texture tiling of the grid defines how tiled the waves will be
            near_water.AddFloorGrid(1, 0, 0, 2560, 2560, 1, 1, WATER_HEIGHT, 1, 1);
            near_water.SetTextureEx(0, reflectRS.GetTexture());

            // Comment/uncomment the right texture depending on the method you use
            near_water.SetTextureEx(1, Globals.GetTex("WaterVolume"));
            //water.SetTextureEx(1, Globals.GetTex("WaterDual"))

            near_water.SetLightingMode(CONST_TV_LIGHTINGMODE.TV_LIGHTING_NORMAL);
            near_water.SetCullMode(CONST_TV_CULLING.TV_DOUBLESIDED);

            waterShader_withAlpha = Scene.CreateShader("WaterShader_WithAlpha");
            waterShader_withAlpha.CreateFromEffectFile("Media\\\\Shaders\\\\WaterShader_WithAlpha.fx");
            near_water.SetShader(waterShader_withAlpha);

            waterShader_withAlpha.SetEffectParamTexture("texAlpha", Globals.GetTex("WaterAlpha1"));

            distant_water0 = Scene.CreateMeshBuilder("WaterDistant0");
            distant_water0.AddFloorGrid(1, -5120, -5120, 7680, 0, 1, 1, WATER_HEIGHT, 5, 3);

            distant_water1 = Scene.CreateMeshBuilder("WaterDistant1");
            distant_water1.AddFloorGrid(1, -5120, 2560, 7680, 7680, 1, 1, WATER_HEIGHT, 5, 3);

            distant_water2 = Scene.CreateMeshBuilder("WaterDistant2");
            distant_water2.AddFloorGrid(1, -5120, 0, 0, 2560, 1, 1, WATER_HEIGHT, 2, 1);

            distant_water3 = Scene.CreateMeshBuilder("WaterDistant3");
            distant_water3.AddFloorGrid(1, 2560, 0, 7680, 2560, 1, 1, WATER_HEIGHT, 2, 1);


            distant_water0.SetTextureEx(0, reflectRS.GetTexture());
            distant_water0.SetTextureEx(1, Globals.GetTex("WaterVolume"));
            //distant_water0.SetTextureEx(1, Globals.GetTex("WaterDual"))   'set this to other planes also if you want the other rendering technique 
            distant_water0.SetLightingMode(CONST_TV_LIGHTINGMODE.TV_LIGHTING_NORMAL);
            distant_water0.SetCullMode(CONST_TV_CULLING.TV_DOUBLESIDED);

            distant_water1.SetTextureEx(0, reflectRS.GetTexture());
            distant_water1.SetTextureEx(1, Globals.GetTex("WaterVolume"));
            distant_water1.SetLightingMode(CONST_TV_LIGHTINGMODE.TV_LIGHTING_NORMAL);
            distant_water1.SetCullMode(CONST_TV_CULLING.TV_DOUBLESIDED);

            distant_water2.SetTextureEx(0, reflectRS.GetTexture());
            distant_water2.SetTextureEx(1, Globals.GetTex("WaterVolume"));
            distant_water2.SetLightingMode(CONST_TV_LIGHTINGMODE.TV_LIGHTING_NORMAL);
            distant_water2.SetCullMode(CONST_TV_CULLING.TV_DOUBLESIDED);

            distant_water3.SetTextureEx(0, reflectRS.GetTexture());
            distant_water3.SetTextureEx(1, Globals.GetTex("WaterVolume"));
            distant_water3.SetLightingMode(CONST_TV_LIGHTINGMODE.TV_LIGHTING_NORMAL);
            distant_water3.SetCullMode(CONST_TV_CULLING.TV_DOUBLESIDED);

            waterShader = Scene.CreateShader("WaterShader");
            waterShader.CreateFromEffectFile("Media\\\\Shaders\\\\WaterShader.fx");

            distant_water0.SetShader(waterShader);
            distant_water1.SetShader(waterShader);
            distant_water2.SetShader(waterShader);
            distant_water3.SetShader(waterShader);

            Maths.TVPlaneNormalize(ref waterPlane, waterPlane);

        }

        public void RenderWater()
        {
            near_water.Render();

            distant_water0.Render();
            distant_water1.Render();
            distant_water2.Render();
            distant_water3.Render();

        }

        public void UpdateWater(ref TVCamera Camera, ref TVMathLibrary Maths)
        {

            //View matrix reflection 1
            TV_3DMATRIX view = Camera.GetMatrix();
            TV_3DMATRIX reflView = Camera.GetRotationMatrix();
            reflView.m41 = Camera.GetPosition().x;
            reflView.m42 = Camera.GetPosition().y;
            reflView.m43 = Camera.GetPosition().z;
            Maths.TVMatrixReflect(ref reflectMat, waterPlane);
            reflView *= reflectMat;

            // View matrix reflection 2
            // Using two reflections allows not to reverse the culling mode on reflected geometry
            TV_PLANE comb = new TV_PLANE();
            TV_3DVECTOR vec = new TV_3DVECTOR(reflView.m41, reflView.m42, reflView.m43);
            TV_3DVECTOR vec2 = vec + new TV_3DVECTOR(reflView.m31, reflView.m32, reflView.m33);
            TV_3DVECTOR vec3 = vec + new TV_3DVECTOR(reflView.m21, reflView.m22, reflView.m23);
            Maths.TVPlaneFromPoints(ref comb, vec, vec2, vec3);
            Maths.TVMatrixReflect(ref reflectMat, comb);
            reflView *= reflectMat;

            //Transform clipping plane
            TV_3DMATRIX invTransView = new TV_3DMATRIX();
            Maths.TVMatrixTranspose(ref invTransView, reflView);
            TV_4DVECTOR clipPlane = new TV_4DVECTOR();
            Maths.TVVec4Transform(ref clipPlane, new TV_4DVECTOR(waterPlane.Normal.x, waterPlane.Normal.y, waterPlane.Normal.z, waterPlane.Dist + FIX_DISTANCE), invTransView);

            //Set oblique depth projection matrix
            //See http://www.terathon.com/code/oblique.html
            TV_3DMATRIX proj = Camera.GetProjectionMatrix();
            TV_3DMATRIX culledProj = proj;
            TV_4DVECTOR q = new TV_4DVECTOR();
            q.x = Math.Sign(clipPlane.x) / culledProj.m11;
            q.y = Math.Sign(clipPlane.y) / culledProj.m22;
            q.z = 1f;
            q.w = (1f - culledProj.m33) / culledProj.m43;
            TV_4DVECTOR scaledPlaneVector = clipPlane * (1f / (clipPlane * q));
            culledProj.m13 = scaledPlaneVector.x;
            culledProj.m23 = scaledPlaneVector.y;
            culledProj.m33 = scaledPlaneVector.z;
            culledProj.m43 = scaledPlaneVector.w;

            Camera.SetMatrix(reflView);
            reflectRS.StartRender();
            //RenderDistant before setting the projection means that the skybox/far geometry111111
            //won't be culled at height = waterplane + fix... Looks better this way.
            //RenderDistant();
            Camera.SetCustomProjection(culledProj);
            //RenderEnvironment();
            reflectRS.EndRender();

            Camera.SetCustomProjection(proj);
            Camera.SetMatrix(view);

        }

    }
}
