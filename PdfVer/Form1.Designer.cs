namespace PdfVer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            convertPDFVersion = new Button();
            groupBox1 = new GroupBox();
            SelectPDFs = new Button();
            selectedPDFVersion = new ComboBox();
            PdfFilesList = new ListBox();
            SelectPDFFiles = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // convertPDFVersion
            // 
            convertPDFVersion.BackColor = Color.MediumSeaGreen;
            convertPDFVersion.Location = new Point(14, 201);
            convertPDFVersion.Name = "convertPDFVersion";
            convertPDFVersion.Size = new Size(340, 30);
            convertPDFVersion.TabIndex = 0;
            convertPDFVersion.Text = "Convert";
            convertPDFVersion.UseVisualStyleBackColor = false;
            convertPDFVersion.Click += convertPDFVersion_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SelectPDFs);
            groupBox1.Controls.Add(selectedPDFVersion);
            groupBox1.Controls.Add(PdfFilesList);
            groupBox1.Controls.Add(convertPDFVersion);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 237);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "PDF Version Changer";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // SelectPDFs
            // 
            SelectPDFs.BackColor = Color.MediumSeaGreen;
            SelectPDFs.Location = new Point(205, 26);
            SelectPDFs.Name = "SelectPDFs";
            SelectPDFs.Size = new Size(149, 140);
            SelectPDFs.TabIndex = 3;
            SelectPDFs.Text = "Select PDF File(s)";
            SelectPDFs.UseVisualStyleBackColor = false;
            SelectPDFs.Click += SelectPDF_Click;
            // 
            // selectedPDFVersion
            // 
            selectedPDFVersion.BackColor = Color.MediumSeaGreen;
            selectedPDFVersion.FormattingEnabled = true;
            selectedPDFVersion.Items.AddRange(new object[] { "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "2.0" });
            selectedPDFVersion.Location = new Point(205, 172);
            selectedPDFVersion.Name = "selectedPDFVersion";
            selectedPDFVersion.Size = new Size(149, 23);
            selectedPDFVersion.TabIndex = 2;
            selectedPDFVersion.Text = "Select Version";
            // 
            // PdfFilesList
            // 
            PdfFilesList.BackColor = Color.MediumSeaGreen;
            PdfFilesList.FormattingEnabled = true;
            PdfFilesList.ItemHeight = 15;
            PdfFilesList.Location = new Point(14, 26);
            PdfFilesList.Name = "PdfFilesList";
            PdfFilesList.Size = new Size(185, 169);
            PdfFilesList.TabIndex = 1;
            // 
            // SelectPDFFiles
            // 
            SelectPDFFiles.FileName = "SelectPDFFiles";
            SelectPDFFiles.Filter = "PDF Files|*.pdf";
            SelectPDFFiles.Multiselect = true;
            SelectPDFFiles.RestoreDirectory = true;
            SelectPDFFiles.FileOk += SelectPDFFiles_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(384, 261);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.InactiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "PdfVer";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button convertPDFVersion;
        private GroupBox groupBox1;
        private ComboBox selectedPDFVersion;
        private ListBox PdfFilesList;
        private OpenFileDialog SelectPDFFiles;
        private Button SelectPDFs;
    }
}