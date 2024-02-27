namespace AudioConvert
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
            openFileDialog1 = new OpenFileDialog();
            filePath = new TextBox();
            openButton = new Button();
            nameBox = new TextBox();
            saveButton = new Button();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // filePath
            // 
            filePath.Location = new Point(12, 12);
            filePath.Name = "filePath";
            filePath.Size = new Size(246, 23);
            filePath.TabIndex = 0;
            // 
            // openButton
            // 
            openButton.Location = new Point(291, 12);
            openButton.Name = "openButton";
            openButton.Size = new Size(75, 23);
            openButton.TabIndex = 1;
            openButton.Text = "Open";
            openButton.UseVisualStyleBackColor = true;
            openButton.Click += openButton_Click;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(12, 82);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(246, 23);
            nameBox.TabIndex = 2;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(291, 82);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 3;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(nameBox);
            Controls.Add(openButton);
            Controls.Add(filePath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox filePath;
        private Button openButton;
        private TextBox nameBox;
        private Button saveButton;
    }
}
