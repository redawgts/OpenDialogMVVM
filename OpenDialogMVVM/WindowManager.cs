using System.Windows;

namespace OpenDialogMVVM;

public class WindowManager : IWindowManager
{
    private readonly IEnumerable<Window> _windows;

    public WindowManager(IEnumerable<Window> windows)
    {
        _windows = windows;
    }

    public bool? OpenCoolDialogWindow()
    {
        var dialog = new DialogWindow(new DialogViewModel());
        return dialog.ShowDialog();
    }

    public bool? OpenCoolDialogWindowWithDI()
    {
        var dialog = _windows.First(w => w.GetType() == typeof(DialogWindow));
        return dialog.ShowDialog();
    }
}