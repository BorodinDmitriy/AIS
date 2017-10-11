namespace Lab1
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
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.btnImageUpload = new System.Windows.Forms.Button();
            this.btnRecognize = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(31, 30);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(346, 347);
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // btnImageUpload
            // 
            this.btnImageUpload.Location = new System.Drawing.Point(402, 30);
            this.btnImageUpload.Name = "btnImageUpload";
            this.btnImageUpload.Size = new System.Drawing.Size(222, 34);
            this.btnImageUpload.TabIndex = 1;
            this.btnImageUpload.Text = "Загрузить картинку";
            this.btnImageUpload.UseVisualStyleBackColor = true;
            this.btnImageUpload.Click += new System.EventHandler(this.btnImageUpload_Click);
            // 
            // btnRecognize
            // 
            this.btnRecognize.Location = new System.Drawing.Point(402, 82);
            this.btnRecognize.Name = "btnRecognize";
            this.btnRecognize.Size = new System.Drawing.Size(222, 34);
            this.btnRecognize.TabIndex = 2;
            this.btnRecognize.Text = "Распознать";
            this.btnRecognize.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(399, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecognize);
            this.Controls.Add(this.btnImageUpload);
            this.Controls.Add(this.pbxImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Button btnImageUpload;
        private System.Windows.Forms.Button btnRecognize;
        private System.Windows.Forms.Label label1;
    }
}

