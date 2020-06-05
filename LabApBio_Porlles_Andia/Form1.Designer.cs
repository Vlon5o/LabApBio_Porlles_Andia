namespace LabApBio_Porlles_Andia
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnImg1 = new System.Windows.Forms.Button();
            this.btnImg2 = new System.Windows.Forms.Button();
            this.ptbxImg2 = new System.Windows.Forms.PictureBox();
            this.ptbxImg1 = new System.Windows.Forms.PictureBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImg1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImg1
            // 
            this.btnImg1.BackColor = System.Drawing.Color.Transparent;
            this.btnImg1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnImg1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg1.Image = ((System.Drawing.Image)(resources.GetObject("btnImg1.Image")));
            this.btnImg1.Location = new System.Drawing.Point(157, 90);
            this.btnImg1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnImg1.Name = "btnImg1";
            this.btnImg1.Size = new System.Drawing.Size(71, 70);
            this.btnImg1.TabIndex = 0;
            this.btnImg1.Text = "Cargar Imagen 1";
            this.btnImg1.UseVisualStyleBackColor = false;
            this.btnImg1.Click += new System.EventHandler(this.btnImg1_Click);
            // 
            // btnImg2
            // 
            this.btnImg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnImg2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnImg2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImg2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImg2.Image = ((System.Drawing.Image)(resources.GetObject("btnImg2.Image")));
            this.btnImg2.Location = new System.Drawing.Point(157, 223);
            this.btnImg2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnImg2.Name = "btnImg2";
            this.btnImg2.Size = new System.Drawing.Size(71, 70);
            this.btnImg2.TabIndex = 1;
            this.btnImg2.Text = "Cargar Imagen 2";
            this.btnImg2.UseVisualStyleBackColor = false;
            this.btnImg2.Click += new System.EventHandler(this.btnImg2_Click);
            // 
            // ptbxImg2
            // 
            this.ptbxImg2.Location = new System.Drawing.Point(50, 209);
            this.ptbxImg2.Margin = new System.Windows.Forms.Padding(1);
            this.ptbxImg2.Name = "ptbxImg2";
            this.ptbxImg2.Size = new System.Drawing.Size(74, 114);
            this.ptbxImg2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxImg2.TabIndex = 4;
            this.ptbxImg2.TabStop = false;
            // 
            // ptbxImg1
            // 
            this.ptbxImg1.Location = new System.Drawing.Point(50, 71);
            this.ptbxImg1.Margin = new System.Windows.Forms.Padding(1);
            this.ptbxImg1.Name = "ptbxImg1";
            this.ptbxImg1.Size = new System.Drawing.Size(74, 114);
            this.ptbxImg1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxImg1.TabIndex = 3;
            this.ptbxImg1.TabStop = false;
            // 
            // btnComparar
            // 
            this.btnComparar.BackgroundImage = global::LabApBio_Porlles_Andia.Properties.Resources.comparar;
            this.btnComparar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnComparar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComparar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComparar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnComparar.Image = ((System.Drawing.Image)(resources.GetObject("btnComparar.Image")));
            this.btnComparar.Location = new System.Drawing.Point(293, 158);
            this.btnComparar.Margin = new System.Windows.Forms.Padding(1);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(101, 75);
            this.btnComparar.TabIndex = 2;
            this.btnComparar.Text = "Comparar Identidad";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "BIOMETRICO COMPARATIVO DE HUELLAS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(444, 364);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbxImg2);
            this.Controls.Add(this.ptbxImg1);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.btnImg2);
            this.Controls.Add(this.btnImg1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImg1;
        private System.Windows.Forms.Button btnImg2;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.PictureBox ptbxImg1;
        private System.Windows.Forms.PictureBox ptbxImg2;
        private System.Windows.Forms.Label label1;
    }
}

