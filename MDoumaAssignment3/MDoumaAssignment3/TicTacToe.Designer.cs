namespace MDoumaAssignment3
{
    partial class TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToe));
            this.tile00 = new System.Windows.Forms.PictureBox();
            this.xAndO = new System.Windows.Forms.ImageList(this.components);
            this.tile01 = new System.Windows.Forms.PictureBox();
            this.tile02 = new System.Windows.Forms.PictureBox();
            this.tile10 = new System.Windows.Forms.PictureBox();
            this.tile20 = new System.Windows.Forms.PictureBox();
            this.tile11 = new System.Windows.Forms.PictureBox();
            this.tile12 = new System.Windows.Forms.PictureBox();
            this.tile21 = new System.Windows.Forms.PictureBox();
            this.tile22 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tile00)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile22)).BeginInit();
            this.SuspendLayout();
            // 
            // tile00
            // 
            this.tile00.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile00.Location = new System.Drawing.Point(49, 63);
            this.tile00.Name = "tile00";
            this.tile00.Size = new System.Drawing.Size(70, 70);
            this.tile00.TabIndex = 0;
            this.tile00.TabStop = false;
            this.tile00.Tag = "1";
            this.tile00.Click += new System.EventHandler(this.Move_Click);
            // 
            // xAndO
            // 
            this.xAndO.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("xAndO.ImageStream")));
            this.xAndO.TransparentColor = System.Drawing.Color.Transparent;
            this.xAndO.Images.SetKeyName(0, "x.png");
            this.xAndO.Images.SetKeyName(1, "o.png");
            // 
            // tile01
            // 
            this.tile01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile01.Location = new System.Drawing.Point(125, 63);
            this.tile01.Name = "tile01";
            this.tile01.Size = new System.Drawing.Size(70, 70);
            this.tile01.TabIndex = 1;
            this.tile01.TabStop = false;
            this.tile01.Tag = "2";
            this.tile01.Click += new System.EventHandler(this.Move_Click);
            // 
            // tile02
            // 
            this.tile02.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile02.Location = new System.Drawing.Point(201, 63);
            this.tile02.Name = "tile02";
            this.tile02.Size = new System.Drawing.Size(70, 70);
            this.tile02.TabIndex = 2;
            this.tile02.TabStop = false;
            this.tile02.Tag = "3";
            this.tile02.Click += new System.EventHandler(this.Move_Click);
            // 
            // tile10
            // 
            this.tile10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile10.Location = new System.Drawing.Point(49, 139);
            this.tile10.Name = "tile10";
            this.tile10.Size = new System.Drawing.Size(70, 70);
            this.tile10.TabIndex = 3;
            this.tile10.TabStop = false;
            this.tile10.Tag = "4";
            this.tile10.Click += new System.EventHandler(this.Move_Click);
            // 
            // tile20
            // 
            this.tile20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile20.Location = new System.Drawing.Point(49, 215);
            this.tile20.Name = "tile20";
            this.tile20.Size = new System.Drawing.Size(70, 70);
            this.tile20.TabIndex = 4;
            this.tile20.TabStop = false;
            this.tile20.Tag = "7";
            this.tile20.Click += new System.EventHandler(this.Move_Click);
            // 
            // tile11
            // 
            this.tile11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile11.Location = new System.Drawing.Point(125, 139);
            this.tile11.Name = "tile11";
            this.tile11.Size = new System.Drawing.Size(70, 70);
            this.tile11.TabIndex = 5;
            this.tile11.TabStop = false;
            this.tile11.Tag = "5";
            this.tile11.Click += new System.EventHandler(this.Move_Click);
            // 
            // tile12
            // 
            this.tile12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile12.Location = new System.Drawing.Point(201, 139);
            this.tile12.Name = "tile12";
            this.tile12.Size = new System.Drawing.Size(70, 70);
            this.tile12.TabIndex = 6;
            this.tile12.TabStop = false;
            this.tile12.Tag = "6";
            this.tile12.Click += new System.EventHandler(this.Move_Click);
            // 
            // tile21
            // 
            this.tile21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile21.Location = new System.Drawing.Point(125, 215);
            this.tile21.Name = "tile21";
            this.tile21.Size = new System.Drawing.Size(70, 70);
            this.tile21.TabIndex = 7;
            this.tile21.TabStop = false;
            this.tile21.Tag = "8";
            this.tile21.Click += new System.EventHandler(this.Move_Click);
            // 
            // tile22
            // 
            this.tile22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tile22.Location = new System.Drawing.Point(201, 215);
            this.tile22.Name = "tile22";
            this.tile22.Size = new System.Drawing.Size(70, 70);
            this.tile22.TabIndex = 8;
            this.tile22.TabStop = false;
            this.tile22.Tag = "9";
            this.tile22.Click += new System.EventHandler(this.Move_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 51);
            this.label1.TabIndex = 9;
            this.label1.Text = "TIC TAC TOE";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Location = new System.Drawing.Point(292, 66);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(65, 13);
            this.lblTurn.TabIndex = 10;
            this.lblTurn.Text = "It\'s X\'s Turn!";
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(370, 317);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tile22);
            this.Controls.Add(this.tile21);
            this.Controls.Add(this.tile12);
            this.Controls.Add(this.tile11);
            this.Controls.Add(this.tile20);
            this.Controls.Add(this.tile10);
            this.Controls.Add(this.tile02);
            this.Controls.Add(this.tile01);
            this.Controls.Add(this.tile00);
            this.Name = "TicTacToe";
            this.Text = "TicTacToe";
            ((System.ComponentModel.ISupportInitialize)(this.tile00)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tile22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tile00;
        private System.Windows.Forms.ImageList xAndO;
        private System.Windows.Forms.PictureBox tile01;
        private System.Windows.Forms.PictureBox tile02;
        private System.Windows.Forms.PictureBox tile10;
        private System.Windows.Forms.PictureBox tile20;
        private System.Windows.Forms.PictureBox tile11;
        private System.Windows.Forms.PictureBox tile12;
        private System.Windows.Forms.PictureBox tile21;
        private System.Windows.Forms.PictureBox tile22;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTurn;
    }
}