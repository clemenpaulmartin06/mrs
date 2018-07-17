using MRS.Models;
using MRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MRS.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PopupView 
	{
		public PopupView ()
		{
			InitializeComponent ();
            BindingContext = new SubMenuViewModel();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var vm = BindingContext as SubMenuViewModel;
            var submenu = e.Item as MoreVert;

            
            DisplayAlert("selected item ", "Description : " + submenu.Description, "Ok");
        }
    }
}