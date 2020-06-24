namespace Builder_s_Project
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
            this.GirBtn = new System.Windows.Forms.Button();
            this.kAdTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yntcGir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GirBtn
            // 
            this.GirBtn.BackgroundImage = global::Builder_s_Project.Properties.Resources.personelbaslık;
            this.GirBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirBtn.Image = ((System.Drawing.Image)(resources.GetObject("GirBtn.Image")));
            this.GirBtn.Location = new System.Drawing.Point(16, 137);
            this.GirBtn.Name = "GirBtn";
            this.GirBtn.Size = new System.Drawing.Size(108, 58);
            this.GirBtn.TabIndex = 0;
            this.GirBtn.Text = "Personel girişi";
            this.GirBtn.UseVisualStyleBackColor = true;
            this.GirBtn.Click += new System.EventHandler(this.GirBtn_Click);
            // 
            // kAdTxt
            // 
            this.kAdTxt.Location = new System.Drawing.Point(94, 26);
            this.kAdTxt.Name = "kAdTxt";
            this.kAdTxt.Size = new System.Drawing.Size(221, 20);
            this.kAdTxt.TabIndex = 1;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(94, 68);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(221, 20);
            this.sifreTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre";
            // 
            // yntcGir
            // 
            this.yntcGir.BackgroundImage = global::Builder_s_Project.Properties.Resources.yonetimbaslık;
            this.yntcGir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yntcGir.Image = ((System.Drawing.Image)(resources.GetObject("yntcGir.Image")));
            this.yntcGir.Location = new System.Drawing.Point(173, 137);
            this.yntcGir.Name = "yntcGir";
            this.yntcGir.Size = new System.Drawing.Size(117, 58);
            this.yntcGir.TabIndex = 5;
            this.yntcGir.Text = "Yonetici girişi";
            this.yntcGir.UseVisualStyleBackColor = true;
            this.yntcGir.Click += new System.EventHandler(this.yntcGir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(369, 278);
            this.Controls.Add(this.yntcGir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.kAdTxt);
            this.Controls.Add(this.GirBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GirBtn;
        private System.Windows.Forms.TextBox kAdTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yntcGir;
    }
}

