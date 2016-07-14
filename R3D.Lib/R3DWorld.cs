using MTV3D65;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace R3D.Lib
{
    [Serializable]
    public class R3DWorld
    {

        //vars
        public List<MeshDefinition> _entityManager = new List<MeshDefinition>();
        public List<LandscapeDefinition> _landscapeManager = new List<LandscapeDefinition>();
        public List<ModelDefinition> _modelManager = new List<ModelDefinition>();

        [NonSerialized]
        public List<TVMesh> _nativeEntityManager = new List<TVMesh>();
        [NonSerialized]
        public List<TVLandscape> _nativeLandscapeManager = new List<TVLandscape>();
        [NonSerialized]
        public List<TVMesh> _nativeModelManager = new List<TVMesh>();

        private SkyboxDefinition _skybox;
        private LandscapeDefinition _landscape;
        private WaterPlaneDefinition _water;
        private CameraDefinition _camera;

        //properties
        public List<MeshDefinition> EntityManager
        {
            get { return _entityManager; }
            set { _entityManager = value; }
        }

        public List<LandscapeDefinition> LandscapeManager
        {
            get { return _landscapeManager; }
            set { _landscapeManager = value; }
        }

        public List<ModelDefinition> ModelManager
        {
            get { return _modelManager; }
            set { _modelManager = value; }
        }

        public  List<TVMesh> NativeEntityManager 
        {
            get { return _nativeEntityManager; }
            set { _nativeEntityManager = value; }
        }

        public List<TVLandscape> NativeLandscapeManager
        {
            get { return _nativeLandscapeManager; }
            set { _nativeLandscapeManager = value; }
        }

        public List<TVMesh> NativeModelManager
        {
            get { return _nativeModelManager; }
            set { _nativeModelManager = value; }
        }


        public SkyboxDefinition SkyBox
        {
            get { return _skybox; }
            set { _skybox = value; }
        }

        public LandscapeDefinition Landscape
        {
            get { return _landscape; }
            set { _landscape = value; }
        }

        public WaterPlaneDefinition Water
        {
            get { return _water; }
            set { _water = value; }
        }

        public CameraDefinition Camera
        {
            get
            {
                if (_camera == null)
                {
                    _camera = new CameraDefinition();
                    _camera.DegreesFOV = 75f;
                    _camera.FarPlane = 100000f;
                    _camera.NearPlane = 1f;
                    _camera.PosX = 0f;
                    _camera.PosY = 0f;
                    _camera.PosZ = 0f;
                    return _camera;
                }
                else
                {
                    return _camera;
                }
            }
            set { _camera = value; }
        }

        public R3DWorld( ) { }

        public void LoadMeshesFromEM(ref TVScene Scene, ref TVTextureFactory TexFact)
        {

            foreach (var item in EntityManager)
            {
                TVMesh Mesh;
                Mesh = Scene.CreateMeshBuilder();

                int MeshTexID = TexFact.LoadTexture(item.Texture, item.TextureName);

                if (item.IsWall)
                {
                    Mesh.AddWall(MeshTexID, item.X1, item.Z1, item.X2, item.Z2, item.Height, item.Altitude, item.TileWidth, item.TileHeight);
                }
                else
                {
                    Mesh.AddFloor(MeshTexID, item.X1, item.Z1, item.X2, item.Z2, item.Altitude, item.TileWidth, item.TileHeight);
                }

                NativeEntityManager.Add(Mesh);
                
                //destroy ref after use
                Mesh = null;

            }

        }

        public void LoadWorld(string FilePath)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(R3DWorld));

            StreamReader reader = File.OpenText(FilePath);

            R3DWorld loadW = serializer.Deserialize(reader) as R3DWorld;

            this.Camera = loadW.Camera;
            this.EntityManager = loadW.EntityManager;
            this.SkyBox = loadW.SkyBox;
            this.Water = loadW.Water;
            this.Landscape = loadW.Landscape;

        }

        public void SaveWorld(string FilePath)
        {
  
            XmlSerializer serializer = new XmlSerializer(typeof(R3DWorld));

            StreamWriter writer = File.CreateText(FilePath);

            serializer.Serialize(writer, this);

            writer.Close();
        }

        public void CreateModel(ref ModelDefinition R3DModel, ref TVScene Scene, ref TVTextureFactory TexFact, ref TVGlobals Globals)
        {
            TVMesh NativeMesh = null;
            ModelDefinition ModelDef = null;
            int mIndex = 0;

            for (int i = 0; i < ModelManager.Count; i++)
            {
                if (ModelManager[i].ModelName == R3DModel.ModelName)
                {
                    ModelDef = ModelManager[i];
                    mIndex = i;
                    break;
                }
            }

            if (ModelDef != null)
            {
                NativeModelManager[mIndex].Destroy();
                NativeModelManager[mIndex] = null;
                NativeModelManager.RemoveAt(mIndex);
                ModelManager.RemoveAt(mIndex);
            }

            NativeMesh = new TVMesh();
            NativeMesh = Scene.CreateMeshBuilder(R3DModel.ModelName);

            NativeMesh.LoadXFile(R3DModel.FilePath, R3DModel.AutoLoadTextures, R3DModel.AutoLoadMaterials);
            NativeMesh.SetCullMode(MTV3D65.CONST_TV_CULLING.TV_DOUBLESIDED);

            if (R3DModel.AutoLoadTextures == false)
            {
                TexFact.LoadTexture(R3DModel.TextureFilePath, R3DModel.TextureName);
                NativeMesh.SetTexture(Globals.GetTex(R3DModel.TextureName));
            }

            NativeMesh.SetPosition(R3DModel.PosX, R3DModel.PosY, R3DModel.PosZ);
            NativeMesh.SetScale(R3DModel.ScaleX, R3DModel.ScaleY, R3DModel.ScaleZ);

            R3DModel.ID = NativeEntityManager.Count + 1;
            ModelManager.Add(R3DModel);
            NativeModelManager.Add(NativeMesh);
        }

        public void CreateMesh(ref MeshDefinition R3DMesh, ref TVScene Scene, ref TVTextureFactory TexFact)
        {

            TVMesh NativeMesh = null;
            MeshDefinition MeshDef = null;
            int mIndex = 0;

            for (int i = 0; i < EntityManager.Count; i++)
            {
                if (EntityManager[i].MeshName == R3DMesh.MeshName)
                {
                    MeshDef = EntityManager[i];
                    mIndex = i;
                    break;
                }
            }
            
            if (MeshDef != null)
            {
                NativeEntityManager[mIndex].Destroy();
                NativeEntityManager[mIndex] = null;
                NativeEntityManager.RemoveAt(mIndex);
                EntityManager.RemoveAt(mIndex);
            }

            NativeMesh = new TVMesh();
            NativeMesh = Scene.CreateMeshBuilder(R3DMesh.MeshName);

            int MeshTexID = TexFact.LoadTexture(R3DMesh.Texture, R3DMesh.TextureName);

            if (R3DMesh.IsWall)
            {
                NativeMesh.AddWall(MeshTexID, R3DMesh.X1, R3DMesh.Z1, R3DMesh.X2, R3DMesh.Z2, R3DMesh.Height, R3DMesh.Altitude, R3DMesh.TileWidth, R3DMesh.TileHeight);
            }
            else
            {
                NativeMesh.AddFloor(MeshTexID, R3DMesh.X1, R3DMesh.Z1, R3DMesh.X2, R3DMesh.Z2, R3DMesh.Altitude, R3DMesh.TileWidth, R3DMesh.TileHeight);
            }

            R3DMesh.ID = NativeEntityManager.Count + 1;
            EntityManager.Add(R3DMesh);
            NativeEntityManager.Add(NativeMesh);

        }

        public void CreateLandscape(ref LandscapeDefinition R3DLand, ref TVLandscape Land, ref TVScene Scene, ref TVTextureFactory TexFact, ref TVMaterialFactory MatFact, ref TVGlobals Globals)
        {
            //free up memory
            Land = null;

            TexFact.SetTextureMode(CONST_TV_TEXTUREMODE.TV_TEXTUREMODE_32BITS);

            //Set Landscape material
            int matNo = 0;
            matNo = MatFact.CreateMaterial("Matte");
            MatFact.SetAmbient(matNo, 0f, 0f, 0f, 0f);
            MatFact.SetDiffuse(matNo, 1f, 1f, 1f, 0.5f);
            MatFact.SetEmissive(matNo, 0f, 0f, 0f, 1f);
            MatFact.SetSpecular(matNo, 0f, 0f, 0f, 1f);
            MatFact.SetOpacity(matNo, 0.5f);

            TexFact.LoadTexture(R3DLand.LandTexture, "LandTexture");
            TexFact.LoadTexture(R3DLand.LandDetail, "LandDetail");

            Land = Scene.CreateLandscape();
            Land.SetAffineLevel(CONST_TV_LANDSCAPE_AFFINE.TV_AFFINE_HIGH);
            Land.GenerateTerrain(R3DLand.Heightmap, CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_HIGH, 10, 10, 0.0F, 0.0F, 0, true);

            Land.SetLightingMode(CONST_TV_LIGHTINGMODE.TV_LIGHTING_MANAGED);
            Land.SetMaterial(Globals.GetMat("Matte"));
            Land.ExpandTexture(Globals.GetTex("LandTexture"), 0, 0, 10, 10, true);
            Land.SetScale(4, 6, 4);
            Land.SetDetailTexture(Globals.GetTex("LandDetail"));
            Land.SetDetailTextureScale(6f, 6f);
            Land.SetDetailMode(CONST_TV_DETAILMAP_MODE.TV_DETAILMAP_MODULATE2X);

            Land.EnableLOD(true, 1000f, CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_VERY_LOW, 0f, false);
            Land.SetProgressiveLOD(true);
            
            LandscapeManager.Add(R3DLand);
            NativeLandscapeManager.Add(Land);
        }



    }

}
