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
        private int _id;
        private KeyValuePair<String, String> _engineSettings;
        private List<MeshDefinition> _entityManager;
        private SkyboxDefinition _skybox;
        private LandscapeDefinition _landscape;
        private WaterPlaneDefinition _water;
        private CameraDefinition _camera;

        //properties
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public List<MeshDefinition> EntityManager
        {
            get { return _entityManager; }
            set { _entityManager = value; }
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

        public void LoadMeshesFromEM(ref List<TVMesh> RawEntityManager, ref List<MeshDefinition> EntityManager, ref TVScene Scene, ref TVTextureFactory TexFact)
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

                RawEntityManager.Add(Mesh);
                
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
            this.ID = loadW.ID;

        }

        public void SaveWorld(string FilePath)
        {
  
            XmlSerializer serializer = new XmlSerializer(typeof(R3DWorld));

            StreamWriter writer = File.CreateText(FilePath);

            serializer.Serialize(writer, this);

            writer.Close();
        }

    }

}
