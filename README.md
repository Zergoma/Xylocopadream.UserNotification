# Xylocopadream.UserNotification

A UI-agnostic `INotificationService` to show error, warning and info messages, so view models do not depend on a UI framework.

| Package | Content |
|---|---|
| `Xylocopadream.UserNotification` | The `INotificationService` interface |
| `Xylocopadream.UserNotification.Maui` | .NET MAUI implementation (alert dialogs) |

## Usage

```csharp
builder.Services.AddUserNotificationMaui();
```

```csharp
public sealed class LoginViewModel(INotificationService notifications)
{
    public Task OnLoginFailedAsync(string reason) => notifications.ShowErrorAsync(reason);
}
```

## License

MIT
