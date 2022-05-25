namespace BoutonAutomatique
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                Button btn = (Button)sender;
            }
            catch(Exception ex)
            {

            }*/
            /*
            Button btn = sender as Button;
            if(btn != null)
            {

            }*/

            if (sender is Button btn)
            {
                MessageBox.Show("C'est un boutton !", "Tatata");
            }
            else
            {
                MessageBox.Show(
                    "Erreur fatale !", 
                    "erreur", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}