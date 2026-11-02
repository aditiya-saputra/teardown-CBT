using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using System.Xml.Serialization;
using ALtPbXRFYNSxmvJIbXR;
using ExamServices;
using Gma.UserActivityMonitor;
using LibraryExam;
using PKf6wKmO0NHVrXhHEoV;

[assembly: ComVisible(false)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: SuppressIldasm]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: Guid("e8a38bd2-5643-4f97-ab6f-df3d1f74bf1b")]
[assembly: AssemblyProduct("ExamServices")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyTitle("ExamServices")]
[assembly: AssemblyCompany("Pusat Asesmen Dan Pembelajaran")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyDescription("Exam Services AN")]
[assembly: AssemblyVersion("1.0.0.0")]
internal class <Module>
{
	private static bool f8DCB4D842ADBEB8;

	internal static void m8DCB4D842ADBEB8()
	{
		if (!f8DCB4D842ADBEB8)
		{
			f8DCB4D842ADBEB8 = true;
			if (Math.Sign((DateTime.Now - new DateTime(2024, 8, 4)).Days) >= 14)
			{
				throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
			}
		}
	}

	static <Module>()
	{
		m8DCB4D842ADBEB8();
	}
}
namespace ExamBrowser
{
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	internal class Form_Password
	{
		private static ResourceManager z5elWwGXA;

		private static CultureInfo N9CG0TBf8;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (z5elWwGXA == null)
				{
					ResourceManager resourceManager = new ResourceManager("ExamBrowser.Form_Password", typeof(Form_Password).Assembly);
					z5elWwGXA = resourceManager;
				}
				return z5elWwGXA;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return N9CG0TBf8;
			}
			set
			{
				N9CG0TBf8 = value;
			}
		}

		internal Form_Password()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor();
		}
	}
}
namespace ExamServices
{
	public class Form1_Main : Form
	{
		private struct cJ3msKFqRnxeQxuWxnO
		{
			public string gj6F4715bK;

			public bool N4QFQ6qiNr;
		}

		private struct j0TtGYFTKU67GQqi4wT
		{
			public cJ3msKFqRnxeQxuWxnO[] iSkFKJKlo2;

			public bool fo8FP0jbO6;
		}

		private struct IpdDGrFedOsma5tFr7b
		{
			public bool DlpFoGRXTZ;

			public string UVlFOd4ZBJ;
		}

		private class LH4SRwFVQGPpDwi83i8
		{
			[CompilerGenerated]
			[DebuggerBrowsable(DebuggerBrowsableState.Never)]
			private string TnMFsFj2Jy;

			[SpecialName]
			[CompilerGenerated]
			public string xkrFbi72fJ()
			{
				return TnMFsFj2Jy;
			}

			[SpecialName]
			[CompilerGenerated]
			public void jikFITAABp(string P_0)
			{
				TnMFsFj2Jy = P_0;
			}

			public LH4SRwFVQGPpDwi83i8()
			{
				dJLOPAmoTijWxbGSvCs.urY36js4go();
				base..ctor();
			}
		}

		private GetConfigure.AppConfig l9CiXJCJO;

		private List<string> kM9S5SL1g;

		private j0TtGYFTKU67GQqi4wT[] BUN6oDsb4;

		private cJ3msKFqRnxeQxuWxnO[] DICgfiisy;

		private string ARq1EiOrj;

		private string kS0cFDell;

		private bool Xgqqdjr8Z;

		private bool r2W4mS9Ja;

		private bool rM5QjtioV;

		private bool rfcTphY1y;

		private bool OPWKoLhJR;

		private Button uGnPw5gso;

		private System.Windows.Forms.Timer aBneIGAxF;

		private System.Windows.Forms.Timer C5mo3WScR;

		private System.Windows.Forms.Timer rnCOy0lm7;

		private System.Windows.Forms.Timer liDVqyCtI;

		private BackgroundWorker jxWbZGNp6;

		private IContainer VvEI6ajph;

		public Form1_Main()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			VvEI6ajph = null;
			base..ctor();
			f7vjJEp0k();
		}

		private void xdfExTDrL()
		{
			kM9S5SL1g = new List<string>();
			GetConfigure getConfigure = new GetConfigure();
			if (getConfigure.ReadConfig(Load_List: false).bukadesktop.Equals(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x28A1D741 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b88edb3d4a5443f59f2c94bbb42b1c5d)))
			{
				if (DTn2GRKZ1() || Desktop.GetCurrent().ToString() != PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x1B0547C4 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_60fcf68a246f430da22c2f187c8b4cc1))
				{
					MessageBox.Show(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x8CB1338 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_95961dbbf48d4589a7c57776ca31ed70), PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0xA30165C ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_bbf5652ac68145268339aabf58f2e7a4), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					Application.Exit();
				}
				else
				{
					uGnPw5gso.PerformClick();
				}
			}
			else if (DTn2GRKZ1())
			{
				MessageBox.Show(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x19975EC6 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_a41b83e1a14d4fabb4d025f7937fc1aa), PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x2CB38D4B ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_6874963f64554f6c9453fb77ae802833), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
			else
			{
				uGnPw5gso.PerformClick();
			}
		}

		private static bool DTn2GRKZ1()
		{
			Process[] processesByName = Process.GetProcessesByName(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x7375FA23 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_e1684c59b1934313ad61f4823737c76c));
			if (processesByName.Length < 1)
			{
				return true;
			}
			return false;
		}

		private Form_Password.IsPasswordValid_result IjrYQStyO()
		{
			Form_Password.IsPasswordValid_result result = default;
			Form_Password form_Password = new Form_Password();
			form_Password.Opacity = 1.0;
			int num = (int)form_Password.ShowDialog();
			if (form_Password.DialogResult == DialogResult.OK)
			{
				return form_Password.IsPasswordValid();
			}
			return result;
		}

		public void SetMessage(string str)
		{
		}

		private void vfJ9aN67j()
		{
			GetConfigure getConfigure = new GetConfigure();
			l9CiXJCJO = default;
			l9CiXJCJO = getConfigure.ReadConfig(Load_List: true);
			GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x149F8E49 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_a9b8ace30e244d0a8a8e3c660a3ab1a4));
			CNmAnpkwk();
			LoadFilterKeys();
		}

		private bool PjMrBdqSf()
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			bool result = false;
			if (appConfig.ModeUjian.Equals(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x26D40E37 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_abcb4675695b4c76a10f38499e59ab5c)))
			{
				string semi = getAgent.GetSemi();
				if (semi == "")
				{
					string text = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x153F61BE ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_832ff6bf92bc42f1b576f3be94752c4e);
					int num = (int)MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
					Application.Exit();
				}
				else if (semi == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-801290702 ^ -1965795825 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_053015b3ee3b44d88bcdf8d56ac27530))
				{
					string text2 = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x1B0546D8 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_60fcf68a246f430da22c2f187c8b4cc1);
					int num2 = (int)MessageBox.Show(text2, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
					Application.Exit();
				}
				else if (semi == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0xA301704 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_bbf5652ac68145268339aabf58f2e7a4))
				{
					string text3 = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0xA3017FA ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_bbf5652ac68145268339aabf58f2e7a4);
					int num3 = (int)MessageBox.Show(text3, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
					Application.Exit();
				}
				else if (semi == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x153F60CC ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_832ff6bf92bc42f1b576f3be94752c4e))
				{
					string text4 = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x252F976E ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_dacb6ed28c3f486089c6ab1def10bd3c);
					int num4 = (int)MessageBox.Show(text4, "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
					Application.Exit();
				}
				else
				{
					string text5 = encryption.EncryptedToke(getAgent.GetSemi(), encryption.passPhraseOnline);
					processStartInfo.Arguments = text5 + PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x77932172 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_2b39c536428a43b4a474fc24f7dfae32) + appConfig.ModeUjian + PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x76632A0D ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_58019b50b63a476ea06057a2db54f06a) + appConfig.SemiUrl + PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x19EE955F ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_e30397021c2e4ed6b2bf5b4d827de689);
					processStartInfo.FileName = GetConfigure.elekBrowserFile;
					try
					{
						Process.Start(processStartInfo);
						result = true;
						GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x76632A1B ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_58019b50b63a476ea06057a2db54f06a));
					}
					catch (Exception ex)
					{
						result = false;
						GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-(-1709162858) ^ 0x621C0A2C ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_3e426832f7f94edca1142495a2d8b604));
						string message = ex.Message;
						GetConfigure.Writer(message);
						Close();
					}
				}
			}
			else if (getAgent.GetWorkToke() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x76632AD9 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_58019b50b63a476ea06057a2db54f06a))
			{
				MessageBox.Show(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x7C3C9F6 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_3e426832f7f94edca1142495a2d8b604), PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x1B0547E2 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_60fcf68a246f430da22c2f187c8b4cc1), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x20982AC9 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_f715fcffe3004c7aa46c8a09578d97a6));
				result = false;
				Application.Exit();
			}
			else
			{
				processStartInfo.Arguments = encryption.EncryptedToke(getAgent.GetWorkToke(), encryption.passPhraseOnline) + PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x49A31445 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_7caab99f71784e09b81bbeacdd7796f2) + appConfig.ModeUjian + PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0xE8E51A3 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_232f69a05029492b8df250a729b6b51f) + appConfig.OnlineUrl;
				processStartInfo.FileName = GetConfigure.elekBrowserFile;
				try
				{
					Process.Start(processStartInfo);
					GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x8715655 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_16ce9e0736c440859615439afa01a69c));
					result = true;
				}
				catch (Exception ex2)
				{
					result = false;
					GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x19EE95A7 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_e30397021c2e4ed6b2bf5b4d827de689));
					string message2 = ex2.Message;
					GetConfigure.Writer(message2);
					Close();
				}
			}
			return result;
		}

		private void WGFadR8yT(string P_0, string P_1)
		{
			if (P_0 == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4FF00111 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b56594b03db845a49b7820e60205c468))
			{
				if (!kM9S5SL1g.Contains(P_1.ToLower()))
				{
					kM9S5SL1g.Add(P_1.ToLower());
				}
			}
			else if (P_0 == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0xA30157C ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_bbf5652ac68145268339aabf58f2e7a4) && kM9S5SL1g.Contains(P_1.ToLower()))
			{
				kM9S5SL1g.Remove(P_1.ToLower());
			}
		}

		public void LoadFilterKeys()
		{
			j0TtGYFTKU67GQqi4wT[] array = new j0TtGYFTKU67GQqi4wT[0];
			for (int i = 0; i < l9CiXJCJO.FilteredKeys.Length; i++)
			{
				string text = l9CiXJCJO.FilteredKeys[i];
				Array.Resize(ref array, array.Length + 1);
				array[i].iSkFKJKlo2 = new cJ3msKFqRnxeQxuWxnO[0];
				if (text.Contains(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5DA74C67 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_df0882656164444fbd203474670ae7a7)))
				{
					string text2 = text;
					while (text2.Contains(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5EA15F25 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_7a69d491a4bf481fa201fbbe72541f2a)))
					{
						int num = text2.IndexOf(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x26D40CCD ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_abcb4675695b4c76a10f38499e59ab5c));
						string gj6F4715bK = text2.Substring(0, num);
						text2 = text2.Replace(text2.Substring(0, num + 1), "");
						Array.Resize(ref array[i].iSkFKJKlo2, array[i].iSkFKJKlo2.Length + 1);
						array[i].iSkFKJKlo2[array[i].iSkFKJKlo2.Length - 1].gj6F4715bK = gj6F4715bK;
						array[i].iSkFKJKlo2[array[i].iSkFKJKlo2.Length - 1].N4QFQ6qiNr = false;
					}
					Array.Resize(ref array[i].iSkFKJKlo2, array[i].iSkFKJKlo2.Length + 1);
					array[i].iSkFKJKlo2[array[i].iSkFKJKlo2.Length - 1].gj6F4715bK = text2;
					array[i].iSkFKJKlo2[array[i].iSkFKJKlo2.Length - 1].N4QFQ6qiNr = false;
				}
				else
				{
					Array.Resize(ref array[i].iSkFKJKlo2, array[i].iSkFKJKlo2.Length + 1);
					array[i].iSkFKJKlo2[array[i].iSkFKJKlo2.Length - 1].gj6F4715bK = text;
					array[i].iSkFKJKlo2[array[i].iSkFKJKlo2.Length - 1].N4QFQ6qiNr = false;
				}
				array[i].fo8FP0jbO6 = false;
			}
			BUN6oDsb4 = array;
		}

		private void CNmAnpkwk()
		{
			cJ3msKFqRnxeQxuWxnO[] array = new cJ3msKFqRnxeQxuWxnO[0];
			for (int i = 0; i < l9CiXJCJO.SpecialKeys.Length; i++)
			{
				Array.Resize(ref array, array.Length + 1);
				array[array.Length - 1].gj6F4715bK = l9CiXJCJO.SpecialKeys[i].ToLower().Trim();
				array[array.Length - 1].N4QFQ6qiNr = false;
			}
			DICgfiisy = array;
		}

		private void RFS0cEKhQ()
		{
			Xgqqdjr8Z = false;
			bool flag = true;
			for (int i = 0; i < DICgfiisy.Length; i++)
			{
				DICgfiisy[i].N4QFQ6qiNr = false;
				for (int j = 0; j < kM9S5SL1g.Count; j++)
				{
					if (DICgfiisy[i].gj6F4715bK == kM9S5SL1g[j])
					{
						DICgfiisy[i].N4QFQ6qiNr = true;
					}
				}
				flag = flag && DICgfiisy[i].N4QFQ6qiNr;
			}
			if (flag)
			{
				BringToFront();
				if (uGnPw5gso.Tag.ToString() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-(-1709162858) ^ 0x70E0A05E ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_832ff6bf92bc42f1b576f3be94752c4e))
				{
					Xgqqdjr8Z = true;
					erMBXTXW7(uGnPw5gso, null);
				}
			}
		}

		private IpdDGrFedOsma5tFr7b I7O5Q4qwS()
		{
			IpdDGrFedOsma5tFr7b result = new IpdDGrFedOsma5tFr7b
			{
				UVlFOd4ZBJ = "",
				DlpFoGRXTZ = false
			};
			for (int i = 0; i < BUN6oDsb4.Length; i++)
			{
				bool flag = true;
				BUN6oDsb4[i].fo8FP0jbO6 = false;
				for (int j = 0; j < BUN6oDsb4[i].iSkFKJKlo2.Length; j++)
				{
					BUN6oDsb4[i].iSkFKJKlo2[j].N4QFQ6qiNr = false;
					for (int k = 0; k < kM9S5SL1g.Count; k++)
					{
						rM5QjtioV = kM9S5SL1g[k].ToLower() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x7266EB21 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_637e3ed536e444c78b13f277a03822de).ToLower() || kM9S5SL1g[k].ToLower() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x8CB1004 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_95961dbbf48d4589a7c57776ca31ed70).ToLower() || kM9S5SL1g[k].ToLower() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x255F540 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b8d902a5a5b248d7a41b2e6ff424fd8a).ToLower() || kM9S5SL1g[k].ToLower() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4068A09E ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_dfa7f1ced813437f8a4356e5abd3ab16).ToLower();
						if (BUN6oDsb4[i].iSkFKJKlo2[j].gj6F4715bK.ToLower() == kM9S5SL1g[k].ToLower())
						{
							BUN6oDsb4[i].iSkFKJKlo2[j].N4QFQ6qiNr = true;
						}
					}
					flag = flag && BUN6oDsb4[i].iSkFKJKlo2[j].N4QFQ6qiNr;
				}
				BUN6oDsb4[i].fo8FP0jbO6 = flag;
				if (flag)
				{
					result.UVlFOd4ZBJ = "";
					for (int l = 0; l < BUN6oDsb4[i].iSkFKJKlo2.Length; l++)
					{
						result.UVlFOd4ZBJ += ((l == 0) ? "" : PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x238FC89C ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_520098cedb1a45709e913928c81430e2));
						result.UVlFOd4ZBJ += BUN6oDsb4[i].iSkFKJKlo2[l].gj6F4715bK;
					}
					BUN6oDsb4[i].fo8FP0jbO6 = false;
					result.DlpFoGRXTZ = true;
					break;
				}
			}
			return result;
		}

		private void Pk0UhXj6T(object P_0, KeyEventArgs P_1)
		{
			WGFadR8yT(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x19975C1C ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_a41b83e1a14d4fabb4d025f7937fc1aa), P_1.KeyCode.ToString());
			P_1.Handled = (r2W4mS9Ja = I7O5Q4qwS().DlpFoGRXTZ);
			if (!P_1.Handled)
			{
				return;
			}
			try
			{
			}
			catch (Exception ex)
			{
				GetConfigure.Writer(ex.Message);
			}
		}

		private void GOdvmdH0g(object P_0, KeyEventArgs P_1)
		{
			P_1.Handled = r2W4mS9Ja;
			RFS0cEKhQ();
			WGFadR8yT(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-(-757132505) ^ 0x4FF6D239 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_9916d941967e40f69bd0e5ad8a8eccc5), P_1.KeyCode.ToString());
		}

		private void oErNKrrRS(object P_0, MouseEventExtArgs P_1)
		{
			if (P_1.Button == MouseButtons.Left && rM5QjtioV)
			{
				P_1.Handled = true;
				C5mo3WScR.Enabled = false;
				C5mo3WScR.Enabled = true;
			}
		}

		private void FpIMf60cP()
		{
			HookManager.KeyDown += Pk0UhXj6T;
			HookManager.KeyUp += GOdvmdH0g;
			HookManager.MouseClickExt += oErNKrrRS;
		}

		public void Unhooks()
		{
			HookManager.KeyDown -= Pk0UhXj6T;
			HookManager.KeyUp -= GOdvmdH0g;
			HookManager.MouseClickExt -= oErNKrrRS;
		}

		private void nP9tL1ttl()
		{
			if (l9CiXJCJO.LockKeys.ToString().Trim() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4068A3D2 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_dfa7f1ced813437f8a4356e5abd3ab16))
			{
				FpIMf60cP();
			}
			GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x28A1D431 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b88edb3d4a5443f59f2c94bbb42b1c5d));
			aBneIGAxF.Enabled = true;
		}

		private void uHhZBZ2cR()
		{
			if (l9CiXJCJO.LockKeys.ToString().Trim() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-(-1548741411) ^ 0x156D1FDF ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_0d5e44dda34940c58decd68f393004d3))
			{
				Unhooks();
			}
			aBneIGAxF.Enabled = false;
			kM9S5SL1g.Clear();
		}

		private void kDHpCEN1b(object P_0, EventArgs P_1)
		{
			rM5QjtioV = false;
			xdfExTDrL();
		}

		private void erMBXTXW7(object P_0, EventArgs P_1)
		{
			if (uGnPw5gso.Tag.ToString() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x45E8946 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_571f5ae64d1545db86d72e5b8f2d3bf5))
			{
				vfJ9aN67j();
				if (!PjMrBdqSf())
				{
					string text = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x7375F9E3 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_e1684c59b1934313ad61f4823737c76c);
					MessageBox.Show(text, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
					return;
				}
				uGnPw5gso.Tag = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x238FCBFA ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_520098cedb1a45709e913928c81430e2);
				nP9tL1ttl();
				rnCOy0lm7.Enabled = true;
				if (l9CiXJCJO.ModeUjian.Equals(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x26D40E37 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_abcb4675695b4c76a10f38499e59ab5c)))
				{
					liDVqyCtI.Enabled = true;
				}
				else
				{
					liDVqyCtI.Enabled = false;
				}
				return;
			}
			bool flag;
			if (!Xgqqdjr8Z)
			{
				flag = IjrYQStyO().valid;
				GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x45E8932 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_571f5ae64d1545db86d72e5b8f2d3bf5));
			}
			else
			{
				flag = true;
				if (!rfcTphY1y)
				{
					GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x38520A58 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_c8c366b251c54560831a0933d492065a));
				}
			}
			if (flag)
			{
				uGnPw5gso.Tag = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x305EF5ED ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_5d981937aa044de6aefa8c62b60f0102);
				uHhZBZ2cR();
				GetConfigure.KillAllBrowser();
				rnCOy0lm7.Enabled = false;
				Application.Exit();
			}
		}

		private void LHG81KFpW(object P_0, EventArgs P_1)
		{
			try
			{
				Process[] processes = Process.GetProcesses();
				string text = l9CiXJCJO.BrowserFilename.ToLower().Replace(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-(-757132505) ^ 0x381F89D5 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_832ff6bf92bc42f1b576f3be94752c4e), "").ToLower()
					.Trim();
				Process[] array = processes;
				foreach (Process process in array)
				{
					string text2 = process.ProcessName.ToLower().Trim();
					if (!(text2 != text))
					{
						continue;
					}
					for (int j = 0; j < l9CiXJCJO.Application.Length; j++)
					{
						string text3 = l9CiXJCJO.Application[j];
						if (text2 == text3 && !string.IsNullOrEmpty(text3))
						{
							process.Kill();
						}
					}
				}
			}
			catch
			{
			}
		}

		private void ktgJ3C7mm(object P_0, EventArgs P_1)
		{
			rfcTphY1y = false;
			liDVqyCtI.Enabled = false;
			if (!string.IsNullOrEmpty(kS0cFDell))
			{
				IPAddress[] addressList = Dns.GetHostByName(Dns.GetHostName()).AddressList;
				bool flag = false;
				for (int i = 0; i < addressList.Length; i++)
				{
					flag = addressList[i].ToString() == kS0cFDell;
					if (flag)
					{
						break;
					}
				}
				if (!flag)
				{
					SetMessage(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x238FCFBE ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_520098cedb1a45709e913928c81430e2));
					GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x2CB3892F ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_6874963f64554f6c9453fb77ae802833));
					if (uGnPw5gso.Tag.ToString() == PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x255F672 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b8d902a5a5b248d7a41b2e6ff424fd8a))
					{
						GetConfigure.KillAllBrowser();
						if (!OPWKoLhJR)
						{
							OPWKoLhJR = true;
							int num = (int)MessageBox.Show(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x6D53575C ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_4df86ad362a54b16aff9302ae0cfd00b), "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
							Thread.Sleep(1000);
						}
						Xgqqdjr8Z = true;
						rfcTphY1y = true;
						erMBXTXW7(uGnPw5gso, null);
					}
				}
				else
				{
					OPWKoLhJR = false;
				}
			}
			liDVqyCtI.Enabled = true;
		}

		private void jg9hvILLx(object P_0, EventArgs P_1)
		{
			rM5QjtioV = false;
			C5mo3WScR.Enabled = false;
		}

		private void WuwHpoEEQ(object P_0, EventArgs P_1)
		{
			if (!jxWbZGNp6.IsBusy)
			{
				jxWbZGNp6.RunWorkerAsync();
			}
		}

		private void X1vye1wky(object P_0, DoWorkEventArgs P_1)
		{
			Process[] processesByName = Process.GetProcessesByName(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x38520A3A ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_c8c366b251c54560831a0933d492065a));
			if (processesByName.Length < 1)
			{
				GetConfigure.Writer(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-364525276 ^ -206873961 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_e30397021c2e4ed6b2bf5b4d827de689));
				uHhZBZ2cR();
				GetConfigure.KillAllBrowser();
				Thread.Sleep(1000);
				Application.Exit();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && VvEI6ajph != null)
			{
				VvEI6ajph.Dispose();
			}
			base.Dispose(disposing);
		}

		private void f7vjJEp0k()
		{
			VvEI6ajph = new Container();
			aBneIGAxF = new System.Windows.Forms.Timer(VvEI6ajph);
			C5mo3WScR = new System.Windows.Forms.Timer(VvEI6ajph);
			rnCOy0lm7 = new System.Windows.Forms.Timer(VvEI6ajph);
			liDVqyCtI = new System.Windows.Forms.Timer(VvEI6ajph);
			jxWbZGNp6 = new BackgroundWorker();
			uGnPw5gso = new Button();
			SuspendLayout();
			aBneIGAxF.Interval = 500;
			aBneIGAxF.Tick += LHG81KFpW;
			C5mo3WScR.Enabled = true;
			C5mo3WScR.Interval = 2000;
			C5mo3WScR.Tick += jg9hvILLx;
			liDVqyCtI.Interval = 1000;
			liDVqyCtI.Tick += ktgJ3C7mm;
			rnCOy0lm7.Interval = 1000;
			rnCOy0lm7.Tick += WuwHpoEEQ;
			jxWbZGNp6.DoWork += X1vye1wky;
			uGnPw5gso.Location = new Point(23, 39);
			uGnPw5gso.Name = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5782D48B ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_5ef84580349147d5a0ea529f8ded7fdd);
			uGnPw5gso.Size = new Size(10, 10);
			uGnPw5gso.TabIndex = 9;
			uGnPw5gso.Tag = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x57A1A262 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_366a139e88f04e1cbfaba72ec3a71921);
			uGnPw5gso.Text = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x76632CB7 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_58019b50b63a476ea06057a2db54f06a);
			uGnPw5gso.UseVisualStyleBackColor = true;
			uGnPw5gso.Click += erMBXTXW7;
			AutoScaleDimensions = new SizeF(6f, 13f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(20, 20);
			Controls.Add(uGnPw5gso);
			Name = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5B931400 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_7e7a1cd262b94d128bd8e406d09652e9);
			Text = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-746057210 ^ -217039113 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_f715fcffe3004c7aa46c8a09578d97a6);
			Load += kDHpCEN1b;
			ResumeLayout(performLayout: false);
		}
	}
	public class Form_Password : Form
	{
		public struct IsPasswordValid_result
		{
			public bool valid;

			public bool isadmin;
		}

		private IContainer AyYkysFqw;

		private System.Windows.Forms.Label QoYnVoryy;

		private TextBox Jaqzxn0Xi;

		private Button eN4FD7qnsG;

		public Form_Password()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor();
			i1bdosZcR();
		}

		public IsPasswordValid_result IsPasswordValid()
		{
			IsPasswordValid_result result = default;
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			string text = Jaqzxn0Xi.Text.Trim();
			string text2 = encryption.DecryptString(encryption.ReadBinFile(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5DA74B97 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_df0882656164444fbd203474670ae7a7)), encryption.passPhrase);
			string text3 = encryption.EncryptString(text, encryption.passPhrase);
			result.valid = (appConfig.Password == text || false || ((appConfig.PasswordSetUrl == text3) ? true : false)) && !string.IsNullOrEmpty(text);
			result.isadmin = appConfig.PasswordSetUrl == text3;
			return result;
		}

		private void yg8WP5OqO(object P_0, EventArgs P_1)
		{
			Close();
		}

		private void J32sGtEsT(object P_0, EventArgs P_1)
		{
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && AyYkysFqw != null)
			{
				AyYkysFqw.Dispose();
			}
			base.Dispose(disposing);
		}

		private void i1bdosZcR()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_Password));
			QoYnVoryy = new System.Windows.Forms.Label();
			Jaqzxn0Xi = new TextBox();
			eN4FD7qnsG = new Button();
			SuspendLayout();
			QoYnVoryy.AutoSize = true;
			QoYnVoryy.Location = new Point(13, 13);
			QoYnVoryy.Name = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x1B0542F4 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_60fcf68a246f430da22c2f187c8b4cc1);
			QoYnVoryy.Size = new Size(53, 13);
			QoYnVoryy.TabIndex = 0;
			QoYnVoryy.Text = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x1AE38B6C ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_98a6ba18323a467e9485f79ea882d762);
			Jaqzxn0Xi.Location = new Point(72, 10);
			Jaqzxn0Xi.Name = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x149F8B63 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_a9b8ace30e244d0a8a8e3c660a3ab1a4);
			Jaqzxn0Xi.PasswordChar = '*';
			Jaqzxn0Xi.Size = new Size(119, 20);
			Jaqzxn0Xi.TabIndex = 1;
			eN4FD7qnsG.DialogResult = DialogResult.OK;
			eN4FD7qnsG.Location = new Point(197, 8);
			eN4FD7qnsG.Name = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4FF0069F ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b56594b03db845a49b7820e60205c468);
			eN4FD7qnsG.Size = new Size(75, 23);
			eN4FD7qnsG.TabIndex = 2;
			eN4FD7qnsG.Text = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4D4FFCDE ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_9dfc7d7488034a68920972daecc9d2a2);
			eN4FD7qnsG.UseVisualStyleBackColor = true;
			eN4FD7qnsG.Click += yg8WP5OqO;
			AcceptButton = eN4FD7qnsG;
			AutoScaleDimensions = new SizeF(6f, 13f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(284, 45);
			Controls.Add(eN4FD7qnsG);
			Controls.Add(Jaqzxn0Xi);
			Controls.Add(QoYnVoryy);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			MaximizeBox = false;
			MinimizeBox = false;
			Name = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4FF00667 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b56594b03db845a49b7820e60205c468);
			StartPosition = FormStartPosition.CenterParent;
			Text = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x55A2DCD7 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_62460421384f4a65a8c8500119b2c6af);
			Load += J32sGtEsT;
			ResumeLayout(performLayout: false);
			PerformLayout();
		}
	}
}
namespace FNn2c3FRZa94VwWWH7Y
{
	internal static class gUkLopFFYyG10dkxOCL
	{
		[STAThread]
		private static void OsoFmcVaea()
		{
			if (!CpwF3Cxo7f())
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(defaultValue: false);
				dJLOPAmoTijWxbGSvCs.urY36js4go();
				Application.Run(new Form1_Main());
			}
			else
			{
				MessageBox.Show(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x62D6384A ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_9916d941967e40f69bd0e5ad8a8eccc5), PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5EA15875 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_7a69d491a4bf481fa201fbbe72541f2a), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				Application.Exit();
			}
		}

		private static bool CpwF3Cxo7f()
		{
			Process[] processesByName = Process.GetProcessesByName(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5F420762 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_7db6aac0615147b0b38b8655a98a7e21));
			if (processesByName.Length > 1)
			{
				return true;
			}
			return false;
		}
	}
}
namespace ExamServices.Properties
{
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[CompilerGenerated]
	internal class Resources
	{
		private static ResourceManager B8FFfYbplA;

		private static CultureInfo WMiFxo61ke;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (B8FFfYbplA == null)
				{
					ResourceManager b8FFfYbplA = new ResourceManager("ExamServices.Properties.Resources", typeof(Resources).Assembly);
					B8FFfYbplA = b8FFfYbplA;
				}
				return B8FFfYbplA;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return WMiFxo61ke;
			}
			set
			{
				WMiFxo61ke = value;
			}
		}

		internal Resources()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor();
		}
	}
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.5.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		public static Settings Default => defaultInstance;

		[DebuggerNonUserCode]
		[ApplicationScopedSetting]
		[DefaultSettingValue("https://192.168.0.200/puspendikunbkservice/CBTservices/WorkstationService.svc")]
		public string ExamBrowser_Arthur_WorkstationService_WorkstationService => (string)this[PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x62D6381A ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_9916d941967e40f69bd0e5ad8a8eccc5)];

		public Settings()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor();
		}

		static Settings()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}
namespace ExamServices.Arthur_WorkstationService
{
	[Serializable]
	[XmlType(Namespace = "http://schemas.datacontract.org/2004/07/CBT.BaseClass.Domain")]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.18408")]
	[DebuggerStepThrough]
	public class CBTResponse
	{
		private string DKGFCC4SQo;

		private bool d7qFL0K1uC;

		private bool Ge0F7ZHPDP;

		[XmlElement(IsNullable = true)]
		public string Message
		{
			get
			{
				return DKGFCC4SQo;
			}
			set
			{
				DKGFCC4SQo = value;
			}
		}

		public bool Result
		{
			get
			{
				return d7qFL0K1uC;
			}
			set
			{
				d7qFL0K1uC = value;
			}
		}

		[XmlIgnore]
		public bool ResultSpecified
		{
			get
			{
				return Ge0F7ZHPDP;
			}
			set
			{
				Ge0F7ZHPDP = value;
			}
		}

		public CBTResponse()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor();
		}
	}
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public class GetDataLove1ServerCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] b2bFu6vFve;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)b2bFu6vFve[0];
			}
		}

		internal GetDataLove1ServerCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			b2bFu6vFve = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void GetDataLove1ServerCompletedEventHandler(object sender, GetDataLove1ServerCompletedEventArgs e);
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public class GetDataLove2ServerCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] PVwFwaWfRE;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)PVwFwaWfRE[0];
			}
		}

		internal GetDataLove2ServerCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			PVwFwaWfRE = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void GetDataLove2ServerCompletedEventHandler(object sender, GetDataLove2ServerCompletedEventArgs e);
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public class GetDataLove3ServerCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] aOHFXm0rq9;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)aOHFXm0rq9[0];
			}
		}

		internal GetDataLove3ServerCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			aOHFXm0rq9 = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void GetDataLove3ServerCompletedEventHandler(object sender, GetDataLove3ServerCompletedEventArgs e);
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public class IsSubmitedRegisteredCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] cmLFlY7Vua;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)cmLFlY7Vua[0];
			}
		}

		internal IsSubmitedRegisteredCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			cmLFlY7Vua = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void IsSubmitedRegisteredCompletedEventHandler(object sender, IsSubmitedRegisteredCompletedEventArgs e);
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public class PesertaTesBeatCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] bf1FGAq55S;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)bf1FGAq55S[0];
			}
		}

		internal PesertaTesBeatCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			bf1FGAq55S = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void PesertaTesBeatCompletedEventHandler(object sender, PesertaTesBeatCompletedEventArgs e);
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public class SubmitWorkstationCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] YiCFEYTDWv;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)YiCFEYTDWv[0];
			}
		}

		internal SubmitWorkstationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			YiCFEYTDWv = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void SubmitWorkstationCompletedEventHandler(object sender, SubmitWorkstationCompletedEventArgs e);
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public class SubmitWorkstationV3CompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] CrTF2v1Yk9;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)CrTF2v1Yk9[0];
			}
		}

		internal SubmitWorkstationV3CompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			CrTF2v1Yk9 = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void SubmitWorkstationV3CompletedEventHandler(object sender, SubmitWorkstationV3CompletedEventArgs e);
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	[DesignerCategory("code")]
	[DebuggerStepThrough]
	public class UnSubmitWorkstationCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] qHCFY1kY3m;

		public CBTResponse Result
		{
			get
			{
				RaiseExceptionIfNecessary();
				return (CBTResponse)qHCFY1kY3m[0];
			}
		}

		internal UnSubmitWorkstationCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState)
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor(exception, cancelled, userState);
			qHCFY1kY3m = results;
		}
	}
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	public delegate void UnSubmitWorkstationCompletedEventHandler(object sender, UnSubmitWorkstationCompletedEventArgs e);
	[WebServiceBinding(Name = "BasicHttpsBinding_IWorkstationService", Namespace = "http://tempuri.org/")]
	[DesignerCategory("code")]
	[GeneratedCode("System.Web.Services", "4.0.30319.18408")]
	[DebuggerStepThrough]
	public class WorkstationService : SoapHttpClientProtocol
	{
		private SendOrPostCallback s2iFMAZkHT;

		private SendOrPostCallback MRFFt5yBCs;

		private SendOrPostCallback So9FZwntl2;

		private SendOrPostCallback SYxFp7SgCL;

		private SendOrPostCallback z9kFBIXg4M;

		private SendOrPostCallback nAGF8myWh9;

		private SendOrPostCallback NZUFJW8xkX;

		private SendOrPostCallback WsKFhKu5MI;

		private bool k2JFHmpkEA;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private SubmitWorkstationV3CompletedEventHandler SUAFyYck8K;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private SubmitWorkstationCompletedEventHandler X2MFj1jgdu;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private UnSubmitWorkstationCompletedEventHandler MGOFiCXA6U;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private IsSubmitedRegisteredCompletedEventHandler trRFSt1XRH;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private PesertaTesBeatCompletedEventHandler Y04F6V9W8B;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private GetDataLove1ServerCompletedEventHandler bTEFg0Z9yQ;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private GetDataLove2ServerCompletedEventHandler JWJF1OWD3H;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private GetDataLove3ServerCompletedEventHandler dLaFcyWyX0;

		public new string Url
		{
			get
			{
				return base.Url;
			}
			set
			{
				if (JQQFNeJo8I(base.Url) && !k2JFHmpkEA && !JQQFNeJo8I(value))
				{
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}

		public new bool UseDefaultCredentials
		{
			get
			{
				return base.UseDefaultCredentials;
			}
			set
			{
				base.UseDefaultCredentials = value;
				k2JFHmpkEA = true;
			}
		}

		public event SubmitWorkstationV3CompletedEventHandler SubmitWorkstationV3Completed
		{
			[CompilerGenerated]
			add
			{
				SubmitWorkstationV3CompletedEventHandler submitWorkstationV3CompletedEventHandler = SUAFyYck8K;
				SubmitWorkstationV3CompletedEventHandler submitWorkstationV3CompletedEventHandler2;
				do
				{
					submitWorkstationV3CompletedEventHandler2 = submitWorkstationV3CompletedEventHandler;
					SubmitWorkstationV3CompletedEventHandler value2 = (SubmitWorkstationV3CompletedEventHandler)Delegate.Combine(submitWorkstationV3CompletedEventHandler2, value);
					submitWorkstationV3CompletedEventHandler = Interlocked.CompareExchange(ref SUAFyYck8K, value2, submitWorkstationV3CompletedEventHandler2);
				}
				while ((object)submitWorkstationV3CompletedEventHandler != submitWorkstationV3CompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				SubmitWorkstationV3CompletedEventHandler submitWorkstationV3CompletedEventHandler = SUAFyYck8K;
				SubmitWorkstationV3CompletedEventHandler submitWorkstationV3CompletedEventHandler2;
				do
				{
					submitWorkstationV3CompletedEventHandler2 = submitWorkstationV3CompletedEventHandler;
					SubmitWorkstationV3CompletedEventHandler value2 = (SubmitWorkstationV3CompletedEventHandler)Delegate.Remove(submitWorkstationV3CompletedEventHandler2, value);
					submitWorkstationV3CompletedEventHandler = Interlocked.CompareExchange(ref SUAFyYck8K, value2, submitWorkstationV3CompletedEventHandler2);
				}
				while ((object)submitWorkstationV3CompletedEventHandler != submitWorkstationV3CompletedEventHandler2);
			}
		}

		public event SubmitWorkstationCompletedEventHandler SubmitWorkstationCompleted
		{
			[CompilerGenerated]
			add
			{
				SubmitWorkstationCompletedEventHandler submitWorkstationCompletedEventHandler = X2MFj1jgdu;
				SubmitWorkstationCompletedEventHandler submitWorkstationCompletedEventHandler2;
				do
				{
					submitWorkstationCompletedEventHandler2 = submitWorkstationCompletedEventHandler;
					SubmitWorkstationCompletedEventHandler value2 = (SubmitWorkstationCompletedEventHandler)Delegate.Combine(submitWorkstationCompletedEventHandler2, value);
					submitWorkstationCompletedEventHandler = Interlocked.CompareExchange(ref X2MFj1jgdu, value2, submitWorkstationCompletedEventHandler2);
				}
				while ((object)submitWorkstationCompletedEventHandler != submitWorkstationCompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				SubmitWorkstationCompletedEventHandler submitWorkstationCompletedEventHandler = X2MFj1jgdu;
				SubmitWorkstationCompletedEventHandler submitWorkstationCompletedEventHandler2;
				do
				{
					submitWorkstationCompletedEventHandler2 = submitWorkstationCompletedEventHandler;
					SubmitWorkstationCompletedEventHandler value2 = (SubmitWorkstationCompletedEventHandler)Delegate.Remove(submitWorkstationCompletedEventHandler2, value);
					submitWorkstationCompletedEventHandler = Interlocked.CompareExchange(ref X2MFj1jgdu, value2, submitWorkstationCompletedEventHandler2);
				}
				while ((object)submitWorkstationCompletedEventHandler != submitWorkstationCompletedEventHandler2);
			}
		}

		public event UnSubmitWorkstationCompletedEventHandler UnSubmitWorkstationCompleted
		{
			[CompilerGenerated]
			add
			{
				UnSubmitWorkstationCompletedEventHandler unSubmitWorkstationCompletedEventHandler = MGOFiCXA6U;
				UnSubmitWorkstationCompletedEventHandler unSubmitWorkstationCompletedEventHandler2;
				do
				{
					unSubmitWorkstationCompletedEventHandler2 = unSubmitWorkstationCompletedEventHandler;
					UnSubmitWorkstationCompletedEventHandler value2 = (UnSubmitWorkstationCompletedEventHandler)Delegate.Combine(unSubmitWorkstationCompletedEventHandler2, value);
					unSubmitWorkstationCompletedEventHandler = Interlocked.CompareExchange(ref MGOFiCXA6U, value2, unSubmitWorkstationCompletedEventHandler2);
				}
				while ((object)unSubmitWorkstationCompletedEventHandler != unSubmitWorkstationCompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				UnSubmitWorkstationCompletedEventHandler unSubmitWorkstationCompletedEventHandler = MGOFiCXA6U;
				UnSubmitWorkstationCompletedEventHandler unSubmitWorkstationCompletedEventHandler2;
				do
				{
					unSubmitWorkstationCompletedEventHandler2 = unSubmitWorkstationCompletedEventHandler;
					UnSubmitWorkstationCompletedEventHandler value2 = (UnSubmitWorkstationCompletedEventHandler)Delegate.Remove(unSubmitWorkstationCompletedEventHandler2, value);
					unSubmitWorkstationCompletedEventHandler = Interlocked.CompareExchange(ref MGOFiCXA6U, value2, unSubmitWorkstationCompletedEventHandler2);
				}
				while ((object)unSubmitWorkstationCompletedEventHandler != unSubmitWorkstationCompletedEventHandler2);
			}
		}

		public event IsSubmitedRegisteredCompletedEventHandler IsSubmitedRegisteredCompleted
		{
			[CompilerGenerated]
			add
			{
				IsSubmitedRegisteredCompletedEventHandler isSubmitedRegisteredCompletedEventHandler = trRFSt1XRH;
				IsSubmitedRegisteredCompletedEventHandler isSubmitedRegisteredCompletedEventHandler2;
				do
				{
					isSubmitedRegisteredCompletedEventHandler2 = isSubmitedRegisteredCompletedEventHandler;
					IsSubmitedRegisteredCompletedEventHandler value2 = (IsSubmitedRegisteredCompletedEventHandler)Delegate.Combine(isSubmitedRegisteredCompletedEventHandler2, value);
					isSubmitedRegisteredCompletedEventHandler = Interlocked.CompareExchange(ref trRFSt1XRH, value2, isSubmitedRegisteredCompletedEventHandler2);
				}
				while ((object)isSubmitedRegisteredCompletedEventHandler != isSubmitedRegisteredCompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				IsSubmitedRegisteredCompletedEventHandler isSubmitedRegisteredCompletedEventHandler = trRFSt1XRH;
				IsSubmitedRegisteredCompletedEventHandler isSubmitedRegisteredCompletedEventHandler2;
				do
				{
					isSubmitedRegisteredCompletedEventHandler2 = isSubmitedRegisteredCompletedEventHandler;
					IsSubmitedRegisteredCompletedEventHandler value2 = (IsSubmitedRegisteredCompletedEventHandler)Delegate.Remove(isSubmitedRegisteredCompletedEventHandler2, value);
					isSubmitedRegisteredCompletedEventHandler = Interlocked.CompareExchange(ref trRFSt1XRH, value2, isSubmitedRegisteredCompletedEventHandler2);
				}
				while ((object)isSubmitedRegisteredCompletedEventHandler != isSubmitedRegisteredCompletedEventHandler2);
			}
		}

		public event PesertaTesBeatCompletedEventHandler PesertaTesBeatCompleted
		{
			[CompilerGenerated]
			add
			{
				PesertaTesBeatCompletedEventHandler pesertaTesBeatCompletedEventHandler = Y04F6V9W8B;
				PesertaTesBeatCompletedEventHandler pesertaTesBeatCompletedEventHandler2;
				do
				{
					pesertaTesBeatCompletedEventHandler2 = pesertaTesBeatCompletedEventHandler;
					PesertaTesBeatCompletedEventHandler value2 = (PesertaTesBeatCompletedEventHandler)Delegate.Combine(pesertaTesBeatCompletedEventHandler2, value);
					pesertaTesBeatCompletedEventHandler = Interlocked.CompareExchange(ref Y04F6V9W8B, value2, pesertaTesBeatCompletedEventHandler2);
				}
				while ((object)pesertaTesBeatCompletedEventHandler != pesertaTesBeatCompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				PesertaTesBeatCompletedEventHandler pesertaTesBeatCompletedEventHandler = Y04F6V9W8B;
				PesertaTesBeatCompletedEventHandler pesertaTesBeatCompletedEventHandler2;
				do
				{
					pesertaTesBeatCompletedEventHandler2 = pesertaTesBeatCompletedEventHandler;
					PesertaTesBeatCompletedEventHandler value2 = (PesertaTesBeatCompletedEventHandler)Delegate.Remove(pesertaTesBeatCompletedEventHandler2, value);
					pesertaTesBeatCompletedEventHandler = Interlocked.CompareExchange(ref Y04F6V9W8B, value2, pesertaTesBeatCompletedEventHandler2);
				}
				while ((object)pesertaTesBeatCompletedEventHandler != pesertaTesBeatCompletedEventHandler2);
			}
		}

		public event GetDataLove1ServerCompletedEventHandler GetDataLove1ServerCompleted
		{
			[CompilerGenerated]
			add
			{
				GetDataLove1ServerCompletedEventHandler getDataLove1ServerCompletedEventHandler = bTEFg0Z9yQ;
				GetDataLove1ServerCompletedEventHandler getDataLove1ServerCompletedEventHandler2;
				do
				{
					getDataLove1ServerCompletedEventHandler2 = getDataLove1ServerCompletedEventHandler;
					GetDataLove1ServerCompletedEventHandler value2 = (GetDataLove1ServerCompletedEventHandler)Delegate.Combine(getDataLove1ServerCompletedEventHandler2, value);
					getDataLove1ServerCompletedEventHandler = Interlocked.CompareExchange(ref bTEFg0Z9yQ, value2, getDataLove1ServerCompletedEventHandler2);
				}
				while ((object)getDataLove1ServerCompletedEventHandler != getDataLove1ServerCompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				GetDataLove1ServerCompletedEventHandler getDataLove1ServerCompletedEventHandler = bTEFg0Z9yQ;
				GetDataLove1ServerCompletedEventHandler getDataLove1ServerCompletedEventHandler2;
				do
				{
					getDataLove1ServerCompletedEventHandler2 = getDataLove1ServerCompletedEventHandler;
					GetDataLove1ServerCompletedEventHandler value2 = (GetDataLove1ServerCompletedEventHandler)Delegate.Remove(getDataLove1ServerCompletedEventHandler2, value);
					getDataLove1ServerCompletedEventHandler = Interlocked.CompareExchange(ref bTEFg0Z9yQ, value2, getDataLove1ServerCompletedEventHandler2);
				}
				while ((object)getDataLove1ServerCompletedEventHandler != getDataLove1ServerCompletedEventHandler2);
			}
		}

		public event GetDataLove2ServerCompletedEventHandler GetDataLove2ServerCompleted
		{
			[CompilerGenerated]
			add
			{
				GetDataLove2ServerCompletedEventHandler getDataLove2ServerCompletedEventHandler = JWJF1OWD3H;
				GetDataLove2ServerCompletedEventHandler getDataLove2ServerCompletedEventHandler2;
				do
				{
					getDataLove2ServerCompletedEventHandler2 = getDataLove2ServerCompletedEventHandler;
					GetDataLove2ServerCompletedEventHandler value2 = (GetDataLove2ServerCompletedEventHandler)Delegate.Combine(getDataLove2ServerCompletedEventHandler2, value);
					getDataLove2ServerCompletedEventHandler = Interlocked.CompareExchange(ref JWJF1OWD3H, value2, getDataLove2ServerCompletedEventHandler2);
				}
				while ((object)getDataLove2ServerCompletedEventHandler != getDataLove2ServerCompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				GetDataLove2ServerCompletedEventHandler getDataLove2ServerCompletedEventHandler = JWJF1OWD3H;
				GetDataLove2ServerCompletedEventHandler getDataLove2ServerCompletedEventHandler2;
				do
				{
					getDataLove2ServerCompletedEventHandler2 = getDataLove2ServerCompletedEventHandler;
					GetDataLove2ServerCompletedEventHandler value2 = (GetDataLove2ServerCompletedEventHandler)Delegate.Remove(getDataLove2ServerCompletedEventHandler2, value);
					getDataLove2ServerCompletedEventHandler = Interlocked.CompareExchange(ref JWJF1OWD3H, value2, getDataLove2ServerCompletedEventHandler2);
				}
				while ((object)getDataLove2ServerCompletedEventHandler != getDataLove2ServerCompletedEventHandler2);
			}
		}

		public event GetDataLove3ServerCompletedEventHandler GetDataLove3ServerCompleted
		{
			[CompilerGenerated]
			add
			{
				GetDataLove3ServerCompletedEventHandler getDataLove3ServerCompletedEventHandler = dLaFcyWyX0;
				GetDataLove3ServerCompletedEventHandler getDataLove3ServerCompletedEventHandler2;
				do
				{
					getDataLove3ServerCompletedEventHandler2 = getDataLove3ServerCompletedEventHandler;
					GetDataLove3ServerCompletedEventHandler value2 = (GetDataLove3ServerCompletedEventHandler)Delegate.Combine(getDataLove3ServerCompletedEventHandler2, value);
					getDataLove3ServerCompletedEventHandler = Interlocked.CompareExchange(ref dLaFcyWyX0, value2, getDataLove3ServerCompletedEventHandler2);
				}
				while ((object)getDataLove3ServerCompletedEventHandler != getDataLove3ServerCompletedEventHandler2);
			}
			[CompilerGenerated]
			remove
			{
				GetDataLove3ServerCompletedEventHandler getDataLove3ServerCompletedEventHandler = dLaFcyWyX0;
				GetDataLove3ServerCompletedEventHandler getDataLove3ServerCompletedEventHandler2;
				do
				{
					getDataLove3ServerCompletedEventHandler2 = getDataLove3ServerCompletedEventHandler;
					GetDataLove3ServerCompletedEventHandler value2 = (GetDataLove3ServerCompletedEventHandler)Delegate.Remove(getDataLove3ServerCompletedEventHandler2, value);
					getDataLove3ServerCompletedEventHandler = Interlocked.CompareExchange(ref dLaFcyWyX0, value2, getDataLove3ServerCompletedEventHandler2);
				}
				while ((object)getDataLove3ServerCompletedEventHandler != getDataLove3ServerCompletedEventHandler2);
			}
		}

		public WorkstationService()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor();
			Url = PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(-801290702 ^ -257595311 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_f715fcffe3004c7aa46c8a09578d97a6);
			if (JQQFNeJo8I(Url))
			{
				UseDefaultCredentials = true;
				k2JFHmpkEA = false;
			}
			else
			{
				k2JFHmpkEA = true;
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/SubmitWorkstationV3", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse SubmitWorkstationV3([XmlElement(IsNullable = true)] string puspendikdata1, [XmlElement(IsNullable = true)] string puspendikdata2, [XmlElement(IsNullable = true)] string puspendikdata3, [XmlElement(IsNullable = true)] string puspendikdata4)
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5DA74991 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_df0882656164444fbd203474670ae7a7), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 })[0];
		}

		public void SubmitWorkstationV3Async(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4)
		{
			SubmitWorkstationV3Async(puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4, null);
		}

		public void SubmitWorkstationV3Async(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4, object userState)
		{
			if (s2iFMAZkHT == null)
			{
				s2iFMAZkHT = PmWF9cWEGP;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x28A1D04D ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_b88edb3d4a5443f59f2c94bbb42b1c5d), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 }, s2iFMAZkHT, userState);
		}

		private void PmWF9cWEGP(object P_0)
		{
			if (SUAFyYck8K != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				SUAFyYck8K(this, new SubmitWorkstationV3CompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/SubmitWorkstation", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse SubmitWorkstation([XmlElement(IsNullable = true)] string puspendikdata1, [XmlElement(IsNullable = true)] string puspendikdata2, [XmlElement(IsNullable = true)] string puspendikdata3, [XmlElement(IsNullable = true)] string puspendikdata4)
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4068A4E4 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_dfa7f1ced813437f8a4356e5abd3ab16), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 })[0];
		}

		public void SubmitWorkstationAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4)
		{
			SubmitWorkstationAsync(puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4, null);
		}

		public void SubmitWorkstationAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4, object userState)
		{
			if (MRFFt5yBCs == null)
			{
				MRFFt5yBCs = whoFrO9fAK;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x7D7FFF6B ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_1f0d8575e2a64f99badd1faea28adcf3), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 }, MRFFt5yBCs, userState);
		}

		private void whoFrO9fAK(object P_0)
		{
			if (X2MFj1jgdu != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				X2MFj1jgdu(this, new SubmitWorkstationCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/UnSubmitWorkstation", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse UnSubmitWorkstation([XmlElement(IsNullable = true)] string puspendikdata1, [XmlElement(IsNullable = true)] string puspendikdata2, [XmlElement(IsNullable = true)] string puspendikdata3, [XmlElement(IsNullable = true)] string puspendikdata4)
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x2CB38A37 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_6874963f64554f6c9453fb77ae802833), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 })[0];
		}

		public void UnSubmitWorkstationAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4)
		{
			UnSubmitWorkstationAsync(puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4, null);
		}

		public void UnSubmitWorkstationAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4, object userState)
		{
			if (So9FZwntl2 == null)
			{
				So9FZwntl2 = hYEFa2LgKU;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x1B05409E ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_60fcf68a246f430da22c2f187c8b4cc1), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 }, So9FZwntl2, userState);
		}

		private void hYEFa2LgKU(object P_0)
		{
			if (MGOFiCXA6U != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				MGOFiCXA6U(this, new UnSubmitWorkstationCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/IsSubmitedRegistered", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse IsSubmitedRegistered([XmlElement(IsNullable = true)] string puspendikdata1, [XmlElement(IsNullable = true)] string puspendikdata2, [XmlElement(IsNullable = true)] string puspendikdata3, [XmlElement(IsNullable = true)] string puspendikdata4)
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x1CA09234 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_8da749a9eea94d3182f20b29368f8de3), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 })[0];
		}

		public void IsSubmitedRegisteredAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4)
		{
			IsSubmitedRegisteredAsync(puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4, null);
		}

		public void IsSubmitedRegisteredAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4, object userState)
		{
			if (SYxFp7SgCL == null)
			{
				SYxFp7SgCL = FwOFAC3rRH;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x385209D6 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_c8c366b251c54560831a0933d492065a), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 }, SYxFp7SgCL, userState);
		}

		private void FwOFAC3rRH(object P_0)
		{
			if (trRFSt1XRH != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				trRFSt1XRH(this, new IsSubmitedRegisteredCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/PesertaTesBeat", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse PesertaTesBeat([XmlElement(IsNullable = true)] string puspendikdata1, [XmlElement(IsNullable = true)] string puspendikdata2, [XmlElement(IsNullable = true)] string puspendikdata3, [XmlElement(IsNullable = true)] string puspendikdata4)
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0xEBE608E ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_6b45aad2ca5049239702a633bdad69fa), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 })[0];
		}

		public void PesertaTesBeatAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4)
		{
			PesertaTesBeatAsync(puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4, null);
		}

		public void PesertaTesBeatAsync(string puspendikdata1, string puspendikdata2, string puspendikdata3, string puspendikdata4, object userState)
		{
			if (z9kFBIXg4M == null)
			{
				z9kFBIXg4M = aC3F0Agsik;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x4E4427AD ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_8058ed4e3b5642a889dd6c4665301b14), new object[4] { puspendikdata1, puspendikdata2, puspendikdata3, puspendikdata4 }, z9kFBIXg4M, userState);
		}

		private void aC3F0Agsik(object P_0)
		{
			if (Y04F6V9W8B != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				Y04F6V9W8B(this, new PesertaTesBeatCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/GetDataLove1Server", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse GetDataLove1Server()
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5AE916E3 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_053015b3ee3b44d88bcdf8d56ac27530), new object[0])[0];
		}

		public void GetDataLove1ServerAsync()
		{
			GetDataLove1ServerAsync(null);
		}

		public void GetDataLove1ServerAsync(object userState)
		{
			if (nAGF8myWh9 == null)
			{
				nAGF8myWh9 = thIF5LXYmE;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5B931736 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_7e7a1cd262b94d128bd8e406d09652e9), new object[0], nAGF8myWh9, userState);
		}

		private void thIF5LXYmE(object P_0)
		{
			if (bTEFg0Z9yQ != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				bTEFg0Z9yQ(this, new GetDataLove1ServerCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/GetDataLove2Server", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse GetDataLove2Server()
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x7D7FFFA7 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_1f0d8575e2a64f99badd1faea28adcf3), new object[0])[0];
		}

		public void GetDataLove2ServerAsync()
		{
			GetDataLove2ServerAsync(null);
		}

		public void GetDataLove2ServerAsync(object userState)
		{
			if (NZUFJW8xkX == null)
			{
				NZUFJW8xkX = gvHFU8p3n8;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x76632F95 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_58019b50b63a476ea06057a2db54f06a), new object[0], NZUFJW8xkX, userState);
		}

		private void gvHFU8p3n8(object P_0)
		{
			if (JWJF1OWD3H != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				JWJF1OWD3H(this, new GetDataLove2ServerCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		[SoapDocumentMethod("http://tempuri.org/IWorkstationService/GetDataLove3Server", ParameterStyle = SoapParameterStyle.Wrapped, RequestNamespace = "http://tempuri.org/", ResponseNamespace = "http://tempuri.org/", Use = SoapBindingUse.Literal)]
		[return: XmlElement(IsNullable = true)]
		public CBTResponse GetDataLove3Server()
		{
			return (CBTResponse)Invoke(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x238FC3D8 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_520098cedb1a45709e913928c81430e2), new object[0])[0];
		}

		public void GetDataLove3ServerAsync()
		{
			GetDataLove3ServerAsync(null);
		}

		public void GetDataLove3ServerAsync(object userState)
		{
			if (WsKFhKu5MI == null)
			{
				WsKFhKu5MI = sCNFvdjVYf;
			}
			InvokeAsync(PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5B9318C6 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_7e7a1cd262b94d128bd8e406d09652e9), new object[0], WsKFhKu5MI, userState);
		}

		private void sCNFvdjVYf(object P_0)
		{
			if (dLaFcyWyX0 != null)
			{
				InvokeCompletedEventArgs e = (InvokeCompletedEventArgs)P_0;
				dLaFcyWyX0(this, new GetDataLove3ServerCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
			}
		}

		public new void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
		}

		private bool JQQFNeJo8I(string P_0)
		{
			if (P_0 == null || P_0 == string.Empty)
			{
				return false;
			}
			Uri uri = new Uri(P_0);
			return uri.Port >= 1024 && string.Compare(uri.Host, PDENUARDKHJ71ysCRux.KBSR0Dt1Sr(0x5DA746D7 ^ <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}.m_188e107399a14b6fbb545059884f62e9.m_df0882656164444fbd203474670ae7a7), StringComparison.OrdinalIgnoreCase) == 0;
		}
	}
}
internal class <Module>{4499B700-155C-4DC4-91AC-70D929CABBF7}
{
}
namespace BRgFQvFksD1rgVgOIe8
{
	internal class eOKRFgFd4IdBL0SGL22
	{
		internal delegate void naUKorFzfo8TcDIgq1d(object o);

		internal static Module Kb7Fn4QI2D;

		internal static void AjX3im0Mqp(int typemdt)
		{
			Type type = Kb7Fn4QI2D.ResolveType(33554432 + typemdt);
			FieldInfo[] fields = type.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				MethodInfo method = (MethodInfo)Kb7Fn4QI2D.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		public eOKRFgFd4IdBL0SGL22()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			base..ctor();
		}

		static eOKRFgFd4IdBL0SGL22()
		{
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			Kb7Fn4QI2D = typeof(eOKRFgFd4IdBL0SGL22).Assembly.ManifestModule;
		}
	}
}
namespace ALtPbXRFYNSxmvJIbXR
{
	internal class PDENUARDKHJ71ysCRux
	{
		private delegate void PKXBHmmMVcTXH9tdLEs(object o);

		internal class bj9HGlmtJaK7T3lsCIU : Attribute
		{
			internal class Bm50XumZATHXFex8CDs<xKrD7Gmp30avtLOCUM4>
			{
				public Bm50XumZATHXFex8CDs()
				{
					dJLOPAmoTijWxbGSvCs.urY36js4go();
					base..ctor();
				}
			}

			public bj9HGlmtJaK7T3lsCIU(object P_0)
			{
			}
		}

		internal class b5R4ZImBkLyVuofXsVl
		{
			internal static string hg2m8XHbPw(string P_0, string P_1)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(P_0);
				byte[] key = new byte[32]
				{
					82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
					51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
					34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
					1, 88
				};
				byte[] iV = RIURXv2vgH(Encoding.Unicode.GetBytes(P_1));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = jPmRuMetci();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iV;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint tFcI5mmJrjRCsXZbuOw(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr X8Hp6kmhqZEGNfA1wZ7();

		internal struct YmkcDsmHkFXZEIcG3nh
		{
			internal bool IaKmysmbll;

			internal byte[] Mn4mjlvJNa;
		}

		internal class XkT7HOmiCfFhGJX07Vs
		{
			private BinaryReader FoBmcFHanb;

			public XkT7HOmiCfFhGJX07Vs(Stream P_0)
			{
				FoBmcFHanb = new BinaryReader(P_0);
			}

			[SpecialName]
			internal Stream f9UtU12u5A()
			{
				return FoBmcFHanb.BaseStream;
			}

			internal byte[] Ea2mSfIMLA(int P_0)
			{
				return FoBmcFHanb.ReadBytes(P_0);
			}

			internal int eArm6fQMyA(byte[] P_0, int P_1, int P_2)
			{
				return FoBmcFHanb.Read(P_0, P_1, P_2);
			}

			internal int vV2mgIKjlU()
			{
				return FoBmcFHanb.ReadInt32();
			}

			internal void jAAm1pSC36()
			{
				FoBmcFHanb.Close();
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		private delegate IntPtr dJ5ua6mqjCdOQgoR8PY(IntPtr hModule, string lpName, uint lpType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr VXVOWim4IBkY2ASjDXm(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int Wcwft2mQ2wXAJFTqer0(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int Jy1haamTfVwKZXwsZVN(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr gXtLyymKAhEU9XoJaw8(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int yloXGhmPfpVqhwcpaxi(IntPtr ptr);

		[Flags]
		private enum kW2LClmea2qr2DA2bxq
		{

		}

		private static uint[] ktWRoC1Ah5;

		private static bool L6DROVh7QZ;

		internal static RSACryptoServiceProvider GZcRbjQLcY;

		private static List<string> EX4RkIhWag;

		private static object PeDmmXeOyS;

		private static int ruomfmoOHR;

		internal static tFcI5mmJrjRCsXZbuOw Kjnmwb8udR;

		private static int Fgimlyca1N;

		private static bool CBYmG30bmV;

		private static IntPtr KLvmYNIO7B;

		[bj9HGlmtJaK7T3lsCIU(typeof(bj9HGlmtJaK7T3lsCIU.Bm50XumZATHXFex8CDs<object>[]))]
		private static bool nkPm967kbo;

		private static VXVOWim4IBkY2ASjDXm l82mAq7fEF;

		private static Jy1haamTfVwKZXwsZVN vQsm5DMXjx;

		private static yloXGhmPfpVqhwcpaxi ohVmvrpoIS;

		internal static tFcI5mmJrjRCsXZbuOw BXAmuJWwjF;

		private static Wcwft2mQ2wXAJFTqer0 bDim0kXgFr;

		private static IntPtr xixmFIGt4a;

		private static int FHPRsRqPUl;

		private static IntPtr MsymNybKi8;

		private static dJ5ua6mqjCdOQgoR8PY rFbmafGRZR;

		private static gXtLyymKAhEU9XoJaw8 lFNmUUF0Br;

		private static List<int> NkmRn2UcZo;

		private static int VxHm2AKE17;

		private static long iXSm75W1TD;

		internal static Hashtable hLSmrJ6WbE;

		private static byte[] qsSmDa2j85;

		private static bool G2fmE1kOLx;

		private static byte[] HWYRzIThpx;

		internal static Assembly T3sReKY5xV;

		private static object cHmRdPn0YC;

		private static SortedList i3HmC4fd4c;

		private static bool dsrRVNQ7QG;

		private static object yDmRWU3rV8;

		private static IntPtr k1WmRfrTsH;

		private static Dictionary<int, int> auRRIA66x1;

		private static long h5tmXse6EB;

		private static int n1vmLy7Wo8;

		private static bool nnOmxEY68p;

		private static int[] rTUm3KH4FP;

		static PDENUARDKHJ71ysCRux()
		{
			T3sReKY5xV = typeof(PDENUARDKHJ71ysCRux).Assembly;
			ktWRoC1Ah5 = new uint[64]
			{
				3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
				4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
				3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
				1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
				681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
				2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
				4149444226u, 3174756917u, 718787259u, 3951481745u
			};
			L6DROVh7QZ = false;
			dsrRVNQ7QG = false;
			GZcRbjQLcY = null;
			auRRIA66x1 = null;
			yDmRWU3rV8 = new object();
			FHPRsRqPUl = 0;
			cHmRdPn0YC = new object();
			EX4RkIhWag = null;
			NkmRn2UcZo = null;
			HWYRzIThpx = new byte[0];
			qsSmDa2j85 = new byte[0];
			xixmFIGt4a = IntPtr.Zero;
			k1WmRfrTsH = IntPtr.Zero;
			PeDmmXeOyS = new string[0];
			rTUm3KH4FP = new int[0];
			ruomfmoOHR = 1;
			nnOmxEY68p = false;
			i3HmC4fd4c = new SortedList();
			n1vmLy7Wo8 = 0;
			iXSm75W1TD = 0L;
			BXAmuJWwjF = null;
			Kjnmwb8udR = null;
			h5tmXse6EB = 0L;
			Fgimlyca1N = 0;
			CBYmG30bmV = false;
			G2fmE1kOLx = false;
			VxHm2AKE17 = 0;
			KLvmYNIO7B = IntPtr.Zero;
			nkPm967kbo = false;
			hLSmrJ6WbE = new Hashtable();
			rFbmafGRZR = null;
			l82mAq7fEF = null;
			bDim0kXgFr = null;
			vQsm5DMXjx = null;
			lFNmUUF0Br = null;
			ohVmvrpoIS = null;
			MsymNybKi8 = IntPtr.Zero;
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private void Fju3S1rRmg()
		{
		}

		internal static byte[] xQtRRZ1eI1(byte[] P_0)
		{
			uint[] array = new uint[16];
			uint num = (uint)((448 - P_0.Length * 8 % 512 + 512) % 512);
			if (num == 0)
			{
				num = 512u;
			}
			uint num2 = (uint)(P_0.Length + num / 8 + 8);
			ulong num3 = (ulong)P_0.Length * 8uL;
			byte[] array2 = new byte[num2];
			for (int i = 0; i < P_0.Length; i++)
			{
				array2[i] = P_0[i];
			}
			array2[P_0.Length] |= 128;
			for (int num4 = 8; num4 > 0; num4--)
			{
				array2[num2 - num4] = (byte)((num3 >> (8 - num4) * 8) & 0xFF);
			}
			uint num5 = (uint)(array2.Length * 8) / 32u;
			uint num6 = 1732584193u;
			uint num7 = 4023233417u;
			uint num8 = 2562383102u;
			uint num9 = 271733878u;
			for (uint num10 = 0u; num10 < num5 / 16; num10++)
			{
				uint num11 = num10 << 6;
				for (uint num12 = 0u; num12 < 61; num12 += 4)
				{
					array[num12 >> 2] = (uint)((array2[num11 + (num12 + 3)] << 24) | (array2[num11 + (num12 + 2)] << 16) | (array2[num11 + (num12 + 1)] << 8) | array2[num11 + num12]);
				}
				uint num13 = num6;
				uint num14 = num7;
				uint num15 = num8;
				uint num16 = num9;
				k6NRmMD5o8(ref num6, num7, num8, num9, 0u, 7, 1u, array);
				k6NRmMD5o8(ref num9, num6, num7, num8, 1u, 12, 2u, array);
				k6NRmMD5o8(ref num8, num9, num6, num7, 2u, 17, 3u, array);
				k6NRmMD5o8(ref num7, num8, num9, num6, 3u, 22, 4u, array);
				k6NRmMD5o8(ref num6, num7, num8, num9, 4u, 7, 5u, array);
				k6NRmMD5o8(ref num9, num6, num7, num8, 5u, 12, 6u, array);
				k6NRmMD5o8(ref num8, num9, num6, num7, 6u, 17, 7u, array);
				k6NRmMD5o8(ref num7, num8, num9, num6, 7u, 22, 8u, array);
				k6NRmMD5o8(ref num6, num7, num8, num9, 8u, 7, 9u, array);
				k6NRmMD5o8(ref num9, num6, num7, num8, 9u, 12, 10u, array);
				k6NRmMD5o8(ref num8, num9, num6, num7, 10u, 17, 11u, array);
				k6NRmMD5o8(ref num7, num8, num9, num6, 11u, 22, 12u, array);
				k6NRmMD5o8(ref num6, num7, num8, num9, 12u, 7, 13u, array);
				k6NRmMD5o8(ref num9, num6, num7, num8, 13u, 12, 14u, array);
				k6NRmMD5o8(ref num8, num9, num6, num7, 14u, 17, 15u, array);
				k6NRmMD5o8(ref num7, num8, num9, num6, 15u, 22, 16u, array);
				IiLR3dwX9K(ref num6, num7, num8, num9, 1u, 5, 17u, array);
				IiLR3dwX9K(ref num9, num6, num7, num8, 6u, 9, 18u, array);
				IiLR3dwX9K(ref num8, num9, num6, num7, 11u, 14, 19u, array);
				IiLR3dwX9K(ref num7, num8, num9, num6, 0u, 20, 20u, array);
				IiLR3dwX9K(ref num6, num7, num8, num9, 5u, 5, 21u, array);
				IiLR3dwX9K(ref num9, num6, num7, num8, 10u, 9, 22u, array);
				IiLR3dwX9K(ref num8, num9, num6, num7, 15u, 14, 23u, array);
				IiLR3dwX9K(ref num7, num8, num9, num6, 4u, 20, 24u, array);
				IiLR3dwX9K(ref num6, num7, num8, num9, 9u, 5, 25u, array);
				IiLR3dwX9K(ref num9, num6, num7, num8, 14u, 9, 26u, array);
				IiLR3dwX9K(ref num8, num9, num6, num7, 3u, 14, 27u, array);
				IiLR3dwX9K(ref num7, num8, num9, num6, 8u, 20, 28u, array);
				IiLR3dwX9K(ref num6, num7, num8, num9, 13u, 5, 29u, array);
				IiLR3dwX9K(ref num9, num6, num7, num8, 2u, 9, 30u, array);
				IiLR3dwX9K(ref num8, num9, num6, num7, 7u, 14, 31u, array);
				IiLR3dwX9K(ref num7, num8, num9, num6, 12u, 20, 32u, array);
				Dy8RfthABt(ref num6, num7, num8, num9, 5u, 4, 33u, array);
				Dy8RfthABt(ref num9, num6, num7, num8, 8u, 11, 34u, array);
				Dy8RfthABt(ref num8, num9, num6, num7, 11u, 16, 35u, array);
				Dy8RfthABt(ref num7, num8, num9, num6, 14u, 23, 36u, array);
				Dy8RfthABt(ref num6, num7, num8, num9, 1u, 4, 37u, array);
				Dy8RfthABt(ref num9, num6, num7, num8, 4u, 11, 38u, array);
				Dy8RfthABt(ref num8, num9, num6, num7, 7u, 16, 39u, array);
				Dy8RfthABt(ref num7, num8, num9, num6, 10u, 23, 40u, array);
				Dy8RfthABt(ref num6, num7, num8, num9, 13u, 4, 41u, array);
				Dy8RfthABt(ref num9, num6, num7, num8, 0u, 11, 42u, array);
				Dy8RfthABt(ref num8, num9, num6, num7, 3u, 16, 43u, array);
				Dy8RfthABt(ref num7, num8, num9, num6, 6u, 23, 44u, array);
				Dy8RfthABt(ref num6, num7, num8, num9, 9u, 4, 45u, array);
				Dy8RfthABt(ref num9, num6, num7, num8, 12u, 11, 46u, array);
				Dy8RfthABt(ref num8, num9, num6, num7, 15u, 16, 47u, array);
				Dy8RfthABt(ref num7, num8, num9, num6, 2u, 23, 48u, array);
				A6oRxfLdyX(ref num6, num7, num8, num9, 0u, 6, 49u, array);
				A6oRxfLdyX(ref num9, num6, num7, num8, 7u, 10, 50u, array);
				A6oRxfLdyX(ref num8, num9, num6, num7, 14u, 15, 51u, array);
				A6oRxfLdyX(ref num7, num8, num9, num6, 5u, 21, 52u, array);
				A6oRxfLdyX(ref num6, num7, num8, num9, 12u, 6, 53u, array);
				A6oRxfLdyX(ref num9, num6, num7, num8, 3u, 10, 54u, array);
				A6oRxfLdyX(ref num8, num9, num6, num7, 10u, 15, 55u, array);
				A6oRxfLdyX(ref num7, num8, num9, num6, 1u, 21, 56u, array);
				A6oRxfLdyX(ref num6, num7, num8, num9, 8u, 6, 57u, array);
				A6oRxfLdyX(ref num9, num6, num7, num8, 15u, 10, 58u, array);
				A6oRxfLdyX(ref num8, num9, num6, num7, 6u, 15, 59u, array);
				A6oRxfLdyX(ref num7, num8, num9, num6, 13u, 21, 60u, array);
				A6oRxfLdyX(ref num6, num7, num8, num9, 4u, 6, 61u, array);
				A6oRxfLdyX(ref num9, num6, num7, num8, 11u, 10, 62u, array);
				A6oRxfLdyX(ref num8, num9, num6, num7, 2u, 15, 63u, array);
				A6oRxfLdyX(ref num7, num8, num9, num6, 9u, 21, 64u, array);
				num6 += num13;
				num7 += num14;
				num8 += num15;
				num9 += num16;
			}
			byte[] array3 = new byte[16];
			Array.Copy(BitConverter.GetBytes(num6), 0, array3, 0, 4);
			Array.Copy(BitConverter.GetBytes(num7), 0, array3, 4, 4);
			Array.Copy(BitConverter.GetBytes(num8), 0, array3, 8, 4);
			Array.Copy(BitConverter.GetBytes(num9), 0, array3, 12, 4);
			return array3;
		}

		private static void k6NRmMD5o8(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + QWcRCHebHu(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + ktWRoC1Ah5[P_6 - 1], P_5);
		}

		private static void IiLR3dwX9K(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + QWcRCHebHu(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + ktWRoC1Ah5[P_6 - 1], P_5);
		}

		private static void Dy8RfthABt(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + QWcRCHebHu(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + ktWRoC1Ah5[P_6 - 1], P_5);
		}

		private static void A6oRxfLdyX(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + QWcRCHebHu(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + ktWRoC1Ah5[P_6 - 1], P_5);
		}

		private static uint QWcRCHebHu(uint P_0, ushort P_1)
		{
			return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
		}

		internal static bool MXqRLFRC8Q()
		{
			if (!L6DROVh7QZ)
			{
				waLRwJhciV();
				L6DROVh7QZ = true;
			}
			return dsrRVNQ7QG;
		}

		internal PDENUARDKHJ71ysCRux()
		{
		}

		private void T4FR7ZqNVb(byte[] P_0, byte[] P_1, byte[] P_2)
		{
			int num = P_2.Length % 4;
			int num2 = P_2.Length / 4;
			byte[] array = new byte[P_2.Length];
			int num3 = P_0.Length / 4;
			uint num4 = 0u;
			uint num5 = 0u;
			uint num6 = 0u;
			if (num > 0)
			{
				num2++;
			}
			uint num7 = 0u;
			for (int i = 0; i < num2; i++)
			{
				int num8 = i % num3;
				int num9 = i * 4;
				num7 = (uint)(num8 * 4);
				num5 = (uint)((P_0[num7 + 3] << 24) | (P_0[num7 + 2] << 16) | (P_0[num7 + 1] << 8) | P_0[num7]);
				uint num10 = 255u;
				int num11 = 0;
				if (i == num2 - 1 && num > 0)
				{
					num6 = 0u;
					num4 += num5;
					for (int j = 0; j < num; j++)
					{
						if (j > 0)
						{
							num6 <<= 8;
						}
						num6 |= P_2[P_2.Length - (1 + j)];
					}
				}
				else
				{
					num4 += num5;
					num7 = (uint)num9;
					num6 = (uint)((P_2[num7 + 3] << 24) | (P_2[num7 + 2] << 16) | (P_2[num7 + 1] << 8) | P_2[num7]);
				}
				uint num12 = num4;
				num4 = 0u;
				uint num13 = num12;
				uint num14 = 2040033812u;
				uint num15 = 113317424u;
				uint num16 = 1751358442u;
				uint num17 = 683545857u;
				if (num14 == 0)
				{
					num14--;
				}
				uint num18 = num13 / num14 + num14;
				num14 = num13 - num16 + num18 + num13;
				ulong num19 = num16 * 133953954;
				num19 |= 1;
				num15 = (uint)(num15 * num15 % num19);
				uint num20 = ((num13 << 11) | (num13 >> 21)) ^ num14;
				uint num21 = num20 & 0xFF00FF;
				num20 &= 0xFF00FF00u;
				num13 = (num20 >> 8) | (num21 << 8);
				num19 = num14 * 855107465;
				num19 |= 1;
				num16 = (uint)(num16 * num16 % num19);
				num17 = 2602960497u + num14;
				num13 ^= num13 << 14;
				num13 += num13;
				num13 ^= num13 << 15;
				num13 += num16;
				num13 ^= num13 >> 1;
				num13 += num17;
				num13 = (((num16 << 3) - num14) ^ num16) + num13;
				num4 = num12 + (uint)(double)num13;
				if (i == num2 - 1 && num > 0)
				{
					uint num22 = num4 ^ num6;
					for (int k = 0; k < num; k++)
					{
						if (k > 0)
						{
							num10 <<= 8;
							num11 += 8;
						}
						array[num9 + k] = (byte)((num22 & num10) >> num11);
					}
				}
				else
				{
					uint num23 = num4 ^ num6;
					array[num9] = (byte)(num23 & 0xFF);
					array[num9 + 1] = (byte)((num23 & 0xFF00) >> 8);
					array[num9 + 2] = (byte)((num23 & 0xFF0000) >> 16);
					array[num9 + 3] = (byte)((num23 & 0xFF000000u) >> 24);
				}
			}
			HWYRzIThpx = array;
		}

		internal static SymmetricAlgorithm jPmRuMetci()
		{
			SymmetricAlgorithm symmetricAlgorithm = null;
			if (MXqRLFRC8Q())
			{
				try
				{
					return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					try
					{
						return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
					}
					catch
					{
						return new RijndaelManaged();
					}
				}
			}
			try
			{
				return new RijndaelManaged();
			}
			catch
			{
				try
				{
					return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
				catch
				{
					return (SymmetricAlgorithm)Activator.CreateInstance("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", "System.Security.Cryptography.AesCryptoServiceProvider").Unwrap();
				}
			}
		}

		internal static void waLRwJhciV()
		{
			try
			{
				new RijndaelManaged();
				dsrRVNQ7QG = false;
			}
			catch
			{
				dsrRVNQ7QG = true;
			}
		}

		internal static byte[] RIURXv2vgH(byte[] P_0)
		{
			if (!MXqRLFRC8Q())
			{
				return new MD5CryptoServiceProvider().ComputeHash(P_0);
			}
			return xQtRRZ1eI1(P_0);
		}

		internal static void iobRlXlGTC(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
		{
			while (P_2 != 0)
			{
				int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
				P_1.Read(P_3, 0, num);
				IrxRGhE9FZ(P_0, P_3, 0, num);
				P_2 -= (uint)num;
			}
		}

		internal static void IrxRGhE9FZ(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
		{
			P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
		}

		internal static uint k3EREU2Z0p(uint P_0, int P_1, long P_2, BinaryReader P_3)
		{
			for (int i = 0; i < P_1; i++)
			{
				P_3.BaseStream.Position = P_2 + (i * 40 + 8);
				uint num = P_3.ReadUInt32();
				uint num2 = P_3.ReadUInt32();
				P_3.ReadUInt32();
				uint num3 = P_3.ReadUInt32();
				if (num2 <= P_0 && P_0 < num2 + num)
				{
					return num3 + P_0 - num2;
				}
			}
			return 0u;
		}

		public static void qABR2Chh7g(RuntimeTypeHandle P_0)
		{
			try
			{
				Type typeFromHandle = Type.GetTypeFromHandle(P_0);
				if (auRRIA66x1 == null)
				{
					lock (yDmRWU3rV8)
					{
						Dictionary<int, int> dictionary = new Dictionary<int, int>();
						BinaryReader binaryReader = new BinaryReader(typeof(PDENUARDKHJ71ysCRux).Assembly.GetManifestResourceStream("8tgfXEwufAK5fUXI8x.KUsnYmXv0oIOZL5d7a"));
						binaryReader.BaseStream.Position = 0L;
						byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
						binaryReader.Close();
						if (array.Length != 0)
						{
							int num = array.Length % 4;
							int num2 = array.Length / 4;
							byte[] array2 = new byte[array.Length];
							uint num3 = 0u;
							uint num4 = 0u;
							if (num > 0)
							{
								num2++;
							}
							uint num5 = 0u;
							for (int i = 0; i < num2; i++)
							{
								int num6 = i * 4;
								uint num7 = 255u;
								int num8 = 0;
								if (i == num2 - 1 && num > 0)
								{
									num4 = 0u;
									for (int j = 0; j < num; j++)
									{
										if (j > 0)
										{
											num4 <<= 8;
										}
										num4 |= array[array.Length - (1 + j)];
									}
								}
								else
								{
									num5 = (uint)num6;
									num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
								}
								num3 = num3;
								num3 += AppRrvyQJA(num3);
								if (i == num2 - 1 && num > 0)
								{
									uint num9 = num3 ^ num4;
									for (int k = 0; k < num; k++)
									{
										if (k > 0)
										{
											num7 <<= 8;
											num8 += 8;
										}
										array2[num6 + k] = (byte)((num9 & num7) >> num8);
									}
								}
								else
								{
									uint num10 = num3 ^ num4;
									array2[num6] = (byte)(num10 & 0xFF);
									array2[num6 + 1] = (byte)((num10 & 0xFF00) >> 8);
									array2[num6 + 2] = (byte)((num10 & 0xFF0000) >> 16);
									array2[num6 + 3] = (byte)((num10 & 0xFF000000u) >> 24);
								}
							}
							array = array2;
							array2 = null;
							int num11 = array.Length / 8;
							XkT7HOmiCfFhGJX07Vs xkT7HOmiCfFhGJX07Vs = new XkT7HOmiCfFhGJX07Vs(new MemoryStream(array));
							for (int l = 0; l < num11; l++)
							{
								int key = xkT7HOmiCfFhGJX07Vs.vV2mgIKjlU();
								int value = xkT7HOmiCfFhGJX07Vs.vV2mgIKjlU();
								dictionary.Add(key, value);
							}
							xkT7HOmiCfFhGJX07Vs.jAAm1pSC36();
						}
						auRRIA66x1 = dictionary;
					}
				}
				FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
				for (int m = 0; m < fields.Length; m++)
				{
					try
					{
						FieldInfo fieldInfo = fields[m];
						int metadataToken = fieldInfo.MetadataToken;
						int num12 = auRRIA66x1[metadataToken];
						bool flag = (num12 & 0x40000000) > 0;
						num12 &= 0x3FFFFFFF;
						MethodInfo methodInfo = (MethodInfo)typeof(PDENUARDKHJ71ysCRux).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
						if (methodInfo.IsStatic)
						{
							fieldInfo.SetValue(null, Delegate.CreateDelegate(fieldInfo.FieldType, methodInfo));
							continue;
						}
						ParameterInfo[] parameters = methodInfo.GetParameters();
						int num13 = parameters.Length + 1;
						Type[] array3 = new Type[num13];
						if (methodInfo.DeclaringType.IsValueType)
						{
							array3[0] = methodInfo.DeclaringType.MakeByRefType();
						}
						else
						{
							array3[0] = typeof(object);
						}
						for (int n = 0; n < parameters.Length; n++)
						{
							array3[n + 1] = parameters[n].ParameterType;
						}
						DynamicMethod dynamicMethod = new DynamicMethod(string.Empty, methodInfo.ReturnType, array3, typeFromHandle, skipVisibility: true);
						ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
						for (int num14 = 0; num14 < num13; num14++)
						{
							switch (num14)
							{
							case 0:
								iLGenerator.Emit(OpCodes.Ldarg_0);
								break;
							case 1:
								iLGenerator.Emit(OpCodes.Ldarg_1);
								break;
							case 2:
								iLGenerator.Emit(OpCodes.Ldarg_2);
								break;
							case 3:
								iLGenerator.Emit(OpCodes.Ldarg_3);
								break;
							default:
								iLGenerator.Emit(OpCodes.Ldarg_S, num14);
								break;
							}
						}
						iLGenerator.Emit(OpCodes.Tailcall);
						iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, methodInfo);
						iLGenerator.Emit(OpCodes.Ret);
						fieldInfo.SetValue(null, dynamicMethod.CreateDelegate(typeFromHandle));
					}
					catch (Exception)
					{
					}
				}
			}
			catch (Exception)
			{
			}
		}

		private static uint UClR9xumeT(uint P_0)
		{
			return (uint)"{11111-22222-10009-11112}".Length;
		}

		private static uint AppRrvyQJA(uint P_0)
		{
			return 0u;
		}

		internal static void dcTRaMMVFs()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void m6cRAtLOOi(Stream P_0, int P_1)
		{
			int num = 142;
			byte[] array = default;
			int num5 = default;
			int num6 = default;
			ICryptoTransform transform = default;
			byte[] array3 = default;
			byte[] array4 = default;
			int num7 = default;
			byte[] array2 = default;
			int num4 = default;
			byte[] array6 = default;
			int num3 = default;
			byte[] array5 = default;
			Stream stream = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 39:
						array[27] = 152;
						num = 203;
						break;
					case 238:
						num5 = 104 + 45;
						num2 = 153;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 82;
						}
						continue;
					case 177:
						num6 = 128 - 113;
						num2 = 22;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 126;
						}
						continue;
					case 54:
					{
						object obj = B6hAa83ZO0JrZ2HjnZd();
						sYgkYo3pKp1AF8Q1Pdr(obj, CipherMode.CBC);
						transform = (ICryptoTransform)nwcUVy3Bgj6b0gcd7mC(obj, array3, array4);
						num2 = 165;
						continue;
					}
					case 266:
					case 347:
						array3[num7] ^= array4[num7];
						num2 = 172;
						continue;
					case 220:
						array2[12] = 101;
						num2 = 47;
						continue;
					case 337:
						array[31] = 139;
						num2 = 92;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 101;
						}
						continue;
					case 89:
						array[14] = (byte)num6;
						num2 = 130;
						continue;
					case 118:
						array2[11] = 7;
						num2 = 108;
						continue;
					case 159:
						num5 = 122 + 116;
						num2 = 249;
						continue;
					case 241:
						array[21] = (byte)num4;
						num2 = 151;
						continue;
					case 26:
						array[29] = (byte)num4;
						num2 = 323;
						continue;
					case 243:
						array4[9] = array6[4];
						num2 = 161;
						continue;
					case 30:
						num6 = 157 - 52;
						num = 232;
						break;
					case 175:
						array[11] = (byte)num6;
						num2 = 32;
						continue;
					case 346:
						array2[8] = (byte)num3;
						num2 = 186;
						continue;
					case 180:
						array2[2] = (byte)num5;
						num2 = 128;
						continue;
					case 307:
						num4 = 17 + 58;
						num2 = 207;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 351;
						}
						continue;
					case 164:
						num4 = 161 - 53;
						num2 = 212;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 356;
						}
						continue;
					case 87:
						if (e7t47e3juoaAX5SYqf7(T3sReKY5xV) != null)
						{
							num2 = 225;
							continue;
						}
						goto case 268;
					case 144:
						array[20] = (byte)num4;
						num2 = 192;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 46;
						}
						continue;
					case 142:
					{
						XkT7HOmiCfFhGJX07Vs xkT7HOmiCfFhGJX07Vs = new XkT7HOmiCfFhGJX07Vs(P_0);
						jrdd2d30HyBWxWZov9F(R2dBHi3APONIYtKNS2S(xkT7HOmiCfFhGJX07Vs), 0L);
						array5 = (byte[])Xr7dsJ3UbY6DIkfFycn(xkT7HOmiCfFhGJX07Vs, (int)iI43LM35XbT8CscQVKy(R2dBHi3APONIYtKNS2S(xkT7HOmiCfFhGJX07Vs)));
						sSTBw93vRuFf8VFXVru(xkT7HOmiCfFhGJX07Vs);
						num2 = 1;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 141;
						}
						continue;
					}
					case 299:
						array[15] = 124;
						num2 = 197;
						continue;
					case 297:
						num3 = 132 + 49;
						num2 = 83;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 62;
						}
						continue;
					case 265:
						array2[5] = 128;
						num2 = 17;
						continue;
					case 203:
						array[27] = 197;
						num2 = 191;
						continue;
					case 135:
						num3 = 28 + 74;
						num2 = 161;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 328;
						}
						continue;
					case 264:
						array2[14] = 118;
						num2 = 188;
						continue;
					case 204:
						num6 = 254 - 84;
						num2 = 291;
						continue;
					case 57:
						array2[9] = 118;
						num2 = 297;
						continue;
					case 192:
						array[20] = 159;
						num2 = 0;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 0;
						}
						continue;
					case 60:
						array2[8] = (byte)num5;
						num = 345;
						break;
					case 350:
						array[28] = (byte)num4;
						num2 = 311;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 233;
						}
						continue;
					case 223:
						array2[10] = 222;
						num2 = 293;
						continue;
					case 171:
						array2[14] = (byte)num3;
						num2 = 125;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 82;
						}
						continue;
					case 210:
						array[8] = 37;
						num2 = 116;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 263;
						}
						continue;
					case 207:
						num4 = 60 + 63;
						num2 = 230;
						continue;
					case 291:
						array[6] = (byte)num6;
						num2 = 177;
						continue;
					case 311:
						num4 = 26 + 67;
						num2 = 267;
						continue;
					case 2:
						array2[11] = 122;
						num2 = 103;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 118;
						}
						continue;
					case 114:
						array2[14] = (byte)num3;
						num2 = 256;
						continue;
					case 271:
						array[21] = (byte)num4;
						num2 = 6;
						continue;
					case 236:
					case 327:
						if (num7 < array4.Length)
						{
							num2 = 266;
							if (x927kn3atyOZxef7ohl() != null)
							{
								num2 = 155;
							}
							continue;
						}
						goto case 167;
					case 330:
						array[4] = 35;
						num2 = 73;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 60;
						}
						continue;
					case 305:
						array[17] = (byte)num6;
						num2 = 214;
						continue;
					case 46:
					{
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						SGfNOQ3JECUxxvu988O(cryptoStream, array5, 0, array5.Length);
						sQq75f3haY10HZvrwuJ(cryptoStream);
						HWYRzIThpx = (byte[])qhBU0L3HH36HZaLhrgy(stream);
						yoGPiP3yC7N7uq4lMnR(stream);
						yoGPiP3yC7N7uq4lMnR(cryptoStream);
						num2 = 309;
						continue;
					}
					case 195:
						num5 = 60 + 76;
						num2 = 180;
						continue;
					case 188:
						num3 = 205 - 88;
						num2 = 269;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 334;
						}
						continue;
					case 253:
						array[26] = 164;
						num2 = 16;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 68;
						}
						continue;
					case 332:
						array[12] = 93;
						num2 = 47;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 63;
						}
						continue;
					case 319:
						array[10] = (byte)num6;
						num2 = 12;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 12;
						}
						continue;
					case 259:
						array[28] = 152;
						num2 = 47;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 67;
						}
						continue;
					case 156:
						array[24] = 55;
						num2 = 209;
						continue;
					case 122:
						num3 = 158 - 52;
						num2 = 45;
						continue;
					case 152:
						num6 = 22 + 105;
						num2 = 246;
						continue;
					case 295:
						array[13] = (byte)num6;
						num2 = 336;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 3;
						}
						continue;
					case 23:
						array4[13] = array6[6];
						num = 98;
						break;
					case 4:
						array[25] = 138;
						num2 = 51;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 120;
						}
						continue;
					case 262:
						array2[6] = 111;
						num2 = 20;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 242;
						}
						continue;
					case 21:
						array[0] = 111;
						num = 86;
						break;
					case 267:
						array[29] = (byte)num4;
						num2 = 306;
						continue;
					case 151:
						num6 = 52 - 41;
						num2 = 320;
						continue;
					case 9:
						array[24] = (byte)num6;
						num2 = 287;
						continue;
					case 58:
						array[15] = (byte)num4;
						num2 = 329;
						continue;
					case 16:
						array[30] = (byte)num4;
						num2 = 11;
						continue;
					case 248:
						num4 = 224 - 106;
						num2 = 58;
						continue;
					case 84:
						num4 = 167 - 55;
						num2 = 71;
						continue;
					case 322:
						array[15] = (byte)num6;
						num2 = 248;
						continue;
					case 88:
						array2[3] = 76;
						num2 = 222;
						continue;
					case 230:
						array[29] = (byte)num4;
						num2 = 65;
						continue;
					case 312:
						num6 = 107 + 94;
						num2 = 43;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 170;
						}
						continue;
					case 167:
						if (P_1 == -1)
						{
							num2 = 54;
							continue;
						}
						goto case 87;
					case 81:
						array2[3] = 80;
						num2 = 57;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 166;
						}
						continue;
					case 125:
						num3 = 5 + 52;
						num2 = 114;
						continue;
					case 76:
						array[6] = (byte)num4;
						num = 318;
						break;
					case 274:
						array2[7] = 142;
						num = 96;
						break;
					case 349:
						num3 = 68 + 43;
						num2 = 335;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 22;
						}
						continue;
					case 95:
						array2[2] = 140;
						num2 = 159;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 78;
						}
						continue;
					case 292:
						array[26] = 119;
						num2 = 1;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 53;
						}
						continue;
					case 128:
						num5 = 65 + 40;
						num = 221;
						break;
					case 263:
						num6 = 186 - 62;
						num = 42;
						break;
					case 104:
						array[11] = (byte)num6;
						num2 = 67;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 289;
						}
						continue;
					case 105:
						num3 = 66 + 52;
						num2 = 128;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 251;
						}
						continue;
					case 82:
						num6 = 175 - 58;
						num2 = 185;
						continue;
					case 1:
						num6 = 28 + 29;
						num2 = 9;
						continue;
					case 90:
						array[30] = (byte)num6;
						num2 = 111;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 117;
						}
						continue;
					case 193:
						array2[10] = 84;
						num2 = 223;
						continue;
					case 279:
						array2[5] = 143;
						num2 = 131;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 216;
						}
						continue;
					case 77:
						array[0] = 158;
						num2 = 21;
						continue;
					case 43:
						array[10] = (byte)num6;
						num2 = 102;
						continue;
					case 201:
						array2[3] = 149;
						num2 = 16;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 81;
						}
						continue;
					case 225:
					case 326:
						new PDENUARDKHJ71ysCRux().T4FR7ZqNVb(array3, array4, array5);
						num2 = 37;
						continue;
					case 361:
						num6 = 141 - 47;
						num2 = 104;
						continue;
					case 217:
						num4 = 71 - 15;
						num2 = 179;
						continue;
					case 85:
						array[3] = (byte)num4;
						num2 = 84;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 13;
						}
						continue;
					case 182:
						num4 = 34 + 107;
						num2 = 137;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 98;
						}
						continue;
					case 254:
						array[14] = (byte)num4;
						num2 = 215;
						continue;
					case 83:
						array2[9] = (byte)num3;
						num2 = 135;
						continue;
					case 31:
						array6 = (byte[])jAruca3tRdxWQkLt3Rf(yM0euA3Mi5nyxOWruS0(T3sReKY5xV));
						num2 = 198;
						continue;
					case 168:
						num3 = 227 - 75;
						num2 = 214;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 302;
						}
						continue;
					case 56:
						num5 = 141 - 47;
						num2 = 112;
						continue;
					case 133:
						array2[7] = (byte)num3;
						num2 = 86;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 122;
						}
						continue;
					case 334:
						array2[14] = (byte)num3;
						num2 = 132;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 294;
						}
						continue;
					case 219:
						num6 = 234 - 78;
						num2 = 50;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 1;
						}
						continue;
					case 344:
						array2[15] = (byte)num3;
						num2 = 150;
						continue;
					case 189:
						array2[7] = 111;
						num2 = 205;
						continue;
					case 218:
						array[19] = 122;
						num2 = 284;
						continue;
					case 300:
						array[13] = (byte)num4;
						num2 = 307;
						continue;
					case 359:
						num3 = 235 - 78;
						num2 = 344;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 106;
						}
						continue;
					case 276:
						array[5] = 141;
						num2 = 235;
						continue;
					case 163:
						array[17] = 137;
						num2 = 282;
						continue;
					case 5:
						array4[5] = array6[2];
						num2 = 116;
						continue;
					case 324:
						array[16] = (byte)num6;
						num2 = 160;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 163;
						}
						continue;
					case 357:
						array2[6] = (byte)num3;
						num2 = 86;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 274;
						}
						continue;
					case 145:
						array2[14] = (byte)num3;
						num2 = 72;
						continue;
					case 331:
						num4 = 136 + 20;
						num2 = 85;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 31;
						}
						continue;
					case 301:
						array2[2] = (byte)num5;
						num2 = 149;
						continue;
					case 7:
						array[23] = 176;
						num2 = 25;
						continue;
					case 69:
						num5 = 58 + 70;
						num2 = 275;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 88;
						}
						continue;
					case 97:
						array2[15] = 157;
						num2 = 359;
						continue;
					case 19:
						array2[8] = (byte)num5;
						num2 = 56;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 12;
						}
						continue;
					case 251:
						array2[1] = (byte)num3;
						num = 286;
						break;
					case 148:
						array[8] = 158;
						num2 = 283;
						continue;
					case 216:
						array2[5] = 122;
						num2 = 333;
						continue;
					case 143:
						num6 = 219 - 113;
						num2 = 233;
						continue;
					case 232:
						array[7] = (byte)num6;
						num2 = 162;
						continue;
					case 8:
						array[19] = (byte)num4;
						num2 = 255;
						continue;
					case 174:
						num6 = 246 - 82;
						num2 = 64;
						continue;
					case 354:
						array4[3] = array6[1];
						num2 = 5;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 1;
						}
						continue;
					case 166:
						array2[4] = 112;
						num2 = 277;
						continue;
					case 110:
						array2[1] = (byte)num3;
						num2 = 258;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 132;
						}
						continue;
					case 137:
						array[5] = (byte)num4;
						num2 = 270;
						continue;
					case 278:
						array[8] = (byte)num4;
						num2 = 134;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 148;
						}
						continue;
					case 160:
						array[10] = (byte)num4;
						num2 = 234;
						continue;
					case 355:
						num3 = 108 + 42;
						num2 = 317;
						continue;
					case 246:
						array[2] = (byte)num6;
						num2 = 55;
						continue;
					case 79:
						array[6] = (byte)num6;
						num2 = 204;
						continue;
					case 184:
						array[26] = (byte)num4;
						num2 = 129;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 292;
						}
						continue;
					case 333:
						array2[5] = 165;
						num2 = 296;
						continue;
					case 117:
						array[31] = 187;
						num2 = 91;
						continue;
					case 280:
						array[26] = (byte)num4;
						num2 = 253;
						continue;
					case 298:
						array[27] = 166;
						num2 = 39;
						continue;
					case 102:
						array[10] = 118;
						num2 = 228;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 304;
						}
						continue;
					case 20:
						array[22] = (byte)num4;
						num2 = 131;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 128;
						}
						continue;
					case 65:
						num4 = 115 + 61;
						num2 = 26;
						continue;
					case 342:
						JHEXph3N0CbDxYcwqJL(array4);
						num2 = 21;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 31;
						}
						continue;
					case 34:
						array[1] = 152;
						num2 = 38;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 224;
						}
						continue;
					case 154:
						if (array6.Length != 0)
						{
							num2 = 65;
							if (rlTSF53rdlrM3eD67Ld())
							{
								num2 = 239;
							}
							continue;
						}
						goto case 78;
					case 257:
						array2[11] = (byte)num3;
						num2 = 349;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 331;
						}
						continue;
					case 119:
						num4 = 94 + 100;
						num2 = 184;
						continue;
					case 187:
						array2[2] = 156;
						num2 = 15;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 121;
						}
						continue;
					case 70:
						num3 = 161 - 53;
						num2 = 315;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 122;
						}
						continue;
					case 293:
						array2[10] = 242;
						num = 127;
						break;
					case 78:
						num7 = 0;
						num2 = 327;
						continue;
					case 94:
						array[15] = (byte)num6;
						num2 = 49;
						continue;
					case 343:
						array2[9] = 94;
						num2 = 57;
						continue;
					case 165:
						stream = (Stream)dScbqa38h9alkoPISOR();
						num2 = 46;
						continue;
					case 339:
						array[3] = 97;
						num2 = 75;
						continue;
					case 12:
						num6 = 111 + 122;
						num2 = 175;
						continue;
					case 106:
						array2[4] = 206;
						num = 265;
						break;
					case 252:
						array[21] = (byte)num6;
						num2 = 44;
						continue;
					case 318:
						num6 = 250 - 83;
						num2 = 79;
						continue;
					case 181:
						array[16] = 140;
						num2 = 183;
						continue;
					case 140:
						array2[1] = (byte)num5;
						num2 = 187;
						continue;
					case 98:
						array4[15] = array6[7];
						num2 = 69;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 78;
						}
						continue;
					case 227:
						array2[11] = (byte)num3;
						num2 = 2;
						continue;
					case 185:
						array[5] = (byte)num6;
						num2 = 312;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 190;
						}
						continue;
					case 53:
						num4 = 97 + 14;
						num2 = 280;
						continue;
					case 328:
						array2[10] = (byte)num3;
						num2 = 340;
						continue;
					case 250:
						num3 = 112 + 30;
						num2 = 110;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 5;
						}
						continue;
					case 72:
						num3 = 190 - 63;
						num2 = 171;
						continue;
					case 310:
						array[25] = (byte)num4;
						num2 = 21;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 119;
						}
						continue;
					case 73:
						array[5] = 76;
						num2 = 82;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 9;
						}
						continue;
					case 49:
						array[15] = 86;
						num2 = 191;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 299;
						}
						continue;
					case 286:
						array2[1] = 171;
						num2 = 132;
						continue;
					case 242:
						num3 = 109 - 72;
						num2 = 357;
						continue;
					case 196:
						num6 = 101 + 25;
						num = 316;
						break;
					case 44:
						array[21] = 94;
						num2 = 211;
						continue;
					case 29:
						array[8] = (byte)num6;
						num2 = 210;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 175;
						}
						continue;
					case 287:
						array[24] = 225;
						num2 = 13;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 156;
						}
						continue;
					case 162:
						num6 = 53 + 15;
						num2 = 4;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 14;
						}
						continue;
					case 314:
						num3 = 56 + 75;
						num2 = 145;
						continue;
					case 75:
						num4 = 116 + 42;
						num2 = 244;
						continue;
					case 66:
						array[11] = (byte)num4;
						num2 = 200;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 139;
						}
						continue;
					case 38:
						array3 = array;
						num2 = 208;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 87;
						}
						continue;
					case 256:
						array2[14] = 80;
						num2 = 264;
						continue;
					case 255:
						array[19] = 144;
						num2 = 219;
						continue;
					case 282:
						num4 = 21 + 5;
						num = 231;
						break;
					case 158:
						array[12] = 107;
						num = 332;
						break;
					case 245:
						array2[13] = 194;
						num2 = 281;
						continue;
					case 55:
						array[2] = 94;
						num2 = 10;
						continue;
					case 202:
						num4 = 15 + 93;
						num2 = 178;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 136;
						}
						continue;
					case 341:
						array[7] = 84;
						num2 = 288;
						continue;
					case 111:
						num4 = 134 - 44;
						num2 = 212;
						continue;
					case 92:
						array2[13] = 168;
						num2 = 314;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 287;
						}
						continue;
					case 352:
						array2[1] = (byte)num3;
						num2 = 360;
						continue;
					case 157:
						array[18] = (byte)num6;
						num2 = 30;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 51;
						}
						continue;
					case 15:
						array[13] = (byte)num6;
						num2 = 273;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 128;
						}
						continue;
					case 109:
						num6 = 107 + 66;
						num2 = 69;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 124;
						}
						continue;
					case 37:
						return;
					case 213:
						num6 = 201 + 53;
						num2 = 319;
						continue;
					case 150:
						array2[15] = 158;
						num2 = 108;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 138;
						}
						continue;
					case 229:
						array[8] = 153;
						num = 348;
						break;
					case 231:
						array[17] = (byte)num4;
						num2 = 321;
						continue;
					case 212:
						array[23] = (byte)num4;
						num2 = 217;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 97;
						}
						continue;
					case 316:
						array[3] = (byte)num6;
						num2 = 339;
						continue;
					case 198:
						if (array6 != null)
						{
							num2 = 154;
							continue;
						}
						goto case 78;
					case 190:
						array[9] = 24;
						num2 = 28;
						continue;
					case 247:
						array[7] = 170;
						num2 = 341;
						continue;
					case 244:
						array[3] = (byte)num4;
						num2 = 331;
						continue;
					case 108:
						array2[12] = 107;
						num2 = 220;
						continue;
					case 313:
						num4 = 228 - 76;
						num2 = 136;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 77;
						}
						continue;
					case 275:
						array2[3] = (byte)num5;
						num2 = 88;
						continue;
					case 63:
						num6 = 95 + 57;
						num2 = 295;
						continue;
					case 131:
						array[22] = 33;
						num2 = 6;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 7;
						}
						continue;
					case 96:
						num3 = 11 + 34;
						num2 = 133;
						continue;
					case 13:
						array[18] = (byte)num4;
						num2 = 27;
						continue;
					case 205:
						num5 = 130 + 123;
						num2 = 127;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 261;
						}
						continue;
					case 179:
						array[23] = (byte)num4;
						num2 = 1;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 1;
						}
						continue;
					case 208:
						array2 = new byte[16];
						num2 = 256;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 355;
						}
						continue;
					case 25:
						num4 = 225 - 75;
						num2 = 358;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 203;
						}
						continue;
					case 302:
						array2[0] = (byte)num3;
						num2 = 113;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 65;
						}
						continue;
					case 35:
						num4 = 125 - 41;
						num2 = 13;
						continue;
					case 358:
						array[23] = (byte)num4;
						num2 = 111;
						continue;
					case 200:
						num6 = 110 + 68;
						num2 = 80;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 9;
						}
						continue;
					case 155:
						array[1] = (byte)num4;
						num = 152;
						break;
					case 64:
						array[9] = (byte)num6;
						num2 = 206;
						continue;
					case 61:
						num6 = 52 + 5;
						num2 = 94;
						continue;
					case 360:
						num5 = 134 - 30;
						num2 = 140;
						continue;
					case 48:
						array2[15] = 144;
						num2 = 99;
						continue;
					case 288:
						num4 = 254 - 84;
						num2 = 278;
						continue;
					case 206:
						array[9] = 202;
						num2 = 190;
						continue;
					case 103:
						num6 = 79 + 37;
						num2 = 252;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 208;
						}
						continue;
					case 234:
						num6 = 74 + 56;
						num2 = 109;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 194;
						}
						continue;
					case 134:
						num5 = 186 - 62;
						num2 = 20;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 60;
						}
						continue;
					case 170:
						array[5] = (byte)num6;
						num2 = 276;
						continue;
					default:
						array[21] = 134;
						num2 = 103;
						continue;
					case 124:
						array[1] = (byte)num6;
						num2 = 100;
						continue;
					case 340:
						num5 = 134 - 44;
						num2 = 308;
						continue;
					case 28:
						num6 = 194 - 64;
						num = 43;
						break;
					case 176:
						num4 = 76 + 82;
						num2 = 27;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 310;
						}
						continue;
					case 289:
						num6 = 65 + 51;
						num2 = 169;
						continue;
					case 74:
						array2[1] = (byte)num3;
						num = 105;
						break;
					case 224:
						num4 = 18 - 0;
						num2 = 75;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 155;
						}
						continue;
					case 283:
						array[8] = 104;
						num2 = 229;
						continue;
					case 294:
						num3 = 189 - 63;
						num2 = 124;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 129;
						}
						continue;
					case 121:
						num5 = 15 + 87;
						num2 = 77;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 301;
						}
						continue;
					case 6:
						num4 = 173 - 57;
						num = 241;
						break;
					case 304:
						num4 = 49 + 91;
						num2 = 160;
						continue;
					case 41:
						array[11] = 144;
						num2 = 361;
						continue;
					case 112:
						array2[8] = (byte)num5;
						num2 = 134;
						continue;
					case 113:
						array2[0] = 209;
						num2 = 250;
						continue;
					case 40:
						array[30] = (byte)num6;
						num2 = 148;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 237;
						}
						continue;
					case 272:
						num3 = 166 - 55;
						num2 = 227;
						continue;
					case 22:
						array[31] = 105;
						num = 143;
						break;
					case 71:
						array[4] = (byte)num4;
						num2 = 62;
						continue;
					case 237:
						num4 = 42 + 73;
						num2 = 16;
						continue;
					case 132:
						num3 = 243 - 81;
						num2 = 352;
						continue;
					case 120:
						array[25] = 142;
						num2 = 33;
						continue;
					case 141:
						array = new byte[32];
						num2 = 77;
						continue;
					case 215:
						array[14] = 153;
						num = 61;
						break;
					case 211:
						num4 = 103 + 53;
						num2 = 271;
						continue;
					case 173:
						array[28] = 108;
						num2 = 199;
						continue;
					case 136:
						array[7] = (byte)num4;
						num2 = 179;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 247;
						}
						continue;
					case 126:
						array[6] = (byte)num6;
						num2 = 30;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 15;
						}
						continue;
					case 306:
						num4 = 79 + 109;
						num2 = 115;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 21;
						}
						continue;
					case 115:
						array[29] = (byte)num4;
						num = 207;
						break;
					case 353:
						num6 = 142 + 35;
						num2 = 3;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 15;
						}
						continue;
					case 146:
						array[1] = 144;
						num2 = 107;
						continue;
					case 356:
						array[0] = (byte)num4;
						num2 = 198;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 260;
						}
						continue;
					case 317:
						array2[0] = (byte)num3;
						num2 = 240;
						continue;
					case 285:
						array2[12] = 96;
						num2 = 238;
						continue;
					case 127:
						num3 = 155 - 51;
						num2 = 148;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 257;
						}
						continue;
					case 320:
						array[21] = (byte)num6;
						num = 290;
						break;
					case 68:
						array[26] = 249;
						num = 298;
						break;
					case 290:
						array[22] = 201;
						num2 = 269;
						continue;
					case 50:
						array[20] = (byte)num6;
						num2 = 2;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 18;
						}
						continue;
					case 130:
						array[14] = 131;
						num2 = 52;
						continue;
					case 33:
						array[25] = 234;
						num2 = 202;
						continue;
					case 186:
						num3 = 113 - 83;
						num2 = 3;
						continue;
					case 116:
						array4[7] = array6[3];
						num2 = 243;
						continue;
					case 24:
						array[30] = 107;
						num2 = 226;
						continue;
					case 129:
						array2[15] = (byte)num3;
						num2 = 97;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 12;
						}
						continue;
					case 221:
						array2[3] = (byte)num5;
						num2 = 52;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 69;
						}
						continue;
					case 233:
						array[31] = (byte)num6;
						num2 = 38;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 36;
						}
						continue;
					case 321:
						num6 = 74 + 67;
						num = 305;
						break;
					case 36:
						array[0] = (byte)num4;
						num2 = 146;
						continue;
					case 281:
						array2[13] = 181;
						num2 = 92;
						continue;
					case 303:
						num6 = 110 + 20;
						num2 = 26;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 40;
						}
						continue;
					case 240:
						array2[0] = 132;
						num2 = 70;
						continue;
					case 47:
						num5 = 239 - 79;
						num2 = 338;
						continue;
					case 99:
						array4 = array2;
						num2 = 342;
						continue;
					case 191:
						array[28] = 134;
						num2 = 173;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 86;
						}
						continue;
					case 222:
						array2[3] = 63;
						num2 = 201;
						continue;
					case 268:
						FHPRsRqPUl = 80;
						num2 = 23;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 326;
						}
						continue;
					case 325:
						num5 = 77 + 28;
						num2 = 19;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 15;
						}
						continue;
					case 362:
						array[19] = 150;
						num2 = 202;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 218;
						}
						continue;
					case 172:
						num7++;
						num2 = 236;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 0;
						}
						continue;
					case 59:
						array2[12] = 162;
						num2 = 285;
						continue;
					case 139:
						num4 = 28 + 14;
						num2 = 20;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 11;
						}
						continue;
					case 100:
						array[1] = 183;
						num2 = 34;
						continue;
					case 336:
						num4 = 15 + 112;
						num2 = 300;
						continue;
					case 273:
						array[14] = 160;
						num2 = 93;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 9;
						}
						continue;
					case 42:
						array[9] = (byte)num6;
						num2 = 174;
						continue;
					case 14:
						array[7] = (byte)num6;
						num2 = 313;
						continue;
					case 93:
						num6 = 120 + 68;
						num2 = 89;
						continue;
					case 17:
						array2[5] = 167;
						num2 = 279;
						continue;
					case 86:
						array[0] = 158;
						num2 = 164;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 144;
						}
						continue;
					case 209:
						array[24] = 135;
						num2 = 4;
						continue;
					case 261:
						array2[7] = (byte)num5;
						num2 = 325;
						continue;
					case 338:
						array2[12] = (byte)num5;
						num2 = 59;
						continue;
					case 309:
						array5 = HWYRzIThpx;
						num2 = 87;
						continue;
					case 258:
						num3 = 156 - 52;
						num = 74;
						break;
					case 228:
						array[30] = 101;
						num2 = 6;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 24;
						}
						continue;
					case 32:
						num4 = 32 + 78;
						num2 = 66;
						continue;
					case 335:
						array2[11] = (byte)num3;
						num2 = 272;
						continue;
					case 226:
						array[30] = 90;
						num2 = 303;
						continue;
					case 11:
						num6 = 176 + 33;
						num2 = 90;
						continue;
					case 161:
						array4[11] = array6[5];
						num2 = 23;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 16;
						}
						continue;
					case 67:
						num4 = 152 - 101;
						num2 = 350;
						continue;
					case 194:
						array[10] = (byte)num6;
						num2 = 213;
						continue;
					case 284:
						num4 = 151 - 50;
						num2 = 8;
						continue;
					case 147:
						num6 = 65 + 106;
						num2 = 322;
						continue;
					case 329:
						array[16] = 158;
						num2 = 68;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 181;
						}
						continue;
					case 107:
						array[1] = 95;
						num2 = 109;
						continue;
					case 348:
						num6 = 77 + 28;
						num2 = 29;
						continue;
					case 249:
						array2[2] = (byte)num5;
						num2 = 195;
						continue;
					case 51:
						array[18] = 108;
						num2 = 4;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 35;
						}
						continue;
					case 315:
						array2[0] = (byte)num3;
						num2 = 168;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 163;
						}
						continue;
					case 62:
						array[4] = 124;
						num2 = 237;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 330;
						}
						continue;
					case 214:
						num6 = 15 + 90;
						num2 = 157;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 52;
						}
						continue;
					case 183:
						num6 = 126 - 103;
						num2 = 324;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 256;
						}
						continue;
					case 153:
						array2[12] = (byte)num5;
						num2 = 245;
						continue;
					case 277:
						array2[4] = 164;
						num2 = 41;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 106;
						}
						continue;
					case 149:
						array2[2] = 90;
						num2 = 52;
						if (rlTSF53rdlrM3eD67Ld())
						{
							num2 = 95;
						}
						continue;
					case 239:
						array4[1] = array6[0];
						num2 = 354;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 235;
						}
						continue;
					case 138:
						array2[15] = 92;
						num2 = 48;
						continue;
					case 178:
						array[25] = (byte)num4;
						num2 = 176;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 163;
						}
						continue;
					case 18:
						num4 = 129 - 43;
						num2 = 144;
						continue;
					case 123:
						array[2] = (byte)num4;
						num2 = 196;
						continue;
					case 101:
						array[31] = 88;
						num2 = 22;
						continue;
					case 323:
						array[29] = 1;
						num = 228;
						break;
					case 270:
						num4 = 43 + 85;
						num2 = 76;
						continue;
					case 235:
						array[5] = 58;
						num2 = 110;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 182;
						}
						continue;
					case 199:
						array[28] = 97;
						num2 = 259;
						if (!rlTSF53rdlrM3eD67Ld())
						{
							num2 = 233;
						}
						continue;
					case 269:
						array[22] = 96;
						num2 = 94;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 139;
						}
						continue;
					case 169:
						array[12] = (byte)num6;
						num2 = 120;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 158;
						}
						continue;
					case 27:
						array[18] = 203;
						num2 = 362;
						continue;
					case 80:
						array[11] = (byte)num6;
						num2 = 41;
						continue;
					case 10:
						num4 = 61 + 111;
						num2 = 123;
						continue;
					case 260:
						num4 = 186 - 98;
						num2 = 36;
						continue;
					case 308:
						array2[10] = (byte)num5;
						num2 = 193;
						if (x927kn3atyOZxef7ohl() != null)
						{
							num2 = 94;
						}
						continue;
					case 3:
						array2[8] = (byte)num3;
						num2 = 343;
						continue;
					case 345:
						num3 = 132 - 44;
						num = 346;
						break;
					case 351:
						array[13] = (byte)num4;
						num2 = 353;
						continue;
					case 45:
						array2[7] = (byte)num3;
						num2 = 189;
						continue;
					case 52:
						num4 = 190 - 63;
						num2 = 254;
						continue;
					case 197:
						array[15] = 131;
						num2 = 147;
						continue;
					case 296:
						array2[6] = 68;
						num2 = 262;
						continue;
					case 91:
						array[31] = 35;
						num2 = 80;
						if (x927kn3atyOZxef7ohl() == null)
						{
							num2 = 337;
						}
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string KBSR0Dt1Sr(int P_0)
		{
			if (HWYRzIThpx.Length == 0)
			{
				EX4RkIhWag = new List<string>();
				NkmRn2UcZo = new List<int>();
				m6cRAtLOOi(T3sReKY5xV.GetManifestResourceStream("T4dTfkFkr4fhK6jo8H.yeV6ZtRbcyLZJuAo1B"), P_0);
			}
			if (FHPRsRqPUl < 75)
			{
				if ((object)T3sReKY5xV != new StackFrame(1).GetMethod().DeclaringType.Assembly)
				{
					throw new Exception();
				}
				FHPRsRqPUl++;
			}
			lock (cHmRdPn0YC)
			{
				int num = BitConverter.ToInt32(HWYRzIThpx, P_0);
				if (num < NkmRn2UcZo.Count && NkmRn2UcZo[num] == P_0)
				{
					return EX4RkIhWag[num];
				}
				try
				{
					dJLOPAmoTijWxbGSvCs.urY36js4go();
					byte[] array = new byte[num];
					Array.Copy(HWYRzIThpx, P_0 + 4, array, 0, num);
					string text = Encoding.Unicode.GetString(array, 0, array.Length);
					EX4RkIhWag.Add(text);
					NkmRn2UcZo.Add(P_0);
					Array.Copy(BitConverter.GetBytes(EX4RkIhWag.Count - 1), 0, HWYRzIThpx, P_0, 4);
					return text;
				}
				catch
				{
				}
			}
			return "";
		}

		internal static string dQxR5unqNW(string P_0)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(P_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		private static int a1GRUeuVqb()
		{
			return 5;
		}

		private static void j6LRvVDF3B()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private static Delegate SsIRNh6O1R(IntPtr P_0, Type P_1)
		{
			return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
			{
				typeof(IntPtr),
				typeof(Type)
			}).Invoke(null, new object[2] { P_0, P_1 });
		}

		internal static object L4IRM4gZyJ(object P_0)
		{
			try
			{
				if (File.Exists(((Assembly)P_0).Location))
				{
					return ((Assembly)P_0).Location;
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "")))
				{
					return ((Assembly)P_0).GetName().CodeBase.ToString().Replace("file:///", "");
				}
			}
			catch
			{
			}
			try
			{
				if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString()))
				{
					return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
						.ToString();
				}
			}
			catch
			{
			}
			return "";
		}

		[DllImport("kernel32", EntryPoint = "LoadLibrary")]
		public static extern IntPtr avcRtvIq3S(string P_0);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
		public static extern IntPtr z9LRZ3nZ02(IntPtr P_0, string P_1);

		private static IntPtr wlpRpxjO7h(IntPtr P_0, string P_1, uint P_2)
		{
			if (rFbmafGRZR == null)
			{
				rFbmafGRZR = (dJ5ua6mqjCdOQgoR8PY)Marshal.GetDelegateForFunctionPointer(z9LRZ3nZ02(xMpiFL8WN(), "Find ".Trim() + "ResourceA"), typeof(dJ5ua6mqjCdOQgoR8PY));
			}
			return rFbmafGRZR(P_0, P_1, P_2);
		}

		private static IntPtr WJJRBx8v6e(IntPtr P_0, uint P_1, uint P_2, uint P_3)
		{
			if (l82mAq7fEF == null)
			{
				l82mAq7fEF = (VXVOWim4IBkY2ASjDXm)Marshal.GetDelegateForFunctionPointer(z9LRZ3nZ02(xMpiFL8WN(), "Virtual ".Trim() + "Alloc"), typeof(VXVOWim4IBkY2ASjDXm));
			}
			return l82mAq7fEF(P_0, P_1, P_2, P_3);
		}

		private static int p8KR8TBQEM(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
		{
			if (bDim0kXgFr == null)
			{
				bDim0kXgFr = (Wcwft2mQ2wXAJFTqer0)Marshal.GetDelegateForFunctionPointer(z9LRZ3nZ02(xMpiFL8WN(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Wcwft2mQ2wXAJFTqer0));
			}
			return bDim0kXgFr(P_0, P_1, P_2, P_3, out P_4);
		}

		private static int h29RJCVrS3(IntPtr P_0, int P_1, int P_2, ref int P_3)
		{
			if (vQsm5DMXjx == null)
			{
				vQsm5DMXjx = (Jy1haamTfVwKZXwsZVN)Marshal.GetDelegateForFunctionPointer(z9LRZ3nZ02(xMpiFL8WN(), "Virtual ".Trim() + "Protect"), typeof(Jy1haamTfVwKZXwsZVN));
			}
			return vQsm5DMXjx(P_0, P_1, P_2, ref P_3);
		}

		private static IntPtr yqvRhvPq9i(uint P_0, int P_1, uint P_2)
		{
			if (lFNmUUF0Br == null)
			{
				lFNmUUF0Br = (gXtLyymKAhEU9XoJaw8)Marshal.GetDelegateForFunctionPointer(z9LRZ3nZ02(xMpiFL8WN(), "Open ".Trim() + "Process"), typeof(gXtLyymKAhEU9XoJaw8));
			}
			return lFNmUUF0Br(P_0, P_1, P_2);
		}

		private static int vVuRHwXlCT(IntPtr P_0)
		{
			if (ohVmvrpoIS == null)
			{
				ohVmvrpoIS = (yloXGhmPfpVqhwcpaxi)Marshal.GetDelegateForFunctionPointer(z9LRZ3nZ02(xMpiFL8WN(), "Close ".Trim() + "Handle"), typeof(yloXGhmPfpVqhwcpaxi));
			}
			return ohVmvrpoIS(P_0);
		}

		[SpecialName]
		private static IntPtr xMpiFL8WN()
		{
			if (MsymNybKi8 == IntPtr.Zero)
			{
				MsymNybKi8 = avcRtvIq3S("kernel ".Trim() + "32.dll");
			}
			return MsymNybKi8;
		}

		private static byte[] vKcRygipV5(string P_0)
		{
			using FileStream fileStream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.Read);
			int num = 0;
			int num2 = (int)fileStream.Length;
			byte[] array = new byte[num2];
			while (num2 > 0)
			{
				int num3 = fileStream.Read(array, num, num2);
				num += num3;
				num2 -= num3;
			}
			return array;
		}

		internal static Stream kryRjkVciL()
		{
			return new MemoryStream();
		}

		internal static byte[] vNBRigOevE(Stream P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		private static byte[] OGfRS2aKbr(byte[] P_0)
		{
			Stream stream = kryRjkVciL();
			SymmetricAlgorithm symmetricAlgorithm = jPmRuMetci();
			symmetricAlgorithm.Key = new byte[32]
			{
				221, 9, 153, 92, 79, 65, 36, 34, 14, 34,
				106, 104, 165, 175, 8, 139, 217, 240, 102, 127,
				141, 99, 203, 164, 90, 172, 170, 52, 77, 117,
				101, 190
			};
			symmetricAlgorithm.IV = new byte[16]
			{
				40, 14, 150, 152, 81, 124, 207, 224, 111, 0,
				92, 20, 34, 244, 4, 222
			};
			CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(P_0, 0, P_0.Length);
			cryptoStream.Close();
			byte[] result = vNBRigOevE(stream);
			dJLOPAmoTijWxbGSvCs.urY36js4go();
			return result;
		}

		private byte[] Y3pR6jSsUA()
		{
			return null;
		}

		private byte[] r6aRgQww5D()
		{
			return null;
		}

		private byte[] DxnR1g4HlX()
		{
			_ = "{11111-22222-20001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] N63Rcmeqw5()
		{
			_ = "{11111-22222-20001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] fjFRqC9W6y()
		{
			_ = "{11111-22222-30001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] Oj3R4gYFlv()
		{
			_ = "{11111-22222-30001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] lQURQlhM9C()
		{
			_ = "{11111-22222-40001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] qrmRT1MUcT()
		{
			_ = "{11111-22222-40001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] nDoRK2seI3()
		{
			_ = "{11111-22222-50001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] DTlRPyDKi2()
		{
			_ = "{11111-22222-50001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal static object R2dBHi3APONIYtKNS2S(object P_0)
		{
			return ((XkT7HOmiCfFhGJX07Vs)P_0).f9UtU12u5A();
		}

		internal static void jrdd2d30HyBWxWZov9F(object P_0, long P_1)
		{
			((Stream)P_0).Position = P_1;
		}

		internal static long iI43LM35XbT8CscQVKy(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		internal static object Xr7dsJ3UbY6DIkfFycn(object P_0, int P_1)
		{
			return ((XkT7HOmiCfFhGJX07Vs)P_0).Ea2mSfIMLA(P_1);
		}

		internal static void sSTBw93vRuFf8VFXVru(object P_0)
		{
			((XkT7HOmiCfFhGJX07Vs)P_0).jAAm1pSC36();
		}

		internal static void JHEXph3N0CbDxYcwqJL(object P_0)
		{
			Array.Reverse((Array)P_0);
		}

		internal static object yM0euA3Mi5nyxOWruS0(object P_0)
		{
			return ((Assembly)P_0).GetName();
		}

		internal static object jAruca3tRdxWQkLt3Rf(object P_0)
		{
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		internal static object B6hAa83ZO0JrZ2HjnZd()
		{
			return jPmRuMetci();
		}

		internal static void sYgkYo3pKp1AF8Q1Pdr(object P_0, CipherMode P_1)
		{
			((SymmetricAlgorithm)P_0).Mode = P_1;
		}

		internal static object nwcUVy3Bgj6b0gcd7mC(object P_0, object P_1, object P_2)
		{
			return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
		}

		internal static object dScbqa38h9alkoPISOR()
		{
			return kryRjkVciL();
		}

		internal static void SGfNOQ3JECUxxvu988O(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void sQq75f3haY10HZvrwuJ(object P_0)
		{
			((CryptoStream)P_0).FlushFinalBlock();
		}

		internal static object qhBU0L3HH36HZaLhrgy(object P_0)
		{
			return vNBRigOevE((Stream)P_0);
		}

		internal static void yoGPiP3yC7N7uq4lMnR(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object e7t47e3juoaAX5SYqf7(object P_0)
		{
			return ((Assembly)P_0).EntryPoint;
		}

		internal static bool rlTSF53rdlrM3eD67Ld()
		{
			return null == null;
		}

		internal static object x927kn3atyOZxef7ohl()
		{
			return null;
		}
	}
}
namespace PKf6wKmO0NHVrXhHEoV
{
	internal class dJLOPAmoTijWxbGSvCs
	{
		private static bool n1XmV9FxME;

		internal static void urY36js4go()
		{
			if (!n1XmV9FxME)
			{
				n1XmV9FxME = true;
				if (Math.Sign((DateTime.Now - new DateTime(2024, 8, 4)).Days) >= 14)
				{
					throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
				}
			}
		}
	}
}
internal sealed class <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}
{
	internal int m_95961dbbf48d4589a7c57776ca31ed70;

	internal int m_0ee6c1b45c2748db99d758fa843e9a27;

	internal int m_8b119ebbe94c45418e762bb601700d14;

	internal int m_a7cd1a7996324418a47bcade062d4495;

	internal int m_5ef84580349147d5a0ea529f8ded7fdd;

	internal int m_9916d941967e40f69bd0e5ad8a8eccc5;

	internal int m_cbb103b0cdc346999852f26d84530679;

	internal int m_cfc7ed5521c740d59ba45fd9d736ebbd;

	internal int m_29972cea107544b9884ff2e2f971e577;

	internal int m_3e426832f7f94edca1142495a2d8b604;

	internal int m_1f0d8575e2a64f99badd1faea28adcf3;

	internal int m_9d97895787f544ba8df5550fbb50be72;

	internal int m_2b39c536428a43b4a474fc24f7dfae32;

	internal int m_a84bd9a213f94a79aa2c43135560ced6;

	internal int m_df0882656164444fbd203474670ae7a7;

	internal int m_7e7a1cd262b94d128bd8e406d09652e9;

	internal int m_4df86ad362a54b16aff9302ae0cfd00b;

	internal int m_ed760f102fde4334bee5fba83e1d5bb4;

	internal int m_2c330d85012a49c889642a2403697ff2;

	internal int m_a0093999659c452d98aefedd721863b7;

	internal int m_674d8f5e5d6b42878794196403d0e5fb;

	internal int m_f51435a335544c4d8ac2b6980c0ae958;

	internal int m_a9b8ace30e244d0a8a8e3c660a3ab1a4;

	internal int m_c11e4a270ada4402a68deea7a1f576b6;

	internal int m_7cd112dfa7f34b1c9a26b8bbcb48b9b2;

	internal int m_f6f347622e79441abf64f41b3149eb25;

	internal int m_253667f3eef242e1bd36755acf8689df;

	internal int m_143399f83cb74823b67eee7036dca200;

	internal int m_f3e6c1a188784a58954d43fedc10d0c1;

	internal int m_80c3b4f93b994fbb9d6435941a489781;

	internal int m_0a3d43819810482b95e9024df6e32a73;

	internal int m_846e5003b3d0401a84de33ef787c97da;

	internal int m_0d8ae8cf4c5a4e8b9c5642736e4409b6;

	internal int m_58019b50b63a476ea06057a2db54f06a;

	internal int m_e1eca528a8a647d5adec3fe0954e7bfa;

	internal int m_e30397021c2e4ed6b2bf5b4d827de689;

	internal int m_6b45aad2ca5049239702a633bdad69fa;

	internal int m_24170717605948d59e5961f9a67f9221;

	internal int m_571f5ae64d1545db86d72e5b8f2d3bf5;

	internal int m_a41b83e1a14d4fabb4d025f7937fc1aa;

	internal int m_7db6aac0615147b0b38b8655a98a7e21;

	internal int m_b787f4c8b01a4a0c84039732255f6897;

	internal int m_8f754fb7a9d24c0f8696c26cb886b05a;

	internal int m_6852c6d8dbee45faa42dd37427c15cd9;

	internal int m_9dfc7d7488034a68920972daecc9d2a2;

	internal int m_637e3ed536e444c78b13f277a03822de;

	internal int m_b8d902a5a5b248d7a41b2e6ff424fd8a;

	internal int m_b88edb3d4a5443f59f2c94bbb42b1c5d;

	internal int m_a9d0fc25874046c285a3dd2fbce54cc1;

	internal int m_6874963f64554f6c9453fb77ae802833;

	internal int m_eb0ea10e32dd4532bfb6477f8c657ccc;

	internal int m_9e5ee57318754f5f96c331f5450290ad;

	internal int m_820a42d03d5f4ad68e9a9168cf388a75;

	internal int m_f715fcffe3004c7aa46c8a09578d97a6;

	internal int m_78e4a4374e47432c84a69ca3a0497e98;

	internal int m_aa9a4efb852a4d8a958c971ded1a0106;

	internal int m_130b462d48954a46bfecd02c83057cfb;

	internal int m_dacb6ed28c3f486089c6ab1def10bd3c;

	internal int m_e1684c59b1934313ad61f4823737c76c;

	internal int m_053015b3ee3b44d88bcdf8d56ac27530;

	internal int m_b56594b03db845a49b7820e60205c468;

	internal int m_119a668492e64ba6bfc56f9f85e6e732;

	internal int m_232f69a05029492b8df250a729b6b51f;

	internal int m_dfa7f1ced813437f8a4356e5abd3ab16;

	internal int m_87aabf3718f14b4bab6c3c37bf77a3f8;

	internal int m_0faf56919dad47aca09d838ea3d3b68b;

	internal int m_8e01ba447e8a41a1b230b4a72e1ca380;

	internal int m_ca09aac4405e4e6db681625503f98a27;

	internal int m_947697468a8944d1b842d4947773325e;

	internal int m_98a6ba18323a467e9485f79ea882d762;

	internal int m_0d5e44dda34940c58decd68f393004d3;

	internal int m_5e10999593964b0f97bc7f7dac34c52b;

	internal int m_60fcf68a246f430da22c2f187c8b4cc1;

	internal int m_0e8862824fa94a6db335a0bc7284c6da;

	internal int m_48cbaa2cf2b74c91b6c2ce6fecabe1fa;

	internal int m_5d981937aa044de6aefa8c62b60f0102;

	internal int m_62460421384f4a65a8c8500119b2c6af;

	internal int m_398bb4a5c3744252a695511bd8c91cd3;

	internal int m_8dc98ddf9b72445fa03fb63f9039deb2;

	internal int m_f2e5d90dfe53426fb05abb7910ceb65b;

	internal int m_987eb1cf8f504dca89ebd7085435a919;

	internal int m_ce67bba4fb674b9bb2d69ed6298464ed;

	internal int m_6f40e9ecd7ea40db822b41a3b46348a7;

	internal int m_7caab99f71784e09b81bbeacdd7796f2;

	internal int m_9d7547e2412c46d2a6a3a960a66b3c17;

	internal int m_e4c8f7c29b044398aad8337ab6c45325;

	internal int m_88696a0b161345cdb8cd7f841a73f4bd;

	internal int m_366a139e88f04e1cbfaba72ec3a71921;

	internal int m_abcb4675695b4c76a10f38499e59ab5c;

	internal int m_a46edfd26cf545b9b3e4e5a8913e5fcd;

	internal int m_975999bc255f4ef1aadc4d6f99f865b6;

	internal int m_25645d2a33f442419902e919f1fef0f4;

	internal int m_8da749a9eea94d3182f20b29368f8de3;

	internal int m_14c4f153c5484c93b63019acfbe6ca69;

	internal int m_e57a6f959dbb419aa5736362a7f245ca;

	internal int m_16ce9e0736c440859615439afa01a69c;

	internal int m_fa4ff8f83a2947fc90490da206c0d0a2;

	internal int m_c8c366b251c54560831a0933d492065a;

	internal int m_1adc419baba34d5d84746a461578b2d4;

	internal int m_b71a382f9b0c4eafb9285eec91e6a59a;

	internal int m_4ede3f0bfff14b3ba098ee896b06d9fe;

	internal int m_520098cedb1a45709e913928c81430e2;

	internal int m_7a69d491a4bf481fa201fbbe72541f2a;

	internal int m_d1384292f3a0406887edeaa5881730cd;

	internal int m_fd20d2f7342f473bb1e716c0ea60d768;

	internal int m_f3f29cb439374100befc53d726498946;

	internal int m_0afd2f6fa280490aae007ec2a18f36b4;

	internal int m_5ed3d29f08464e8fa349b6629a79e951;

	internal int m_2d7962d964354e839158a833da683fc6;

	internal int m_5e29b67f79d04bfeb3d8afc567c2439f;

	internal int m_8058ed4e3b5642a889dd6c4665301b14;

	internal int m_832ff6bf92bc42f1b576f3be94752c4e;

	internal int m_bbf5652ac68145268339aabf58f2e7a4;

	internal static <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61} m_188e107399a14b6fbb545059884f62e9;

	internal int m_fe7c55c325134899987e62b1b53584c7;

	internal int m_06cf7a74520c46c3b114d8dbcadacbb8;

	internal int m_225986189590429da7088d28f2684e35;

	static <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}()
	{
		ue871b05a6e764bdcbc1b34f0513bf437();
	}

	internal static void ue871b05a6e764bdcbc1b34f0513bf437()
	{
		m_188e107399a14b6fbb545059884f62e9 = new <Module>{789744db-0abe-49c8-9eec-1dfa43a3ec61}();
		m_188e107399a14b6fbb545059884f62e9.m_398bb4a5c3744252a695511bd8c91cd3 = 0x75B787B8 ^ 0x75B787B8;
		m_188e107399a14b6fbb545059884f62e9.m_a7cd1a7996324418a47bcade062d4495 = 0x23A1612D ^ 0x23A1612D;
		m_188e107399a14b6fbb545059884f62e9.m_820a42d03d5f4ad68e9a9168cf388a75 = -9686480 ^ -1344368464;
		m_188e107399a14b6fbb545059884f62e9.m_9dfc7d7488034a68920972daecc9d2a2 = 0x2CDB32A4 ^ 0x6194CBFE;
		m_188e107399a14b6fbb545059884f62e9.m_8f754fb7a9d24c0f8696c26cb886b05a = 0x5F843D54 ^ 0x5F843D54;
		m_188e107399a14b6fbb545059884f62e9.m_87aabf3718f14b4bab6c3c37bf77a3f8 = -950358175 ^ -1977584877;
		m_188e107399a14b6fbb545059884f62e9.m_5e10999593964b0f97bc7f7dac34c52b = -1581409127 ^ -1581409127;
		m_188e107399a14b6fbb545059884f62e9.m_bbf5652ac68145268339aabf58f2e7a4 = 0x3AA3305A ^ 0x30932626;
		m_188e107399a14b6fbb545059884f62e9.m_119a668492e64ba6bfc56f9f85e6e732 = -1294981512 ^ -2027408424;
		m_188e107399a14b6fbb545059884f62e9.m_e30397021c2e4ed6b2bf5b4d827de689 = 0x3AA3305A ^ 0x234DA76D;
		m_188e107399a14b6fbb545059884f62e9.m_232f69a05029492b8df250a729b6b51f = 0xDF73973 ^ 0x3796AB2;
		m_188e107399a14b6fbb545059884f62e9.m_b56594b03db845a49b7820e60205c468 = 0xF39135 ^ 0x4F0392DE;
		m_188e107399a14b6fbb545059884f62e9.m_7db6aac0615147b0b38b8655a98a7e21 = 0x3764657D ^ 0x682667C1;
		m_188e107399a14b6fbb545059884f62e9.m_5ed3d29f08464e8fa349b6629a79e951 = -929037838 ^ -289400139;
		m_188e107399a14b6fbb545059884f62e9.m_225986189590429da7088d28f2684e35 = -340511085 ^ -340511085;
		m_188e107399a14b6fbb545059884f62e9.m_25645d2a33f442419902e919f1fef0f4 = -283076931 ^ -283076931;
		m_188e107399a14b6fbb545059884f62e9.m_571f5ae64d1545db86d72e5b8f2d3bf5 = -891836976 ^ -829870330;
		m_188e107399a14b6fbb545059884f62e9.m_d1384292f3a0406887edeaa5881730cd = 0x270E40A5 ^ 0x596E8AA5;
		m_188e107399a14b6fbb545059884f62e9.m_60fcf68a246f430da22c2f187c8b4cc1 = -(288504065 - 1354734158) ^ 0x2488268F;
		m_188e107399a14b6fbb545059884f62e9.m_62460421384f4a65a8c8500119b2c6af = -1294981512 ^ -411893783;
		m_188e107399a14b6fbb545059884f62e9.m_0afd2f6fa280490aae007ec2a18f36b4 = -86520077 ^ -86520077;
		m_188e107399a14b6fbb545059884f62e9.m_9e5ee57318754f5f96c331f5450290ad = -2018237347 ^ -2018237347;
		m_188e107399a14b6fbb545059884f62e9.m_df0882656164444fbd203474670ae7a7 = -(-173689621 ^ -945007185) ^ -1873719263;
		m_188e107399a14b6fbb545059884f62e9.m_f2e5d90dfe53426fb05abb7910ceb65b = -86520077 ^ -86520077;
		m_188e107399a14b6fbb545059884f62e9.m_520098cedb1a45709e913928c81430e2 = -829320560 ^ -316778134;
		m_188e107399a14b6fbb545059884f62e9.m_6852c6d8dbee45faa42dd37427c15cd9 = 0x41E2265F ^ 0x56246C9C;
		m_188e107399a14b6fbb545059884f62e9.m_fe7c55c325134899987e62b1b53584c7 = -950358175 ^ -950358175;
		m_188e107399a14b6fbb545059884f62e9.m_1f0d8575e2a64f99badd1faea28adcf3 = -(-735973547) ^ 0x56A1E8F6;
		m_188e107399a14b6fbb545059884f62e9.m_e57a6f959dbb419aa5736362a7f245ca = -1952336536 ^ -1952336536;
		m_188e107399a14b6fbb545059884f62e9.m_130b462d48954a46bfecd02c83057cfb = -31394773 ^ -1083265127;
		m_188e107399a14b6fbb545059884f62e9.m_8058ed4e3b5642a889dd6c4665301b14 = -(-735973547) ^ 0x659A30B4;
		m_188e107399a14b6fbb545059884f62e9.m_832ff6bf92bc42f1b576f3be94752c4e = 0x2B4B43E ^ 0x178BD50A;
		m_188e107399a14b6fbb545059884f62e9.m_2b39c536428a43b4a474fc24f7dfae32 = 0x23A1612D ^ 0x5432423D;
		m_188e107399a14b6fbb545059884f62e9.m_053015b3ee3b44d88bcdf8d56ac27530 = -696415370 ^ -1936418233;
		m_188e107399a14b6fbb545059884f62e9.m_674d8f5e5d6b42878794196403d0e5fb = 0x3084EEA7 ^ 0x3084EEA7;
		m_188e107399a14b6fbb545059884f62e9.m_c8c366b251c54560831a0933d492065a = -1747024010 ^ -1349744346;
		m_188e107399a14b6fbb545059884f62e9.m_a9d0fc25874046c285a3dd2fbce54cc1 = -1851235226 ^ -1851235226;
		m_188e107399a14b6fbb545059884f62e9.m_7a69d491a4bf481fa201fbbe72541f2a = -1581409127 ^ -14892730;
		m_188e107399a14b6fbb545059884f62e9.m_e1684c59b1934313ad61f4823737c76c = 0x4902125 ^ 0x77E5DB50;
		m_188e107399a14b6fbb545059884f62e9.m_5ef84580349147d5a0ea529f8ded7fdd = -538418944 ^ -2006273713;
		m_188e107399a14b6fbb545059884f62e9.m_253667f3eef242e1bd36755acf8689df = ~(-1069878398) ^ 0x33DE6280;
		m_188e107399a14b6fbb545059884f62e9.m_a46edfd26cf545b9b3e4e5a8913e5fcd = 0x270E40A5 ^ 0x270E40A5;
		m_188e107399a14b6fbb545059884f62e9.m_9d7547e2412c46d2a6a3a960a66b3c17 = -2018237347 ^ -2018237347;
		m_188e107399a14b6fbb545059884f62e9.m_a84bd9a213f94a79aa2c43135560ced6 = -1952336536 ^ -1907084752;
		m_188e107399a14b6fbb545059884f62e9.m_8da749a9eea94d3182f20b29368f8de3 = -233588960 ^ -290250094;
		m_188e107399a14b6fbb545059884f62e9.m_aa9a4efb852a4d8a958c971ded1a0106 = 0xC44F292 ^ 0xC44F292;
		m_188e107399a14b6fbb545059884f62e9.m_4df86ad362a54b16aff9302ae0cfd00b = -340511085 ^ -2031655541;
		m_188e107399a14b6fbb545059884f62e9.m_7e7a1cd262b94d128bd8e406d09652e9 = -2145489008 ^ -611483788;
		m_188e107399a14b6fbb545059884f62e9.m_fd20d2f7342f473bb1e716c0ea60d768 = 0x75B787B8 ^ 0x75B787B8;
		m_188e107399a14b6fbb545059884f62e9.m_dfa7f1ced813437f8a4356e5abd3ab16 = -(-1870349665 << 4) ^ -1210255934;
		m_188e107399a14b6fbb545059884f62e9.m_0e8862824fa94a6db335a0bc7284c6da = -1581409127 ^ -1581409127;
		m_188e107399a14b6fbb545059884f62e9.m_2d7962d964354e839158a833da683fc6 = -2018237347 ^ -2018237347;
		m_188e107399a14b6fbb545059884f62e9.m_6874963f64554f6c9453fb77ae802833 = -903410432 ^ -426475413;
		m_188e107399a14b6fbb545059884f62e9.m_ce67bba4fb674b9bb2d69ed6298464ed = 0xC44F292 ^ 0xC44F292;
		m_188e107399a14b6fbb545059884f62e9.m_0faf56919dad47aca09d838ea3d3b68b = -1952336536 ^ -1952336536;
		m_188e107399a14b6fbb545059884f62e9.m_06cf7a74520c46c3b114d8dbcadacbb8 = 0xF39135 ^ 0xF39135;
		m_188e107399a14b6fbb545059884f62e9.m_1adc419baba34d5d84746a461578b2d4 = -891836976 ^ -76918181;
		m_188e107399a14b6fbb545059884f62e9.m_8dc98ddf9b72445fa03fb63f9039deb2 = 0x59E394B ^ 0x59E394B;
		m_188e107399a14b6fbb545059884f62e9.m_7cd112dfa7f34b1c9a26b8bbcb48b9b2 = -(-884254470) ^ 0x34B4A706;
		m_188e107399a14b6fbb545059884f62e9.m_b88edb3d4a5443f59f2c94bbb42b1c5d = -2145489008 ^ -1463830319;
		m_188e107399a14b6fbb545059884f62e9.m_a9b8ace30e244d0a8a8e3c660a3ab1a4 = -136366395 ^ -482297604;
		m_188e107399a14b6fbb545059884f62e9.m_846e5003b3d0401a84de33ef787c97da = -1482286804 ^ -1482286804;
		m_188e107399a14b6fbb545059884f62e9.m_6b45aad2ca5049239702a633bdad69fa = 0x524FCF85 ^ 0x5CF1A8B9;
		m_188e107399a14b6fbb545059884f62e9.m_14c4f153c5484c93b63019acfbe6ca69 = -unchecked(-1947804249 + -972628121) ^ -1374534926;
		m_188e107399a14b6fbb545059884f62e9.m_3e426832f7f94edca1142495a2d8b604 = -355009895 ^ -317377713;
		m_188e107399a14b6fbb545059884f62e9.m_e1eca528a8a647d5adec3fe0954e7bfa = -1565556138 ^ -1565556138;
		m_188e107399a14b6fbb545059884f62e9.m_b8d902a5a5b248d7a41b2e6ff424fd8a = -1496421357 ^ -1533306271;
		m_188e107399a14b6fbb545059884f62e9.m_e4c8f7c29b044398aad8337ab6c45325 = 0x270E40A5 ^ 0x270E40A5;
		m_188e107399a14b6fbb545059884f62e9.m_366a139e88f04e1cbfaba72ec3a71921 = 0x6ACCFF96 ^ 0x3D6D5E64;
		m_188e107399a14b6fbb545059884f62e9.m_f51435a335544c4d8ac2b6980c0ae958 = ~(-(-1038140827)) ^ -850286343;
		m_188e107399a14b6fbb545059884f62e9.m_975999bc255f4ef1aadc4d6f99f865b6 = 0x3AA3305A ^ 0x3AA3305A;
		m_188e107399a14b6fbb545059884f62e9.m_78e4a4374e47432c84a69ca3a0497e98 = -1496421357 ^ -1496421357;
		m_188e107399a14b6fbb545059884f62e9.m_abcb4675695b4c76a10f38499e59ab5c = -(552185944 >> 5) ^ -668156855;
		m_188e107399a14b6fbb545059884f62e9.m_8e01ba447e8a41a1b230b4a72e1ca380 = 0x2ABD101 ^ 0x2ABD101;
		m_188e107399a14b6fbb545059884f62e9.m_dacb6ed28c3f486089c6ab1def10bd3c = 0x12DFF7B0 ^ 0x37F062D8;
		m_188e107399a14b6fbb545059884f62e9.m_80c3b4f93b994fbb9d6435941a489781 = -2018237347 ^ -2018237347;
		m_188e107399a14b6fbb545059884f62e9.m_a0093999659c452d98aefedd721863b7 = -136366395 ^ -136366395;
		m_188e107399a14b6fbb545059884f62e9.m_0d8ae8cf4c5a4e8b9c5642736e4409b6 = -86520077 ^ -86520077;
		m_188e107399a14b6fbb545059884f62e9.m_0a3d43819810482b95e9024df6e32a73 = -1851235226 ^ -626662307;
		m_188e107399a14b6fbb545059884f62e9.m_b787f4c8b01a4a0c84039732255f6897 = -929037838 ^ -929037838;
		m_188e107399a14b6fbb545059884f62e9.m_f6f347622e79441abf64f41b3149eb25 = -2107799170 ^ -2107799170;
		m_188e107399a14b6fbb545059884f62e9.m_b71a382f9b0c4eafb9285eec91e6a59a = -1565556138 ^ -1565556138;
		m_188e107399a14b6fbb545059884f62e9.m_98a6ba18323a467e9485f79ea882d762 = -987387936 ^ -540661302;
		m_188e107399a14b6fbb545059884f62e9.m_6f40e9ecd7ea40db822b41a3b46348a7 = -1826491606 ^ -1826491606;
		m_188e107399a14b6fbb545059884f62e9.m_cfc7ed5521c740d59ba45fd9d736ebbd = 0xDF73973 ^ 0xDF73973;
		m_188e107399a14b6fbb545059884f62e9.m_987eb1cf8f504dca89ebd7085435a919 = 0xE6D4E0B ^ 0xE6D4E0B;
		m_188e107399a14b6fbb545059884f62e9.m_f3e6c1a188784a58954d43fedc10d0c1 = 0x1FED58C0 ^ 0x1FED58C0;
		m_188e107399a14b6fbb545059884f62e9.m_4ede3f0bfff14b3ba098ee896b06d9fe = 0x5F843D54 ^ 0x5F843D54;
		m_188e107399a14b6fbb545059884f62e9.m_947697468a8944d1b842d4947773325e = -950358175 ^ -950358175;
		m_188e107399a14b6fbb545059884f62e9.m_29972cea107544b9884ff2e2f971e577 = 0xDF73973 ^ 0xDF73973;
		m_188e107399a14b6fbb545059884f62e9.m_9d97895787f544ba8df5550fbb50be72 = -119414673 ^ -119414673;
		m_188e107399a14b6fbb545059884f62e9.m_ed760f102fde4334bee5fba83e1d5bb4 = -1496421357 ^ -1496421357;
		m_188e107399a14b6fbb545059884f62e9.m_f3f29cb439374100befc53d726498946 = 0x6ACCFF96 ^ 0x6ACCFF96;
		m_188e107399a14b6fbb545059884f62e9.m_0d5e44dda34940c58decd68f393004d3 = -340511085 ^ -1567178129;
		m_188e107399a14b6fbb545059884f62e9.m_16ce9e0736c440859615439afa01a69c = -538418944 ^ -677825247;
		m_188e107399a14b6fbb545059884f62e9.m_ca09aac4405e4e6db681625503f98a27 = 0xF39135 ^ 0xF39135;
		m_188e107399a14b6fbb545059884f62e9.m_9916d941967e40f69bd0e5ad8a8eccc5 = -(552185944 >> 5) ^ -1674670178;
		m_188e107399a14b6fbb545059884f62e9.m_7caab99f71784e09b81bbeacdd7796f2 = 0x3084EEA7 ^ 0x7927F880;
		m_188e107399a14b6fbb545059884f62e9.m_cbb103b0cdc346999852f26d84530679 = -(-405925340 - 235409559) ^ 0x2639FE73;
		m_188e107399a14b6fbb545059884f62e9.m_95961dbbf48d4589a7c57776ca31ed70 = 0x5855D2C2 ^ 0x509EC1DA;
		m_188e107399a14b6fbb545059884f62e9.m_eb0ea10e32dd4532bfb6477f8c657ccc = -340511085 ^ -340511085;
		m_188e107399a14b6fbb545059884f62e9.m_5e29b67f79d04bfeb3d8afc567c2439f = 0x2ABD101 ^ 0x2ABD101;
		m_188e107399a14b6fbb545059884f62e9.m_f715fcffe3004c7aa46c8a09578d97a6 = -1826491606 ^ -1279665369;
		m_188e107399a14b6fbb545059884f62e9.m_0ee6c1b45c2748db99d758fa843e9a27 = -1565556138 ^ -1565556138;
		m_188e107399a14b6fbb545059884f62e9.m_8b119ebbe94c45418e762bb601700d14 = -1917014 ^ -1917014;
		m_188e107399a14b6fbb545059884f62e9.m_fa4ff8f83a2947fc90490da206c0d0a2 = -538418944 ^ -538418944;
		m_188e107399a14b6fbb545059884f62e9.m_c11e4a270ada4402a68deea7a1f576b6 = -119414673 ^ -119414673;
		m_188e107399a14b6fbb545059884f62e9.m_58019b50b63a476ea06057a2db54f06a = -1952336536 ^ -37577465;
		m_188e107399a14b6fbb545059884f62e9.m_48cbaa2cf2b74c91b6c2ce6fecabe1fa = -unchecked(-1947804249 + -972628121) ^ -1374534926;
		m_188e107399a14b6fbb545059884f62e9.m_a41b83e1a14d4fabb4d025f7937fc1aa = -903410432 ^ -743418906;
		m_188e107399a14b6fbb545059884f62e9.m_5d981937aa044de6aefa8c62b60f0102 = 0x2B4B43E ^ 0x32EA4243;
		m_188e107399a14b6fbb545059884f62e9.m_143399f83cb74823b67eee7036dca200 = -233588960 ^ -233588960;
		m_188e107399a14b6fbb545059884f62e9.m_88696a0b161345cdb8cd7f841a73f4bd = -525773579 ^ -525773579;
		m_188e107399a14b6fbb545059884f62e9.m_24170717605948d59e5961f9a67f9221 = -unchecked(-1678195234 - 2063435055) ^ -2045001665;
		m_188e107399a14b6fbb545059884f62e9.m_637e3ed536e444c78b13f277a03822de = ~(-1069878398) ^ 0x4DA3E45A;
		m_188e107399a14b6fbb545059884f62e9.m_2c330d85012a49c889642a2403697ff2 = 0x76196A9 ^ 0x1249588A;
	}
}
