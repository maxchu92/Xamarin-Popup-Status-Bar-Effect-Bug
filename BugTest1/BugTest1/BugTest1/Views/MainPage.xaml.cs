using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BugTest1.Views {
	public partial class MainPage {
		public MainPage() {
			InitializeComponent();
		}

		private async void BtnOpenContentPage_Clicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ContentTestPage());
		}

		private async void BtnOpenPopupPage_Clicked(object sender, EventArgs e) {
			await PopupNavigation.Instance.PushAsync(new PopupTestPage());
		}
	}
}
