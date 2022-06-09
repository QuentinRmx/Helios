using TodoApp.Data.Models;
using TodoApp.Data.Repository;

namespace TodoApp;

public partial class App : Application
{
	public static Repository<Todo> TodoRepo { get; private set; }


	public static Page? MainPageRef { get; private set; }

	public App(Repository<Todo> todoRepo)
	{
		InitializeComponent();

		TodoRepo = todoRepo;


		MainPage = new MainPage();
		MainPageRef = MainPage;
	}
}
