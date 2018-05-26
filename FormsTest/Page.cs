using System;

using Xamarin.Forms;

namespace FormsTest
{
    public class Page : ContentPage
    {
        public Page()
        {
        }
		protected override void OnAppearing()
		{
            base.OnAppearing();
            DependencyService.Get<IFormsTest>()?.PushPage(AutomationId);
		}
		protected override void OnDisappearing()
		{
            base.OnDisappearing();
            DependencyService.Get<IFormsTest>()?.PopPage(AutomationId);
		}
	}
}

