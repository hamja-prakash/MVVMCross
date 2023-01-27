using MvvmCross.Commands;
using MvvmCross.ViewModels;
using MvxForms.Core.Model;
using MvxForms.Core.Services;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MvxForms.Core.ViewModels
{
    public class MainViewModel : MvxViewModel
    {
        private IUserService UserService;
        public ObservableCollection<User> Users { get; } = new ObservableCollection<User>();
        public MainViewModel(IUserService userService)
        {
            UserService = userService;
        }


        private string _text = "Hello MvvmCross";
        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value); }
        }

        private string _title = "MvvmCross";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public override void ViewAppeared()
        {
            base.ViewAppeared();
            var mUsers = UserService.GetUsers();
            foreach (var contact in mUsers)
            {
                Users.Add(contact);
            }
        }

        public Task ShowContactDetails(User user)
        {
            return NavigationService.Navigate<UserDetailsViewModel, User>(user);
        }
    }
}
