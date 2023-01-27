using MvvmCross.Forms.Views;
using MvxForms.Core.Model;
using Xamarin.Forms;

namespace MVVMCrossDemo.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GrdContact_Tapped(object sender, System.EventArgs e)
        {
            if (sender is Grid grdContact && grdContact.BindingContext is User mUser && mUser != null)
            {
                ViewModel.ShowContactDetails(mUser);
            }
        }
    }
}