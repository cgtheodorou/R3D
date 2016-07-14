namespace R3D.Editors
{
    partial class ModelEditor
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
            this.tName = new System.Windows.Forms.TextBox();
            this.tFilePath = new System.Windows.Forms.TextBox();
            this.tTexFilePath = new System.Windows.Forms.TextBox();
            this.tTexName = new System.Windows.Forms.TextBox();
            this.tPosY = new System.Windows.Forms.TextBox();
            this.tPosX = new System.Windows.Forms.TextBox();
            this.tScaleX = new System.Windows.Forms.TextBox();
            this.tPosZ = new System.Windows.Forms.TextBox();
            this.tScaleY = new System.Windows.Forms.TextBox();
            this.tScaleZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bFileBrowse = new System.Windows.Forms.Button();
            this.bTexBrowse = new System.Windows.Forms.Button();
            this.chAutoLoadTex = new System.Windows.Forms.CheckBox();
            this.chAutoLoadMat = new System.Windows.Forms.CheckBox();
            this.bApply = new System.Windows.Forms.Button();
            this.cbCulling = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(87, 16);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(100, 20);
            this.tName.TabIndex = 0;
            // 
            // tFilePath
            // 
            this.tFilePath.Location = new System.Drawing.Point(87, 42);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Size = new System.Drawing.Size(100, 20);
            this.tFilePath.TabIndex = 1;
            // 
            // tTexFilePath
            // 
            this.tTexFilePath.Location = new System.Drawing.Point(87, 94);
            this.tTexFilePath.Name = "tTexFilePath";
            this.tTexFilePath.Size = new System.Drawing.Size(100, 20);
            this.tTexFilePath.TabIndex = 2;
            // 
            // tTexName
            // 
            this.tTexName.Location = new System.Drawing.Point(87, 68);
            this.tTexName.Name = "tTexName";
            this.tTexName.Size = new System.Drawing.Size(100, 20);
            this.tTexName.TabIndex = 3;
            // 
            // tPosY
            // 
            this.tPosY.Location = new System.Drawing.Point(87, 186);
            this.tPosY.Name = "tPosY";
            this.tPosY.Size = new System.Drawing.Size(48, 20);
            this.tPosY.TabIndex = 4;
            // 
            // tPosX
            // 
            this.tPosX.Location = new System.Drawing.Point(87, 160);
            this.tPosX.Name = "tPosX";
            this.tPosX.Size = new System.Drawing.Size(48, 20);
            this.tPosX.TabIndex = 5;
            // 
            // tScaleX
            // 
            this.tScaleX.Location = new System.Drawing.Point(219, 160);
            this.tScaleX.Name = "tScaleX";
            this.tScaleX.Size = new System.Drawing.Size(48, 20);
            this.tScaleX.TabIndex = 6;
            // 
            // tPosZ
            // 
            this.tPosZ.Location = new System.Drawing.Point(87, 212);
            this.tPosZ.Name = "tPosZ";
            this.tPosZ.Size = new System.Drawing.Size(48, 20);
            this.tPosZ.TabIndex = 7;
            // 
            // tScaleY
            // 
            this.tScaleY.Location = new System.Drawing.Point(219, 186);
            this.tScaleY.Name = "tScaleY";
            this.tScaleY.Size = new System.Drawing.Size(48, 20);
            this.tScaleY.TabIndex = 8;
            // 
            // tScaleZ
            // 
            this.tScaleZ.Location = new System.Drawing.Point(219, 212);
            this.tScaleZ.Name = "tScaleZ";
            this.tScaleZ.Size = new System.Drawing.Size(48, 20);
            this.tScaleZ.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "File Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tex. File Path";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tex. Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "PosX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "PosY";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "PosZ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(172, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "ScaleX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(172, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "ScaleY";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(172, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "ScaleZ";
            // 
            // bFileBrowse
            // 
            this.bFileBrowse.Location = new System.Drawing.Point(193, 42);
            this.bFileBrowse.Name = "bFileBrowse";
            this.bFileBrowse.Size = new System.Drawing.Size(75, 20);
            this.bFileBrowse.TabIndex = 20;
            this.bFileBrowse.Text = "Browse";
            this.bFileBrowse.UseVisualStyleBackColor = true;
            this.bFileBrowse.Click += new System.EventHandler(this.bFileBrowse_Click);
            // 
            // bTexBrowse
            // 
            this.bTexBrowse.Location = new System.Drawing.Point(194, 94);
            this.bTexBrowse.Name = "bTexBrowse";
            this.bTexBrowse.Size = new System.Drawing.Size(75, 20);
            this.bTexBrowse.TabIndex = 21;
            this.bTexBrowse.Text = "Browse";
            this.bTexBrowse.UseVisualStyleBackColor = true;
            this.bTexBrowse.Click += new System.EventHandler(this.bTexBrowse_Click);
            // 
            // chAutoLoadTex
            // 
            this.chAutoLoadTex.AutoSize = true;
            this.chAutoLoadTex.Location = new System.Drawing.Point(12, 254);
            this.chAutoLoadTex.Name = "chAutoLoadTex";
            this.chAutoLoadTex.Size = new System.Drawing.Size(119, 17);
            this.chAutoLoadTex.TabIndex = 22;
            this.chAutoLoadTex.Text = "Auto Load Textures";
            this.chAutoLoadTex.UseVisualStyleBackColor = true;
            // 
            // chAutoLoadMat
            // 
            this.chAutoLoadMat.AutoSize = true;
            this.chAutoLoadMat.Location = new System.Drawing.Point(12, 277);
            this.chAutoLoadMat.Name = "chAutoLoadMat";
            this.chAutoLoadMat.Size = new System.Drawing.Size(120, 17);
            this.chAutoLoadMat.TabIndex = 23;
            this.chAutoLoadMat.Text = "Auto Load Materials";
            this.chAutoLoadMat.UseVisualStyleBackColor = true;
            // 
            // bApply
            // 
            this.bApply.Location = new System.Drawing.Point(12, 310);
            this.bApply.Name = "bApply";
            this.bApply.Size = new System.Drawing.Size(75, 30);
            this.bApply.TabIndex = 24;
            this.bApply.Text = "Apply";
            this.bApply.UseVisualStyleBackColor = true;
            this.bApply.Click += new System.EventHandler(this.bApply_Click);
            // 
            // cbCulling
            // 
            this.cbCulling.FormattingEnabled = true;
            this.cbCulling.Items.AddRange(new object[] {
            "Doublesided"});
            this.cbCulling.Location = new System.Drawing.Point(87, 125);
            this.cbCulling.Name = "cbCulling";
            this.cbCulling.Size = new System.Drawing.Size(100, 21);
            this.cbCulling.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Culling Mode";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ModelEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 355);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbCulling);
            this.Controls.Add(this.bApply);
            this.Controls.Add(this.chAutoLoadMat);
            this.Controls.Add(this.chAutoLoadTex);
            this.Controls.Add(this.bTexBrowse);
            this.Controls.Add(this.bFileBrowse);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tScaleZ);
            this.Controls.Add(this.tScaleY);
            this.Controls.Add(this.tPosZ);
            this.Controls.Add(this.tScaleX);
            this.Controls.Add(this.tPosX);
            this.Controls.Add(this.tPosY);
            this.Controls.Add(this.tTexName);
            this.Controls.Add(this.tTexFilePath);
            this.Controls.Add(this.tFilePath);
            this.Controls.Add(this.tName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelEditor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tFilePath;
        private System.Windows.Forms.TextBox tTexFilePath;
        private System.Windows.Forms.TextBox tTexName;
        private System.Windows.Forms.TextBox tPosY;
        private System.Windows.Forms.TextBox tPosX;
        private System.Windows.Forms.TextBox tScaleX;
        private System.Windows.Forms.TextBox tPosZ;
        private System.Windows.Forms.TextBox tScaleY;
        private System.Windows.Forms.TextBox tScaleZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bFileBrowse;
        private System.Windows.Forms.Button bTexBrowse;
        private System.Windows.Forms.CheckBox chAutoLoadTex;
        private System.Windows.Forms.CheckBox chAutoLoadMat;
        private System.Windows.Forms.Button bApply;
        private System.Windows.Forms.ComboBox cbCulling;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}