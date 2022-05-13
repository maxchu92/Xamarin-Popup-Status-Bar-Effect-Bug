using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BugTest1.Views {
	public partial class PopupTestPage {
		public PopupTestPage() {
			InitializeComponent();
		}
		private async void BtnOpenContentPage_Clicked(object sender, EventArgs e) {
			await Navigation.PushAsync(new ContentTestPage());
			await PopupNavigation.Instance.PopAllAsync();
		}

		private async void BtnOpenPopupPage_Clicked(object sender, EventArgs e) {
			await PopupNavigation.Instance.PushAsync(new PopupTestPage());
		}

		private async void BtnBack_Clicked(object sender, EventArgs e) {
			if (PopupNavigation.Instance.PopupStack.Any()) {
				await PopupNavigation.Instance.PopAsync();
			}
			await Navigation.PopAsync();
		}

		private async void BtnResetStack_Clicked(object sender, EventArgs e) {
			if (PopupNavigation.Instance.PopupStack.Any()) {
				await PopupNavigation.Instance.PopAllAsync();
				Application.Current.MainPage = new NavigationPage(new MainPage());
			}
		}
	}
}
