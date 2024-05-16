namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                string Msg = "";
                double Etanol = Convert.ToDouble (txt_etanol.Text);
                double Gasolina = Convert.ToDouble(txt_gasolina.Text);
                if (Etanol <= (Gasolina * 0.7))
                {
                    Msg = "O valor do etanol está compensando";
                }
                else
                {
                    Msg = "A gasolina está compensando";
                }
                DisplayAlert("Calculando", Msg, "Ok");
            }catch (Exception ex)
            {
                DisplayAlert("Ops",ex.Message, "Fechar");
            }
        }
    }
}
