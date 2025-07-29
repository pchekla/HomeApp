using System;
using System.Linq;
using Xamarin.Forms;
 
namespace HomeApp.Pages
{
  public partial class LoginPage: ContentPage 
   {
    public
    const string BUTTON_TEXT = "Войти";
       public static int loginCounter = 0;

    // Создаем объект, возвращающий свойства устройства
    IDeviceDetector detector = DependencyService.Get < IDeviceDetector > ();
 
       public LoginPage()
       {
           InitializeComponent();

      if (Device.Idiom == TargetIdiom.Desktop)
        loginButton.CornerRadius = 0;

      // Передаем информацию о платформе на экран
      if (detector != null)
      {
          runningDevice.Text = detector.GetDevice();
      }
      else
      {
          // Fallback решение если DependencyService не работает
          runningDevice.Text = $"Запущено на платформе {Device.RuntimePlatform}";
      }
       }
 
       /// <summary>
       /// По клику обрабатываем счётчик и выводим разные сообщения
       /// </summary>
    private void Login_Click(object sender, EventArgs e) {
      if (loginCounter == 0) 
           {
               loginButton.Text = $"Выполняется вход..";
           }
      else if (loginCounter > 5) 
           {
               loginButton.IsEnabled = false;

        var infoMessage = (Label) stackLayout.Children.Last();
        infoMessage.Text = "Слишком много попыток! Попробуйте позже";
        // задаем красный цвет сообщения
        infoMessage.TextColor = Color.FromRgb(255, 0, 0);
           }
           else
           {
               loginButton.Text = $"Выполняется вход...   Попыток входа: {loginCounter}";
           }

           loginCounter += 1;
       }
   }
}
