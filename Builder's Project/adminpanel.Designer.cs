namespace Builder_s_Project
{
    partial class adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            this.kAdTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.YoneticiEkleBtn = new System.Windows.Forms.Button();
            this.YoneticiSilBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.veriCekBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // kAdTxt
            // 
            this.kAdTxt.Location = new System.Drawing.Point(169, 21);
            this.kAdTxt.Name = "kAdTxt";
            this.kAdTxt.Size = new System.Drawing.Size(100, 20);
            this.kAdTxt.TabIndex = 0;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Location = new System.Drawing.Point(169, 74);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.Size = new System.Drawing.Size(100, 20);
            this.sifreTxt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sifre";
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackgroundImage = global::Builder_s_Project.Properties.Resources.personelbaslık;
            this.ekleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekleBtn.Image = ((System.Drawing.Image)(resources.GetObject("ekleBtn.Image")));
            this.ekleBtn.Location = new System.Drawing.Point(12, 132);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(129, 66);
            this.ekleBtn.TabIndex = 4;
            this.ekleBtn.Text = "Kullanıcıyı ekle";
            this.ekleBtn.UseVisualStyleBackColor = true;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silBtn.Image = ((System.Drawing.Image)(resources.GetObject("silBtn.Image")));
            this.silBtn.Location = new System.Drawing.Point(12, 228);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(129, 64);
            this.silBtn.TabIndex = 5;
            this.silBtn.Text = "Kullanıcıyı sil";
            this.silBtn.UseVisualStyleBackColor = true;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // YoneticiEkleBtn
            // 
            this.YoneticiEkleBtn.BackgroundImage = global::Builder_s_Project.Properties.Resources.yonetimbaslık;
            this.YoneticiEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YoneticiEkleBtn.Image = ((System.Drawing.Image)(resources.GetObject("YoneticiEkleBtn.Image")));
            this.YoneticiEkleBtn.Location = new System.Drawing.Point(169, 132);
            this.YoneticiEkleBtn.Name = "YoneticiEkleBtn";
            this.YoneticiEkleBtn.Size = new System.Drawing.Size(114, 66);
            this.YoneticiEkleBtn.TabIndex = 6;
            this.YoneticiEkleBtn.Text = "yonetici ekle";
            this.YoneticiEkleBtn.UseVisualStyleBackColor = true;
            this.YoneticiEkleBtn.Click += new System.EventHandler(this.YoneticiEkleBtn_Click);
            // 
            // YoneticiSilBtn
            // 
            this.YoneticiSilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YoneticiSilBtn.Image = ((System.Drawing.Image)(resources.GetObject("YoneticiSilBtn.Image")));
            this.YoneticiSilBtn.Location = new System.Drawing.Point(169, 228);
            this.YoneticiSilBtn.Name = "YoneticiSilBtn";
            this.YoneticiSilBtn.Size = new System.Drawing.Size(114, 64);
            this.YoneticiSilBtn.TabIndex = 7;
            this.YoneticiSilBtn.Text = "yonetici sil";
            this.YoneticiSilBtn.UseVisualStyleBackColor = true;
            this.YoneticiSilBtn.Click += new System.EventHandler(this.YoneticiSilBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 178);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // veriCekBtn
            // 
            this.veriCekBtn.BackgroundImage = global::Builder_s_Project.Properties.Resources.button;
            this.veriCekBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veriCekBtn.Image = ((System.Drawing.Image)(resources.GetObject("veriCekBtn.Image")));
            this.veriCekBtn.Location = new System.Drawing.Point(561, 196);
            this.veriCekBtn.Name = "veriCekBtn";
            this.veriCekBtn.Size = new System.Drawing.Size(143, 50);
            this.veriCekBtn.TabIndex = 9;
            this.veriCekBtn.Text = "Verileri çek";
            this.veriCekBtn.UseVisualStyleBackColor = true;
            this.veriCekBtn.Click += new System.EventHandler(this.veriCekBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(400, 268);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(336, 150);
            this.dataGridView2.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 327);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yetililer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Kullanıcılar";
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(750, 430);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.veriCekBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.YoneticiSilBtn);
            this.Controls.Add(this.YoneticiEkleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.kAdTxt);
            this.Name = "adminpanel";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.adminpanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kAdTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button YoneticiEkleBtn;
        private System.Windows.Forms.Button YoneticiSilBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button veriCekBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}