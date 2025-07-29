// Ignore Spelling: App

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
               // Исправлено: правильное имя поля для Entry - placeHolder
               placeHolder.PlaceholderColor = Color.SlateGray;
               // Исправлено: предполагаемое имя кнопки - loginButton -> registerButton
               registerButton.TextColor = Color.AliceBlue;
               registerButton.Margin = new Thickness(0, 5);
           }
       }
   }
}