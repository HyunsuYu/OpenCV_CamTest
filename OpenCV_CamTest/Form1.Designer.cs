
namespace OpenCV_CamTest
{
    partial class Form1
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
            this.pictureBox_CamImage = new System.Windows.Forms.PictureBox();
            this.button_Capture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CamImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_CamImage
            // 
            this.pictureBox_CamImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox_CamImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_CamImage.Name = "pictureBox_CamImage";
            this.pictureBox_CamImage.Size = new System.Drawing.Size(763, 636);
            this.pictureBox_CamImage.TabIndex = 0;
            this.pictureBox_CamImage.TabStop = false;
            // 
            // button_Capture
            // 
            this.button_Capture.Location = new System.Drawing.Point(769, 554);
            this.button_Capture.Name = "button_Capture";
            this.button_Capture.Size = new System.Drawing.Size(172, 70);
            this.button_Capture.TabIndex = 1;
            this.button_Capture.Text = "Start";
            this.button_Capture.UseVisualStyleBackColor = true;
            this.button_Capture.Click += new System.EventHandler(this.button_Capture_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 636);
            this.Controls.Add(this.button_Capture);
            this.Controls.Add(this.pictureBox_CamImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CamImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_CamImage;
        private System.Windows.Forms.Button button_Capture;
    }
}

