using System.Windows;

namespace OpenDialogMVVM;

public partial class DialogWindow : Window
{
    public DialogWindow(DialogViewModel viewModel)
    {
        InitializeComponent();
        DataContext = viewModel;
    }
}
