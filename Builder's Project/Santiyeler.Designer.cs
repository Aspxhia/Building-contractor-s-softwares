namespace Builder_s_Project
{
    partial class Santiyeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Santiyeler));
            this.santiyeEkleBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bitisBtn = new System.Windows.Forms.TextBox();
            this.baslaBtn = new System.Windows.Forms.TextBox();
            this.adresBtn = new System.Windows.Forms.TextBox();
            this.isimBtn = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // santiyeEkleBtn
            // 
            this.santiyeEkleBtn.BackgroundImage = global::Builder_s_Project.Properties.Resources.button;
            this.santiyeEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.santiyeEkleBtn.Location = new System.Drawing.Point(199, 12);
            this.santiyeEkleBtn.Name = "santiyeEkleBtn";
            this.santiyeEkleBtn.Size = new System.Drawing.Size(118, 32);
            this.santiyeEkleBtn.TabIndex = 0;
            this.santiyeEkleBtn.Text = "Şantiye Ekle";
            this.santiyeEkleBtn.UseVisualStyleBackColor = true;
            this.santiyeEkleBtn.Click += new System.EventHandler(this.santiyeEkleBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BackgroundImage = global::Builder_s_Project.Properties.Resources.background2;
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.EkleBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bitisBtn);
            this.panel1.Controls.Add(this.baslaBtn);
            this.panel1.Controls.Add(this.adresBtn);
            this.panel1.Controls.Add(this.isimBtn);
            this.panel1.Location = new System.Drawing.Point(347, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 182);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Gizle";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // EkleBtn
            // 
            this.EkleBtn.Location = new System.Drawing.Point(122, 156);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(75, 23);
            this.EkleBtn.TabIndex = 8;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.UseVisualStyleBackColor = true;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Baslangıc Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şantiye Adresi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Şantiye ismi";
            // 
            // bitisBtn
            // 
            this.bitisBtn.Location = new System.Drawing.Point(97, 119);
            this.bitisBtn.Name = "bitisBtn";
            this.bitisBtn.Size = new System.Drawing.Size(100, 20);
            this.bitisBtn.TabIndex = 3;
            // 
            // baslaBtn
            // 
            this.baslaBtn.Location = new System.Drawing.Point(97, 76);
            this.baslaBtn.Name = "baslaBtn";
            this.baslaBtn.Size = new System.Drawing.Size(100, 20);
            this.baslaBtn.TabIndex = 2;
            // 
            // adresBtn
            // 
            this.adresBtn.Location = new System.Drawing.Point(97, 39);
            this.adresBtn.Name = "adresBtn";
            this.adresBtn.Size = new System.Drawing.Size(100, 20);
            this.adresBtn.TabIndex = 1;
            // 
            // isimBtn
            // 
            this.isimBtn.Location = new System.Drawing.Point(97, 3);
            this.isimBtn.Name = "isimBtn";
            this.isimBtn.Size = new System.Drawing.Size(100, 20);
            this.isimBtn.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 87);
            this.dataGridView1.TabIndex = 5;
            // 
            // Santiyeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.santiyeEkleBtn);
            this.Name = "Santiyeler";
            this.Text = "Santiyeler";
            this.Load += new System.EventHandler(this.Santiyeler_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button santiyeEkleBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bitisBtn;
        private System.Windows.Forms.TextBox baslaBtn;
        private System.Windows.Forms.TextBox adresBtn;
        private System.Windows.Forms.TextBox isimBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}