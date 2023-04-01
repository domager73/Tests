namespace Tests
{
    partial class FormMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBoxFileName = new System.Windows.Forms.MaskedTextBox();
            this.buttomNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(454, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите файл для считывания";
            // 
            // maskedTextBoxFileName
            // 
            this.maskedTextBoxFileName.Location = new System.Drawing.Point(499, 331);
            this.maskedTextBoxFileName.Name = "maskedTextBoxFileName";
            this.maskedTextBoxFileName.Size = new System.Drawing.Size(190, 23);
            this.maskedTextBoxFileName.TabIndex = 1;
            // 
            // buttomNext
            // 
            this.buttomNext.Location = new System.Drawing.Point(532, 360);
            this.buttomNext.Name = "buttomNext";
            this.buttomNext.Size = new System.Drawing.Size(121, 42);
            this.buttomNext.TabIndex = 2;
            this.buttomNext.Text = "Далее";
            this.buttomNext.UseVisualStyleBackColor = true;
            this.buttomNext.Click += new System.EventHandler(this.buttomNext_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 654);
            this.Controls.Add(this.buttomNext);
            this.Controls.Add(this.maskedTextBoxFileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaskedTextBox maskedTextBoxFileName;
        private Button buttomNext;
        private Button buttomRes;
    }
}