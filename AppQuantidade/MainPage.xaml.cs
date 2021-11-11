using Xamarin.Forms;

namespace AppQuantidade
{
    public partial class MainPage : ContentPage
    {
        public int quantidade = 0;


        public MainPage()
        {
            InitializeComponent();
            UpdateNumber();
        }

        private void UpdateNumber()
        {
            LblQuantidade.Text = quantidade.ToString();
        }

        private void IncrementAction(object sender, System.EventArgs e)
        {
            quantidade++;
            UpdateNumber();
        }

        private void DecrementAction(object sender, System.EventArgs e)
        {
            if (quantidade > 0)
                quantidade--;

            UpdateNumber();
        }
    }
}
