
namespace AppNote.Views;

public partial class NoteNiew : ContentView
{
	public NoteNiew()
	{
        InitializeComponent();
		BindingContext = new ViewModels.NoteViewModel();
	}

 
}