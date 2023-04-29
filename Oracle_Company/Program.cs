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
			Application.Run(new TaiChinhForm());
            Oracle_Management_Library.GlobalConfig.InitializeConnections();
            Application.Run(new NhanVien());
		}
	}
}