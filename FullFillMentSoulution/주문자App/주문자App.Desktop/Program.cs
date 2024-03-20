using Avalonia;
using Avalonia.ReactiveUI;
using System;

namespace 주문자App.Desktop
{
    internal sealed class Program
    {
        // Initialization code. Don't use any Avalonia, third-party APIs or any
        // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
        // yet and stuff might break.
        [STAThread]
        public static void Main(string[] args) => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

        // Avalonia configuration, don't remove; also used by visual designer.
        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .WithInterFont()
                .LogToTrace()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<MainViewModel>();
                    // 다른 서비스나 ViewModel을 여기에 등록할 수 있습니다.
                })
                .UseReactiveUI();
        private static void ConfigureServices(IServiceCollection services)
        {
            // ViewModel 등록
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<LoginViewModel>();
            // 필요한 다른 서비스나 ViewModel을 여기에 등록
        }
    }
}
