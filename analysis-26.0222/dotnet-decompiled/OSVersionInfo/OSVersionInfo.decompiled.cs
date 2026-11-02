using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.Win32;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("OSVersionInfoDLL")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("OSVersionInfoDLL")]
[assembly: AssemblyCopyright("Copyright ©  2010-2016")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("a3be4af5-b38a-442d-a0a8-8c63450c2888")]
[assembly: AssemblyFileVersion("3.0.0.0")]
[assembly: AssemblyVersion("3.0.0.0")]
namespace JCS
{
	public static class OSVersionInfo
	{
		public enum SoftwareArchitecture
		{
			Unknown,
			Bit32,
			Bit64
		}

		public enum ProcessorArchitecture
		{
			Unknown,
			Bit32,
			Bit64,
			Itanium64
		}

		private delegate bool IsWow64ProcessDelegate([In] IntPtr handle, out bool isWow64Process);

		private struct OSVERSIONINFOEX
		{
			public int dwOSVersionInfoSize;

			public int dwMajorVersion;

			public int dwMinorVersion;

			public int dwBuildNumber;

			public int dwPlatformId;

			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
			public string szCSDVersion;

			public short wServicePackMajor;

			public short wServicePackMinor;

			public short wSuiteMask;

			public byte wProductType;

			public byte wReserved;
		}

		public struct SYSTEM_INFO
		{
			internal _PROCESSOR_INFO_UNION uProcessorInfo;

			public uint dwPageSize;

			public IntPtr lpMinimumApplicationAddress;

			public IntPtr lpMaximumApplicationAddress;

			public IntPtr dwActiveProcessorMask;

			public uint dwNumberOfProcessors;

			public uint dwProcessorType;

			public uint dwAllocationGranularity;

			public ushort dwProcessorLevel;

			public ushort dwProcessorRevision;
		}

		[StructLayout(LayoutKind.Explicit)]
		public struct _PROCESSOR_INFO_UNION
		{
			[FieldOffset(0)]
			internal uint dwOemId;

			[FieldOffset(0)]
			internal ushort wProcessorArchitecture;

			[FieldOffset(2)]
			internal ushort wReserved;
		}

		private static string s_Edition;

		private static string s_Name;

		private const int PRODUCT_UNDEFINED = 0;

		private const int PRODUCT_ULTIMATE = 1;

		private const int PRODUCT_HOME_BASIC = 2;

		private const int PRODUCT_HOME_PREMIUM = 3;

		private const int PRODUCT_ENTERPRISE = 4;

		private const int PRODUCT_HOME_BASIC_N = 5;

		private const int PRODUCT_BUSINESS = 6;

		private const int PRODUCT_STANDARD_SERVER = 7;

		private const int PRODUCT_DATACENTER_SERVER = 8;

		private const int PRODUCT_SMALLBUSINESS_SERVER = 9;

		private const int PRODUCT_ENTERPRISE_SERVER = 10;

		private const int PRODUCT_STARTER = 11;

		private const int PRODUCT_DATACENTER_SERVER_CORE = 12;

		private const int PRODUCT_STANDARD_SERVER_CORE = 13;

		private const int PRODUCT_ENTERPRISE_SERVER_CORE = 14;

		private const int PRODUCT_ENTERPRISE_SERVER_IA64 = 15;

		private const int PRODUCT_BUSINESS_N = 16;

		private const int PRODUCT_WEB_SERVER = 17;

		private const int PRODUCT_CLUSTER_SERVER = 18;

		private const int PRODUCT_HOME_SERVER = 19;

		private const int PRODUCT_STORAGE_EXPRESS_SERVER = 20;

		private const int PRODUCT_STORAGE_STANDARD_SERVER = 21;

		private const int PRODUCT_STORAGE_WORKGROUP_SERVER = 22;

		private const int PRODUCT_STORAGE_ENTERPRISE_SERVER = 23;

		private const int PRODUCT_SERVER_FOR_SMALLBUSINESS = 24;

		private const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM = 25;

		private const int PRODUCT_HOME_PREMIUM_N = 26;

		private const int PRODUCT_ENTERPRISE_N = 27;

		private const int PRODUCT_ULTIMATE_N = 28;

		private const int PRODUCT_WEB_SERVER_CORE = 29;

		private const int PRODUCT_MEDIUMBUSINESS_SERVER_MANAGEMENT = 30;

		private const int PRODUCT_MEDIUMBUSINESS_SERVER_SECURITY = 31;

		private const int PRODUCT_MEDIUMBUSINESS_SERVER_MESSAGING = 32;

		private const int PRODUCT_SERVER_FOUNDATION = 33;

		private const int PRODUCT_HOME_PREMIUM_SERVER = 34;

		private const int PRODUCT_SERVER_FOR_SMALLBUSINESS_V = 35;

		private const int PRODUCT_STANDARD_SERVER_V = 36;

		private const int PRODUCT_DATACENTER_SERVER_V = 37;

		private const int PRODUCT_ENTERPRISE_SERVER_V = 38;

		private const int PRODUCT_DATACENTER_SERVER_CORE_V = 39;

		private const int PRODUCT_STANDARD_SERVER_CORE_V = 40;

		private const int PRODUCT_ENTERPRISE_SERVER_CORE_V = 41;

		private const int PRODUCT_HYPERV = 42;

		private const int PRODUCT_STORAGE_EXPRESS_SERVER_CORE = 43;

		private const int PRODUCT_STORAGE_STANDARD_SERVER_CORE = 44;

		private const int PRODUCT_STORAGE_WORKGROUP_SERVER_CORE = 45;

		private const int PRODUCT_STORAGE_ENTERPRISE_SERVER_CORE = 46;

		private const int PRODUCT_STARTER_N = 47;

		private const int PRODUCT_PROFESSIONAL = 48;

		private const int PRODUCT_PROFESSIONAL_N = 49;

		private const int PRODUCT_SB_SOLUTION_SERVER = 50;

		private const int PRODUCT_SERVER_FOR_SB_SOLUTIONS = 51;

		private const int PRODUCT_STANDARD_SERVER_SOLUTIONS = 52;

		private const int PRODUCT_STANDARD_SERVER_SOLUTIONS_CORE = 53;

		private const int PRODUCT_SB_SOLUTION_SERVER_EM = 54;

		private const int PRODUCT_SERVER_FOR_SB_SOLUTIONS_EM = 55;

		private const int PRODUCT_SOLUTION_EMBEDDEDSERVER = 56;

		private const int PRODUCT_SOLUTION_EMBEDDEDSERVER_CORE = 57;

		private const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMT = 59;

		private const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDL = 60;

		private const int PRODUCT_ESSENTIALBUSINESS_SERVER_MGMTSVC = 61;

		private const int PRODUCT_ESSENTIALBUSINESS_SERVER_ADDLSVC = 62;

		private const int PRODUCT_SMALLBUSINESS_SERVER_PREMIUM_CORE = 63;

		private const int PRODUCT_CLUSTER_SERVER_V = 64;

		private const int PRODUCT_EMBEDDED = 65;

		private const int PRODUCT_STARTER_E = 66;

		private const int PRODUCT_HOME_BASIC_E = 67;

		private const int PRODUCT_HOME_PREMIUM_E = 68;

		private const int PRODUCT_PROFESSIONAL_E = 69;

		private const int PRODUCT_ENTERPRISE_E = 70;

		private const int PRODUCT_ULTIMATE_E = 71;

		private const int VER_NT_WORKSTATION = 1;

		private const int VER_NT_DOMAIN_CONTROLLER = 2;

		private const int VER_NT_SERVER = 3;

		private const int VER_SUITE_SMALLBUSINESS = 1;

		private const int VER_SUITE_ENTERPRISE = 2;

		private const int VER_SUITE_TERMINAL = 16;

		private const int VER_SUITE_DATACENTER = 128;

		private const int VER_SUITE_SINGLEUSERTS = 256;

		private const int VER_SUITE_PERSONAL = 512;

		private const int VER_SUITE_BLADE = 1024;

		public static SoftwareArchitecture ProgramBits
		{
			get
			{
				SoftwareArchitecture softwareArchitecture = SoftwareArchitecture.Unknown;
				Environment.GetEnvironmentVariables();
				return (IntPtr.Size * 8) switch
				{
					64 => SoftwareArchitecture.Bit64, 
					32 => SoftwareArchitecture.Bit32, 
					_ => SoftwareArchitecture.Unknown, 
				};
			}
		}

		public static SoftwareArchitecture OSBits
		{
			get
			{
				SoftwareArchitecture softwareArchitecture = SoftwareArchitecture.Unknown;
				switch (IntPtr.Size * 8)
				{
				case 64:
					return SoftwareArchitecture.Bit64;
				case 32:
					if (Is32BitProcessOn64BitProcessor())
					{
						return SoftwareArchitecture.Bit64;
					}
					return SoftwareArchitecture.Bit32;
				default:
					return SoftwareArchitecture.Unknown;
				}
			}
		}

		public static ProcessorArchitecture ProcessorBits
		{
			get
			{
				ProcessorArchitecture result = ProcessorArchitecture.Unknown;
				try
				{
					SYSTEM_INFO lpSystemInfo = default;
					GetNativeSystemInfo(ref lpSystemInfo);
					result = lpSystemInfo.uProcessorInfo.wProcessorArchitecture switch
					{
						9 => ProcessorArchitecture.Bit64, 
						6 => ProcessorArchitecture.Itanium64, 
						0 => ProcessorArchitecture.Bit32, 
						_ => ProcessorArchitecture.Unknown, 
					};
				}
				catch
				{
				}
				return result;
			}
		}

		public static string Edition
		{
			get
			{
				if (s_Edition != null)
				{
					return s_Edition;
				}
				string result = string.Empty;
				OperatingSystem oSVersion = Environment.OSVersion;
				OSVERSIONINFOEX osVersionInfo = new OSVERSIONINFOEX
				{
					dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX))
				};
				if (GetVersionEx(ref osVersionInfo))
				{
					int major = oSVersion.Version.Major;
					int minor = oSVersion.Version.Minor;
					byte wProductType = osVersionInfo.wProductType;
					short wSuiteMask = osVersionInfo.wSuiteMask;
					switch (major)
					{
					case 4:
						switch (wProductType)
						{
						case 1:
							result = "Workstation";
							break;
						case 3:
							result = (((wSuiteMask & 2) == 0) ? "Standard Server" : "Enterprise Server");
							break;
						}
						break;
					case 5:
						switch (wProductType)
						{
						case 1:
							if ((wSuiteMask & 0x200) != 0)
							{
								result = "Home";
							}
							else
							{
								result = ((GetSystemMetrics(86) != 0) ? "Tablet Edition" : "Professional");
							}
							break;
						case 3:
							if (minor != 0)
							{
								if ((wSuiteMask & 0x80) != 0)
								{
									result = "Datacenter";
								}
								else if ((wSuiteMask & 2) != 0)
								{
									result = "Enterprise";
								}
								else
								{
									result = (((wSuiteMask & 0x400) == 0) ? "Standard" : "Web Edition");
								}
							}
							else if ((wSuiteMask & 0x80) != 0)
							{
								result = "Datacenter Server";
							}
							else
							{
								result = (((wSuiteMask & 2) == 0) ? "Server" : "Advanced Server");
							}
							break;
						}
						break;
					case 6:
					{
						if (GetProductInfo(major, minor, osVersionInfo.wServicePackMajor, osVersionInfo.wServicePackMinor, out var edition))
						{
							switch (edition)
							{
							case 6:
								result = "Business";
								break;
							case 16:
								result = "Business N";
								break;
							case 18:
								result = "HPC Edition";
								break;
							case 64:
								result = "HPC Edition without Hyper-V";
								break;
							case 8:
								result = "Datacenter Server";
								break;
							case 12:
								result = "Datacenter Server (core installation)";
								break;
							case 37:
								result = "Datacenter Server without Hyper-V";
								break;
							case 39:
								result = "Datacenter Server without Hyper-V (core installation)";
								break;
							case 65:
								result = "Embedded";
								break;
							case 4:
								result = "Enterprise";
								break;
							case 27:
								result = "Enterprise N";
								break;
							case 70:
								result = "Enterprise E";
								break;
							case 10:
								result = "Enterprise Server";
								break;
							case 14:
								result = "Enterprise Server (core installation)";
								break;
							case 41:
								result = "Enterprise Server without Hyper-V (core installation)";
								break;
							case 15:
								result = "Enterprise Server for Itanium-based Systems";
								break;
							case 38:
								result = "Enterprise Server without Hyper-V";
								break;
							case 59:
								result = "Essential Business Server MGMT";
								break;
							case 60:
								result = "Essential Business Server ADDL";
								break;
							case 61:
								result = "Essential Business Server MGMTSVC";
								break;
							case 62:
								result = "Essential Business Server ADDLSVC";
								break;
							case 2:
								result = "Home Basic";
								break;
							case 5:
								result = "Home Basic N";
								break;
							case 67:
								result = "Home Basic E";
								break;
							case 3:
								result = "Home Premium";
								break;
							case 26:
								result = "Home Premium N";
								break;
							case 68:
								result = "Home Premium E";
								break;
							case 34:
								result = "Home Premium Server";
								break;
							case 42:
								result = "Microsoft Hyper-V Server";
								break;
							case 30:
								result = "Windows Essential Business Management Server";
								break;
							case 32:
								result = "Windows Essential Business Messaging Server";
								break;
							case 31:
								result = "Windows Essential Business Security Server";
								break;
							case 48:
								result = "Professional";
								break;
							case 49:
								result = "Professional N";
								break;
							case 69:
								result = "Professional E";
								break;
							case 50:
								result = "SB Solution Server";
								break;
							case 54:
								result = "SB Solution Server EM";
								break;
							case 51:
								result = "Server for SB Solutions";
								break;
							case 55:
								result = "Server for SB Solutions EM";
								break;
							case 24:
								result = "Windows Essential Server Solutions";
								break;
							case 35:
								result = "Windows Essential Server Solutions without Hyper-V";
								break;
							case 33:
								result = "Server Foundation";
								break;
							case 9:
								result = "Windows Small Business Server";
								break;
							case 25:
								result = "Windows Small Business Server Premium";
								break;
							case 63:
								result = "Windows Small Business Server Premium (core installation)";
								break;
							case 56:
								result = "Solution Embedded Server";
								break;
							case 57:
								result = "Solution Embedded Server (core installation)";
								break;
							case 7:
								result = "Standard Server";
								break;
							case 13:
								result = "Standard Server (core installation)";
								break;
							case 52:
								result = "Standard Server Solutions";
								break;
							case 53:
								result = "Standard Server Solutions (core installation)";
								break;
							case 40:
								result = "Standard Server without Hyper-V (core installation)";
								break;
							case 36:
								result = "Standard Server without Hyper-V";
								break;
							case 11:
								result = "Starter";
								break;
							case 47:
								result = "Starter N";
								break;
							case 66:
								result = "Starter E";
								break;
							case 23:
								result = "Enterprise Storage Server";
								break;
							case 46:
								result = "Enterprise Storage Server (core installation)";
								break;
							case 20:
								result = "Express Storage Server";
								break;
							case 43:
								result = "Express Storage Server (core installation)";
								break;
							case 21:
								result = "Standard Storage Server";
								break;
							case 44:
								result = "Standard Storage Server (core installation)";
								break;
							case 22:
								result = "Workgroup Storage Server";
								break;
							case 45:
								result = "Workgroup Storage Server (core installation)";
								break;
							case 0:
								result = "Unknown product";
								break;
							case 1:
								result = "Ultimate";
								break;
							case 28:
								result = "Ultimate N";
								break;
							case 71:
								result = "Ultimate E";
								break;
							case 17:
								result = "Web Server";
								break;
							case 29:
								result = "Web Server (core installation)";
								break;
							}
						}
						break;
					}
					}
				}
				s_Edition = result;
				return result;
			}
		}

		public static string Name
		{
			get
			{
				if (s_Name != null)
				{
					return s_Name;
				}
				string result = "unknown";
				OperatingSystem oSVersion = Environment.OSVersion;
				OSVERSIONINFOEX osVersionInfo = new OSVERSIONINFOEX
				{
					dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX))
				};
				if (GetVersionEx(ref osVersionInfo))
				{
					int num = oSVersion.Version.Major;
					int num2 = oSVersion.Version.Minor;
					if (num == 6 && num2 == 2)
					{
						string text = RegistryRead("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentVersion", "");
						if (!string.IsNullOrEmpty(text))
						{
							string[] array = text.Split('.');
							num = Convert.ToInt32(array[0]);
							num2 = Convert.ToInt32(array[1]);
						}
						if (IsWindows10())
						{
							num = 10;
							num2 = 0;
						}
					}
					switch (oSVersion.Platform)
					{
					case PlatformID.Win32S:
						result = "Windows 3.1";
						break;
					case PlatformID.WinCE:
						result = "Windows CE";
						break;
					case PlatformID.Win32Windows:
						if (num == 4)
						{
							string szCSDVersion = osVersionInfo.szCSDVersion;
							switch (num2)
							{
							case 0:
								result = ((!(szCSDVersion == "B") && !(szCSDVersion == "C")) ? "Windows 95" : "Windows 95 OSR2");
								break;
							case 10:
								result = ((!(szCSDVersion == "A")) ? "Windows 98" : "Windows 98 Second Edition");
								break;
							case 90:
								result = "Windows Me";
								break;
							}
						}
						break;
					case PlatformID.Win32NT:
					{
						byte wProductType = osVersionInfo.wProductType;
						switch (num)
						{
						case 3:
							result = "Windows NT 3.51";
							break;
						case 4:
							switch (wProductType)
							{
							case 1:
								result = "Windows NT 4.0";
								break;
							case 3:
								result = "Windows NT 4.0 Server";
								break;
							}
							break;
						case 5:
							switch (num2)
							{
							case 0:
								result = "Windows 2000";
								break;
							case 1:
								result = "Windows XP";
								break;
							case 2:
								result = "Windows Server 2003";
								break;
							}
							break;
						case 6:
							switch (num2)
							{
							case 0:
								switch (wProductType)
								{
								case 1:
									result = "Windows Vista";
									break;
								case 3:
									result = "Windows Server 2008";
									break;
								}
								break;
							case 1:
								switch (wProductType)
								{
								case 1:
									result = "Windows 7";
									break;
								case 3:
									result = "Windows Server 2008 R2";
									break;
								}
								break;
							case 2:
								switch (wProductType)
								{
								case 1:
									result = "Windows 8";
									break;
								case 3:
									result = "Windows Server 2012";
									break;
								}
								break;
							case 3:
								switch (wProductType)
								{
								case 1:
									result = "Windows 8.1";
									break;
								case 3:
									result = "Windows Server 2012 R2";
									break;
								}
								break;
							}
							break;
						case 10:
							if (num2 == 0)
							{
								switch (wProductType)
								{
								case 1:
									result = "Windows 10";
									break;
								case 3:
									result = "Windows Server 2016";
									break;
								}
							}
							break;
						}
						break;
					}
					}
				}
				s_Name = result;
				return result;
			}
		}

		public static string ServicePack
		{
			get
			{
				string result = string.Empty;
				OSVERSIONINFOEX osVersionInfo = new OSVERSIONINFOEX
				{
					dwOSVersionInfoSize = Marshal.SizeOf(typeof(OSVERSIONINFOEX))
				};
				if (GetVersionEx(ref osVersionInfo))
				{
					result = osVersionInfo.szCSDVersion;
				}
				return result;
			}
		}

		public static int BuildVersion => int.Parse(RegistryRead("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentBuildNumber", "0"));

		public static string VersionString => Version.ToString();

		public static Version Version => new Version(MajorVersion, MinorVersion, BuildVersion, RevisionVersion);

		public static int MajorVersion
		{
			get
			{
				if (IsWindows10())
				{
					return 10;
				}
				string text = RegistryRead("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentVersion", "");
				if (!string.IsNullOrEmpty(text))
				{
					return int.Parse(text.Split('.')[0]);
				}
				return Environment.OSVersion.Version.Major;
			}
		}

		public static int MinorVersion
		{
			get
			{
				if (IsWindows10())
				{
					return 0;
				}
				string text = RegistryRead("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "CurrentVersion", "");
				if (!string.IsNullOrEmpty(text))
				{
					return int.Parse(text.Split('.')[1]);
				}
				return Environment.OSVersion.Version.Minor;
			}
		}

		public static int RevisionVersion
		{
			get
			{
				if (IsWindows10())
				{
					return 0;
				}
				return Environment.OSVersion.Version.Revision;
			}
		}

		[DllImport("Kernel32.dll")]
		internal static extern bool GetProductInfo(int osMajorVersion, int osMinorVersion, int spMajorVersion, int spMinorVersion, out int edition);

		[DllImport("kernel32.dll")]
		private static extern bool GetVersionEx(ref OSVERSIONINFOEX osVersionInfo);

		[DllImport("user32")]
		public static extern int GetSystemMetrics(int nIndex);

		[DllImport("kernel32.dll")]
		public static extern void GetSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO lpSystemInfo);

		[DllImport("kernel32.dll")]
		public static extern void GetNativeSystemInfo([MarshalAs(UnmanagedType.Struct)] ref SYSTEM_INFO lpSystemInfo);

		[DllImport("kernel32", SetLastError = true)]
		public static extern IntPtr LoadLibrary(string libraryName);

		[DllImport("kernel32", SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hwnd, string procedureName);

		private static IsWow64ProcessDelegate GetIsWow64ProcessDelegate()
		{
			IntPtr intPtr = LoadLibrary("kernel32");
			if (intPtr != IntPtr.Zero)
			{
				IntPtr procAddress = GetProcAddress(intPtr, "IsWow64Process");
				if (procAddress != IntPtr.Zero)
				{
					return (IsWow64ProcessDelegate)Marshal.GetDelegateForFunctionPointer(procAddress, typeof(IsWow64ProcessDelegate));
				}
			}
			return null;
		}

		private static bool Is32BitProcessOn64BitProcessor()
		{
			IsWow64ProcessDelegate isWow64ProcessDelegate = GetIsWow64ProcessDelegate();
			if (isWow64ProcessDelegate == null)
			{
				return false;
			}
			if (!isWow64ProcessDelegate(Process.GetCurrentProcess().Handle, out var isWow64Process))
			{
				return false;
			}
			return isWow64Process;
		}

		private static bool IsWindows10()
		{
			if (RegistryRead("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", "ProductName", "").StartsWith("Windows 10", StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			return false;
		}

		private static string RegistryRead(string RegistryPath, string Field, string DefaultValue)
		{
			string result = "";
			string text = "";
			string text2 = "";
			try
			{
				RegistryKey registryKey = null;
				string[] array = RegistryPath.Split('\\');
				if (array.Length != 0)
				{
					array[0] = array[0].ToUpper();
					if (array[0] == "HKEY_CLASSES_ROOT")
					{
						registryKey = Registry.ClassesRoot;
					}
					else if (array[0] == "HKEY_CURRENT_USER")
					{
						registryKey = Registry.CurrentUser;
					}
					else if (array[0] == "HKEY_LOCAL_MACHINE")
					{
						registryKey = Registry.LocalMachine;
					}
					else if (array[0] == "HKEY_USERS")
					{
						registryKey = Registry.Users;
					}
					else if (array[0] == "HKEY_CURRENT_CONFIG")
					{
						registryKey = Registry.CurrentConfig;
					}
					if (registryKey != null)
					{
						for (int i = 1; i < array.Length; i++)
						{
							text2 = text2 + text + array[i];
							text = "\\";
						}
						if (text2 != "")
						{
							registryKey = registryKey.OpenSubKey(text2);
							result = (string)registryKey.GetValue(Field, DefaultValue);
							registryKey.Close();
						}
					}
				}
			}
			catch
			{
			}
			return result;
		}
	}
}
namespace JCS.Properties
{
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (resourceMan == null)
				{
					resourceMan = new ResourceManager("JCS.Properties.Resources", typeof(Resources).Assembly);
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		internal Resources()
		{
		}
	}
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());

		public static Settings Default => defaultInstance;
	}
}
