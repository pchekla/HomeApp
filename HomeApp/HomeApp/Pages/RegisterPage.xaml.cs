using Xamarin.Forms;
 
namespace HomeApp.Pages
{
   public partial class RegisterPage : ContentPage
   {
       public RegisterPage()
       {
           InitializeComponent();
           PlatformAdjust();
       }
 
       /// <summary>
       /// Настраиваем вид для разных платформ
       /// </summary>
       public void PlatformAdjust()
       {
           if (Device.RuntimePlatform == Device.UWP)
           {
               placeHolder.PlaceholderColor = Color.SlateGray;
               loginButton.TextColor = Color.AliceBlue;
               loginButton.Margin = new Thickness(0, 5);
           }
       }
   }
}