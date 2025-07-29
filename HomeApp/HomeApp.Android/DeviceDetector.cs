using Android.OS;
using Xamarin.Forms;
using HomeApp;

[assembly: Dependency(typeof (HomeApp.Droid.DeviceDetector))]
namespace HomeApp.Droid 
{
  public class DeviceDetector: IDeviceDetector 
  {
    public string GetDevice() 
    {
      // Сообщаем строку с информацией о платформе
      return $"Запущено на устройстве {Build.Product},{System.Environment.NewLine} платформа {Device.RuntimePlatform}";
    }
  }
}