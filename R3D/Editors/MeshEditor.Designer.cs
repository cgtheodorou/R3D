namespace R3D.Editors
{
    partial class MeshEditor
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
            this.lbTexture = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tTexture = new System.Windows.Forms.TextBox();
            this.bLoadTex = new System.Windows.Forms.Button();
            this.tTextureName = new System.Windows.Forms.TextBox();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.lbZ1 = new System.Windows.Forms.Label();
            this.lbZ2 = new System.Windows.Forms.Label();
            this.lbHeight = new System.Windows.Forms.Label();
            this.lbAltitude = new System.Windows.Forms.Label();
            this.lbTileW = new System.Windows.Forms.Label();
            this.lbTileH = new System.Windows.Forms.Label();
            this.tX1 = new System.Windows.Forms.TextBox();
            this.tX2 = new System.Windows.Forms.TextBox();
            this.tZ1 = new System.Windows.Forms.TextBox();
            this.tZ2 = new System.Windows.Forms.TextBox();
            this.tHeight = new System.Windows.Forms.TextBox();
            this.tAltitude = new System.Windows.Forms.TextBox();
            this.tTileW = new System.Windows.Forms.TextBox();
            this.tTileH = new System.Windows.Forms.TextBox();
            this.bApply = new System.Windows.Forms.Button();
            this.rbWall = new System.Windows.Forms.RadioButton();
            this.rbFloor = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // lbTexture
            // 
            this.lbTexture.AutoSize = true;
            this.lbTexture.Location = new System.Drawing.Point(10, 24);
            this.lbTexture.Name = "lbTexture";
            this.lbTexture.Size = new System.Drawing.Size(43, 13);
            this.lbTexture.TabIndex = 2;
            this.lbTexture.Text = "Texture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tex. Name";
            // 
            // tTexture
            // 
            this.tTexture.Location = new System.Drawing.Point(68, 21);
            this.tTexture.Name = "tTexture";
            this.tTexture.Size = new System.Drawing.Size(209, 20);
            this.tTexture.TabIndex = 5;
            // 
            // bLoadTex
            // 
            this.bLoadTex.Location = new System.Drawing.Point(283, 19);
            this.bLoadTex.Name = "bLoadTex";
            this.bLoadTex.Size = new System.Drawing.Size(75, 23);
            this.bLoadTex.TabIndex = 6;
            this.bLoadTex.Text = "Browse";
            this.bLoadTex.UseVisualStyleBackColor = true;
            this.bLoadTex.Click += new System.EventHandler(this.bLoadTex_Click);
            // 
            // tTextureName
            // 
            this.tTextureName.Location = new System.Drawing.Point(68, 58);
            this.tTextureName.Name = "tTextureName";
            this.tTextureName.Size = new System.Drawing.Size(124, 20);
            this.tTextureName.TabIndex = 8;
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Location = new System.Drawing.Point(10, 106);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(20, 13);
            this.lbX1.TabIndex = 10;
            this.lbX1.Text = "X1";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Location = new System.Drawing.Point(10, 138);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(20, 13);
            this.lbX2.TabIndex = 11;
            this.lbX2.Text = "X2";
            // 
            // lbZ1
            // 
            this.lbZ1.AutoSize = true;
            this.lbZ1.Location = new System.Drawing.Point(99, 106);
            this.lbZ1.Name = "lbZ1";
            this.lbZ1.Size = new System.Drawing.Size(20, 13);
            this.lbZ1.TabIndex = 12;
            this.lbZ1.Text = "Z1";
            // 
            // lbZ2
            // 
            this.lbZ2.AutoSize = true;
            this.lbZ2.Location = new System.Drawing.Point(99, 138);
            this.lbZ2.Name = "lbZ2";
            this.lbZ2.Size = new System.Drawing.Size(20, 13);
            this.lbZ2.TabIndex = 13;
            this.lbZ2.Text = "Z2";
            // 
            // lbHeight
            // 
            this.lbHeight.AutoSize = true;
            this.lbHeight.Location = new System.Drawing.Point(189, 106);
            this.lbHeight.Name = "lbHeight";
            this.lbHeight.Size = new System.Drawing.Size(38, 13);
            this.lbHeight.TabIndex = 14;
            this.lbHeight.Text = "Height";
            // 
            // lbAltitude
            // 
            this.lbAltitude.AutoSize = true;
            this.lbAltitude.Location = new System.Drawing.Point(189, 138);
            this.lbAltitude.Name = "lbAltitude";
            this.lbAltitude.Size = new System.Drawing.Size(42, 13);
            this.lbAltitude.TabIndex = 15;
            this.lbAltitude.Text = "Altitude";
            // 
            // lbTileW
            // 
            this.lbTileW.AutoSize = true;
            this.lbTileW.Location = new System.Drawing.Point(293, 106);
            this.lbTileW.Name = "lbTileW";
            this.lbTileW.Size = new System.Drawing.Size(55, 13);
            this.lbTileW.TabIndex = 16;
            this.lbTileW.Text = "Tile Width";
            // 
            // lbTileH
            // 
            this.lbTileH.AutoSize = true;
            this.lbTileH.Location = new System.Drawing.Point(293, 138);
            this.lbTileH.Name = "lbTileH";
            this.lbTileH.Size = new System.Drawing.Size(58, 13);
            this.lbTileH.TabIndex = 17;
            this.lbTileH.Text = "Tile Height";
            // 
            // tX1
            // 
            this.tX1.Location = new System.Drawing.Point(36, 103);
            this.tX1.Name = "tX1";
            this.tX1.Size = new System.Drawing.Size(41, 20);
            this.tX1.TabIndex = 18;
            // 
            // tX2
            // 
            this.tX2.Location = new System.Drawing.Point(36, 135);
            this.tX2.Name = "tX2";
            this.tX2.Size = new System.Drawing.Size(41, 20);
            this.tX2.TabIndex = 19;
            // 
            // tZ1
            // 
            this.tZ1.Location = new System.Drawing.Point(125, 103);
            this.tZ1.Name = "tZ1";
            this.tZ1.Size = new System.Drawing.Size(41, 20);
            this.tZ1.TabIndex = 20;
            // 
            // tZ2
            // 
            this.tZ2.Location = new System.Drawing.Point(125, 135);
            this.tZ2.Name = "tZ2";
            this.tZ2.Size = new System.Drawing.Size(41, 20);
            this.tZ2.TabIndex = 21;
            // 
            // tHeight
            // 
            this.tHeight.Location = new System.Drawing.Point(233, 103);
            this.tHeight.Name = "tHeight";
            this.tHeight.Size = new System.Drawing.Size(41, 20);
            this.tHeight.TabIndex = 22;
            // 
            // tAltitude
            // 
            this.tAltitude.Location = new System.Drawing.Point(233, 135);
            this.tAltitude.Name = "tAltitude";
            this.tAltitude.Size = new System.Drawing.Size(41, 20);
            this.tAltitude.TabIndex = 23;
            // 
            // tTileW
            // 
            this.tTileW.Location = new System.Drawing.Point(354, 103);
            this.tTileW.Name = "tTileW";
            this.tTileW.Size = new System.Drawing.Size(41, 20);
            this.tTileW.TabIndex = 24;
            // 
            // tTileH
            // 
            this.tTileH.Location = new System.Drawing.Point(354, 131);
            this.tTileH.Name = "tTileH";
            this.tTileH.Size = new System.Drawing.Size(41, 20);
            this.tTileH.TabIndex = 25;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(12, 238);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 23);
            this.bApply.TabIndex = 27;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // rbWall
            // 
            this.rbWall.AutoSize = true;
            this.rbWall.Location = new System.Drawing.Point(12, 192);
            this.rbWall.Name = "rbWall";
            this.rbWall.Size = new System.Drawing.Size(46, 17);
            this.rbWall.TabIndex = 28;
            this.rbWall.TabStop = true;
            this.rbWall.Text = "Wall";
            this.rbWall.UseVisualStyleBackColor = true;
            // 
            // rbFloor
            // 
            this.rbFloor.AutoSize = true;
            this.rbFloor.Location = new System.Drawing.Point(68, 192);
            this.rbFloor.Name = "rbFloor";
            this.rbFloor.Size = new System.Drawing.Size(84, 17);
            this.rbFloor.TabIndex = 29;
            this.rbFloor.TabStop = true;
            this.rbFloor.Text = "Floor/Ceiling";
            this.rbFloor.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MeshEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 290);
            this.Controls.Add(this.rbFloor);
            this.Controls.Add(this.rbWall);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.tTileH);
            this.Controls.Add(this.tTileW);
            this.Controls.Add(this.tAltitude);
            this.Controls.Add(this.tHeight);
            this.Controls.Add(this.tZ2);
            this.Controls.Add(this.tZ1);
            this.Controls.Add(this.tX2);
            this.Controls.Add(this.tX1);
            this.Controls.Add(this.lbTileH);
            this.Controls.Add(this.lbTileW);
            this.Controls.Add(this.lbAltitude);
            this.Controls.Add(this.lbHeight);
            this.Controls.Add(this.lbZ2);
            this.Controls.Add(this.lbZ1);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.tTextureName);
            this.Controls.Add(this.bLoadTex);
            this.Controls.Add(this.tTexture);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbTexture);
            this.Name = "MeshEditor";
            this.Text = "MeshEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbTexture;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tTexture;
        private System.Windows.Forms.Button bLoadTex;
        private System.Windows.Forms.TextBox tTextureName;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.Label lbZ1;
        private System.Windows.Forms.Label lbZ2;
        private System.Windows.Forms.Label lbHeight;
        private System.Windows.Forms.Label lbAltitude;
        private System.Windows.Forms.Label lbTileW;
        private System.Windows.Forms.Label lbTileH;
        private System.Windows.Forms.TextBox tX1;
        private System.Windows.Forms.TextBox tX2;
        private System.Windows.Forms.TextBox tZ1;
        private System.Windows.Forms.TextBox tZ2;
        private System.Windows.Forms.TextBox tHeight;
        private System.Windows.Forms.TextBox tAltitude;
        private System.Windows.Forms.TextBox tTileW;
        private System.Windows.Forms.TextBox tTileH;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.RadioButton rbWall;
        private System.Windows.Forms.RadioButton rbFloor;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}