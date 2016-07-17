using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MTV3D65;
using System.IO;
using R3D.Lib;

namespace R3D
{
    public partial class Editor : Form
    {

        //Declarations
        public R3DWorld World;
        public bool DoLoop;

        public TVViewport viewPort;
        public TVEngine Engine;
        public TVLandscape Land;
        public TVTextureFactory TexFact;
        public TVScene Scene;
        public TVInputEngine Inputs;
        public TVGlobals Globals;
        public TVCamera Camera;
        public TVAtmosphere Atmo;
        public TVScreen2DText ScreenText;
        public TVLightEngine Lights;
        public TVMaterialFactory MatFact;
        public TVMathLibrary Maths;
        public TVScreen2DImmediate Screen2D;
        public TVScreen2DText Text2D;

        private TVCollisionResult CollisionResult;
        private TVMesh selectedMesh;

        public List<KeyValuePair<string, string>> pendingTasks;

        enum EditorMode { MOVE, SCALE };
        private EditorMode editMode = 0;

        private float sngPositionX;
        private float sngPositionY;
        private float sngPositionZ;
        private float snglookatX;
        private float snglookatY;
        private float snglookatZ;
        private float sngAngleX;
        private float sngAngleY;
        private float sngWalk;
        private float sngStrafe;

        //Engine Settings
        public bool vSyncON = true;
        public bool initKeys = true;
        public bool initMouse = true;
        public bool drawEditGrid = true;

        public Editor()
        {

            InitializeComponent();

            BindEvents();

            pendingTasks = new List<KeyValuePair<string, string>>();

            InitTV();

            InitCore();

            DoLoop = true;
            Main_Loop();

        }

        private void BindEvents()
        {
            //Form Events
            this.FormClosing += Editor_FormClosing;
            lstEntities.MouseDoubleClick += lstEntities_MouseDoubleClick;
            lstModels.MouseDoubleClick += lstModels_MouseDoubleClick;
        }

        private void InitTV()
        {
            Engine = new TVEngine();
            Scene = new TVScene();
            Inputs = new TVInputEngine();
            Atmo = new TVAtmosphere();
            MatFact = new TVMaterialFactory();
            TexFact = new TVTextureFactory();
            Globals = new TVGlobals();
            Maths = new TVMathLibrary();
            Screen2D = new TVScreen2DImmediate();
            Text2D = new TVScreen2DText();
            Lights = new TVLightEngine();
            Camera = new TVCamera();
        }

        private void InitCore()
        {

            if (World == null) { World = new R3DWorld(); }

            //set the media path for the world
            World.MediaPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Media\\";

            Engine.SetSearchDirectory(Application.StartupPath);

            Engine.Init3DWindowed(WorldViewPort.Handle);

            viewPort = Engine.GetViewport();
            viewPort.SetAutoResize(true);
            
            Engine.DisplayFPS(true);

            Engine.SetAngleSystem(MTV3D65.CONST_TV_ANGLE.TV_ANGLE_DEGREE);

            Engine.SetDebugFile("C:\\debug.txt");
            Engine.SetDebugMode(true);

            if (initKeys != false || initMouse != false)
            {
                Inputs.Initialize(initKeys, initMouse);
            }

            if (vSyncON)
            {
                Engine.SetVSync(vSyncON);
            }

            //Init Camera
            Engine.SetCamera(Camera);
            Camera.SetViewFrustum(World.Camera.DegreesFOV, World.Camera.FarPlane, World.Camera.NearPlane);

            sngPositionX = World.Camera.PosX;
            sngPositionY = World.Camera.PosY;
            sngPositionZ = World.Camera.PosZ;

            this.Show();
            this.Focus();

        }

        private void Main_Loop()
        {

            do
            {

                Editor_Logic();

                Check_Movement();

                if (World.Water != null)
                {
                    World.Water.UpdateWater(ref Camera, ref Maths);
                }

                Engine.Clear();

                Scene.RenderAllMeshes();

                Atmo.Clouds_Render();
                RenderDistant();
                RenderEnvironment();

                if (World.Water != null)
                {
                    World.Water.RenderWater();
                }

                Text2D.Action_BeginText();
                Text2D.TextureFont_DrawText("X:" + sngPositionX, 10, 30, Globals.RGBA(1, 1, 1, 1));
                Text2D.TextureFont_DrawText("Y:" + sngPositionY, 10, 50, Globals.RGBA(1, 1, 1, 1));
                Text2D.TextureFont_DrawText("Z:" + sngPositionZ, 10, 70, Globals.RGBA(1, 1, 1, 1));

                Text2D.TextureFont_DrawText("LookX:" + snglookatX, 10, 90, Globals.RGBA(1, 1, 1, 1));
                Text2D.TextureFont_DrawText("LookY:" + snglookatY, 10, 110, Globals.RGBA(1, 1, 1, 1));
                Text2D.TextureFont_DrawText("LookZ:" + snglookatZ, 10, 130, Globals.RGBA(1, 1, 1, 1));

                Text2D.TextureFont_DrawText("Edit Mode:" + editMode.ToString(), 10, 150, Globals.RGBA(1, 1, 1, 1));
                Text2D.Action_EndText();

                if (drawEditGrid)
                {
                    Draw_Editor_Grid();
                }

                Engine.RenderToScreen();

                Application.DoEvents();

            } while (DoLoop == true);

            Destroy();
            ExecutePending();
        }

        public void RenderDistant()
        {
            if (Atmo != null) { Atmo.Atmosphere_Render(); }
        }

        public void RenderEnvironment()
        {
            if (Land != null) { Land.Render(); }   
        }

        private void Editor_Logic()
        {
            // Camera Movement
            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_W) == true)
            {
                sngWalk = 1;
            }
            else if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_S) == true)
            {
                sngWalk = -1;
            }

            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_A) == true)
            {
                sngStrafe = 1;
            }
            else if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_D) == true)
            {
                sngStrafe = -1;
            }

            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_Q) == true)
            {
                int tmpMouseLookX = 0;
                int tmpMouseLookY = 0;

                Inputs.GetMouseState(ref tmpMouseLookX, ref tmpMouseLookY);

                sngAngleX = sngAngleX - ((float)tmpMouseLookY / 100);
                sngAngleY = sngAngleY - ((float)tmpMouseLookX / 100);
            }

            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_R) == true)
            {
                sngPositionX = 0f;
                sngPositionY = 0f;
                sngPositionZ = 0f;
            }

            //

            //change edit mode
            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_M) == true)
            {
                switch (editMode)
                {
                    case EditorMode.MOVE:
                        editMode = EditorMode.SCALE;
                        break;
                    case EditorMode.SCALE:
                        editMode = EditorMode.MOVE;
                        break;
                    default:
                        break;
                }
            }

            int tmpMouseX = 0, tmpMouseY = 0;
            bool tmpMouseB1 = false;

            Inputs.GetAbsMouseState(ref tmpMouseX, ref tmpMouseY, ref tmpMouseB1);

            if (tmpMouseB1)
            {

                CollisionResult = Scene.MousePick(tmpMouseX, tmpMouseY, 1, CONST_TV_TESTTYPE.TV_TESTTYPE_BOUNDINGBOX);

                if (CollisionResult.IsCollision())
                {
                    selectedMesh?.ShowBoundingBox(false);
                    selectedMesh = CollisionResult.GetCollisionMesh();
                    selectedMesh.ShowBoundingBox(true,Globals.Colorkey(CONST_TV_COLORKEY.TV_COLORKEY_GREEN));
                    ShowSelected();
                }

            }

            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_UPARROW))
            {

                if (selectedMesh != null)
                {

                    if (editMode == EditorMode.MOVE)
                    {
                        TV_3DVECTOR pos = selectedMesh.GetPosition();
                        selectedMesh.SetPosition(pos.x, pos.y + 1, pos.z);
                    }
                    else if (editMode == EditorMode.SCALE)
                    {
                        TV_3DVECTOR scale = selectedMesh.GetScale();
                        selectedMesh.SetScale(scale.x, scale.y + 0.001f, scale.z);
                    }

                }

            }

            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_DOWNARROW))
            {

                if (selectedMesh != null)
                {
                    if (editMode == EditorMode.MOVE)
                    {
                        TV_3DVECTOR pos = selectedMesh.GetPosition();
                        selectedMesh.SetPosition(pos.x, pos.y - 1, pos.z);
                    }
                    else if (editMode == EditorMode.SCALE)
                    {
                        TV_3DVECTOR scale = selectedMesh.GetScale();
                        selectedMesh.SetScale(scale.x, scale.y - 0.001f, scale.z);
                    }
                }

            }

            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_LEFTARROW))
            {

                if (selectedMesh != null)
                {
                    if (editMode == EditorMode.MOVE)
                    {
                        TV_3DVECTOR pos = selectedMesh.GetPosition();
                        selectedMesh.SetPosition(pos.x, pos.y, pos.z + 1);
                    }
                    else if (editMode == EditorMode.SCALE)
                    {
                        TV_3DVECTOR scale = selectedMesh.GetScale();
                        selectedMesh.SetScale(scale.x, scale.y, scale.z + 0.001f);
                    }
                }

            }

            if (Inputs.IsKeyPressed(CONST_TV_KEY.TV_KEY_RIGHTARROW))
            {

                if (selectedMesh != null)
                {
                    if (editMode == EditorMode.MOVE)
                    {
                        TV_3DVECTOR pos = selectedMesh.GetPosition();
                        selectedMesh.SetPosition(pos.x, pos.y, pos.z - 1);
                    }
                    else if (editMode == EditorMode.SCALE)
                    {
                        TV_3DVECTOR scale = selectedMesh.GetScale();
                        selectedMesh.SetScale(scale.x, scale.y, scale.z - 0.001f);
                    }
                }

            }

        }

        private void ShowSelected()
        {
            MeshDefinition R3DMesh = World.EntityManager.Find(x => x.MeshName == selectedMesh.GetMeshName());
            lstEntities.SelectedItem = R3DMesh;
        }

        private void Draw_Editor_Grid()
        {
            int lines = 0;
            do
            {
                lines += 100;
                Screen2D.Draw_Line3D(1, 1, lines, 2000, 1, lines, Globals.RGBA(0, 1, 0, 1), Globals.RGBA(0, 1, 0, 1));
                Screen2D.Draw_Line3D(lines, 1, 1, lines, 1, 2000, Globals.RGBA(0, 1, 0, 1), Globals.RGBA(0, 1, 0, 1));
            } while (lines < 2000);
        }

        private void Check_Movement()
        {
            if (sngAngleX > 1.3f)
                sngAngleX = 1.3f;
            if (sngAngleX < -1.3)
                sngAngleX = -1.3f;

            if (sngWalk > 0)
            {
                sngWalk = sngWalk - (float)0.005 * (float)Engine.TimeElapsed();
                if (sngWalk < 0)
                    sngWalk = 0;
            }
            else if (sngWalk < 0)
            {
                sngWalk = sngWalk + (float)0.005 * (float)Engine.TimeElapsed();
                if (sngWalk > 0)
                    sngWalk = 0;
            }


            if (sngStrafe > 0)
            {
                sngStrafe = sngStrafe - (float)0.005 * (float)Engine.TimeElapsed();
                if (sngStrafe < 0)
                    sngStrafe = 0;
            }
            else if (sngStrafe < 0)
            {
                sngStrafe = sngStrafe + (float)0.005 * (float)Engine.TimeElapsed();
                if (sngStrafe > 0)
                    sngStrafe = 0;
            }

            sngPositionX = sngPositionX + ((float)Math.Cos(sngAngleY) * sngWalk / 2 * Engine.TimeElapsed()) + (float)Math.Cos(sngAngleY + 3.141596 / 2) * sngStrafe / 5 * Engine.TimeElapsed();
            sngPositionZ = sngPositionZ + ((float)Math.Sin(sngAngleY) * sngWalk / 2 * Engine.TimeElapsed()) + (float)Math.Sin(sngAngleY + 3.141596 / 2) * sngStrafe / 5 * Engine.TimeElapsed();

            if (Land != null)
            {
                sngPositionY = Land.GetHeight(sngPositionX, sngPositionZ) + 10;
            }
            else
            {
                sngPositionY = World.Camera.PosY;
            }


            snglookatX = sngPositionX + (float)Math.Cos(sngAngleY);
            snglookatY = sngPositionY + (float)Math.Tan(sngAngleX);
            snglookatZ = sngPositionZ + (float)Math.Sin(sngAngleY);

            Scene.SetCamera(sngPositionX, sngPositionY, sngPositionZ, snglookatX, snglookatY, snglookatZ);

        }

        private void Destroy(bool exit = false)
        {
            //Release objects to clear memory.
            if (Engine != null) { Engine.ReleaseAll(); }

            World = null;

            if (exit) {

                Engine = null;
                Scene = null;
                Inputs = null;
                Atmo = null;
                MatFact = null;
                TexFact = null;
                Globals = null;
                Maths = null;
                Screen2D = null;
                Text2D = null;
                Lights = null;
                Camera = null;
                viewPort = null;
                World = null;

                System.Environment.Exit(0);

            }          
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Destroy(true);
        }

        private void Editor_FormClosing(object sender, FormClosingEventArgs e)
        {
            Destroy(true);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                World.SaveWorld(file);
                MessageBox.Show("World saved!");
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;

                KeyValuePair<string, string> task = new KeyValuePair<string, string>("load", file);
                pendingTasks.Add(task);
                DoLoop = false;

            }
        }

        private void bNewLand_Click(object sender, EventArgs e)
        {    
            tcSettings.Focus();
            
            DialogResult dr;
            
            LandscapeDefinition LandSc = new LandscapeDefinition();

            using (R3D.Landscape.LandscapeEditor LandEdit = new R3D.Landscape.LandscapeEditor(ref LandSc))
            {
                dr = LandEdit.ShowDialog();
            }

            if (dr == DialogResult.OK)
            {
                //free memory
                Land = null;

                World.Landscape = LandSc;
                TV_3DVECTOR lv = new TV_3DVECTOR(0, -0.9F, -0.8F);
                Lights.CreateDirectionalLight(lv, 1, 1, 0.95F, "Sunlight", 1.0F);
                World.CreateLandscape(ref LandSc, ref Land, ref Scene, ref TexFact, ref MatFact, ref Globals);
            }

        }

        void lstEntities_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tcSettings.Focus();

            DialogResult dr;
            int index = this.lstEntities.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MeshDefinition R3DMesh = (MeshDefinition)lstEntities.Items[index];
                using (R3D.Editors.MeshEditor meshEdit = new R3D.Editors.MeshEditor(ref R3DMesh))
                {
                   dr = meshEdit.ShowDialog();
                }

                if (dr == DialogResult.OK)
                {
                    World.CreateMesh(ref R3DMesh, ref Scene, ref TexFact);
                    BindEntities();
                }       

            }
        }

        void lstModels_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tcSettings.Focus();

            DialogResult dr;
            int index = this.lstModels.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                ModelDefinition R3DModel = (ModelDefinition)lstModels.Items[index];
                using (R3D.Editors.ModelEditor modelEdit = new R3D.Editors.ModelEditor(ref R3DModel))
                {
                    dr = modelEdit.ShowDialog();
                }

                if (dr == DialogResult.OK)
                {
                    World.CreateModel(ref R3DModel, ref Scene, ref TexFact, ref Globals);
                    BindModels();
                }

            }
        }

        private void BindEntities()
        {
            //clear out previous
            lstEntities.DataSource = null;

            lstEntities.DataSource = World.EntityManager;
            lstEntities.DisplayMember = "MeshName";
            lstEntities.ValueMember = "ID";
        }

        private void BindModels()
        {
            //clear out previous
            lstModels.DataSource = null;

            lstModels.DataSource = World.ModelManager;
            lstModels.DisplayMember = "ModelName";
            lstModels.ValueMember = "ID";
        }

        private void bCreateMesh_Click(object sender, EventArgs e)
        {
            tcSettings.Focus();

            DialogResult dr;
            MeshDefinition R3DMesh = new MeshDefinition();
            using (R3D.Editors.MeshEditor meshEdit = new R3D.Editors.MeshEditor(ref R3DMesh))
            {
                dr = meshEdit.ShowDialog();
            }

            if (dr == DialogResult.OK)
            {
                World.CreateMesh(ref R3DMesh, ref Scene, ref TexFact);
                BindEntities();
            }

        }

        private void bCreateModel_Click(object sender, EventArgs e)
        {
            tcSettings.Focus();

            DialogResult dr;
            ModelDefinition R3DModel = new ModelDefinition();
            using (R3D.Editors.ModelEditor modelEdit = new R3D.Editors.ModelEditor(ref R3DModel))
            {
                dr = modelEdit.ShowDialog();
            }

            if (dr == DialogResult.OK)
            {
                World.CreateModel(ref R3DModel, ref Scene, ref TexFact, ref Globals);
                BindModels();
            }

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitCore();
            DoLoop = true;
            Main_Loop();
        }

        private void ExecutePending()
        { 
            foreach (var item in pendingTasks)
            {
                if (item.Key == "load")
                {
                    World = new R3DWorld();
                    World.LoadWorld(item.Value);
                    InitWorld();
                }
            }

            pendingTasks = null;
        }

        public void InitWorld()
        {

            InitCore();

            if (World != null)
            {
                // Init skybox
                if (World.SkyBox != null)
                {
                    World.SkyBox.CreateSkybox(ref TexFact, ref Atmo, ref Globals);
                }

                // Init lighting setup
                Lights.CreateDirectionalLight(new TV_3DVECTOR(0, -0.9f, -0.8f), 1, 1, 0.95f, "Sunlight", 1f);

                // Init Landscape
                if (World.Landscape != null)
                {
                    LandscapeDefinition R3DLand = World.Landscape;
                    World.CreateLandscape(ref R3DLand, ref Land, ref Scene, ref TexFact, ref MatFact, ref Globals);
                }

                //Init Waterplane
                if (World.Water != null)
                {
                    World.Water.CreateWaterPlane(ref TexFact, ref Scene, ref Camera, ref Maths, ref Globals);
                }

                if (World.EntityManager != null && World.EntityManager.Count > 0)
                {
                    World.LoadMeshesFromEM(ref Scene, ref TexFact);
                    BindEntities();
                }

            }

            DoLoop = true;
            Main_Loop();

        }

        private void enableGridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (drawEditGrid)
            { drawEditGrid = false; ((ToolStripMenuItem)sender).Checked = false; }
            else
            { drawEditGrid = true; ((ToolStripMenuItem)sender).Checked = true; }
        }
    }

}
