namespace Xylocopadream.UserNotification.Maui.DI;

public static class UserNotificationModule
{
    /// <summary>
    /// Inject INotificationService for notification under MAUI
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection AddUserNotificationMaui(this IServiceCollection services)
    {
        services.AddTransient<INotificationService, NotificationService>();

        return services;
    }
}
