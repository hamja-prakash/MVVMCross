using MvvmCross.ViewModels;
using MvxForms.Core.Model;

namespace MvxForms.Core.ViewModels
{
    public class UserDetailsViewModel : MvxViewModel<User>
    {
        public User User { get; private set; }

        public override void Prepare(User user)
        {
            base.Prepare();
            User = user;
        }
    }
}
