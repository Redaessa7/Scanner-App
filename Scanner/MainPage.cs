using Scanner.Code;
using Scanner.Properties;
using System.Diagnostics;

namespace Scanner
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async Task LoadedDevices()
        {
            //picBoxLoading.Visible = true;
            comboBoxDevices.DataSource = await ScannerHelper.GetAllDevices();
            //picBoxLoading.Visible = false;
        }

        private async void MainPage_Load(object sender, EventArgs e)
        {
            await LoadedDevices();
            comboBoxPaperSize.SelectedIndex = 0;
            textBoxPathSave.Text = Properties.Settings.Default.LocalPath;
            if (textBoxPathSave.Text == string.Empty)
            {
                MessageBox.Show("»—Ã«¡ «Œ Ì«— „”«— «·Õ›Ÿ «Ê·«!", "„ﬂ«‰ «·Õ›Ÿ", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                SelectedFolderPath();
            }
        }


        private void SelectedFolderPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "«Œ Ì«— „”«— Õ›Ÿ «·‰”Œ";
            var resualt = dialog.ShowDialog();
            if (resualt == DialogResult.OK)
            {
                Properties.Settings.Default.LocalPath = dialog.SelectedPath;
                Properties.Settings.Default.Save();
                textBoxPathSave.Text = Properties.Settings.Default.LocalPath;
            }
        }

        private void linkLabelChangeSavePath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelectedFolderPath();
        }

        private void linkLabelOpenSavedPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Properties.Settings.Default.LocalPath,
                UseShellExecute = true,
            };
            Process.Start(psi);
        }

        private async void btnScan_Click(object sender, EventArgs e)
        {
            if (comboBoxDevices.Items.Count == 0)
            {
                MessageBox.Show("·« ÌÊÃœ ÃÂ«“ ·Ì „ «·›Õ’ »—Ã«¡ «· «ﬂœ „‰ «‰ Â‰«ﬂ ÃÂ«“ „«”Õ „Ê’·!", "«Œ Ì«— ÃÂ«“", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
                return;
            }

            string deviceName = comboBoxDevices.SelectedText;
            int DPI = Convert.ToInt32(comboBoxDPI.Value);
            string paperSize = comboBoxPaperSize.SelectedText;
            int color = radioButtonColorized.Checked ? 1 : 2;

            pictureBoxLoading.Show();

            // Start Scanning

            for (int i = 1; i <= numericUpDownCountOfPaper.Value; i++)
            {

                pictureBoxShowImage.Image = Resources.scan;
                
                var scannedImage = await ScannerHelper.ScanAsImageAsync(deviceName, paperSize, color, DPI);
                if (scannedImage != null)
                {
                    pictureBoxShowImage.Image = scannedImage;
                    SaveAutoImage(scannedImage, textBoxPathSave.Text);
                }
                await Task.Delay(1000);
            }
            // End Scanning
            pictureBoxLoading.Hide();
        }

        private void SaveAutoImage(Image image, string folderPath)
        {
            try
            {
                string fileName = Path.Combine(folderPath, $"{Guid.NewGuid()}.jpg");
                using (var imageFile = new Bitmap(fileName))
                {
                    imageFile.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        private string GetSelectedPath()
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.UseDescriptionForTitle = true;
            dialog.Description = "«Œ Ì«— „Ã·œ Õ›Ÿ «·’Ê—Â";
            var resualt = dialog.ShowDialog();
            if (resualt == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return string.Empty;
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            string path = GetSelectedPath();

            if(!string.IsNullOrEmpty(path) && pictureBoxShowImage.Image != null)
            {
                SaveAutoImage(pictureBoxShowImage.Image, path);
                MessageBox.Show(" „ Õ›Ÿ «·’Ê—… »‰Ã«Õ", "Õ›Ÿ «·’Ê—Â", MessageBoxButtons.OK, MessageBoxIcon.None,MessageBoxDefaultButton.Button1,MessageBoxOptions.RtlReading);
            }
        }
    }
}
