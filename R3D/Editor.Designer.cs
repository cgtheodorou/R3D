namespace R3D
{
    partial class Editor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.WorldViewPort = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.lstModels = new System.Windows.Forms.ListBox();
            this.bCreateModel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bCreateMesh = new System.Windows.Forms.Button();
            this.lstEntities = new System.Windows.Forms.ListBox();
            this.bNewLand = new System.Windows.Forms.Button();
            this.tcSettings = new System.Windows.Forms.TabControl();
            this.renderTimer = new System.Windows.Forms.Timer(this.components);
            this.bSetModelPos = new System.Windows.Forms.Button();
            this.lbModelX = new System.Windows.Forms.Label();
            this.tModelX = new System.Windows.Forms.TextBox();
            this.tModelY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tModelZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WorldViewPort)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tcSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // WorldViewPort
            // 
            this.WorldViewPort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WorldViewPort.Location = new System.Drawing.Point(12, 27);
            this.WorldViewPort.Name = "WorldViewPort";
            this.WorldViewPort.Size = new System.Drawing.Size(750, 572);
            this.WorldViewPort.TabIndex = 0;
            this.WorldViewPort.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tModelZ);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.tModelY);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.tModelX);
            this.tabGeneral.Controls.Add(this.lbModelX);
            this.tabGeneral.Controls.Add(this.bSetModelPos);
            this.tabGeneral.Controls.Add(this.lstModels);
            this.tabGeneral.Controls.Add(this.bCreateModel);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.bCreateMesh);
            this.tabGeneral.Controls.Add(this.lstEntities);
            this.tabGeneral.Controls.Add(this.bNewLand);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabGeneral.Size = new System.Drawing.Size(206, 550);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // lstModels
            // 
            this.lstModels.FormattingEnabled = true;
            this.lstModels.Location = new System.Drawing.Point(6, 200);
            this.lstModels.Name = "lstModels";
            this.lstModels.Size = new System.Drawing.Size(192, 134);
            this.lstModels.TabIndex = 6;
            // 
            // bCreateModel
            // 
            this.bCreateModel.Location = new System.Drawing.Point(6, 340);
            this.bCreateModel.Name = "bCreateModel";
            this.bCreateModel.Size = new System.Drawing.Size(192, 23);
            this.bCreateModel.TabIndex = 5;
            this.bCreateModel.Text = "Create Model";
            this.bCreateModel.UseVisualStyleBackColor = true;
            this.bCreateModel.Click += new System.EventHandler(this.bCreateModel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BSP Entity Management";
            // 
            // bCreateMesh
            // 
            this.bCreateMesh.Location = new System.Drawing.Point(6, 170);
            this.bCreateMesh.Name = "bCreateMesh";
            this.bCreateMesh.Size = new System.Drawing.Size(192, 23);
            this.bCreateMesh.TabIndex = 3;
            this.bCreateMesh.Text = "Create Entity";
            this.bCreateMesh.UseVisualStyleBackColor = true;
            this.bCreateMesh.Click += new System.EventHandler(this.bCreateMesh_Click);
            // 
            // lstEntities
            // 
            this.lstEntities.FormattingEnabled = true;
            this.lstEntities.Location = new System.Drawing.Point(6, 30);
            this.lstEntities.Name = "lstEntities";
            this.lstEntities.Size = new System.Drawing.Size(192, 134);
            this.lstEntities.TabIndex = 2;
            // 
            // bNewLand
            // 
            this.bNewLand.Location = new System.Drawing.Point(6, 509);
            this.bNewLand.Name = "bNewLand";
            this.bNewLand.Size = new System.Drawing.Size(192, 23);
            this.bNewLand.TabIndex = 1;
            this.bNewLand.Text = "Landscape Editor";
            this.bNewLand.UseVisualStyleBackColor = true;
            this.bNewLand.Click += new System.EventHandler(this.bNewLand_Click);
            // 
            // tcSettings
            // 
            this.tcSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcSettings.Controls.Add(this.tabGeneral);
            this.tcSettings.Location = new System.Drawing.Point(769, 27);
            this.tcSettings.Name = "tcSettings";
            this.tcSettings.SelectedIndex = 0;
            this.tcSettings.Size = new System.Drawing.Size(214, 576);
            this.tcSettings.TabIndex = 2;
            // 
            // bSetModelPos
            // 
            this.bSetModelPos.Location = new System.Drawing.Point(6, 404);
            this.bSetModelPos.Name = "bSetModelPos";
            this.bSetModelPos.Size = new System.Drawing.Size(192, 23);
            this.bSetModelPos.TabIndex = 7;
            this.bSetModelPos.Text = "Set Position";
            this.bSetModelPos.UseVisualStyleBackColor = true;
            this.bSetModelPos.Click += new System.EventHandler(this.bSetModelPos_Click);
            // 
            // lbModelX
            // 
            this.lbModelX.AutoSize = true;
            this.lbModelX.Location = new System.Drawing.Point(9, 381);
            this.lbModelX.Name = "lbModelX";
            this.lbModelX.Size = new System.Drawing.Size(14, 13);
            this.lbModelX.TabIndex = 8;
            this.lbModelX.Text = "X";
            // 
            // tModelX
            // 
            this.tModelX.Location = new System.Drawing.Point(29, 378);
            this.tModelX.Name = "tModelX";
            this.tModelX.Size = new System.Drawing.Size(35, 20);
            this.tModelX.TabIndex = 11;
            // 
            // tModelY
            // 
            this.tModelY.Location = new System.Drawing.Point(94, 378);
            this.tModelY.Name = "tModelY";
            this.tModelY.Size = new System.Drawing.Size(35, 20);
            this.tModelY.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Y";
            // 
            // tModelZ
            // 
            this.tModelZ.Location = new System.Drawing.Point(155, 378);
            this.tModelZ.Name = "tModelZ";
            this.tModelZ.Size = new System.Drawing.Size(35, 20);
            this.tModelZ.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Z";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 615);
            this.Controls.Add(this.tcSettings);
            this.Controls.Add(this.WorldViewPort);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "R3D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.WorldViewPort)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tcSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WorldViewPort;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.Button bNewLand;
        private System.Windows.Forms.TabControl tcSettings;
        private System.Windows.Forms.ListBox lstEntities;
        private System.Windows.Forms.Button bCreateMesh;
        private System.Windows.Forms.ListBox lstModels;
        private System.Windows.Forms.Button bCreateModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.Timer renderTimer;
        private System.Windows.Forms.TextBox tModelZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tModelY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tModelX;
        private System.Windows.Forms.Label lbModelX;
        private System.Windows.Forms.Button bSetModelPos;
    }
}

