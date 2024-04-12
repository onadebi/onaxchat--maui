using OnaxChat.MVVM.Common;
using System.Windows;
using System.Windows.Input;

namespace OnaxChat.MVVM.ViewModel;

public class MainViewModel : CommonINotify
{
    string _text = "Hello";
    string _appName = "OnaxChat";

    public string AppName
    {
        get => _appName;
        set
        {
            _appName = value;
            OnPropertyChanged(nameof(AppName));
        }
    }

    public string Text
    {
        get => _text;

        set
        {
            _text = value;
            OnPropertyChanged(nameof(Text));
        }
    }

    #region Commands
    public ICommand CloseApplication => new RelayCommand((object s) =>
    {
        MessageBoxResult result = MessageBox.Show("Exit program ?", "Confirmation", MessageBoxButton.YesNo,MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
        {
            App.Current.Shutdown();
        }
    });

    public ICommand btnWindow_MinimizeCmd => new RelayCommand((object s) =>
    {
        App.Current.MainWindow.WindowState = WindowState.Minimized;
    });

    public ICommand BtnWindowSizeToggleCmd => new RelayCommand((object s) =>
    {
        WindowState windowState = App.Current.MainWindow.WindowState;
        App.Current.MainWindow.WindowState = windowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized;
    });
    #endregion

}
