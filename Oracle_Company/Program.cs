namespace Oracle_Company
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Oracle_Management_Library.GlobalConfig.InitializeConnections();
<<<<<<< HEAD
            Application.Run(new TruongDeAn());
=======
			Application.Run(new TruongPhongcs());
			Application.Run(new NhanVien());

>>>>>>> 303208ced7b62b44b15680e5be8f6f149767e2aa
		}
	}
}