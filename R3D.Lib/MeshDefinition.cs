using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MTV3D65;

namespace R3D.Lib
{
    [Serializable] public class MeshDefinition
    {

        private int _id;
        private string _meshName;
        private string _texture;
        private string _texName;
        private bool _isWall;
        private float _X1;
        private float _Z1;
        private float _X2;
        private float _Z2;
        private float _height;
        private float _altitude;
        private float _tileWidth;
        private float _tileHeight;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string MeshName
        {
            get { return _meshName; }
            set { _meshName = value; }
        }
        public string Texture
        {
            get { return _texture; }
            set { _texture = value; }
        }

        public string TextureName
        {
            get { return _texName; }
            set { _texName = value; }
        }

        public bool IsWall
        {
            get { return _isWall; }
            set { _isWall = value; }
        }

        public float X1
        {
            get { return _X1; }
            set { _X1 = value; }
        }

        public float Z1
        {
            get { return _Z1; }
            set { _Z1 = value; }
        }


        public float X2
        {
            get { return _X2; }
            set { _X2 = value; }
        }

        public float Z2
        {
            get { return _Z2; }
            set { _Z2 = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public float Altitude
        {
            get { return _altitude; }
            set { _altitude = value; }
        }

        public float TileWidth
        {
            get { return _tileWidth; }
            set { _tileWidth = value; }
        }

        public float TileHeight        {
            get { return _tileHeight; }
            set { _tileHeight = value; }
        }

        public MeshDefinition() { }

        public MeshDefinition(string texture, string texturename, bool iswall, float x1, float z1, float x2, float z2, float height, float altitude, float tilewidth, float tileheight) {
            Texture = texture;
            TextureName = texturename;
            IsWall = iswall;
            X1 = x1;
            Z1 = z1;
            X2 = x2;
            Z2 = z2;
            Height = height;
            Altitude = altitude;
            TileWidth = tilewidth;
            TileHeight = tileheight;
        }

        public void CreateMesh(ref List<TVMesh> RawEntityManager, ref List<MeshDefinition> EntityManager, ref TVScene Scene, ref TVTextureFactory TexFact)
        {

            TVMesh Mesh = null;
            MeshDefinition MeshDef = null;
            int mIndex=0;

            for (int i = 0; i < EntityManager.Count; i++)
            {
                if (EntityManager[i].MeshName == this.MeshName)
                {
                    MeshDef = EntityManager[i];
                    mIndex = i;
                    break;
                }
            }
            
            if (MeshDef != null) {
                Mesh = RawEntityManager[mIndex];
                RawEntityManager.RemoveAt(mIndex);
                EntityManager.RemoveAt(mIndex);
                Mesh.Destroy();
                Mesh = null;

                Mesh = new TVMesh();
                Mesh = Scene.CreateMeshBuilder();
            }
            else
            {
                Mesh = new TVMesh();
                Mesh = Scene.CreateMeshBuilder();
            }


            int MeshTexID = TexFact.LoadTexture(Texture, TextureName);

            if (IsWall)
            {
                Mesh.AddWall(MeshTexID, X1, Z1, X2, Z2, Height, Altitude, TileWidth, TileHeight);
            }
            else
            {
                Mesh.AddFloor(MeshTexID, X1, Z1, X2, Z2, Altitude, TileWidth, TileHeight);
            }

            RawEntityManager.Add(Mesh);
            this.ID = RawEntityManager.Count + 1;
            this.MeshName = Mesh.GetMeshName();
            EntityManager.Add(this);
        }


    }
}
