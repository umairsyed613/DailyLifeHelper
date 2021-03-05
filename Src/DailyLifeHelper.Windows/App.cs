using System;

using Microsoft.MobileBlazorBindings.WebView.Windows;

using Xamarin.Forms;
using Xamarin.Forms.Platform.WPF;

namespace DailyLifeHelper.Windows
{
    public class MainWindow : FormsApplicationPage
    {
        [STAThread]
        public static void Main()
        {
            var app = new System.Windows.Application();
            app.Run(new MainWindow());
        }

        public MainWindow()
        {
            Forms.Init();
            BlazorHybridWindows.Init();
            LoadApplication(new App());
        }
    }
}
