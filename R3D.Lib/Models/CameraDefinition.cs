using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3D.Lib
{
    [Serializable] public class CameraDefinition
    {

        private float _degreesFOV;
        private float _farPlane;
        private float _nearPlane;

        private float _posX;
        private float _posY;
        private float _posZ;

        public float DegreesFOV
        {
            get { return _degreesFOV; }
            set { _degreesFOV = value; }
        }

        public float FarPlane
        {
            get { return _farPlane; }
            set { _farPlane = value; }
        }

        public float NearPlane
        {
            get { return _nearPlane; }
            set { _nearPlane = value; }
        }

        public float PosX
        {
            get { return _posX; }
            set { _posX = value; }
        }

        public float PosY
        {
            get { return _posY; }
            set { _posY = value; }
        }

        public float PosZ
        {
            get { return _posZ; }
            set { _posZ = value; }
        }

        public CameraDefinition() { }


    }
}
