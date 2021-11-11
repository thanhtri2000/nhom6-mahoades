
namespace Decrypition
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBanGiaiMa = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtKetQua = new System.Windows.Forms.RichTextBox();
            this.btnGiaMa = new System.Windows.Forms.Button();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.txtBanMaHoa = new System.Windows.Forms.TextBox();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.txtBanRo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.txtBanGiaiMa);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.txtKetQua);
            this.groupBox1.Controls.Add(this.btnGiaMa);
            this.groupBox1.Controls.Add(this.btnMaHoa);
            this.groupBox1.Controls.Add(this.btnThongTin);
            this.groupBox1.Controls.Add(this.txtBanMaHoa);
            this.groupBox1.Controls.Add(this.txtKhoa);
            this.groupBox1.Controls.Add(this.txtBanRo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnXuatFile);
            this.groupBox1.Location = new System.Drawing.Point(1, 93);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1034, 462);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtBanGiaiMa
            // 
            this.txtBanGiaiMa.Location = new System.Drawing.Point(529, 351);
            this.txtBanGiaiMa.Margin = new System.Windows.Forms.Padding(2);
            this.txtBanGiaiMa.Multiline = true;
            this.txtBanGiaiMa.Name = "txtBanGiaiMa";
            this.txtBanGiaiMa.Size = new System.Drawing.Size(188, 32);
            this.txtBanGiaiMa.TabIndex = 128;
            // 
            // groupBox5
            // 
            this.groupBox5.BackgroundImage = global::Decrypition.Properties.Resources.tg_gif;
            this.groupBox5.Location = new System.Drawing.Point(-13, 395);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(998, 48);
            this.groupBox5.TabIndex = 127;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "c";
            // 
            // txtKetQua
            // 
            this.txtKetQua.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtKetQua.Location = new System.Drawing.Point(0, 0);
            this.txtKetQua.Margin = new System.Windows.Forms.Padding(2);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(505, 330);
            this.txtKetQua.TabIndex = 11;
            this.txtKetQua.Text = "";
            // 
            // btnGiaMa
            // 
            this.btnGiaMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaMa.ForeColor = System.Drawing.Color.Blue;
            this.btnGiaMa.Image = global::Decrypition.Properties.Resources.key4;
            this.btnGiaMa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGiaMa.Location = new System.Drawing.Point(382, 334);
            this.btnGiaMa.Margin = new System.Windows.Forms.Padding(2);
            this.btnGiaMa.Name = "btnGiaMa";
            this.btnGiaMa.Size = new System.Drawing.Size(123, 50);
            this.btnGiaMa.TabIndex = 10;
            this.btnGiaMa.Text = "Giải mã";
            this.btnGiaMa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGiaMa.UseVisualStyleBackColor = true;
            this.btnGiaMa.Click += new System.EventHandler(this.btnGiaMa_Click);
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHoa.ForeColor = System.Drawing.Color.Blue;
            this.btnMaHoa.Image = global::Decrypition.Properties.Resources.key3;
            this.btnMaHoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMaHoa.Location = new System.Drawing.Point(830, 240);
            this.btnMaHoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(141, 59);
            this.btnMaHoa.TabIndex = 9;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // btnThongTin
            // 
            this.btnThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTin.ForeColor = System.Drawing.Color.Blue;
            this.btnThongTin.Image = global::Decrypition.Properties.Resources.in3;
            this.btnThongTin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongTin.Location = new System.Drawing.Point(830, 132);
            this.btnThongTin.Margin = new System.Windows.Forms.Padding(2);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(141, 61);
            this.btnThongTin.TabIndex = 8;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongTin.UseVisualStyleBackColor = true;
            this.btnThongTin.Click += new System.EventHandler(this.btnThongTin_Click);
            // 
            // txtBanMaHoa
            // 
            this.txtBanMaHoa.Location = new System.Drawing.Point(606, 267);
            this.txtBanMaHoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtBanMaHoa.Multiline = true;
            this.txtBanMaHoa.Name = "txtBanMaHoa";
            this.txtBanMaHoa.Size = new System.Drawing.Size(188, 32);
            this.txtBanMaHoa.TabIndex = 7;
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(606, 161);
            this.txtKhoa.Margin = new System.Windows.Forms.Padding(2);
            this.txtKhoa.Multiline = true;
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(188, 32);
            this.txtKhoa.TabIndex = 6;
            // 
            // txtBanRo
            // 
            this.txtBanRo.Location = new System.Drawing.Point(606, 59);
            this.txtBanRo.Margin = new System.Windows.Forms.Padding(2);
            this.txtBanRo.Multiline = true;
            this.txtBanRo.Name = "txtBanRo";
            this.txtBanRo.Size = new System.Drawing.Size(188, 32);
            this.txtBanRo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(510, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Khóa K";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(509, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã hóa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(511, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bản gốc";
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.Blue;
            this.btnXuatFile.Image = global::Decrypition.Properties.Resources.im2;
            this.btnXuatFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatFile.Location = new System.Drawing.Point(830, 41);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(141, 50);
            this.btnXuatFile.TabIndex = 1;
            this.btnXuatFile.Text = "Xuất  file";
            this.btnXuatFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXuatFile.UseVisualStyleBackColor = true;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(284, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(486, 31);
            this.label4.TabIndex = 128;
            this.label4.Text = "DATA ENCRYPITION STANNDARD";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button1.BackgroundImage = global::Decrypition.Properties.Resources.Màu_kem_và_màu_xanh_mòng_két_Hình_chữ_nhật_Bất_động_sản_Biểu_trưng__3_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(-12, -19);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1082, 93);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 548);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtKetQua;
        private System.Windows.Forms.Button btnGiaMa;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.TextBox txtBanMaHoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.TextBox txtBanRo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBanGiaiMa;
    }
}

