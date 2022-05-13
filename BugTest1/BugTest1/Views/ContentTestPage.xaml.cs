using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BugTest1.Views {
	public partial class ContentTestPage {
		public ContentTestPage() {
			InitializeComponent();
		}
		private async void BtnOpenContentPage_Clicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ContentTestPage());
		}

		private async void BtnOpenPopupPage_Clicked(object sender, EventArgs e) {
			await PopupNavigation.Instance.PushAsync(new PopupTestPage());
		}

		private async void BtnBack_Clicked(object sender, EventArgs e) {
			await Navigation.PopAsync();
		}

		private void BtnResetStack_Clicked(object sender, EventArgs e) {
			Application.Current.MainPage = new NavigationPage(new MainPage());
		}
	}
}
