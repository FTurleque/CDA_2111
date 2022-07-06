namespace HttpWebClient
{
    public partial class MainWindow : Form
    {
        Uri uri;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                uri = new Uri(txtUrl.Text);
                Thread thread = new Thread(Downloader.Download);
                thread.Start(uri);

            }
            catch (ArgumentException ex)
            {

            }
            catch (UriFormatException ex)
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}