﻿using System;

using Xamarin.Forms;

namespace Kernel
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new CoursePage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

