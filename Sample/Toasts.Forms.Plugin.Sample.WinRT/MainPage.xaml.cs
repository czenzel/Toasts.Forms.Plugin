﻿namespace Toasts.Forms.Plugin.Sample.WinRT
{
    using global::Plugin.Toasts.WinRT;
    using Xamarin.Forms;

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            
            DependencyService.Register<ToastNotification>();
            ToastNotification.Init();

            LoadApplication(new Sample.App());
        }
    }
}
