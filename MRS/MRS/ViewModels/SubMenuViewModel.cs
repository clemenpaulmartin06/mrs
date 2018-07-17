using MRS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace MRS.ViewModels
{
    public class SubMenuViewModel
    {
        public ObservableCollection<MoreVert> MoreVertList { get; set; }

        private MoreVert _selectedMenu { get; set; }
        public MoreVert SelectedMenu {
            get { return _selectedMenu; }
            set
            {
                if (_selectedMenu != value)
                {
                    _selectedMenu = value;

                    HandleSelectedItem();
                }
            }
        }

        private void HandleSelectedItem()
        {
            Page page = new Page();
            page.DisplayAlert("selected item ", "Description : " + _selectedMenu.Description , "Ok");
        }

        public SubMenuViewModel()
        {
            MoreVertList = new ObservableCollection<MoreVert>
            {
                new MoreVert() { id = 1, Description = "Print", Icon = "baseline_print_black_24.png" },
                new MoreVert() { id = 2, Description = "Average", Icon = "baseline_details_black_24.png" },
                new MoreVert() { id = 3, Description = "Move to First", Icon = "baseline_fast_rewind_black_24.png" },
                new MoreVert() { id = 4, Description = "Move to Last", Icon = "baseline_fast_forward_black_24.png" },
                new MoreVert() { id = 5, Description = "Clear", Icon = "baseline_clear_all_black_24.png" }
            };
        }
    }
}
