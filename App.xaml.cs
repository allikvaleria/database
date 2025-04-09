using database.Views;

namespace database
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new FriendsListPage());
        }

    }
}