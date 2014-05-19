namespace BarcodeGenerator
{
    partial class CreateBarcodeForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.StringToConvertTextBox = new System.Windows.Forms.TextBox();
            this.FileNameToSaveTextBox = new System.Windows.Forms.TextBox();
            this.BarcodePictureBox = new System.Windows.Forms.PictureBox();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ToClipboardButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "String to Convert";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "File Name to Save";
            // 
            // StringToConvertTextBox
            // 
            this.StringToConvertTextBox.Location = new System.Drawing.Point(153, 41);
            this.StringToConvertTextBox.Name = "StringToConvertTextBox";
            this.StringToConvertTextBox.Size = new System.Drawing.Size(177, 20);
            this.StringToConvertTextBox.TabIndex = 2;
            // 
            // FileNameToSaveTextBox
            // 
            this.FileNameToSaveTextBox.Location = new System.Drawing.Point(153, 79);
            this.FileNameToSaveTextBox.Name = "FileNameToSaveTextBox";
            this.FileNameToSaveTextBox.Size = new System.Drawing.Size(177, 20);
            this.FileNameToSaveTextBox.TabIndex = 3;
            // 
            // BarcodePictureBox
            // 
            this.BarcodePictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BarcodePictureBox.Location = new System.Drawing.Point(34, 117);
            this.BarcodePictureBox.Name = "BarcodePictureBox";
            this.BarcodePictureBox.Size = new System.Drawing.Size(296, 50);
            this.BarcodePictureBox.TabIndex = 4;
            this.BarcodePictureBox.TabStop = false;
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(34, 209);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 5;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(254, 209);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 6;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ToClipboardButton
            // 
            this.ToClipboardButton.Location = new System.Drawing.Point(143, 209);
            this.ToClipboardButton.Name = "ToClipboardButton";
            this.ToClipboardButton.Size = new System.Drawing.Size(75, 23);
            this.ToClipboardButton.TabIndex = 7;
            this.ToClipboardButton.Text = "To Clipboard";
            this.ToClipboardButton.UseVisualStyleBackColor = true;
            this.ToClipboardButton.Click += new System.EventHandler(this.ToClipboardButton_Click);
            // 
            // CreateBarcodeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 261);
            this.Controls.Add(this.ToClipboardButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ConvertButton);
            this.Controls.Add(this.BarcodePictureBox);
            this.Controls.Add(this.FileNameToSaveTextBox);
            this.Controls.Add(this.StringToConvertTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateBarcodeForm";
            this.Text = "Create ID Automation 128 Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StringToConvertTextBox;
        private System.Windows.Forms.TextBox FileNameToSaveTextBox;
        private System.Windows.Forms.PictureBox BarcodePictureBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ToClipboardButton;
    }
}

