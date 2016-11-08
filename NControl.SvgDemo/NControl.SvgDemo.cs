using System;
using NControl.Controls;
using NControl.SvgDemo.Resources;
using Xamarin.Forms;

namespace NControl.SvgDemo
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			var content = new ContentPage
			{
				Title = "NControl.SvgDemo",
				Content = new StackLayout
				{
					Padding = 18,
					Spacing = 28,
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							HorizontalTextAlignment = TextAlignment.Center,
							Text = "This is an example of an embedded SVG:"
						},
						new SvgImage{
							// Provide a type contained in the assembly where your svg file
							// is located, I often create a c# class in the same directory
							// as the resources itself to use this to resolve types.
							SvgAssemblyType = typeof(ResourceLoader),

							// Now lets find the name of the resource by using the namespace from
							// the class ResourceLoader (it needs to contain the name of the folder
							// where the class and resource is located
							SvgResource = typeof(ResourceLoader).Namespace + ".Smile.svg",

							// Set height request and layout info to calculate layout
							HeightRequest = 55,
							HorizontalOptions = LayoutOptions.Center,
						}
					}
				}
			};

			MainPage = new NavigationPage(content);
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
