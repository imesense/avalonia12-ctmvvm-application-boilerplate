using System;

using Avalonia;

namespace ImeSense.Boilerplates.Avalonia.Windows;

internal sealed class Program
{
    /// <summary>
    /// Initialization code.
    /// </summary>
    /// <param name="args"></param>
    [STAThread]
    public static void Main(string[] args)
    {
        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
    }

    /// <summary>
    /// Avalonia configuration. Also used by visual designer.
    /// </summary>
    /// <returns></returns>
    public static AppBuilder BuildAvaloniaApp()
    {
        return AppBuilder.Configure<App>()
            .UsePlatformDetect()
#if DEBUG
            .WithDeveloperTools()
#endif
            .UseWin32()
            .WithInterFont()
            .LogToTrace();
    }
}
