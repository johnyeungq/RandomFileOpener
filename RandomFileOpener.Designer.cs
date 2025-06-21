namespace RandomFileOpener
{
    partial class RandomFileOpener
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
            FolderPathTB = new TextBox();
            label1 = new Label();
            browseBtn = new Button();
            openBtn = new Button();
            FileGetLabel = new Label();
            TypeCB = new ComboBox();
            SuspendLayout();
            // 
            // FolderPathTB
            // 
            FolderPathTB.Location = new Point(12, 52);
            FolderPathTB.Name = "FolderPathTB";
            FolderPathTB.Size = new Size(376, 23);
            FolderPathTB.TabIndex = 0;
            FolderPathTB.TextChanged += FolderPathTB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Folder Path";
            // 
            // browseBtn
            // 
            browseBtn.Location = new Point(394, 52);
            browseBtn.Name = "browseBtn";
            browseBtn.Size = new Size(75, 23);
            browseBtn.TabIndex = 2;
            browseBtn.Text = "Browse";
            browseBtn.UseVisualStyleBackColor = true;
            browseBtn.Click += browseBtn_Click;
            // 
            // openBtn
            // 
            openBtn.Location = new Point(382, 95);
            openBtn.Name = "openBtn";
            openBtn.Size = new Size(99, 49);
            openBtn.TabIndex = 3;
            openBtn.Text = "Open";
            openBtn.UseVisualStyleBackColor = true;
            openBtn.Click += openBtn_Click;
            // 
            // FileGetLabel
            // 
            FileGetLabel.AutoSize = true;
            FileGetLabel.Location = new Point(12, 95);
            FileGetLabel.Name = "FileGetLabel";
            FileGetLabel.Size = new Size(77, 15);
            FileGetLabel.TabIndex = 4;
            FileGetLabel.Text = "FileGetLabel";
            FileGetLabel.Visible = false;
            // 
            // TypeCB
            // 
            TypeCB.FormattingEnabled = true;
            TypeCB.Items.AddRange(new object[] { "File", "Folder" });
            TypeCB.Location = new Point(12, 8);
            TypeCB.Name = "TypeCB";
            TypeCB.Size = new Size(121, 23);
            TypeCB.TabIndex = 5;
            // 
            // RandomFileOpener
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 185);
            Controls.Add(TypeCB);
            Controls.Add(FileGetLabel);
            Controls.Add(openBtn);
            Controls.Add(browseBtn);
            Controls.Add(label1);
            Controls.Add(FolderPathTB);
            Name = "RandomFileOpener";
            Text = "RandomFileOpener";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox FolderPathTB;
        private Label label1;
        private Button browseBtn;
        private Button openBtn;
        private Label FileGetLabel;
        private ComboBox TypeCB;
    }
}
