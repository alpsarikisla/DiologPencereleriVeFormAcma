namespace DialogPencereleriVeFormAcma
{
    partial class AnaForm
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
            this.btn_formAc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_formAc
            // 
            this.btn_formAc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_formAc.Location = new System.Drawing.Point(33, 34);
            this.btn_formAc.Name = "btn_formAc";
            this.btn_formAc.Size = new System.Drawing.Size(192, 43);
            this.btn_formAc.TabIndex = 1;
            this.btn_formAc.Text = "Form Aç";
            this.btn_formAc.UseVisualStyleBackColor = true;
            this.btn_formAc.Click += new System.EventHandler(this.btn_formAc_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(33, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "Dialog Aç";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_formAc);
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_formAc;
        private System.Windows.Forms.Button button1;
    }
}