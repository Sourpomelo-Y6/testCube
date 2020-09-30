namespace testCube
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.btnRollPlus = new System.Windows.Forms.Button();
            this.btnRollMinus = new System.Windows.Forms.Button();
            this.btnPitchPlus = new System.Windows.Forms.Button();
            this.btnPitchMinus = new System.Windows.Forms.Button();
            this.btnYawPlus = new System.Windows.Forms.Button();
            this.btnYawMinus = new System.Windows.Forms.Button();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pbMain);
            this.pnlMain.Location = new System.Drawing.Point(12, 12);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(200, 200);
            this.pnlMain.TabIndex = 0;
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.White;
            this.pbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMain.Location = new System.Drawing.Point(0, 0);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(200, 200);
            this.pbMain.TabIndex = 0;
            this.pbMain.TabStop = false;
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(379, 12);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Size = new System.Drawing.Size(200, 230);
            this.txtDebug.TabIndex = 1;
            this.txtDebug.WordWrap = false;
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // btnRollPlus
            // 
            this.btnRollPlus.Location = new System.Drawing.Point(219, 12);
            this.btnRollPlus.Name = "btnRollPlus";
            this.btnRollPlus.Size = new System.Drawing.Size(75, 23);
            this.btnRollPlus.TabIndex = 2;
            this.btnRollPlus.Text = "Roll+";
            this.btnRollPlus.UseVisualStyleBackColor = true;
            this.btnRollPlus.Click += new System.EventHandler(this.btnRollPlus_Click);
            // 
            // btnRollMinus
            // 
            this.btnRollMinus.Location = new System.Drawing.Point(219, 41);
            this.btnRollMinus.Name = "btnRollMinus";
            this.btnRollMinus.Size = new System.Drawing.Size(75, 23);
            this.btnRollMinus.TabIndex = 2;
            this.btnRollMinus.Text = "Roll-";
            this.btnRollMinus.UseVisualStyleBackColor = true;
            this.btnRollMinus.Click += new System.EventHandler(this.btnRollMinus_Click);
            // 
            // btnPitchPlus
            // 
            this.btnPitchPlus.Location = new System.Drawing.Point(219, 70);
            this.btnPitchPlus.Name = "btnPitchPlus";
            this.btnPitchPlus.Size = new System.Drawing.Size(75, 23);
            this.btnPitchPlus.TabIndex = 2;
            this.btnPitchPlus.Text = "Pitch+";
            this.btnPitchPlus.UseVisualStyleBackColor = true;
            this.btnPitchPlus.Click += new System.EventHandler(this.btnPitchPlus_Click);
            // 
            // btnPitchMinus
            // 
            this.btnPitchMinus.Location = new System.Drawing.Point(219, 99);
            this.btnPitchMinus.Name = "btnPitchMinus";
            this.btnPitchMinus.Size = new System.Drawing.Size(75, 23);
            this.btnPitchMinus.TabIndex = 2;
            this.btnPitchMinus.Text = "Pitch-";
            this.btnPitchMinus.UseVisualStyleBackColor = true;
            this.btnPitchMinus.Click += new System.EventHandler(this.btnPitchMinus_Click);
            // 
            // btnYawPlus
            // 
            this.btnYawPlus.Location = new System.Drawing.Point(219, 128);
            this.btnYawPlus.Name = "btnYawPlus";
            this.btnYawPlus.Size = new System.Drawing.Size(75, 23);
            this.btnYawPlus.TabIndex = 2;
            this.btnYawPlus.Text = "Yaw+";
            this.btnYawPlus.UseVisualStyleBackColor = true;
            this.btnYawPlus.Click += new System.EventHandler(this.btnYawPlus_Click);
            // 
            // btnYawMinus
            // 
            this.btnYawMinus.Location = new System.Drawing.Point(219, 157);
            this.btnYawMinus.Name = "btnYawMinus";
            this.btnYawMinus.Size = new System.Drawing.Size(75, 23);
            this.btnYawMinus.TabIndex = 2;
            this.btnYawMinus.Text = "Yaw-";
            this.btnYawMinus.UseVisualStyleBackColor = true;
            this.btnYawMinus.Click += new System.EventHandler(this.btnYawMinus_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYawMinus);
            this.Controls.Add(this.btnYawPlus);
            this.Controls.Add(this.btnPitchMinus);
            this.Controls.Add(this.btnPitchPlus);
            this.Controls.Add(this.btnRollMinus);
            this.Controls.Add(this.btnRollPlus);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Timer tmrMain;
        private System.Windows.Forms.Button btnRollPlus;
        private System.Windows.Forms.Button btnRollMinus;
        private System.Windows.Forms.Button btnPitchPlus;
        private System.Windows.Forms.Button btnPitchMinus;
        private System.Windows.Forms.Button btnYawPlus;
        private System.Windows.Forms.Button btnYawMinus;
    }
}

