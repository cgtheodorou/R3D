using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R3D.Lib
{
    [Serializable]
    public class ModelDefinition
    {

        private int _id;
        private string _modelName;
        private string _filePath;
        private string _texFilePath;
        private string _texName;
        private float _posX;
        private float _posY;
        private float _posZ;
        private float _scaleX;
        private float _scaleY;
        private float _scaleZ;
        private bool _autoLoadTextures;
        private bool _autoLoadMaterials;
        private int _cullMode;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ModelName
        {
            get { return _modelName; }
            set { _modelName = value; }
        }

        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }

        public string TextureFilePath
        {
            get { return _texFilePath; }
            set { _texFilePath = value; }
        }

        public string TextureName
        {
            get { return _texName; }
            set { _texName = value; }
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

        public bool AutoLoadTextures
        {
            get { return _autoLoadTextures; }
            set { _autoLoadTextures = value;  }
        }

        public bool AutoLoadMaterials
        {
            get { return _autoLoadMaterials; }
            set { _autoLoadMaterials = value; }
        }

        public int CullMode
        {
            get { return _cullMode; }
            set { _cullMode = value; }
        }

        public ModelDefinition() { }

        public void SetPosition(float x, float y, float z)
        {
            PosX = x;
            PosY = y;
            PosZ = z;
        }

    }
}
