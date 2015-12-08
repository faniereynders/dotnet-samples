using System.Runtime.InteropServices;

namespace AwesomeApp {
	public static class EnvironmentHelpers{
		public static string OSName{
			get {
				var osName = string.Empty;
				if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)){
					osName = "Windows";
				}
				else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)){
					osName = "Mac";
				}
				else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)){
					osName = "Linux";
				}
				
				return osName;
			}
		}
	}
}