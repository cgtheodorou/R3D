using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTV3D65;

namespace R3D.Lib
{
   [Serializable] public class SkyboxDefinition
    {

        private string _texNegativeX;
        private string _texNegativeY;
        private string _texNegativeZ;
        private string _texPositiveX;
        private string _texPositiveY;
        private string _texPositiveZ;
        private float _scaleX;
        private float _scaleY;
        private float _scaleZ;

        public string TexNegativeX
        {
            get { return _texNegativeX; }
            set { _texNegativeX = value; }
        }

        public string TexNegativeY
        {
            get { return _texNegativeY; }
            set { _texNegativeY = value; }
        }

        public string TexNegativeZ
        {
            get { return _texNegativeZ; }
            set { _texNegativeZ = value; }
        }

        public string TexPositiveX
        {
            get { return _texPositiveX; }
            set { _texPositiveX = value; }
        }

        public string TexPositiveY
        {
            get { return _texPositiveY; }
            set { _texPositiveY = value; }
        }

        public string TexPositiveZ
        {
            get { return _texPositiveZ; }
            set { _texPositiveZ = value; }
        }

        public float ScaleX
        {
            get { return _scaleX; }
            set { _scaleX = value; }
        }

        public float ScaleY
        {
            get { return _scaleY; }
            set { _scaleY = value; }
        }

        public float ScaleZ
        {
            get { return _scaleZ; }
            set { _scaleZ = value; }
        }


        public SkyboxDefinition() { }

        public void CreateSkybox(ref TVTextureFactory TexFact, ref TVAtmosphere Atmo, ref TVGlobals Globals)
        {
            TexFact.LoadTexture(TexNegativeX, "SB_Nx");
            TexFact.LoadTexture(TexNegativeY, "SB_Ny");
            TexFact.LoadTexture(TexNegativeZ, "SB_Nz");
            TexFact.LoadTexture(TexPositiveX, "SB_Px");
            TexFact.LoadTexture(TexPositiveY, "SB_Py");
            TexFact.LoadTexture(TexPositiveZ, "SB_Pz");

            Atmo.SkyBox_Enable(true);
            Atmo.SkyBox_SetScale(ScaleX, ScaleY, ScaleZ);
            Atmo.SkyBox_SetTexture(Globals.GetTex("SB_Px"), Globals.GetTex("SB_Nx"), Globals.GetTex("SB_Nz"), Globals.GetTex("SB_Pz"), Globals.GetTex("SB_Py"), Globals.GetTex("SB_Ny"));
        }

    }
}
