using Microsoft.Maui.Controls;
namespace MauiAppDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Text = "Clicked!";
        }
    }
}
