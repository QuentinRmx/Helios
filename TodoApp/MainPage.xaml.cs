using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;

namespace TodoApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    /// <summary>
    /// If Android then standard Toast notification will be displayed with embedded message (short duration and 14d font size).
    /// If Windows, a similar type of notification is displayed with the given message.
    /// </summary>
    /// <param name="message">The message to be displayed in the notification.</param>
    /// <returns>Task for await calls.</returns>
	public async Task ShowToast(string message)
    {
#if ANDROID
        await ShowToastAndroid(message);
#else
        await ShowToastWindows(message);
#endif
    }

    private async Task ShowToastAndroid(string message)
    {
        var toast = Toast.Make(message);
        await toast.Show();

    }

    private async Task ShowToastWindows(string message)
    {
        // TODO: yikes
        var popup = new Popup
        {
            Content = new VerticalStackLayout
            {
                Children =
        {
            new Label
            {
                Text = message
            }
        }
            }
        };

        await this.ShowPopupAsync(popup);
    }
}
