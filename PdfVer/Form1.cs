using PdfSharp.Pdf.IO;
using PdfSharp.Pdf;

namespace PdfVer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            InitializeComponent();
        }

        private void SelectPDF_Click(object sender, EventArgs e)
        {
            string pdfFileNames = "";
            SelectPDFFiles.ShowDialog(this);
            foreach (String file in SelectPDFFiles.FileNames)
            {
                pdfFileNames += file;
                PdfFilesList.Items.Add(file);
            }
        }

        private void ChangePDFVersion(string filePath, string targetVersion)
        {
            string outputFilePath = Path.Combine(Path.GetDirectoryName(filePath), "changed_" + Path.GetFileName(filePath));

            try
            {
                PdfDocument document = PdfReader.Open(filePath, PdfDocumentOpenMode.Modify);
                document.Version = (int)(float.Parse(targetVersion) * 10);
                document.Save(outputFilePath);
                document.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error changing PDF version for {Path.GetFileName(filePath)}: {ex.Message}");
                this.Close();
            }
        }

        private void convertPDFVersion_Click(object sender, EventArgs e)
        {
            string selectedVersion = selectedPDFVersion.Text;

            if (PdfFilesList.Items.Count == 0)
            {
                MessageBox.Show("Please select PDFs and a target version.");
                return;
            }

            foreach (string item in PdfFilesList.Items)
            {
                ChangePDFVersion(item, selectedVersion);
            }

            MessageBox.Show("PDF versions changed successfully.");
        }
    }
}