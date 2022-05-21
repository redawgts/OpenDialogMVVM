namespace OpenDialogMVVM;

public partial class MainViewModel : ObservableObject
{
    private readonly IWindowManager _manager;

    public MainViewModel(IWindowManager manager)
    {
        _manager = manager;
    }

    [ICommand]
    private void OpenDialog()
    {
        _manager.OpenCoolDialogWindow();
    }

    [ICommand]
    private void OpenDialogWithDI()
    {
        _manager.OpenCoolDialogWindowWithDI();
    }
}
