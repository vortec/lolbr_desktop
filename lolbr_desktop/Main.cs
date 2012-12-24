using System;
using Gtk;
using WebKit;


namespace lolbr_desktop
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//string url = "http://otp.me.uk:8000/testing";
			string url = "http://google.de/";
			
			Console.WriteLine("Loading...");
			
			Application.Init();
			Window window = new Window ("lolbr");
			window.SetDefaultSize(1024, 500);
			
			window.Destroyed += delegate (object sender, EventArgs e) {
				Application.Quit ();
			};
			
			ScrolledWindow scrolled_window = new ScrolledWindow ();
			WebView web_view = new WebView ();
			web_view.Open (url);
			scrolled_window.Add (web_view);
			window.Add(scrolled_window);
			window.ShowAll();
			
			Application.Run();
		}
	}
}
