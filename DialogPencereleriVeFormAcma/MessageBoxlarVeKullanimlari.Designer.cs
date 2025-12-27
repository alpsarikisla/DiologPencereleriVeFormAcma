namespace DialogPencereleriVeFormAcma
{
    partial class MessageBoxlarVeKullanimlari
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_standart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_button1 = new System.Windows.Forms.Button();
            this.btn_button2 = new System.Windows.Forms.Button();
            this.btn_buton3 = new System.Windows.Forms.Button();
            this.btn_buton4 = new System.Windows.Forms.Button();
            this.btn_buton5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_standart);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 62);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Standart Message Box";
            // 
            // btn_standart
            // 
            this.btn_standart.Location = new System.Drawing.Point(6, 19);
            this.btn_standart.Name = "btn_standart";
            this.btn_standart.Size = new System.Drawing.Size(186, 23);
            this.btn_standart.TabIndex = 0;
            this.btn_standart.Text = "Standart Message Box Aç";
            this.btn_standart.UseVisualStyleBackColor = true;
            this.btn_standart.Click += new System.EventHandler(this.btn_standart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_buton5);
            this.groupBox2.Controls.Add(this.btn_buton4);
            this.groupBox2.Controls.Add(this.btn_buton3);
            this.groupBox2.Controls.Add(this.btn_button2);
            this.groupBox2.Controls.Add(this.btn_button1);
            this.groupBox2.Location = new System.Drawing.Point(12, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 109);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Box Butonları";
            // 
            // btn_button1
            // 
            this.btn_button1.Location = new System.Drawing.Point(6, 19);
            this.btn_button1.Name = "btn_button1";
            this.btn_button1.Size = new System.Drawing.Size(145, 23);
            this.btn_button1.TabIndex = 0;
            this.btn_button1.Text = "OK - Cancel";
            this.btn_button1.UseVisualStyleBackColor = true;
            this.btn_button1.Click += new System.EventHandler(this.btn_button1_Click);
            // 
            // btn_button2
            // 
            this.btn_button2.Location = new System.Drawing.Point(6, 48);
            this.btn_button2.Name = "btn_button2";
            this.btn_button2.Size = new System.Drawing.Size(145, 23);
            this.btn_button2.TabIndex = 1;
            this.btn_button2.Text = "Yes - No";
            this.btn_button2.UseVisualStyleBackColor = true;
            this.btn_button2.Click += new System.EventHandler(this.btn_button2_Click);
            // 
            // btn_buton3
            // 
            this.btn_buton3.Location = new System.Drawing.Point(157, 19);
            this.btn_buton3.Name = "btn_buton3";
            this.btn_buton3.Size = new System.Drawing.Size(145, 23);
            this.btn_buton3.TabIndex = 2;
            this.btn_buton3.Text = "Yes - No - Cancel";
            this.btn_buton3.UseVisualStyleBackColor = true;
            this.btn_buton3.Click += new System.EventHandler(this.btn_buton3_Click);
            // 
            // btn_buton4
            // 
            this.btn_buton4.Location = new System.Drawing.Point(157, 48);
            this.btn_buton4.Name = "btn_buton4";
            this.btn_buton4.Size = new System.Drawing.Size(145, 23);
            this.btn_buton4.TabIndex = 3;
            this.btn_buton4.Text = "Retry - Cancel";
            this.btn_buton4.UseVisualStyleBackColor = true;
            this.btn_buton4.Click += new System.EventHandler(this.btn_buton4_Click);
            // 
            // btn_buton5
            // 
            this.btn_buton5.Location = new System.Drawing.Point(6, 77);
            this.btn_buton5.Name = "btn_buton5";
            this.btn_buton5.Size = new System.Drawing.Size(296, 23);
            this.btn_buton5.TabIndex = 4;
            this.btn_buton5.Text = "Abort - Retry - Ignore";
            this.btn_buton5.UseVisualStyleBackColor = true;
            this.btn_buton5.Click += new System.EventHandler(this.btn_buton5_Click);
            // 
            // MessageBoxlarVeKullanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "MessageBoxlarVeKullanimlari";
            this.Text = "MessageBoxlarVeKullanimlari";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_standart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_button1;
        private System.Windows.Forms.Button btn_button2;
        private System.Windows.Forms.Button btn_buton3;
        private System.Windows.Forms.Button btn_buton4;
        private System.Windows.Forms.Button btn_buton5;
    }
}