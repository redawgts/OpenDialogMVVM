global using CommunityToolkit.Mvvm.ComponentModel;
global using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace OpenDialogMVVM;

public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        Ioc.Default.ConfigureServices(new ServiceCollection()
            .AddSingleton<MainWindow>()
            .AddTransient<MainViewModel>()
            .AddTransient<Window, DialogWindow>()
            .AddTransient<DialogViewModel>()
            .AddTransient<IWindowManager, WindowManager>()
            .BuildServiceProvider());

        MainWindow = Ioc.Default.GetRequiredService<MainWindow>();
        MainWindow.Show();
    }
}