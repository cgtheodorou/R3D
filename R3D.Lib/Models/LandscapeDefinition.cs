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


    }
}
