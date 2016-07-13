using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTV3D65;

namespace R3D.Lib
{
    [Serializable] public class LandscapeDefinition
    {

        private string _heightmap;
        private string _landTexture;
        private string _landDetail;

        public string Heightmap
        {
            get { return _heightmap; }
            set { _heightmap = value; }
        }

        public string LandTexture
        {
            get { return _landTexture; }
            set { _landTexture = value; }
        }

        public string LandDetail
        {
            get { return _landDetail; }
            set { _landDetail = value; }
        }

        public LandscapeDefinition() { }

        public void CreateLandscape(ref TVLandscape Land, ref TVScene Scene, ref TVTextureFactory TexFact, ref TVMaterialFactory MatFact, ref TVGlobals Globals)
        {

            TexFact.SetTextureMode(CONST_TV_TEXTUREMODE.TV_TEXTUREMODE_32BITS);

            //Set Landscape material
            int matNo = 0;
            matNo = MatFact.CreateMaterial("Matte");
            MatFact.SetAmbient(matNo, 0f, 0f, 0f, 0f);
            MatFact.SetDiffuse(matNo, 1f, 1f, 1f, 0.5f);
            MatFact.SetEmissive(matNo, 0f, 0f, 0f, 1f);
            MatFact.SetSpecular(matNo, 0f, 0f, 0f, 1f);
            MatFact.SetOpacity(matNo, 0.5f);

            TexFact.LoadTexture(LandTexture, "LandTexture");
            TexFact.LoadTexture(LandDetail, "LandDetail");

            Land = Scene.CreateLandscape();
            Land.SetAffineLevel(CONST_TV_LANDSCAPE_AFFINE.TV_AFFINE_HIGH);
            Land.GenerateTerrain(Heightmap, CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_HIGH, 10, 10, 0.0F, 0.0F, 0, true);

            Land.SetLightingMode(CONST_TV_LIGHTINGMODE.TV_LIGHTING_MANAGED);
            Land.SetMaterial(Globals.GetMat("Matte"));
            Land.ExpandTexture(Globals.GetTex("LandTexture"), 0, 0, 10, 10, true);
            Land.SetScale(4, 6, 4);
            Land.SetDetailTexture(Globals.GetTex("LandDetail"));
            Land.SetDetailTextureScale(6f, 6f);
            Land.SetDetailMode(CONST_TV_DETAILMAP_MODE.TV_DETAILMAP_MODULATE2X);

            Land.EnableLOD(true, 1000f, CONST_TV_LANDSCAPE_PRECISION.TV_PRECISION_VERY_LOW, 0f, false);
            Land.SetProgressiveLOD(true);

        }


    }
}
