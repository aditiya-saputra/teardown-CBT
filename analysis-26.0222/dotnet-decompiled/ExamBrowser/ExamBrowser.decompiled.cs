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
using System.Net.Security;
using System.Reflection;
using System.Reflection.Emit;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using Ionic.Zip;
using POCTPEZfZcdnRff0Gn;
using RestSharp;
using ceW8LqtTowNPrYyqtc;

[assembly: ComVisible(false)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCopyright("Copyright ©  2023")]
[assembly: SuppressIldasm]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: Guid("ee862ec4-00ea-4f3c-8184-ca0d9712c3cf")]
[assembly: AssemblyProduct("Downloadpembaruan")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyTitle("Downloadpembaruan")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyVersion("1.0.0.0")]
internal class <Module>
{
	private static bool f8DE71F43B2DF263;

	internal static void m8DE71F43B2DF263()
	{
		if (!f8DE71F43B2DF263)
		{
			f8DE71F43B2DF263 = true;
			if (Math.Sign((DateTime.Now - new DateTime(2026, 2, 22)).Days) >= 14)
			{
				throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
			}
		}
	}

	static <Module>()
	{
		m8DE71F43B2DF263();
	}
}
namespace Downloadpembaruan
{
	public class Form_pembaruan : Form
	{
		public string versionupdate;

		public string nameupdate;

		private WebClient webClient;

		private Stopwatch sw;

		private bool hasProgresChanged;

		private static System.Timers.Timer checkDLTimer;

		public static string ExamFile;

		public static string namafilezip;

		public static string urlupdatefile;

		public static string validseleksi;

		public static string jenisos;

		public static string urlupdatefolder;

		public const SslProtocols _Tls12 = (SslProtocols)3072;

		public const SecurityProtocolType Tls12 = (SecurityProtocolType)3072;

		private IContainer components;

		private Panel panelContainer;

		private Panel panelTitleBar;

		private System.Windows.Forms.Label LabJudul;

		private Button button1;

		private System.Windows.Forms.Label labelDownloaded;

		private ProgressBar updateProgress1;

		public Form_pembaruan()
		{
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			sw = new Stopwatch();
			hasProgresChanged = false;
			components = null;
			base..ctor();
			InitializeComponent();
		}

		public void readVersion()
		{
			if (validseleksi.Equals(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x3112259D ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_422f85536c544e78a4fcb4f881ecc3f7)))
			{
				if (jenisos.Equals(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x362F148F ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_788db739d6f8473b92ee631d624dc9a6)))
				{
					urlupdatefolder = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2DF3DBFC ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_a804713ab8a5461bb67d7a984a750d46);
				}
				else
				{
					urlupdatefolder = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x3E3396EE ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_00a87fefa7344d0ebf46d618fb8b75db);
				}
			}
			else if (jenisos.Equals(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x129089FF ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_21cbf90e4d764705b2e9e6903aa5355e)))
			{
				urlupdatefolder = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x7AF5BFF ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_08f04dd0bb794120bbaadb4224b0c451);
			}
			else
			{
				urlupdatefolder = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x8AC40B ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_0befc0c44a7647439969e7608d1fdf34);
			}
			string text = DownloadString(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x21D01187 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_4f0bf5183cb942b5be8a13cbebd43f5e) + urlupdatefile + urlupdatefolder + Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x7F608388 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_11c5bacfd15943e5b5a4ca1dc1a43a12));
			if (text.Contains(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2DF3DB2E ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_a804713ab8a5461bb67d7a984a750d46)))
			{
				MessageBox.Show(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x403DCBF1 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_ac1b43ce705547b886924a6aa1695002), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				TulisLog(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x3FEE0351 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_01e99e70540e425091e2f787240a7007));
				runningApps();
				Application.Exit();
				return;
			}
			using (StringReader stringReader = new StringReader(text))
			{
				versionupdate = stringReader.ReadLine();
				nameupdate = stringReader.ReadLine();
			}
			string value = File.ReadAllText(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0xE26C3FB ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_028c7ce2bbf3464caaa2e696d8d4c5c8));
			if (versionupdate.Contains(value))
			{
				TulisLog(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x73607AA6 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_f68d4e736d81482e8552c10af220f9b3));
				runningApps();
			}
			else
			{
				DownloadFile(urlupdatefile + urlupdatefolder + nameupdate, namafilezip);
			}
		}

		public static string DownloadString(string address)
		{
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)3264;
				RestClient restClient = new RestClient(address);
				RestRequest restRequest = new RestRequest(Method.GET);
				restRequest.AddHeader(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x359778E2 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_92b2d5cd7f89418db57fa57a45e7b03f), Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x6589CDA6 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_363d7b8a86e54a80971bda354ad29d84));
				restRequest.AddHeader(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0xEB57386 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_0c4e4696ea324d85a3c75d85b317cc7c), Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x7BF72961 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_8c76c1479aad46bc8bd2847b06260aae));
				restRequest.AddHeader(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x3FEE0391 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_01e99e70540e425091e2f787240a7007), Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x6E6B19A8 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_91ba7d618cb74def8b0929e162a07539));
				IRestResponse restResponse = restClient.Execute(restRequest);
				if (restResponse.StatusCode == HttpStatusCode.OK)
				{
					return restResponse.Content;
				}
				return Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x38D0D471 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_43eafb7d54524098b4a62cc09c7aba61);
			}
			catch (NotSupportedException)
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
				RestClient restClient2 = new RestClient(address);
				RestRequest restRequest2 = new RestRequest(Method.GET);
				restRequest2.AddHeader(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x38D0D631 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_43eafb7d54524098b4a62cc09c7aba61), Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0xDA295C6 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_464abf8754fc4143b2e55113bbbacb16));
				restRequest2.AddHeader(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0xCC65E67 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_5b68586c168c4e4f98e4cee79935d719), Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x569FB3A5 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_ea8702e62beb4762aeb29eb7da4ba185));
				restRequest2.AddHeader(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x6BDBF7 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_fed7a1e1d45746b5be8db10fae27d2b0), Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2DF3D904 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_a804713ab8a5461bb67d7a984a750d46));
				IRestResponse restResponse2 = restClient2.Execute(restRequest2);
				if (restResponse2.StatusCode == HttpStatusCode.OK)
				{
					return restResponse2.Content;
				}
				return Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x734C5EFD ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_6286881d964346908cb51ea221fef546);
			}
			catch (Exception)
			{
				return Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x209806DE ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_855ff5850741436292d316ba6d3a00f5);
			}
		}

		public void DownloadFile(string urlAddress, string location)
		{
			using (webClient = new WebClient())
			{
				webClient.DownloadFileCompleted += Completed;
				webClient.DownloadProgressChanged += (object sender, DownloadProgressChangedEventArgs e) =>
				{
					ProgressChanged(sender, e, hasProgresChanged = true);
				};
				Uri address = (urlAddress.StartsWith(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x75376CC5 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_b19e35bb6ceb4be6afe851dcdd791a9e), StringComparison.OrdinalIgnoreCase) ? new Uri(urlAddress) : new Uri(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x6E6B1BDC ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_91ba7d618cb74def8b0929e162a07539) + urlAddress));
				sw.Start();
				checkDLTimer.Elapsed += checkDownload;
				checkDLTimer.Interval = 10000.0;
				checkDLTimer.Enabled = true;
				try
				{
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					ServicePointManager.SecurityProtocol = (SecurityProtocolType)3264;
					webClient.DownloadFileAsync(address, location);
				}
				catch (NotSupportedException)
				{
					ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
					ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
					webClient.DownloadFileAsync(address, location);
				}
				catch (Exception ex2)
				{
					MessageBox.Show(ex2.Message);
				}
			}
		}

		private void checkDownload(object source, ElapsedEventArgs e)
		{
			if (!hasProgresChanged)
			{
				webClient.CancelAsync();
			}
		}

		private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e, bool has)
		{
			checkDLTimer.Enabled = false;
			updateProgress1.Value = e.ProgressPercentage;
			labelDownloaded.Text = string.Format(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x6589CC16 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_363d7b8a86e54a80971bda354ad29d84), ((double)e.BytesReceived / 1024.0 / 1024.0).ToString(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(-(-722546930) ^ 0x1522A514 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_00a87fefa7344d0ebf46d618fb8b75db)), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x73607BDA ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_f68d4e736d81482e8552c10af220f9b3)));
			checkDLTimer.Enabled = true;
			hasProgresChanged = false;
		}

		private void Completed(object sender, AsyncCompletedEventArgs e)
		{
			sw.Reset();
			checkDLTimer.Enabled = false;
			if (e.Cancelled)
			{
				MessageBox.Show(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(-933612721 ^ -977759839 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_7b5f653d7fe54631b16e5d79370bd977), "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				TulisLog(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2DF3D86A ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_a804713ab8a5461bb67d7a984a750d46));
				File.Delete(namafilezip);
			}
			else
			{
				MessageBox.Show(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2DF3D81A ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_a804713ab8a5461bb67d7a984a750d46) + versionupdate);
				extract();
			}
		}

		public void extract()
		{
			try
			{
				using (ZipFile zipFile = ZipFile.Read(namafilezip))
				{
					zipFile.ExtractAll(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x77B1234D ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_3a0c862fe82444889037de65d0c68a82), ExtractExistingFileAction.OverwriteSilently);
				}
				TulisLog(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x403DCF19 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_ac1b43ce705547b886924a6aa1695002));
			}
			catch (Exception ex)
			{
				MessageBox.Show(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x362F1019 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_788db739d6f8473b92ee631d624dc9a6));
				TulisLog(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2A47CCB3 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_6a04cf2c08b34e2ab5fba0dc7a58b160) + ex);
			}
			File.Delete(namafilezip);
			MessageBox.Show(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x7F4FB484 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_2394459c5a4941cca69bc037fcc08187) + versionupdate);
			TulisLog(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x6E6B18B6 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_91ba7d618cb74def8b0929e162a07539) + versionupdate);
			runningApps();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			sw.Reset();
			webClient.CancelAsync();
			checkDLTimer.Enabled = false;
			Thread.Sleep(2000);
			File.Delete(namafilezip);
			Application.Exit();
		}

		public void runningApps()
		{
			try
			{
				Process.Start(ExamFile);
				Close();
			}
			catch (Exception ex)
			{
				MessageBox.Show(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x403DCFDB ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_ac1b43ce705547b886924a6aa1695002) + ex.Message);
				TulisLog(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x3D4E2D85 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_e65203bc302b463f8bd908842030fdf7) + ex.Message);
				Close();
			}
		}

		public static void TulisLog(string logMessage)
		{
			try
			{
				File.AppendAllText(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x3D4E2D55 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_e65203bc302b463f8bd908842030fdf7), DateTime.Now.ToString(Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x371C42DA ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_9b57db20f46042d7b04b65c29a91db78)) + logMessage + Environment.NewLine);
			}
			catch (Exception ex)
			{
				int num = (int)MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void Form_pembaruan_Load(object sender, EventArgs e)
		{
			readVersion();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Downloadpembaruan.Form_pembaruan));
			this.panelContainer = new System.Windows.Forms.Panel();
			this.updateProgress1 = new System.Windows.Forms.ProgressBar();
			this.panelTitleBar = new System.Windows.Forms.Panel();
			this.LabJudul = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.labelDownloaded = new System.Windows.Forms.Label();
			this.panelContainer.SuspendLayout();
			this.panelTitleBar.SuspendLayout();
			base.SuspendLayout();
			this.panelContainer.BackColor = System.Drawing.Color.GhostWhite;
			this.panelContainer.Controls.Add(this.updateProgress1);
			this.panelContainer.Controls.Add(this.panelTitleBar);
			this.panelContainer.Controls.Add(this.button1);
			this.panelContainer.Controls.Add(this.labelDownloaded);
			this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelContainer.Location = new System.Drawing.Point(0, 0);
			this.panelContainer.Name = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x294E4 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_2ffc3b07cce44cca887a9859967cb583);
			this.panelContainer.Size = new System.Drawing.Size(590, 220);
			this.panelContainer.TabIndex = 7;
			this.updateProgress1.Location = new System.Drawing.Point(21, 81);
			this.updateProgress1.Name = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(-(-1373352096) ^ 0x51E4554B ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_00e70dae6e2f43939c134fe982b1b544);
			this.updateProgress1.Size = new System.Drawing.Size(557, 23);
			this.updateProgress1.TabIndex = 7;
			this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(0, 0, 192);
			this.panelTitleBar.Controls.Add(this.LabJudul);
			this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
			this.panelTitleBar.Name = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x7BF72DD1 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_8c76c1479aad46bc8bd2847b06260aae);
			this.panelTitleBar.Size = new System.Drawing.Size(590, 51);
			this.panelTitleBar.TabIndex = 6;
			this.LabJudul.AutoSize = true;
			this.LabJudul.Font = new System.Drawing.Font(ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x20980028 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_855ff5850741436292d316ba6d3a00f5), 11f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			this.LabJudul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.LabJudul.Location = new System.Drawing.Point(39, 13);
			this.LabJudul.Name = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2A47CE37 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_6a04cf2c08b34e2ab5fba0dc7a58b160);
			this.LabJudul.Size = new System.Drawing.Size(199, 32);
			this.LabJudul.TabIndex = 0;
			this.LabJudul.Text = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x4C0D67D8 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_31664721ec354bb4b116f930a45df5de);
			this.button1.Location = new System.Drawing.Point(470, 149);
			this.button1.Name = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x3CD47774 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_b543bd462760415fa9f1bb3e2ba87be2);
			this.button1.Size = new System.Drawing.Size(108, 38);
			this.button1.TabIndex = 4;
			this.button1.Text = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(-935046542 ^ -183862213 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_e65203bc302b463f8bd908842030fdf7);
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			this.labelDownloaded.AutoSize = true;
			this.labelDownloaded.Font = new System.Drawing.Font(ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2D787E20 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_1e2109022b5047b78770c369a1688d63), 10f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.labelDownloaded.Location = new System.Drawing.Point(211, 127);
			this.labelDownloaded.Name = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0xD392735 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_6596eb633afa477082d52b04f5642b40);
			this.labelDownloaded.Size = new System.Drawing.Size(154, 20);
			this.labelDownloaded.TabIndex = 2;
			this.labelDownloaded.Text = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x73607E08 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_f68d4e736d81482e8552c10af220f9b3);
			base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(590, 220);
			base.Controls.Add(this.panelContainer);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)resources.GetObject(ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x403DCC3D ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_ac1b43ce705547b886924a6aa1695002));
			base.Name = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x7F608414 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_11c5bacfd15943e5b5a4ca1dc1a43a12);
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = ceW8LqtTowNPrYyqtc.Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2A47CF59 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_6a04cf2c08b34e2ab5fba0dc7a58b160);
			base.Load += new System.EventHandler(this.Form_pembaruan_Load);
			this.panelContainer.ResumeLayout(false);
			this.panelContainer.PerformLayout();
			this.panelTitleBar.ResumeLayout(false);
			this.panelTitleBar.PerformLayout();
			base.ResumeLayout(false);
		}

		static Form_pembaruan()
		{
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			checkDLTimer = new System.Timers.Timer();
			ExamFile = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x75376B03 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_b19e35bb6ceb4be6afe851dcdd791a9e);
			namafilezip = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x70EA9901 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_81154e6dfb7f4734a8e704ec816c23a1);
			urlupdatefile = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x734C598B ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_6286881d964346908cb51ea221fef546);
			validseleksi = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x2993E ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_2ffc3b07cce44cca887a9859967cb583);
			jenisos = Ni7vpKpZVHGkY9ZkUb.v8Sa8hFQ7(0x75F75614 ^ <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}.m_e704b67b91414e74941b79e0bc66fcaf.m_84bd11efa6124fe99b417b6698ab958f);
			urlupdatefolder = "";
		}
	}
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			Application.Run(new Form_pembaruan());
		}
	}
}
namespace Downloadpembaruan.Properties
{
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[DebuggerNonUserCode]
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
					ResourceManager resourceManager = new ResourceManager("Downloadpembaruan.Properties.Resources", typeof(Resources).Assembly);
					resourceMan = resourceManager;
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
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			base..ctor();
		}
	}
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		public static Settings Default => defaultInstance;

		public Settings()
		{
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			base..ctor();
		}

		static Settings()
		{
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}
internal class <Module>{155A7D04-A8B9-4841-BF6B-AA4AD5B41787}
{
}
namespace m6xejBXdVaVFO00Gcu
{
	internal class Y0m6RjDVlOfNYKYmsK
	{
		internal delegate void SFU4mbT3GMret7THonf(object o);

		internal static Module Y0mD6RjVl;

		internal static void QpYnvBXBC(int typemdt)
		{
			Type type = Y0mD6RjVl.ResolveType(33554432 + typemdt);
			FieldInfo[] fields = type.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				MethodInfo method = (MethodInfo)Y0mD6RjVl.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		public Y0m6RjDVlOfNYKYmsK()
		{
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			base..ctor();
		}

		static Y0m6RjDVlOfNYKYmsK()
		{
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			Y0mD6RjVl = typeof(Y0m6RjDVlOfNYKYmsK).Assembly.ManifestModule;
		}
	}
}
namespace ceW8LqtTowNPrYyqtc
{
	internal class Ni7vpKpZVHGkY9ZkUb
	{
		private delegate void JIS4qSaojnmEgJCJ1x(object o);

		internal class CdgKySUW8LvZnOaWvV : Attribute
		{
			internal class nQk1dCDfjkptjEH5oiC<T>
			{
				public nQk1dCDfjkptjEH5oiC()
				{
					z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
					base..ctor();
				}
			}

			public CdgKySUW8LvZnOaWvV(object P_0)
			{
			}
		}

		internal class xMpFL8uWN6TA8tkBBK
		{
			internal static string f7rtRVHwO2(string P_0, string P_1)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(P_0);
				byte[] key = new byte[32]
				{
					82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
					51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
					34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
					1, 88
				};
				byte[] iV = kPETfZcdn(Encoding.Unicode.GetBytes(P_1));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = F0g3HioQ5();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iV;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint fvqneleNrHkeHC7sEC(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr CXODNfA6wksxDjjdFY();

		internal struct rtDEbm6pgDK0obvPtP
		{
			internal bool FFktdldvEQ;

			internal byte[] YMHtn9J2VE;
		}

		internal class lLg4EI2JkjDFFcnI9D
		{
			private BinaryReader KlYtekrYvu;

			public lLg4EI2JkjDFFcnI9D(Stream P_0)
			{
				KlYtekrYvu = new BinaryReader(P_0);
			}

			[SpecialName]
			internal Stream f9UtU12u5A()
			{
				return KlYtekrYvu.BaseStream;
			}

			internal byte[] DhftB4KPc1(int P_0)
			{
				return KlYtekrYvu.ReadBytes(P_0);
			}

			internal int hvSt04nqZv(byte[] P_0, int P_1, int P_2)
			{
				return KlYtekrYvu.Read(P_0, P_1, P_2);
			}

			internal int D78t7SpsGQ()
			{
				return KlYtekrYvu.ReadInt32();
			}

			internal void EoxtaWgEXn()
			{
				KlYtekrYvu.Close();
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		private delegate IntPtr m4aUFeOwOkp4TRI1cg(IntPtr hModule, string lpName, uint lpType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr iInOOkqZqqLVVdCREQ(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int Dw8HBnmXCA8lXSOsy2(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int Q1nGQEKglnvkt1baC5(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr bGkRoEPT5XjeqHu4v1(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int Ox1Se2N1mmVAwAgOZx(IntPtr ptr);

		[Flags]
		private enum sd8XUUSuIw2Q5GKMq1
		{

		}

		private static object WnIDE9Dy4a;

		private static byte[] qOODpkZqqL;

		private static byte[] QVdDtCREQP;

		private static IntPtr g8HDgBnXCA;

		private static object Q1nDGGQEgl;

		private static int TmmDTVAwAg;

		internal static fvqneleNrHkeHC7sEC uuID4w2Q5G;

		private static long GbGD88CUhv;

		private static bool rEyDdvbtws;

		private static IntPtr t98D0cpT82;

		private static Dw8HBnmXCA8lXSOsy2 DvBDuE2TTq;

		private static Q1nGQEKglnvkt1baC5 Y4ADeFFv0O;

		private static Ox1Se2N1mmVAwAgOZx DP7D6X9JBc;

		private static int DRLDR8w0rR;

		private static uint[] MHkfeHC7s;

		internal static Hashtable awID7ZEOLI;

		private static bool ywkWsxDjj;

		private static bool GXjD3eqHu4;

		private static IntPtr olXDZSOsy2;

		private static List<int> kRIDX1cg3I;

		private static bool e9lDnJdmmR;

		internal static RSACryptoServiceProvider pFYcBtDEb;

		private static IntPtr GS5D2iVFbv;

		internal static Assembly CZv1qnelN;

		private static SortedList X1kDsx1Se2;

		private static object XPtYP4Lg4;

		private static Dictionary<int, int> BpgvDK0ob;

		[CdgKySUW8LvZnOaWvV(typeof(CdgKySUW8LvZnOaWvV.nQk1dCDfjkptjEH5oiC<object>[]))]
		private static bool firstrundone;

		private static int aIJzkjDFF;

		private static long zZxD90d8XU;

		private static int FDGDJkRoET;

		private static List<string> uFeDDwOkp4;

		private static int ss5DBafsY8;

		private static int[] qvkDwt1baC;

		private static bool aCPoXODNf;

		private static bGkRoEPT5XjeqHu4v1 bjuDAVmQVp;

		private static m4aUFeOwOkp4TRI1cg kI5DaW4SX1;

		internal static fvqneleNrHkeHC7sEC CMqDy16yy0;

		private static iInOOkqZqqLVVdCREQ U2EDUHEjUA;

		static Ni7vpKpZVHGkY9ZkUb()
		{
			CZv1qnelN = typeof(Ni7vpKpZVHGkY9ZkUb).Assembly;
			MHkfeHC7s = new uint[64]
			{
				3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
				4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
				3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
				1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
				681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
				2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
				4149444226u, 3174756917u, 718787259u, 3951481745u
			};
			aCPoXODNf = false;
			ywkWsxDjj = false;
			pFYcBtDEb = null;
			BpgvDK0ob = null;
			XPtYP4Lg4 = new object();
			aIJzkjDFF = 0;
			WnIDE9Dy4a = new object();
			uFeDDwOkp4 = null;
			kRIDX1cg3I = null;
			qOODpkZqqL = new byte[0];
			QVdDtCREQP = new byte[0];
			g8HDgBnXCA = IntPtr.Zero;
			olXDZSOsy2 = IntPtr.Zero;
			Q1nDGGQEgl = new string[0];
			qvkDwt1baC = new int[0];
			FDGDJkRoET = 1;
			GXjD3eqHu4 = false;
			X1kDsx1Se2 = new SortedList();
			TmmDTVAwAg = 0;
			zZxD90d8XU = 0L;
			uuID4w2Q5G = null;
			CMqDy16yy0 = null;
			GbGD88CUhv = 0L;
			DRLDR8w0rR = 0;
			rEyDdvbtws = false;
			e9lDnJdmmR = false;
			ss5DBafsY8 = 0;
			t98D0cpT82 = IntPtr.Zero;
			firstrundone = false;
			awID7ZEOLI = new Hashtable();
			kI5DaW4SX1 = null;
			U2EDUHEjUA = null;
			DvBDuE2TTq = null;
			Y4ADeFFv0O = null;
			bjuDAVmQVp = null;
			DP7D6X9JBc = null;
			GS5D2iVFbv = IntPtr.Zero;
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private void xiubqg3Y8()
		{
		}

		internal static byte[] zfNXYKYms(byte[] P_0)
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
				Cy6pxejBd(ref num6, num7, num8, num9, 0u, 7, 1u, array);
				Cy6pxejBd(ref num9, num6, num7, num8, 1u, 12, 2u, array);
				Cy6pxejBd(ref num8, num9, num6, num7, 2u, 17, 3u, array);
				Cy6pxejBd(ref num7, num8, num9, num6, 3u, 22, 4u, array);
				Cy6pxejBd(ref num6, num7, num8, num9, 4u, 7, 5u, array);
				Cy6pxejBd(ref num9, num6, num7, num8, 5u, 12, 6u, array);
				Cy6pxejBd(ref num8, num9, num6, num7, 6u, 17, 7u, array);
				Cy6pxejBd(ref num7, num8, num9, num6, 7u, 22, 8u, array);
				Cy6pxejBd(ref num6, num7, num8, num9, 8u, 7, 9u, array);
				Cy6pxejBd(ref num9, num6, num7, num8, 9u, 12, 10u, array);
				Cy6pxejBd(ref num8, num9, num6, num7, 10u, 17, 11u, array);
				Cy6pxejBd(ref num7, num8, num9, num6, 11u, 22, 12u, array);
				Cy6pxejBd(ref num6, num7, num8, num9, 12u, 7, 13u, array);
				Cy6pxejBd(ref num9, num6, num7, num8, 13u, 12, 14u, array);
				Cy6pxejBd(ref num8, num9, num6, num7, 14u, 17, 15u, array);
				Cy6pxejBd(ref num7, num8, num9, num6, 15u, 22, 16u, array);
				PaVtFO00G(ref num6, num7, num8, num9, 1u, 5, 17u, array);
				PaVtFO00G(ref num9, num6, num7, num8, 6u, 9, 18u, array);
				PaVtFO00G(ref num8, num9, num6, num7, 11u, 14, 19u, array);
				PaVtFO00G(ref num7, num8, num9, num6, 0u, 20, 20u, array);
				PaVtFO00G(ref num6, num7, num8, num9, 5u, 5, 21u, array);
				PaVtFO00G(ref num9, num6, num7, num8, 10u, 9, 22u, array);
				PaVtFO00G(ref num8, num9, num6, num7, 15u, 14, 23u, array);
				PaVtFO00G(ref num7, num8, num9, num6, 4u, 20, 24u, array);
				PaVtFO00G(ref num6, num7, num8, num9, 9u, 5, 25u, array);
				PaVtFO00G(ref num9, num6, num7, num8, 14u, 9, 26u, array);
				PaVtFO00G(ref num8, num9, num6, num7, 3u, 14, 27u, array);
				PaVtFO00G(ref num7, num8, num9, num6, 8u, 20, 28u, array);
				PaVtFO00G(ref num6, num7, num8, num9, 13u, 5, 29u, array);
				PaVtFO00G(ref num9, num6, num7, num8, 2u, 9, 30u, array);
				PaVtFO00G(ref num8, num9, num6, num7, 7u, 14, 31u, array);
				PaVtFO00G(ref num7, num8, num9, num6, 12u, 20, 32u, array);
				Wujgi7vpK(ref num6, num7, num8, num9, 5u, 4, 33u, array);
				Wujgi7vpK(ref num9, num6, num7, num8, 8u, 11, 34u, array);
				Wujgi7vpK(ref num8, num9, num6, num7, 11u, 16, 35u, array);
				Wujgi7vpK(ref num7, num8, num9, num6, 14u, 23, 36u, array);
				Wujgi7vpK(ref num6, num7, num8, num9, 1u, 4, 37u, array);
				Wujgi7vpK(ref num9, num6, num7, num8, 4u, 11, 38u, array);
				Wujgi7vpK(ref num8, num9, num6, num7, 7u, 16, 39u, array);
				Wujgi7vpK(ref num7, num8, num9, num6, 10u, 23, 40u, array);
				Wujgi7vpK(ref num6, num7, num8, num9, 13u, 4, 41u, array);
				Wujgi7vpK(ref num9, num6, num7, num8, 0u, 11, 42u, array);
				Wujgi7vpK(ref num8, num9, num6, num7, 3u, 16, 43u, array);
				Wujgi7vpK(ref num7, num8, num9, num6, 6u, 23, 44u, array);
				Wujgi7vpK(ref num6, num7, num8, num9, 9u, 4, 45u, array);
				Wujgi7vpK(ref num9, num6, num7, num8, 12u, 11, 46u, array);
				Wujgi7vpK(ref num8, num9, num6, num7, 15u, 16, 47u, array);
				Wujgi7vpK(ref num7, num8, num9, num6, 2u, 23, 48u, array);
				fVHZGkY9Z(ref num6, num7, num8, num9, 0u, 6, 49u, array);
				fVHZGkY9Z(ref num9, num6, num7, num8, 7u, 10, 50u, array);
				fVHZGkY9Z(ref num8, num9, num6, num7, 14u, 15, 51u, array);
				fVHZGkY9Z(ref num7, num8, num9, num6, 5u, 21, 52u, array);
				fVHZGkY9Z(ref num6, num7, num8, num9, 12u, 6, 53u, array);
				fVHZGkY9Z(ref num9, num6, num7, num8, 3u, 10, 54u, array);
				fVHZGkY9Z(ref num8, num9, num6, num7, 10u, 15, 55u, array);
				fVHZGkY9Z(ref num7, num8, num9, num6, 1u, 21, 56u, array);
				fVHZGkY9Z(ref num6, num7, num8, num9, 8u, 6, 57u, array);
				fVHZGkY9Z(ref num9, num6, num7, num8, 15u, 10, 58u, array);
				fVHZGkY9Z(ref num8, num9, num6, num7, 6u, 15, 59u, array);
				fVHZGkY9Z(ref num7, num8, num9, num6, 13u, 21, 60u, array);
				fVHZGkY9Z(ref num6, num7, num8, num9, 4u, 6, 61u, array);
				fVHZGkY9Z(ref num9, num6, num7, num8, 11u, 10, 62u, array);
				fVHZGkY9Z(ref num8, num9, num6, num7, 2u, 15, 63u, array);
				fVHZGkY9Z(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

		private static void Cy6pxejBd(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + OUbGpeW8L(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + MHkfeHC7s[P_6 - 1], P_5);
		}

		private static void PaVtFO00G(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + OUbGpeW8L(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + MHkfeHC7s[P_6 - 1], P_5);
		}

		private static void Wujgi7vpK(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + OUbGpeW8L(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + MHkfeHC7s[P_6 - 1], P_5);
		}

		private static void fVHZGkY9Z(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + OUbGpeW8L(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + MHkfeHC7s[P_6 - 1], P_5);
		}

		private static uint OUbGpeW8L(uint P_0, ushort P_1)
		{
			return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
		}

		internal static bool ATowwNPrY()
		{
			if (!aCPoXODNf)
			{
				PY2sRQVOC();
				aCPoXODNf = true;
			}
			return ywkWsxDjj;
		}

		internal Ni7vpKpZVHGkY9ZkUb()
		{
		}

		private void mqtJcO6oA(byte[] P_0, byte[] P_1, byte[] P_2)
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
				uint num14 = 1900251927u;
				uint num15 = 290750971u;
				uint num16 = 2105069455u;
				uint num17 = 789030146u;
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
			qOODpkZqqL = array;
		}

		internal static SymmetricAlgorithm F0g3HioQ5()
		{
			SymmetricAlgorithm symmetricAlgorithm = null;
			if (ATowwNPrY())
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

		internal static void PY2sRQVOC()
		{
			try
			{
				new RijndaelManaged();
				ywkWsxDjj = false;
			}
			catch
			{
				ywkWsxDjj = true;
			}
		}

		internal static byte[] kPETfZcdn(byte[] P_0)
		{
			if (!ATowwNPrY())
			{
				return new MD5CryptoServiceProvider().ComputeHash(P_0);
			}
			return zfNXYKYms(P_0);
		}

		internal static void off90GnsO(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
		{
			while (P_2 != 0)
			{
				int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
				P_1.Read(P_3, 0, num);
				hcP4kFba5(P_0, P_3, 0, num);
				P_2 -= (uint)num;
			}
		}

		internal static void hcP4kFba5(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
		{
			P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
		}

		internal static uint PfNynOvuA(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

		public static void laFROyAMj(RuntimeTypeHandle P_0)
		{
			try
			{
				Type typeFromHandle = Type.GetTypeFromHandle(P_0);
				if (BpgvDK0ob == null)
				{
					lock (XPtYP4Lg4)
					{
						Dictionary<int, int> dictionary = new Dictionary<int, int>();
						BinaryReader binaryReader = new BinaryReader(typeof(Ni7vpKpZVHGkY9ZkUb).Assembly.GetManifestResourceStream("d4b9nT2dtbUOakQV2x.oI8nlfSnK1vMN3ZaZR"));
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
								num3 += BsjB3E2bv(num3);
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
							lLg4EI2JkjDFFcnI9D lLg4EI2JkjDFFcnI9D2 = new lLg4EI2JkjDFFcnI9D(new MemoryStream(array));
							for (int l = 0; l < num11; l++)
							{
								int key = lLg4EI2JkjDFFcnI9D2.D78t7SpsGQ();
								int value = lLg4EI2JkjDFFcnI9D2.D78t7SpsGQ();
								dictionary.Add(key, value);
							}
							lLg4EI2JkjDFFcnI9D2.EoxtaWgEXn();
						}
						BpgvDK0ob = dictionary;
					}
				}
				FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
				for (int m = 0; m < fields.Length; m++)
				{
					try
					{
						FieldInfo fieldInfo = fields[m];
						int metadataToken = fieldInfo.MetadataToken;
						int num12 = BpgvDK0ob[metadataToken];
						bool flag = (num12 & 0x40000000) > 0;
						num12 &= 0x3FFFFFFF;
						MethodInfo methodInfo = (MethodInfo)typeof(Ni7vpKpZVHGkY9ZkUb).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

		private static uint udAnniqFd(uint P_0)
		{
			return (uint)"{11111-22222-10009-11112}".Length;
		}

		private static uint BsjB3E2bv(uint P_0)
		{
			return 0u;
		}

		internal static void BhV0hHBTR()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void LYM7HWeev(Stream P_0, int P_1)
		{
			int num = 194;
			byte[] array4 = default;
			int num4 = default;
			byte[] array5 = default;
			byte[] array2 = default;
			byte[] array6 = default;
			int num3 = default;
			int num5 = default;
			int num6 = default;
			int num7 = default;
			byte[] array = default;
			Stream stream = default;
			ICryptoTransform transform = default;
			byte[] array3 = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 22:
						array4[21] = (byte)num4;
						num2 = 271;
						continue;
					case 326:
						array5[3] = 157;
						num2 = 7;
						continue;
					case 126:
						array2[13] = array6[6];
						num2 = 46;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 51;
						}
						continue;
					case 17:
						num4 = 130 - 43;
						num2 = 347;
						continue;
					case 238:
						array4[8] = (byte)num3;
						num2 = 115;
						continue;
					case 34:
						array5[15] = 132;
						num2 = 74;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 324;
						}
						continue;
					case 226:
						array4[31] = (byte)num4;
						num2 = 132;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 12;
						}
						continue;
					case 320:
						num3 = 81 + 10;
						num2 = 121;
						continue;
					case 274:
						num5 = 126 + 41;
						num2 = 135;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 110;
						}
						continue;
					case 77:
						array2 = array5;
						num2 = 52;
						continue;
					case 73:
						num4 = 75 - 41;
						num2 = 297;
						continue;
					case 219:
						array5[0] = (byte)num6;
						num2 = 159;
						continue;
					case 83:
						array5[2] = (byte)num5;
						num2 = 102;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 143;
						}
						continue;
					case 110:
						array4[6] = 151;
						num2 = 190;
						continue;
					case 62:
						array5[13] = 88;
						num2 = 44;
						continue;
					case 49:
						array4[18] = 36;
						num2 = 199;
						continue;
					case 14:
						if (array6.Length != 0)
						{
							num2 = 217;
							if (tkCy8Yydv5lcj0o3KU() == null)
							{
								num2 = 227;
							}
							continue;
						}
						goto case 84;
					case 158:
						num4 = 209 - 69;
						num2 = 239;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 6;
						}
						continue;
					case 124:
						num5 = 250 - 83;
						num2 = 83;
						continue;
					case 265:
						array5[3] = (byte)num5;
						num2 = 72;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 3;
						}
						continue;
					case 171:
						array2[9] = array6[4];
						num2 = 132;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 186;
						}
						continue;
					case 47:
						array4[5] = 7;
						num2 = 110;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 34;
						}
						continue;
					case 283:
						num7++;
						num = 242;
						break;
					case 321:
						array4[28] = (byte)num4;
						num2 = 1;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 0;
						}
						continue;
					case 253:
						array4[25] = (byte)num4;
						num2 = 261;
						continue;
					case 156:
						array4[27] = (byte)num4;
						num2 = 4;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 1;
						}
						continue;
					case 249:
						array4[10] = (byte)num3;
						num2 = 243;
						continue;
					case 131:
						array4[24] = (byte)num4;
						num2 = 118;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 96;
						}
						continue;
					case 114:
						array4[28] = (byte)num4;
						num2 = 258;
						continue;
					case 50:
						array5[11] = 133;
						num2 = 147;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 157;
						}
						continue;
					case 264:
						array4[24] = 183;
						num2 = 266;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 101;
						}
						continue;
					case 193:
						array4 = new byte[32];
						num2 = 29;
						continue;
					case 93:
						array4[0] = (byte)num4;
						num2 = 20;
						continue;
					case 145:
						array2[5] = array6[2];
						num2 = 10;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 43;
						}
						continue;
					case 216:
						array4[28] = 132;
						num2 = 270;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 322;
						}
						continue;
					case 236:
						array4[23] = (byte)num4;
						num2 = 222;
						continue;
					case 319:
						array4[30] = (byte)num4;
						num2 = 18;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 3;
						}
						continue;
					case 202:
						num6 = 112 + 54;
						num2 = 219;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 60;
						}
						continue;
					case 33:
						array5[7] = 76;
						num2 = 204;
						continue;
					case 129:
						array4[17] = 120;
						num2 = 119;
						continue;
					case 149:
						array5[15] = (byte)num5;
						num2 = 34;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 31;
						}
						continue;
					case 137:
						array4[2] = (byte)num4;
						num2 = 54;
						continue;
					case 195:
						num3 = 133 - 44;
						num2 = 139;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 28;
						}
						continue;
					case 348:
						array4[20] = (byte)num3;
						num = 225;
						break;
					case 59:
						array4[20] = (byte)num4;
						num2 = 84;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 268;
						}
						continue;
					case 295:
						array5[14] = (byte)num5;
						num2 = 105;
						continue;
					case 246:
						num4 = 158 - 52;
						num2 = 154;
						continue;
					case 203:
						array4[9] = (byte)num4;
						num2 = 195;
						continue;
					case 184:
						num3 = 219 - 73;
						num2 = 333;
						continue;
					case 200:
						array4[4] = 96;
						num2 = 6;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 8;
						}
						continue;
					case 269:
						array4[22] = (byte)num3;
						num2 = 346;
						continue;
					case 207:
						num5 = 240 - 124;
						num2 = 23;
						continue;
					case 72:
						array5[3] = 108;
						num2 = 101;
						continue;
					case 111:
						array4[0] = (byte)num3;
						num2 = 201;
						continue;
					case 174:
						array4[1] = 143;
						num2 = 301;
						continue;
					case 2:
						num6 = 8 + 65;
						num2 = 20;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 48;
						}
						continue;
					case 125:
						array4[10] = (byte)num3;
						num2 = 29;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 42;
						}
						continue;
					case 108:
						array4[14] = 94;
						num2 = 241;
						continue;
					case 240:
						array5[8] = 231;
						num2 = 312;
						continue;
					case 166:
						num6 = 151 - 50;
						num2 = 252;
						continue;
					case 344:
						array5[1] = 94;
						num2 = 124;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 124;
						}
						continue;
					case 308:
						num4 = 201 - 67;
						num2 = 181;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 73;
						}
						continue;
					case 142:
						array4[16] = 183;
						num2 = 0;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 6;
						}
						continue;
					case 44:
						num5 = 122 + 40;
						num2 = 235;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 295;
						}
						continue;
					case 275:
						array4[26] = 86;
						num2 = 241;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 247;
						}
						continue;
					case 134:
						array4[14] = 135;
						num = 85;
						break;
					case 213:
						array4[3] = 95;
						num2 = 315;
						continue;
					case 257:
						num5 = 226 - 75;
						num2 = 192;
						continue;
					case 218:
						array4[18] = 106;
						num2 = 19;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 14;
						}
						continue;
					case 181:
						array4[23] = (byte)num4;
						num2 = 241;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 307;
						}
						continue;
					case 118:
						array4[24] = 83;
						num2 = 338;
						continue;
					case 53:
						array4[0] = (byte)num4;
						num2 = 144;
						continue;
					case 204:
						array5[7] = 116;
						num2 = 141;
						continue;
					case 30:
						array4[20] = (byte)num3;
						num2 = 79;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 11;
						}
						continue;
					case 186:
						array2[11] = array6[5];
						num2 = 82;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 126;
						}
						continue;
					case 68:
						array4[26] = (byte)num3;
						num = 210;
						break;
					case 180:
						array4[13] = 126;
						num2 = 76;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 92;
						}
						continue;
					case 9:
						num3 = 112 - 77;
						num2 = 116;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 273;
						}
						continue;
					case 262:
						num6 = 167 - 55;
						num2 = 33;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 87;
						}
						continue;
					case 26:
						num5 = 183 - 61;
						num2 = 62;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 237;
						}
						continue;
					case 239:
						array4[7] = (byte)num4;
						num2 = 206;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 138;
						}
						continue;
					case 28:
						array5[6] = (byte)num6;
						num2 = 26;
						continue;
					case 323:
						array4[1] = 94;
						num2 = 174;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 127;
						}
						continue;
					case 147:
						num4 = 33 + 52;
						num2 = 253;
						continue;
					case 116:
						array = array4;
						num2 = 117;
						continue;
					case 350:
						array5[3] = 158;
						num2 = 106;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 40;
						}
						continue;
					case 150:
						num3 = 2 + 10;
						num = 30;
						break;
					case 337:
						array5[1] = (byte)num5;
						num2 = 172;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 342;
						}
						continue;
					case 37:
						array4[9] = 95;
						num2 = 270;
						continue;
					case 70:
						num4 = 148 - 49;
						num2 = 67;
						continue;
					case 217:
						array5[10] = (byte)num6;
						num2 = 309;
						continue;
					case 245:
						num4 = 162 + 71;
						num2 = 156;
						continue;
					case 88:
						num3 = 24 + 60;
						num2 = 66;
						continue;
					case 303:
						array4[31] = 33;
						num2 = 116;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 37;
						}
						continue;
					case 4:
						num3 = 241 - 80;
						num2 = 256;
						continue;
					case 230:
						array4[17] = (byte)num3;
						num2 = 184;
						continue;
					case 261:
						array4[25] = 154;
						num2 = 275;
						continue;
					case 29:
						array4[0] = 166;
						num2 = 153;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 316;
						}
						continue;
					case 188:
						array4[6] = 77;
						num = 158;
						break;
					case 287:
						num4 = 114 + 20;
						num2 = 236;
						continue;
					case 211:
						num4 = 82 + 58;
						num2 = 5;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 0;
						}
						continue;
					case 121:
						array4[5] = (byte)num3;
						num2 = 70;
						continue;
					case 85:
						num3 = 119 + 106;
						num2 = 71;
						continue;
					case 57:
						array5[13] = 158;
						num = 232;
						break;
					case 340:
					{
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						s0XvAasS1Q7JC1idN8(cryptoStream, array3, 0, array3.Length);
						vvp32gNe0WwkQnWRb8(cryptoStream);
						qOODpkZqqL = (byte[])t4O6d5uX2jh16aVGww(stream);
						ajByiqZFfbQAQAl8vV(stream);
						ajByiqZFfbQAQAl8vV(cryptoStream);
						num2 = 294;
						continue;
					}
					case 225:
						num4 = 230 - 76;
						num2 = 10;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 22;
						}
						continue;
					case 157:
						array5[12] = 161;
						num2 = 78;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 51;
						}
						continue;
					case 96:
						num3 = 187 - 62;
						num2 = 249;
						continue;
					case 223:
						array5[6] = 140;
						num2 = 257;
						continue;
					case 291:
						num3 = 78 + 34;
						num2 = 269;
						continue;
					case 100:
						array4[8] = 145;
						num2 = 15;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 15;
						}
						continue;
					case 130:
						num4 = 123 + 77;
						num2 = 185;
						continue;
					case 285:
						array5[0] = (byte)num5;
						num2 = 281;
						continue;
					case 127:
						array4[18] = 89;
						num2 = 211;
						continue;
					case 341:
						num4 = 218 - 72;
						num2 = 114;
						continue;
					case 237:
						array5[6] = (byte)num5;
						num2 = 192;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 223;
						}
						continue;
					case 54:
						array4[3] = 98;
						num2 = 97;
						continue;
					case 32:
						array4[2] = (byte)num4;
						num2 = 175;
						continue;
					case 325:
						num6 = 106 - 25;
						num2 = 156;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 160;
						}
						continue;
					case 86:
						num3 = 251 - 83;
						num2 = 112;
						continue;
					case 141:
						num6 = 222 + 2;
						num2 = 58;
						continue;
					case 12:
						array5[12] = (byte)num6;
						num2 = 82;
						continue;
					case 5:
						array4[19] = (byte)num4;
						num = 95;
						break;
					case 324:
						array5[15] = 166;
						num2 = 325;
						continue;
					case 206:
						array4[7] = 96;
						num2 = 0;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 0;
						}
						continue;
					case 343:
						num3 = 131 + 10;
						num2 = 136;
						continue;
					case 119:
						num3 = 185 + 39;
						num2 = 230;
						continue;
					case 228:
					{
						object obj = kxLUlYqMGA85PR2VQj();
						wjb4mDP4a8wJGIICFB(obj, CipherMode.CBC);
						transform = (ICryptoTransform)YEDMVZMDb5LBJ6ea53(obj, array, array2);
						num2 = 10;
						continue;
					}
					case 136:
						array4[19] = (byte)num3;
						num2 = 150;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 46;
						}
						continue;
					case 282:
						num4 = 250 - 83;
						num2 = 32;
						continue;
					case 289:
						array5[5] = (byte)num5;
						num2 = 189;
						continue;
					case 234:
						num3 = 209 - 69;
						num2 = 170;
						continue;
					case 163:
						array5[11] = 86;
						num2 = 2;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 50;
						}
						continue;
					case 165:
						array4[30] = 94;
						num2 = 98;
						continue;
					case 335:
						num3 = 139 - 46;
						num2 = 191;
						continue;
					case 277:
						array4[29] = 156;
						num2 = 36;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 35;
						}
						continue;
					case 272:
						num3 = 113 + 37;
						num2 = 329;
						continue;
					case 7:
						array5[4] = 147;
						num2 = 220;
						continue;
					case 254:
						array5[14] = 167;
						num2 = 155;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 274;
						}
						continue;
					case 80:
						array5[8] = (byte)num6;
						num2 = 244;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 51;
						}
						continue;
					case 280:
						array4[11] = 48;
						num2 = 313;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 199;
						}
						continue;
					case 19:
						array4[18] = 137;
						num2 = 127;
						continue;
					case 182:
						array4[8] = (byte)num3;
						num2 = 21;
						continue;
					case 247:
						num3 = 10 + 39;
						num2 = 68;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 61;
						}
						continue;
					case 183:
						array4[16] = 241;
						num2 = 185;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 332;
						}
						continue;
					case 305:
						array5[1] = 107;
						num2 = 13;
						continue;
					case 27:
						num5 = 37 + 16;
						num2 = 334;
						continue;
					case 104:
						array5[4] = (byte)num6;
						num2 = 102;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 172;
						}
						continue;
					case 278:
						array4[29] = (byte)num4;
						num2 = 277;
						continue;
					case 294:
						array3 = qOODpkZqqL;
						num2 = 215;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 290;
						}
						continue;
					case 214:
						array4[17] = (byte)num3;
						num2 = 25;
						continue;
					case 135:
						array5[14] = (byte)num5;
						num2 = 151;
						continue;
					case 8:
						array4[5] = 124;
						num2 = 320;
						continue;
					case 309:
						array5[10] = 160;
						num2 = 207;
						continue;
					case 175:
						num4 = 42 - 6;
						num2 = 137;
						continue;
					case 270:
						num4 = 202 - 67;
						num2 = 203;
						continue;
					case 310:
						array4[4] = 120;
						num2 = 234;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 98;
						}
						continue;
					case 194:
					{
						lLg4EI2JkjDFFcnI9D lLg4EI2JkjDFFcnI9D2 = new lLg4EI2JkjDFFcnI9D(P_0);
						g04Qq8VXFYmisjEvyM(sZX4F2dvd84yL5gZjR(lLg4EI2JkjDFFcnI9D2), 0L);
						array3 = (byte[])xUK4juFGVqJLbnrMvC(lLg4EI2JkjDFFcnI9D2, (int)KiMRjsLIjV3RGrZs2f(sZX4F2dvd84yL5gZjR(lLg4EI2JkjDFFcnI9D2)));
						Lm4b6WHetEH2UiZi4a(lLg4EI2JkjDFFcnI9D2);
						num2 = 193;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 93;
						}
						continue;
					}
					case 97:
						num3 = 103 + 107;
						num2 = 75;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 35;
						}
						continue;
					case 255:
						array4[28] = (byte)num3;
						num2 = 341;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 112;
						}
						continue;
					case 299:
						array4[15] = 18;
						num2 = 142;
						continue;
					case 140:
						num3 = 226 - 75;
						num2 = 173;
						continue;
					case 172:
						array5[4] = 54;
						num2 = 257;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 288;
						}
						continue;
					case 167:
						num5 = 15 + 37;
						num2 = 337;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 260;
						}
						continue;
					case 38:
						array5[4] = 77;
						num2 = 161;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 138;
						}
						continue;
					case 103:
						num4 = 110 - 19;
						num2 = 63;
						continue;
					case 21:
						num3 = 86 + 124;
						num2 = 300;
						continue;
					case 232:
						num6 = 249 - 83;
						num2 = 328;
						continue;
					case 11:
						num3 = 249 - 83;
						num2 = 138;
						continue;
					case 250:
						array4[30] = 89;
						num2 = 165;
						continue;
					case 302:
						num4 = 22 + 44;
						num2 = 229;
						continue;
					case 208:
					case 304:
						array[num7] ^= array2[num7];
						num2 = 283;
						continue;
					case 224:
						num3 = 85 + 6;
						num2 = 111;
						continue;
					case 113:
						num4 = 21 + 97;
						num2 = 78;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 177;
						}
						continue;
					case 177:
						array4[21] = (byte)num4;
						num2 = 272;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 201;
						}
						continue;
					case 288:
						array5[5] = 94;
						num2 = 187;
						continue;
					case 164:
						num3 = 207 - 69;
						num2 = 327;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 155;
						}
						continue;
					case 128:
						array4[7] = (byte)num3;
						num2 = 153;
						continue;
					case 192:
						array5[6] = (byte)num5;
						num2 = 19;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 60;
						}
						continue;
					case 152:
						array4[13] = 82;
						num2 = 73;
						continue;
					case 327:
						array4[31] = (byte)num3;
						num = 303;
						break;
					case 231:
						if (array6 == null)
						{
							num2 = 84;
							if (!V0J3M5lhHEwGCilv91())
							{
								num2 = 31;
							}
							continue;
						}
						goto case 14;
					case 105:
						array5[14] = 122;
						num2 = 254;
						continue;
					case 42:
						array4[10] = 86;
						num2 = 55;
						continue;
					case 189:
						array5[5] = 209;
						num = 345;
						break;
					case 220:
						array5[4] = 163;
						num2 = 38;
						continue;
					case 342:
						array5[1] = 122;
						num2 = 150;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 284;
						}
						continue;
					case 67:
						array4[5] = (byte)num4;
						num2 = 317;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 21;
						}
						continue;
					case 138:
						array4[12] = (byte)num3;
						num2 = 23;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 46;
						}
						continue;
					case 251:
						num5 = 77 + 43;
						num2 = 215;
						continue;
					case 75:
						array4[3] = (byte)num3;
						num = 213;
						break;
					case 161:
						num6 = 150 - 50;
						num2 = 87;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 104;
						}
						continue;
					case 18:
						num3 = 165 - 55;
						num2 = 273;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 298;
						}
						continue;
					case 292:
						array4[4] = 77;
						num2 = 88;
						continue;
					case 316:
						array4[0] = 88;
						num2 = 224;
						continue;
					case 313:
						array4[11] = 136;
						num2 = 6;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 9;
						}
						continue;
					case 139:
						array4[9] = (byte)num3;
						num2 = 140;
						continue;
					case 16:
						num4 = 188 - 122;
						num2 = 45;
						continue;
					case 266:
						num4 = 189 - 63;
						num2 = 32;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 131;
						}
						continue;
					case 191:
						array4[27] = (byte)num3;
						num2 = 280;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 302;
						}
						continue;
					case 10:
						stream = (Stream)PpeFMIA2cYC7mZ8ces();
						num2 = 330;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 340;
						}
						continue;
					case 210:
						array4[26] = 64;
						num2 = 103;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 43;
						}
						continue;
					case 205:
						array5[6] = (byte)num6;
						num2 = 33;
						continue;
					case 317:
						num3 = 222 - 74;
						num = 339;
						break;
					case 339:
						array4[5] = (byte)num3;
						num2 = 3;
						continue;
					case 94:
						array4[30] = (byte)num3;
						num2 = 59;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 336;
						}
						continue;
					case 331:
						array4[21] = (byte)num3;
						num2 = 113;
						continue;
					case 332:
						num3 = 107 + 0;
						num2 = 214;
						continue;
					case 333:
						array4[18] = (byte)num3;
						num2 = 49;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 29;
						}
						continue;
					case 168:
						array4[24] = (byte)num4;
						num2 = 72;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 146;
						}
						continue;
					case 221:
						num6 = 6 + 57;
						num2 = 0;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 35;
						}
						continue;
					case 155:
						num5 = 240 - 80;
						num2 = 285;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 168;
						}
						continue;
					case 256:
						array4[28] = (byte)num3;
						num2 = 216;
						continue;
					case 198:
						array4[2] = (byte)num4;
						num2 = 330;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 44;
						}
						continue;
					case 87:
						array5[9] = (byte)num6;
						num2 = 38;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 221;
						}
						continue;
					case 101:
						array5[3] = 145;
						num2 = 326;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 75;
						}
						continue;
					case 258:
						num4 = 209 - 97;
						num2 = 258;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 321;
						}
						continue;
					case 338:
						array4[25] = 99;
						num2 = 260;
						continue;
					case 39:
						array4[21] = (byte)num3;
						num2 = 247;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 291;
						}
						continue;
					case 43:
						array2[7] = array6[3];
						num2 = 171;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 160;
						}
						continue;
					case 41:
						array5[2] = (byte)num5;
						num2 = 350;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 225;
						}
						continue;
					case 312:
						array5[9] = 100;
						num2 = 120;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 66;
						}
						continue;
					case 273:
						array4[11] = (byte)num3;
						num = 11;
						break;
					case 91:
						num6 = 132 - 44;
						num2 = 209;
						continue;
					case 1:
						array4[29] = 150;
						num2 = 76;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 13;
						}
						continue;
					case 244:
						array5[8] = 148;
						num2 = 166;
						continue;
					case 160:
						array5[15] = (byte)num6;
						num2 = 77;
						continue;
					case 293:
						array4[18] = (byte)num4;
						num2 = 218;
						continue;
					case 162:
						array4[12] = (byte)num4;
						num2 = 4;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 16;
						}
						continue;
					case 201:
						num4 = 110 + 39;
						num2 = 64;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 93;
						}
						continue;
					case 60:
						num6 = 120 + 78;
						num2 = 205;
						continue;
					case 178:
						array4[19] = (byte)num3;
						num2 = 75;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 343;
						}
						continue;
					case 286:
						array5[1] = (byte)num6;
						num2 = 86;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 344;
						}
						continue;
					case 297:
						array4[13] = (byte)num4;
						num2 = 78;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 134;
						}
						continue;
					case 336:
						num4 = 162 - 54;
						num2 = 226;
						continue;
					case 69:
						num6 = 156 - 52;
						num2 = 80;
						continue;
					case 267:
						array4[17] = 197;
						num2 = 263;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 211;
						}
						continue;
					case 148:
						num3 = 132 - 44;
						num2 = 125;
						continue;
					default:
						num3 = 206 + 43;
						num2 = 128;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 61;
						}
						continue;
					case 271:
						num3 = 33 + 122;
						num2 = 326;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 331;
						}
						continue;
					case 322:
						num3 = 79 + 120;
						num2 = 255;
						continue;
					case 187:
						num5 = 65 + 81;
						num2 = 289;
						continue;
					case 78:
						num6 = 46 + 16;
						num2 = 12;
						continue;
					case 229:
						array4[27] = (byte)num4;
						num2 = 205;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 246;
						}
						continue;
					case 179:
						array4[3] = 34;
						num2 = 310;
						continue;
					case 314:
						num6 = 20 + 115;
						num2 = 217;
						continue;
					case 117:
						array5 = new byte[16];
						num2 = 202;
						continue;
					case 106:
						num5 = 59 + 36;
						num2 = 11;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 265;
						}
						continue;
					case 268:
						num3 = 72 - 67;
						num2 = 348;
						continue;
					case 98:
						array4[30] = 211;
						num2 = 56;
						continue;
					case 45:
						array4[12] = (byte)num4;
						num2 = 180;
						continue;
					case 55:
						num4 = 95 - 40;
						num2 = 81;
						continue;
					case 296:
						array5[9] = 180;
						num2 = 2;
						continue;
					case 20:
						num4 = 54 - 15;
						num2 = 53;
						continue;
					case 123:
						array4[11] = 87;
						num2 = 280;
						continue;
					case 173:
						array4[9] = (byte)num3;
						num2 = 276;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 17;
						}
						continue;
					case 248:
						array4[6] = 105;
						num2 = 188;
						continue;
					case 120:
						array5[9] = 154;
						num2 = 262;
						continue;
					case 107:
						array4[19] = (byte)num3;
						num2 = 50;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 235;
						}
						continue;
					case 74:
					case 242:
						if (num7 < array2.Length)
						{
							num2 = 208;
							if (!V0J3M5lhHEwGCilv91())
							{
								num2 = 73;
							}
							continue;
						}
						goto case 169;
					case 306:
						array4[14] = (byte)num4;
						num2 = 109;
						continue;
					case 95:
						num3 = 62 + 90;
						num = 107;
						break;
					case 24:
						num6 = 222 - 74;
						num2 = 9;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 28;
						}
						continue;
					case 76:
						num4 = 207 - 69;
						num2 = 278;
						continue;
					case 79:
						num4 = 128 - 42;
						num2 = 59;
						continue;
					case 151:
						num5 = 41 + 103;
						num2 = 149;
						continue;
					case 122:
						array5[12] = 167;
						num = 27;
						break;
					case 56:
						num4 = 171 - 57;
						num = 319;
						break;
					case 144:
						array4[1] = 161;
						num2 = 323;
						continue;
					case 276:
						array4[9] = 153;
						num2 = 31;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 99;
						}
						continue;
					case 63:
						array4[26] = (byte)num4;
						num2 = 335;
						continue;
					case 197:
						array4[10] = (byte)num3;
						num2 = 96;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 86;
						}
						continue;
					case 315:
						array4[3] = 108;
						num2 = 135;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 179;
						}
						continue;
					case 170:
						array4[4] = (byte)num3;
						num2 = 279;
						continue;
					case 318:
						array4[13] = (byte)num4;
						num2 = 152;
						continue;
					case 65:
						aIJzkjDFF = 80;
						num2 = 212;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 233;
						}
						continue;
					case 52:
						QeDaco1htdOt8QduCl(array2);
						num2 = 311;
						continue;
					case 102:
						array4[22] = 101;
						num2 = 308;
						continue;
					case 176:
						array5[11] = 76;
						num2 = 163;
						continue;
					case 48:
						array5[10] = (byte)num6;
						num = 314;
						break;
					case 329:
						array4[21] = (byte)num3;
						num2 = 61;
						continue;
					case 115:
						array4[8] = 13;
						num = 86;
						break;
					case 301:
						num4 = 106 + 102;
						num2 = 109;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 198;
						}
						continue;
					case 109:
						array4[14] = 213;
						num2 = 0;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 17;
						}
						continue;
					case 159:
						array5[0] = 126;
						num = 91;
						break;
					case 169:
						if (P_1 == -1)
						{
							num2 = 228;
							continue;
						}
						goto case 290;
					case 212:
						array2[3] = array6[1];
						num2 = 145;
						continue;
					case 71:
						array4[14] = (byte)num3;
						num2 = 108;
						continue;
					case 196:
						return;
					case 215:
						array5[8] = (byte)num5;
						num2 = 31;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 69;
						}
						continue;
					case 146:
						array4[24] = 124;
						num2 = 185;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 264;
						}
						continue;
					case 349:
						array4[6] = (byte)num3;
						num2 = 125;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 248;
						}
						continue;
					case 260:
						array4[25] = 199;
						num2 = 147;
						continue;
					case 46:
						num4 = 121 + 124;
						num2 = 162;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 141;
						}
						continue;
					case 311:
						array6 = (byte[])osHuZWD1Pq7EdBLCv8(YHO7hTExRUcplbFuCy(CZv1qnelN));
						num2 = 231;
						continue;
					case 82:
						array5[12] = 92;
						num2 = 122;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 17;
						}
						continue;
					case 23:
						array5[10] = (byte)num5;
						num2 = 176;
						continue;
					case 3:
						array4[5] = 66;
						num2 = 47;
						continue;
					case 92:
						num4 = 229 - 76;
						num2 = 55;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 318;
						}
						continue;
					case 81:
						array4[10] = (byte)num4;
						num = 40;
						break;
					case 334:
						array5[13] = (byte)num5;
						num2 = 57;
						continue;
					case 290:
						if (AdgT0ro4mq5wpRWoRy(CZv1qnelN) != null)
						{
							num2 = 64;
							continue;
						}
						goto case 65;
					case 31:
						array5[13] = 168;
						num2 = 62;
						continue;
					case 154:
						array4[27] = (byte)num4;
						num2 = 92;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 245;
						}
						continue;
					case 51:
						array2[15] = array6[7];
						num2 = 49;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 133;
						}
						continue;
					case 190:
						num3 = 78 + 99;
						num2 = 349;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 225;
						}
						continue;
					case 132:
						array4[31] = 122;
						num2 = 164;
						continue;
					case 25:
						array4[17] = 225;
						num2 = 267;
						continue;
					case 263:
						array4[17] = 86;
						num2 = 129;
						continue;
					case 346:
						array4[22] = 140;
						num2 = 90;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 3;
						}
						continue;
					case 112:
						array4[9] = (byte)num3;
						num2 = 19;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 37;
						}
						continue;
					case 13:
						num6 = 211 - 70;
						num2 = 286;
						continue;
					case 84:
					case 133:
						num7 = 0;
						num2 = 74;
						continue;
					case 279:
						array4[4] = 155;
						num2 = 292;
						continue;
					case 209:
						array5[0] = (byte)num6;
						num = 155;
						break;
					case 66:
						array4[4] = (byte)num3;
						num2 = 200;
						continue;
					case 36:
						array4[29] = 215;
						num2 = 250;
						continue;
					case 328:
						array5[13] = (byte)num6;
						num2 = 9;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 31;
						}
						continue;
					case 227:
						array2[1] = array6[0];
						num2 = 212;
						continue;
					case 58:
						array5[7] = (byte)num6;
						num2 = 97;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 251;
						}
						continue;
					case 298:
						array4[30] = (byte)num3;
						num2 = 89;
						if (tkCy8Yydv5lcj0o3KU() != null)
						{
							num2 = 72;
						}
						continue;
					case 6:
						array4[16] = 22;
						num2 = 167;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 183;
						}
						continue;
					case 15:
						num3 = 139 - 46;
						num2 = 238;
						continue;
					case 99:
						num3 = 226 - 75;
						num2 = 148;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 197;
						}
						continue;
					case 35:
						array5[9] = (byte)num6;
						num2 = 296;
						continue;
					case 252:
						array5[8] = (byte)num6;
						num2 = 240;
						continue;
					case 235:
						num3 = 166 - 55;
						num2 = 178;
						continue;
					case 345:
						array5[6] = 99;
						num2 = 24;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 6;
						}
						continue;
					case 90:
						array4[22] = 115;
						num2 = 102;
						continue;
					case 259:
						num5 = 50 + 84;
						num = 41;
						break;
					case 330:
						array4[2] = 158;
						num2 = 282;
						continue;
					case 300:
						array4[8] = (byte)num3;
						num2 = 100;
						continue;
					case 241:
						num4 = 206 - 68;
						num2 = 306;
						continue;
					case 222:
						num4 = 147 - 49;
						num2 = 168;
						continue;
					case 307:
						array4[23] = 138;
						num = 287;
						break;
					case 40:
						array4[11] = 153;
						num2 = 123;
						continue;
					case 347:
						array4[15] = (byte)num4;
						num2 = 130;
						if (!V0J3M5lhHEwGCilv91())
						{
							num2 = 123;
						}
						continue;
					case 284:
						array5[1] = 88;
						num = 305;
						break;
					case 185:
						array4[15] = (byte)num4;
						num2 = 49;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 299;
						}
						continue;
					case 281:
						array5[0] = 238;
						num2 = 167;
						continue;
					case 243:
						array4[10] = 164;
						num2 = 37;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 148;
						}
						continue;
					case 89:
						num3 = 100 + 120;
						num2 = 94;
						continue;
					case 143:
						array5[2] = 33;
						num2 = 259;
						continue;
					case 199:
						num4 = 70 + 75;
						num2 = 293;
						continue;
					case 153:
						num3 = 30 + 12;
						num2 = 130;
						if (V0J3M5lhHEwGCilv91())
						{
							num2 = 182;
						}
						continue;
					case 61:
						num3 = 174 + 74;
						num2 = 20;
						if (tkCy8Yydv5lcj0o3KU() == null)
						{
							num2 = 39;
						}
						continue;
					case 64:
					case 233:
						new Ni7vpKpZVHGkY9ZkUb().mqtJcO6oA(array, array2, array3);
						num2 = 196;
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string v8Sa8hFQ7(int P_0)
		{
			if (qOODpkZqqL.Length == 0)
			{
				uFeDDwOkp4 = new List<string>();
				kRIDX1cg3I = new List<int>();
				LYM7HWeev(CZv1qnelN.GetManifestResourceStream("Z5moGj8xIc6qu3YH1J.SGTInLkEliyg1aS6Np"), P_0);
			}
			if (aIJzkjDFF < 75)
			{
				if ((object)CZv1qnelN != new StackFrame(1).GetMethod().DeclaringType.Assembly)
				{
					throw new Exception();
				}
				aIJzkjDFF++;
			}
			lock (WnIDE9Dy4a)
			{
				int num = BitConverter.ToInt32(qOODpkZqqL, P_0);
				if (num < kRIDX1cg3I.Count && kRIDX1cg3I[num] == P_0)
				{
					return uFeDDwOkp4[num];
				}
				try
				{
					z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
					byte[] array = new byte[num];
					Array.Copy(qOODpkZqqL, P_0 + 4, array, 0, num);
					string text = Encoding.Unicode.GetString(array, 0, array.Length);
					uFeDDwOkp4.Add(text);
					kRIDX1cg3I.Add(P_0);
					Array.Copy(BitConverter.GetBytes(uFeDDwOkp4.Count - 1), 0, qOODpkZqqL, P_0, 4);
					return text;
				}
				catch
				{
				}
			}
			return "";
		}

		internal static string EbSURpKkd(string P_0)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(P_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		private static int V2OuYgXkD()
		{
			return 5;
		}

		private static void nIXet1r3W()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private static Delegate hu4AKlcw8(IntPtr P_0, Type P_1)
		{
			return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
			{
				typeof(IntPtr),
				typeof(Type)
			}).Invoke(null, new object[2] { P_0, P_1 });
		}

		internal static object PBu28H92I(object P_0)
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
		public static extern IntPtr gEmOxjevy(string P_0);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
		public static extern IntPtr VP6qaWD67(IntPtr P_0, string P_1);

		private static IntPtr HhKmApbqM(IntPtr P_0, string P_1, uint P_2)
		{
			if (kI5DaW4SX1 == null)
			{
				kI5DaW4SX1 = (m4aUFeOwOkp4TRI1cg)Marshal.GetDelegateForFunctionPointer(VP6qaWD67(xMpiFL8WN(), "Find ".Trim() + "ResourceA"), typeof(m4aUFeOwOkp4TRI1cg));
			}
			return kI5DaW4SX1(P_0, P_1, P_2);
		}

		private static IntPtr CQ8KpwfmW(IntPtr P_0, uint P_1, uint P_2, uint P_3)
		{
			if (U2EDUHEjUA == null)
			{
				U2EDUHEjUA = (iInOOkqZqqLVVdCREQ)Marshal.GetDelegateForFunctionPointer(VP6qaWD67(xMpiFL8WN(), "Virtual ".Trim() + "Alloc"), typeof(iInOOkqZqqLVVdCREQ));
			}
			return U2EDUHEjUA(P_0, P_1, P_2, P_3);
		}

		private static int qhOPNI5hK(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
		{
			if (DvBDuE2TTq == null)
			{
				DvBDuE2TTq = (Dw8HBnmXCA8lXSOsy2)Marshal.GetDelegateForFunctionPointer(VP6qaWD67(xMpiFL8WN(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(Dw8HBnmXCA8lXSOsy2));
			}
			return DvBDuE2TTq(P_0, P_1, P_2, P_3, out P_4);
		}

		private static int CyhNKtDhN(IntPtr P_0, int P_1, int P_2, ref int P_3)
		{
			if (Y4ADeFFv0O == null)
			{
				Y4ADeFFv0O = (Q1nGQEKglnvkt1baC5)Marshal.GetDelegateForFunctionPointer(VP6qaWD67(xMpiFL8WN(), "Virtual ".Trim() + "Protect"), typeof(Q1nGQEKglnvkt1baC5));
			}
			return Y4ADeFFv0O(P_0, P_1, P_2, ref P_3);
		}

		private static IntPtr lUWSIfCTM(uint P_0, int P_1, uint P_2)
		{
			if (bjuDAVmQVp == null)
			{
				bjuDAVmQVp = (bGkRoEPT5XjeqHu4v1)Marshal.GetDelegateForFunctionPointer(VP6qaWD67(xMpiFL8WN(), "Open ".Trim() + "Process"), typeof(bGkRoEPT5XjeqHu4v1));
			}
			return bjuDAVmQVp(P_0, P_1, P_2);
		}

		private static int XdZHBI9wM(IntPtr P_0)
		{
			if (DP7D6X9JBc == null)
			{
				DP7D6X9JBc = (Ox1Se2N1mmVAwAgOZx)Marshal.GetDelegateForFunctionPointer(VP6qaWD67(xMpiFL8WN(), "Close ".Trim() + "Handle"), typeof(Ox1Se2N1mmVAwAgOZx));
			}
			return DP7D6X9JBc(P_0);
		}

		[SpecialName]
		private static IntPtr xMpiFL8WN()
		{
			if (GS5D2iVFbv == IntPtr.Zero)
			{
				GS5D2iVFbv = gEmOxjevy("kernel ".Trim() + "32.dll");
			}
			return GS5D2iVFbv;
		}

		private static byte[] PlL5HuggP(string P_0)
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

		internal static Stream MQ4Q7Tmmn()
		{
			return new MemoryStream();
		}

		internal static byte[] odFM3MlAA(Stream P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		private static byte[] JEPhgwSRG(byte[] P_0)
		{
			Stream stream = MQ4Q7Tmmn();
			SymmetricAlgorithm symmetricAlgorithm = F0g3HioQ5();
			symmetricAlgorithm.Key = new byte[32]
			{
				179, 157, 24, 119, 96, 198, 145, 62, 159, 125,
				155, 123, 193, 179, 22, 94, 122, 59, 175, 166,
				198, 105, 221, 67, 173, 38, 171, 109, 227, 113,
				47, 55
			};
			symmetricAlgorithm.IV = new byte[16]
			{
				175, 210, 83, 6, 75, 59, 87, 98, 104, 7,
				156, 51, 59, 196, 75, 44
			};
			CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(P_0, 0, P_0.Length);
			cryptoStream.Close();
			byte[] result = odFM3MlAA(stream);
			z6oAH0ggHioQ5FY2RQ.rPZXSxnqb();
			return result;
		}

		private byte[] LSOxTDPd4()
		{
			return null;
		}

		private byte[] zF5CQkh7j()
		{
			return null;
		}

		private byte[] KgeL3cbxK()
		{
			_ = "{11111-22222-20001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] LUnr8VNMq()
		{
			_ = "{11111-22222-20001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] aAmja2lQk()
		{
			_ = "{11111-22222-30001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] NOGIFSrxI()
		{
			_ = "{11111-22222-30001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] E4qkSojnm()
		{
			_ = "{11111-22222-40001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] agJFCJ1xK()
		{
			_ = "{11111-22222-40001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] pgKVySW8L()
		{
			_ = "{11111-22222-50001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] XZnlOaWvV()
		{
			_ = "{11111-22222-50001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal static object sZX4F2dvd84yL5gZjR(object P_0)
		{
			return ((lLg4EI2JkjDFFcnI9D)P_0).f9UtU12u5A();
		}

		internal static void g04Qq8VXFYmisjEvyM(object P_0, long P_1)
		{
			((Stream)P_0).Position = P_1;
		}

		internal static long KiMRjsLIjV3RGrZs2f(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		internal static object xUK4juFGVqJLbnrMvC(object P_0, int P_1)
		{
			return ((lLg4EI2JkjDFFcnI9D)P_0).DhftB4KPc1(P_1);
		}

		internal static void Lm4b6WHetEH2UiZi4a(object P_0)
		{
			((lLg4EI2JkjDFFcnI9D)P_0).EoxtaWgEXn();
		}

		internal static void QeDaco1htdOt8QduCl(object P_0)
		{
			Array.Reverse((Array)P_0);
		}

		internal static object YHO7hTExRUcplbFuCy(object P_0)
		{
			return ((Assembly)P_0).GetName();
		}

		internal static object osHuZWD1Pq7EdBLCv8(object P_0)
		{
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		internal static object kxLUlYqMGA85PR2VQj()
		{
			return F0g3HioQ5();
		}

		internal static void wjb4mDP4a8wJGIICFB(object P_0, CipherMode P_1)
		{
			((SymmetricAlgorithm)P_0).Mode = P_1;
		}

		internal static object YEDMVZMDb5LBJ6ea53(object P_0, object P_1, object P_2)
		{
			return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
		}

		internal static object PpeFMIA2cYC7mZ8ces()
		{
			return MQ4Q7Tmmn();
		}

		internal static void s0XvAasS1Q7JC1idN8(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void vvp32gNe0WwkQnWRb8(object P_0)
		{
			((CryptoStream)P_0).FlushFinalBlock();
		}

		internal static object t4O6d5uX2jh16aVGww(object P_0)
		{
			return odFM3MlAA((Stream)P_0);
		}

		internal static void ajByiqZFfbQAQAl8vV(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object AdgT0ro4mq5wpRWoRy(object P_0)
		{
			return ((Assembly)P_0).EntryPoint;
		}

		internal static bool V0J3M5lhHEwGCilv91()
		{
			return null == null;
		}

		internal static object tkCy8Yydv5lcj0o3KU()
		{
			return null;
		}
	}
}
namespace POCTPEZfZcdnRff0Gn
{
	internal class z6oAH0ggHioQ5FY2RQ
	{
		private static bool DqZDOydcoF;

		internal static void rPZXSxnqb()
		{
			if (!DqZDOydcoF)
			{
				DqZDOydcoF = true;
				if (Math.Sign((DateTime.Now - new DateTime(2026, 2, 22)).Days) >= 14)
				{
					throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
				}
			}
		}
	}
}
internal sealed class <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}
{
	internal int m_0470da84d1cb4450af0e1948c18ea480;

	internal int m_72d5401ec49f4680b7a120e5d2514666;

	internal int m_3a0c862fe82444889037de65d0c68a82;

	internal int m_a3092932ecaa472abc946f42fe030ee3;

	internal int m_972e97c1df2943e6a0543978be76fd6c;

	internal int m_036ecd56c413453d95555d1b761e3d28;

	internal int m_9844ec19872343f1baa97e1d17447f31;

	internal int m_864f861b49a54ce8b9cb0cfbe242b02f;

	internal int m_493c9b46a07d4752a9f959f19ad30340;

	internal int m_855ff5850741436292d316ba6d3a00f5;

	internal int m_c9f5384b03b94ff9a3af6046e3d50640;

	internal int m_84bd11efa6124fe99b417b6698ab958f;

	internal int m_b543bd462760415fa9f1bb3e2ba87be2;

	internal int m_ad7b134bbd794b99b516d3b9f1c04884;

	internal int m_57b6f81a1d6942f59a14857ef9402351;

	internal int m_3f4b60adc68f47218a239f80e823a5ef;

	internal int m_dd1eb759079343049168347da943d75a;

	internal int m_61fa5f78516c4072baece1fd3c2b7b80;

	internal int m_dd4a8773a91a44c4ac1bdef8eb9e88aa;

	internal int m_81154e6dfb7f4734a8e704ec816c23a1;

	internal int m_d054a247ea17451180af29c7ae44dc81;

	internal int m_6286881d964346908cb51ea221fef546;

	internal int m_dea9a02eb6974f888b29cde89061f0d0;

	internal int m_e4d35dd47e2042c7884d4202f0f8f99e;

	internal int m_6a04cf2c08b34e2ab5fba0dc7a58b160;

	internal int m_7d8e206f6acf4aecb56289bb89b6d982;

	internal int m_dc13ebaa68544782943f4f33934a5676;

	internal int m_2394459c5a4941cca69bc037fcc08187;

	internal int m_21cbf90e4d764705b2e9e6903aa5355e;

	internal int m_9b57db20f46042d7b04b65c29a91db78;

	internal int m_361eda792ed14853ad89b1134cc943f1;

	internal int m_9432e344089b4a3fb02c9a18deaddb38;

	internal int m_f49a6982f85e4ae1bbafab2f72901189;

	internal int m_b30803cf82684e938c47b64254157aea;

	internal int m_91ba7d618cb74def8b0929e162a07539;

	internal int m_7a9955aa638d41b7a1fc55464aeb0502;

	internal int m_815dcf1a432e40d3ad84bf62bcf3b91c;

	internal int m_8f5772bb7cf64d2a9d0731eeec3a81ff;

	internal int m_028c7ce2bbf3464caaa2e696d8d4c5c8;

	internal int m_65edf8cb719c4ad781ec64a8cb344f7a;

	internal int m_1e2109022b5047b78770c369a1688d63;

	internal int m_e572b96f1c034ed9be9ad44f9702ca1d;

	internal int m_7e215b6140f04526a852642223990dbe;

	internal int m_788db739d6f8473b92ee631d624dc9a6;

	internal int m_dac4dce665fb455e8e4f9e4b3445bd12;

	internal int m_9133c818a2b5438d878b930dabb8b8b5;

	internal int m_f7376b50178146c695803f9b26eb6f23;

	internal int m_2bf14d10db3242c295a8040b00b735b9;

	internal int m_0c4e4696ea324d85a3c75d85b317cc7c;

	internal static <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b} m_e704b67b91414e74941b79e0bc66fcaf;

	internal int m_017da7eb20f44e6585f9322994d67c13;

	internal int m_6dc40cb450ff4ae38d008b8a0a16b6e3;

	internal int m_81bbd530c9d34c4e871339fe33ec6549;

	internal int m_5b68586c168c4e4f98e4cee79935d719;

	internal int m_1fd77fefa3874e908817eade73c33f42;

	internal int m_b6c3fcabd69549be940f63596e9d6cd3;

	internal int m_00e70dae6e2f43939c134fe982b1b544;

	internal int m_6ed89ede5c504d98a1ed577062ce30a9;

	internal int m_fed7a1e1d45746b5be8db10fae27d2b0;

	internal int m_0deff9385c6943d187b7d66d4226de76;

	internal int m_e2a113023a244d35b12192d4194d2aa5;

	internal int m_f68d4e736d81482e8552c10af220f9b3;

	internal int m_4af71c14af9646ea8dfc48d408f4a9a0;

	internal int m_3991fbacc3db4082bafa408d27bd5d0e;

	internal int m_272e1e79de334b158a546ad09a779130;

	internal int m_4c24d9f86ef841a98ec42ea4757f00e1;

	internal int m_09fff2c3704c44b7b9814dc6aebc2a5c;

	internal int m_8c76c1479aad46bc8bd2847b06260aae;

	internal int m_ad350cabaa7d434b9e8da89f6df02dfe;

	internal int m_2ffc3b07cce44cca887a9859967cb583;

	internal int m_bd9cba1a9ae34b99832a02c9fcd82e54;

	internal int m_31b8f50ffbfa41f6bd05863592e3406b;

	internal int m_00a87fefa7344d0ebf46d618fb8b75db;

	internal int m_92b2d5cd7f89418db57fa57a45e7b03f;

	internal int m_84e098bd8d784dddaaf258c651ce1b20;

	internal int m_0cc248683079436c93981a542f719eae;

	internal int m_963bc12783ed4e67ae6cdebc9561aa01;

	internal int m_0f9de3c03a614c969ad05b343243148a;

	internal int m_08f04dd0bb794120bbaadb4224b0c451;

	internal int m_01e99e70540e425091e2f787240a7007;

	internal int m_a804713ab8a5461bb67d7a984a750d46;

	internal int m_d27226ec5c5743d2a279b7fb75f53eee;

	internal int m_6596eb633afa477082d52b04f5642b40;

	internal int m_11c5bacfd15943e5b5a4ca1dc1a43a12;

	internal int m_b503c96f499b4cb49a19be19b7cadabb;

	internal int m_66590c35c69a44caac4d3a8ebafc3424;

	internal int m_363d7b8a86e54a80971bda354ad29d84;

	internal int m_ac1b43ce705547b886924a6aa1695002;

	internal int m_c398577fff49453f979e0fa63af14be5;

	internal int m_ca8443b5292341f6a3c0de11b8f9429b;

	internal int m_422f85536c544e78a4fcb4f881ecc3f7;

	internal int m_1256cce1f5dd4e14abd015567abcc386;

	internal int m_18f5939d92e9455e906bfdd2f1dddc5c;

	internal int m_43eafb7d54524098b4a62cc09c7aba61;

	internal int m_f856686fb1174e32ad8c47271fb239cd;

	internal int m_100a1ccec23a4479b89de4ac85919e09;

	internal int m_b19e35bb6ceb4be6afe851dcdd791a9e;

	internal int m_4f0bf5183cb942b5be8a13cbebd43f5e;

	internal int m_3d509c7bc48e4d4ba89015cf13c928ae;

	internal int m_43cfc00ae4a9456c96efb4970b8482bb;

	internal int m_e65203bc302b463f8bd908842030fdf7;

	internal int m_2d299cf9155c461ba600512a488675b8;

	internal int m_0266179245c849d08e306baa61ab29a1;

	internal int m_3d6123ebb8534333ac7989c21ca21bbe;

	internal int m_ea8702e62beb4762aeb29eb7da4ba185;

	internal int m_a7d69614090f41d08b740ccad76d355e;

	internal int m_cb7161ab4b0941729c90f6f3457c8ab2;

	internal int m_fe3373ce374b4efc85d17b7d1454784f;

	internal int m_464abf8754fc4143b2e55113bbbacb16;

	internal int m_3d156dc9137c48f7ba55c2c62bef0dbb;

	internal int m_a72ea75ce4c0401b9dc989973e0f1b7b;

	internal int m_09a1781c6fd843c89ab7dc25a51cc05e;

	internal int m_b1dcb4e900fe4f7d98b9427c5d78f685;

	internal int m_31664721ec354bb4b116f930a45df5de;

	internal int m_7b5f653d7fe54631b16e5d79370bd977;

	internal int m_0befc0c44a7647439969e7608d1fdf34;

	internal int m_ff8447b616b34fa4951adbbb397c3fb6;

	internal int m_d8e135242465443d99a5a51ce062be8e;

	internal int m_6b90621226d64853903c17cf1f306d4f;

	internal int m_21c6d5e38d024d27a16b170a37f809f3;

	internal int m_11c34a60e7a1423eb634d014e13da969;

	internal int m_b5d4ff5d81224edf89bc14efc29175b5;

	internal int m_701bfa1500e4470280d2578a0b861a68;

	internal int m_232c04c20cb540caac5ed344328d700f;

	internal int m_a490893c5d6443c5b31f9fae6992ba06;

	internal int m_def4cebe474e4711bec47b2f0ccb3bf5;

	internal int m_1536985e7afc4ac68cb9c6bc54c6c710;

	static <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}()
	{
		p80a86f2904b043b89a417ca4d0f80688();
	}

	internal static void p80a86f2904b043b89a417ca4d0f80688()
	{
		m_e704b67b91414e74941b79e0bc66fcaf = new <Module>{4e6c4e3e-445d-4173-b395-16e6bdbea19b}();
		m_e704b67b91414e74941b79e0bc66fcaf.m_09fff2c3704c44b7b9814dc6aebc2a5c = -(-1502809263) ^ 0x59930CAF;
		m_e704b67b91414e74941b79e0bc66fcaf.m_72d5401ec49f4680b7a120e5d2514666 = 0x88B1F06 ^ 0x7BEFA593;
		m_e704b67b91414e74941b79e0bc66fcaf.m_bd9cba1a9ae34b99832a02c9fcd82e54 = -1461328264 ^ -1461328264;
		m_e704b67b91414e74941b79e0bc66fcaf.m_57b6f81a1d6942f59a14857ef9402351 = 0x257680 ^ 0x257680;
		m_e704b67b91414e74941b79e0bc66fcaf.m_65edf8cb719c4ad781ec64a8cb344f7a = -1458228238 ^ -1876320762;
		m_e704b67b91414e74941b79e0bc66fcaf.m_361eda792ed14853ad89b1134cc943f1 = -944372038 ^ -944372038;
		m_e704b67b91414e74941b79e0bc66fcaf.m_1fd77fefa3874e908817eade73c33f42 = 0x88B1F06 ^ 0x4F0150A4;
		m_e704b67b91414e74941b79e0bc66fcaf.m_11c5bacfd15943e5b5a4ca1dc1a43a12 = -1416750502 ^ -722560642;
		m_e704b67b91414e74941b79e0bc66fcaf.m_2d299cf9155c461ba600512a488675b8 = 0xC21F8B ^ 0x52202930;
		m_e704b67b91414e74941b79e0bc66fcaf.m_a72ea75ce4c0401b9dc989973e0f1b7b = 0x88B1F06 ^ 0x88B1F06;
		m_e704b67b91414e74941b79e0bc66fcaf.m_21c6d5e38d024d27a16b170a37f809f3 = 0x178BE4D ^ 0x178BE4D;
		m_e704b67b91414e74941b79e0bc66fcaf.m_b1dcb4e900fe4f7d98b9427c5d78f685 = 0x7F83CDF0 ^ 0x6997026A;
		m_e704b67b91414e74941b79e0bc66fcaf.m_0befc0c44a7647439969e7608d1fdf34 = -1795542249 ^ -1804535958;
		m_e704b67b91414e74941b79e0bc66fcaf.m_01e99e70540e425091e2f787240a7007 = 0x75D42A8F ^ 0x4A3A2BD4;
		m_e704b67b91414e74941b79e0bc66fcaf.m_e65203bc302b463f8bd908842030fdf7 = -1416750502 ^ -1765789053;
		m_e704b67b91414e74941b79e0bc66fcaf.m_1536985e7afc4ac68cb9c6bc54c6c710 = -(-142462249) ^ 0x87DCD29;
		m_e704b67b91414e74941b79e0bc66fcaf.m_21cbf90e4d764705b2e9e6903aa5355e = -(~2104733361) ^ 0x6FE3274B;
		m_e704b67b91414e74941b79e0bc66fcaf.m_b5d4ff5d81224edf89bc14efc29175b5 = -1470169294 ^ -1470169294;
		m_e704b67b91414e74941b79e0bc66fcaf.m_a490893c5d6443c5b31f9fae6992ba06 = 0x32F93DA8 ^ 0x32F93DA8;
		m_e704b67b91414e74941b79e0bc66fcaf.m_2ffc3b07cce44cca887a9859967cb583 = -1700583660 ^ -1700678112;
		m_e704b67b91414e74941b79e0bc66fcaf.m_91ba7d618cb74def8b0929e162a07539 = -746319681 ^ -1108407301;
		m_e704b67b91414e74941b79e0bc66fcaf.m_2394459c5a4941cca69bc037fcc08187 = -1104050192 ^ -1048694650;
		m_e704b67b91414e74941b79e0bc66fcaf.m_0470da84d1cb4450af0e1948c18ea480 = -25433826 ^ -1131394612;
		m_e704b67b91414e74941b79e0bc66fcaf.m_6286881d964346908cb51ea221fef546 = -1268839773 ^ -955034472;
		m_e704b67b91414e74941b79e0bc66fcaf.m_e572b96f1c034ed9be9ad44f9702ca1d = 0x75D42A8F ^ 0x75D42A8F;
		m_e704b67b91414e74941b79e0bc66fcaf.m_963bc12783ed4e67ae6cdebc9561aa01 = -1416750502 ^ -349947066;
		m_e704b67b91414e74941b79e0bc66fcaf.m_31b8f50ffbfa41f6bd05863592e3406b = 0x462D7332 ^ 0x7ABBDC55;
		m_e704b67b91414e74941b79e0bc66fcaf.m_18f5939d92e9455e906bfdd2f1dddc5c = -1390805168 ^ -1390805168;
		m_e704b67b91414e74941b79e0bc66fcaf.m_61fa5f78516c4072baece1fd3c2b7b80 = -(-960911721) ^ 0x72450D6E;
		m_e704b67b91414e74941b79e0bc66fcaf.m_0deff9385c6943d187b7d66d4226de76 = 0x88B1F06 ^ 0x88B1F06;
		m_e704b67b91414e74941b79e0bc66fcaf.m_464abf8754fc4143b2e55113bbbacb16 = -(-1502809263) ^ 0x54319BCB;
		m_e704b67b91414e74941b79e0bc66fcaf.m_e2a113023a244d35b12192d4194d2aa5 = 0x544ED807 ^ 0x544ED807;
		m_e704b67b91414e74941b79e0bc66fcaf.m_4af71c14af9646ea8dfc48d408f4a9a0 = -1590343280 ^ -1590343280;
		m_e704b67b91414e74941b79e0bc66fcaf.m_ac1b43ce705547b886924a6aa1695002 = -1704898236 ^ -631465375;
		m_e704b67b91414e74941b79e0bc66fcaf.m_2bf14d10db3242c295a8040b00b735b9 = 0xBB4E800 ^ 0xBB4E800;
		m_e704b67b91414e74941b79e0bc66fcaf.m_92b2d5cd7f89418db57fa57a45e7b03f = -455165232 ^ -783695692;
		m_e704b67b91414e74941b79e0bc66fcaf.m_6ed89ede5c504d98a1ed577062ce30a9 = 0x350E11F ^ 0x65CEBCA7;
		m_e704b67b91414e74941b79e0bc66fcaf.m_dd1eb759079343049168347da943d75a = -(1688924092 << 1) ^ 0x36AA2088;
		m_e704b67b91414e74941b79e0bc66fcaf.m_dac4dce665fb455e8e4f9e4b3445bd12 = -(-1502809263) ^ 0x59930CAF;
		m_e704b67b91414e74941b79e0bc66fcaf.m_11c34a60e7a1423eb634d014e13da969 = -(-434626815) ^ 0x19E7E0FF;
		m_e704b67b91414e74941b79e0bc66fcaf.m_43eafb7d54524098b4a62cc09c7aba61 = (-(-1417199179) + -1494602483) ^ -1011728401;
		m_e704b67b91414e74941b79e0bc66fcaf.m_ea8702e62beb4762aeb29eb7da4ba185 = -1724578817 ^ -810896648;
		m_e704b67b91414e74941b79e0bc66fcaf.m_08f04dd0bb794120bbaadb4224b0c451 = -1795542249 ^ -1823119172;
		m_e704b67b91414e74941b79e0bc66fcaf.m_d8e135242465443d99a5a51ce062be8e = -32767641 ^ -32767641;
		m_e704b67b91414e74941b79e0bc66fcaf.m_3991fbacc3db4082bafa408d27bd5d0e = -2023631824 ^ -1081366316 ^ 0x38EA7CE4;
		m_e704b67b91414e74941b79e0bc66fcaf.m_701bfa1500e4470280d2578a0b861a68 = -29869273 ^ -29869273;
		m_e704b67b91414e74941b79e0bc66fcaf.m_100a1ccec23a4479b89de4ac85919e09 = -1234552472 ^ -1234552472;
		m_e704b67b91414e74941b79e0bc66fcaf.m_8f5772bb7cf64d2a9d0731eeec3a81ff = 0x7F83CDF0 ^ 0x7F83CDF0;
		m_e704b67b91414e74941b79e0bc66fcaf.m_cb7161ab4b0941729c90f6f3457c8ab2 = 0x208489BB ^ 0x208489BB;
		m_e704b67b91414e74941b79e0bc66fcaf.m_815dcf1a432e40d3ad84bf62bcf3b91c = -898152457 ^ -898152457;
		m_e704b67b91414e74941b79e0bc66fcaf.m_422f85536c544e78a4fcb4f881ecc3f7 = 0x2B2D7C58 ^ 0x1A3F59C5;
		m_e704b67b91414e74941b79e0bc66fcaf.m_31664721ec354bb4b116f930a45df5de = -(1688924092 << 1) ^ 0x7AA74102;
		m_e704b67b91414e74941b79e0bc66fcaf.m_7e215b6140f04526a852642223990dbe = -2024614690 ^ -2024614690;
		m_e704b67b91414e74941b79e0bc66fcaf.m_0266179245c849d08e306baa61ab29a1 = -1590343280 ^ -1590343280;
		m_e704b67b91414e74941b79e0bc66fcaf.m_def4cebe474e4711bec47b2f0ccb3bf5 = -2024614690 ^ -2024614690;
		m_e704b67b91414e74941b79e0bc66fcaf.m_c9f5384b03b94ff9a3af6046e3d50640 = (-(-1204370595) << 6) ^ -229693248;
		m_e704b67b91414e74941b79e0bc66fcaf.m_3d509c7bc48e4d4ba89015cf13c928ae = -(-960911721) ^ 0x39465969;
		m_e704b67b91414e74941b79e0bc66fcaf.m_dd4a8773a91a44c4ac1bdef8eb9e88aa = -1268839773 ^ -340937536;
		m_e704b67b91414e74941b79e0bc66fcaf.m_c398577fff49453f979e0fa63af14be5 = -824092533 ^ -824092533;
		m_e704b67b91414e74941b79e0bc66fcaf.m_028c7ce2bbf3464caaa2e696d8d4c5c8 = -32767641 ^ -265633232;
		m_e704b67b91414e74941b79e0bc66fcaf.m_66590c35c69a44caac4d3a8ebafc3424 = -(-1343847236) ^ 0x4A0C7EB1 ^ 0x1A1505F5;
		m_e704b67b91414e74941b79e0bc66fcaf.m_4c24d9f86ef841a98ec42ea4757f00e1 = 0x88B1F06 ^ 0x60251319;
		m_e704b67b91414e74941b79e0bc66fcaf.m_ff8447b616b34fa4951adbbb397c3fb6 = -25433826 ^ -25433826;
		m_e704b67b91414e74941b79e0bc66fcaf.m_9133c818a2b5438d878b930dabb8b8b5 = -1458228238 ^ -1458228238;
		m_e704b67b91414e74941b79e0bc66fcaf.m_f49a6982f85e4ae1bbafab2f72901189 = 0x625F760 ^ 0x625F760;
		m_e704b67b91414e74941b79e0bc66fcaf.m_0c4e4696ea324d85a3c75d85b317cc7c = -1795542249 ^ -1706081749;
		m_e704b67b91414e74941b79e0bc66fcaf.m_ca8443b5292341f6a3c0de11b8f9429b = 0x32F93DA8 ^ 0x2D8F20C8;
		m_e704b67b91414e74941b79e0bc66fcaf.m_b6c3fcabd69549be940f63596e9d6cd3 = 0x3CEA3C42 ^ 0x3CEA3C42;
		m_e704b67b91414e74941b79e0bc66fcaf.m_6596eb633afa477082d52b04f5642b40 = 0x625F760 ^ 0xB1CD699;
		m_e704b67b91414e74941b79e0bc66fcaf.m_8c76c1479aad46bc8bd2847b06260aae = 0x63072DBD ^ 0x18F0067E;
		m_e704b67b91414e74941b79e0bc66fcaf.m_f68d4e736d81482e8552c10af220f9b3 = -2023631824 ^ -1081366316 ^ 0x4B8A0402;
		m_e704b67b91414e74941b79e0bc66fcaf.m_1e2109022b5047b78770c369a1688d63 = -1187397520 ^ -1807632144;
		m_e704b67b91414e74941b79e0bc66fcaf.m_fe3373ce374b4efc85d17b7d1454784f = 0x6F66AACF ^ 0x6F66AACF;
		m_e704b67b91414e74941b79e0bc66fcaf.m_81bbd530c9d34c4e871339fe33ec6549 = 0xC21F8B ^ 0x3B99A526;
		m_e704b67b91414e74941b79e0bc66fcaf.m_84bd11efa6124fe99b417b6698ab958f = 0x326E3F4C ^ 0x47996148;
		m_e704b67b91414e74941b79e0bc66fcaf.m_09a1781c6fd843c89ab7dc25a51cc05e = -1704898236 ^ -1704898236;
		m_e704b67b91414e74941b79e0bc66fcaf.m_9b57db20f46042d7b04b65c29a91db78 = -25433826 ^ -915952018;
		m_e704b67b91414e74941b79e0bc66fcaf.m_e4d35dd47e2042c7884d4202f0f8f99e = -132187392 ^ -132187392;
		m_e704b67b91414e74941b79e0bc66fcaf.m_9844ec19872343f1baa97e1d17447f31 = -(1688924092 << 1) ^ 0x36AA2088;
		m_e704b67b91414e74941b79e0bc66fcaf.m_a7d69614090f41d08b740ccad76d355e = -25433826 ^ -25433826;
		m_e704b67b91414e74941b79e0bc66fcaf.m_6a04cf2c08b34e2ab5fba0dc7a58b160 = -1590343280 ^ -1955429991;
		m_e704b67b91414e74941b79e0bc66fcaf.m_b19e35bb6ceb4be6afe851dcdd791a9e = -1590343280 ^ -738056755;
		m_e704b67b91414e74941b79e0bc66fcaf.m_3f4b60adc68f47218a239f80e823a5ef = -1470169294 ^ -1470169294;
		m_e704b67b91414e74941b79e0bc66fcaf.m_00e70dae6e2f43939c134fe982b1b544 = 0x7F83CDF0 ^ 0x7FBC2DEB;
		m_e704b67b91414e74941b79e0bc66fcaf.m_232c04c20cb540caac5ed344328d700f = -(-1502809263) ^ 0x59930CAF;
		m_e704b67b91414e74941b79e0bc66fcaf.m_3d156dc9137c48f7ba55c2c62bef0dbb = 0x2B2D7C58 ^ 0x2B2D7C58;
		m_e704b67b91414e74941b79e0bc66fcaf.m_363d7b8a86e54a80971bda354ad29d84 = 0x355E00C ^ 0x66DC2F08;
		m_e704b67b91414e74941b79e0bc66fcaf.m_272e1e79de334b158a546ad09a779130 = -1390805168 ^ -1390805168;
		m_e704b67b91414e74941b79e0bc66fcaf.m_788db739d6f8473b92ee631d624dc9a6 = -1704898236 ^ -1404156467;
		m_e704b67b91414e74941b79e0bc66fcaf.m_d27226ec5c5743d2a279b7fb75f53eee = -(-1502809263) ^ 0x59930CAF;
		m_e704b67b91414e74941b79e0bc66fcaf.m_3d6123ebb8534333ac7989c21ca21bbe = -(-434626815) ^ 0x19E7E0FF;
		m_e704b67b91414e74941b79e0bc66fcaf.m_7a9955aa638d41b7a1fc55464aeb0502 = 0x32F93DA8 ^ 0x3C663BC9;
		m_e704b67b91414e74941b79e0bc66fcaf.m_0f9de3c03a614c969ad05b343243148a = -45467058 ^ -715636257;
		m_e704b67b91414e74941b79e0bc66fcaf.m_7d8e206f6acf4aecb56289bb89b6d982 = -1771420883 ^ -1144480146;
		m_e704b67b91414e74941b79e0bc66fcaf.m_493c9b46a07d4752a9f959f19ad30340 = -898152457 ^ -2117744675;
		m_e704b67b91414e74941b79e0bc66fcaf.m_b503c96f499b4cb49a19be19b7cadabb = 0x257680 ^ 0x3B4FE569;
		m_e704b67b91414e74941b79e0bc66fcaf.m_a804713ab8a5461bb67d7a984a750d46 = (-(-1141494753) << 3) ^ 0xDBD44E0;
		m_e704b67b91414e74941b79e0bc66fcaf.m_972e97c1df2943e6a0543978be76fd6c = 0x552FC3F ^ 0x1BF001D4;
		m_e704b67b91414e74941b79e0bc66fcaf.m_f856686fb1174e32ad8c47271fb239cd = 0x326E3F4C ^ 0x34CC74AC;
		m_e704b67b91414e74941b79e0bc66fcaf.m_6dc40cb450ff4ae38d008b8a0a16b6e3 = 0x625F760 ^ 0x625F760;
		m_e704b67b91414e74941b79e0bc66fcaf.m_6b90621226d64853903c17cf1f306d4f = 0x19F37010 ^ 0x19F37010;
		m_e704b67b91414e74941b79e0bc66fcaf.m_dc13ebaa68544782943f4f33934a5676 = -1795542249 ^ -1795542249;
		m_e704b67b91414e74941b79e0bc66fcaf.m_9432e344089b4a3fb02c9a18deaddb38 = -1187397520 ^ -1187397520;
		m_e704b67b91414e74941b79e0bc66fcaf.m_a3092932ecaa472abc946f42fe030ee3 = -(1688924092 << 1) ^ 0x36AA2088;
		m_e704b67b91414e74941b79e0bc66fcaf.m_b543bd462760415fa9f1bb3e2ba87be2 = -(-87692013 ^ -1008114737) ^ -100204498;
		m_e704b67b91414e74941b79e0bc66fcaf.m_7b5f653d7fe54631b16e5d79370bd977 = 0xBB4E800 ^ 0x65649A6;
		m_e704b67b91414e74941b79e0bc66fcaf.m_00a87fefa7344d0ebf46d618fb8b75db = -1234552472 ^ -2007388238;
		m_e704b67b91414e74941b79e0bc66fcaf.m_5b68586c168c4e4f98e4cee79935d719 = 0x24A9DB55 ^ 0x286F8788;
		m_e704b67b91414e74941b79e0bc66fcaf.m_dea9a02eb6974f888b29cde89061f0d0 = -204124176 ^ -204124176;
		m_e704b67b91414e74941b79e0bc66fcaf.m_d054a247ea17451180af29c7ae44dc81 = 0x32F93DA8 ^ 0x32F93DA8;
		m_e704b67b91414e74941b79e0bc66fcaf.m_fed7a1e1d45746b5be8db10fae27d2b0 = 0x3513BCD3 ^ 0x357865EE;
		m_e704b67b91414e74941b79e0bc66fcaf.m_81154e6dfb7f4734a8e704ec816c23a1 = 0x32F93DA8 ^ 0x4213A331;
		m_e704b67b91414e74941b79e0bc66fcaf.m_ad350cabaa7d434b9e8da89f6df02dfe = -2023631824 ^ -1081366316 ^ 0x38EA7CE4;
		m_e704b67b91414e74941b79e0bc66fcaf.m_3a0c862fe82444889037de65d0c68a82 = -(~-525276700) ^ -1761489252;
		m_e704b67b91414e74941b79e0bc66fcaf.m_036ecd56c413453d95555d1b761e3d28 = -(~-525276700) ^ -525276699;
		m_e704b67b91414e74941b79e0bc66fcaf.m_f7376b50178146c695803f9b26eb6f23 = 0x355E00C ^ 0x355E00C;
		m_e704b67b91414e74941b79e0bc66fcaf.m_84e098bd8d784dddaaf258c651ce1b20 = 0xBB4E800 ^ 0xBB4E800;
		m_e704b67b91414e74941b79e0bc66fcaf.m_1256cce1f5dd4e14abd015567abcc386 = 0x355E00C ^ 0x355E00C;
		m_e704b67b91414e74941b79e0bc66fcaf.m_4f0bf5183cb942b5be8a13cbebd43f5e = 0x75D42A8F ^ 0x54043B90;
		m_e704b67b91414e74941b79e0bc66fcaf.m_017da7eb20f44e6585f9322994d67c13 = -2024614690 ^ -2024614690;
		m_e704b67b91414e74941b79e0bc66fcaf.m_43cfc00ae4a9456c96efb4970b8482bb = -204124176 ^ -1177411075;
		m_e704b67b91414e74941b79e0bc66fcaf.m_855ff5850741436292d316ba6d3a00f5 = 0x32F93DA8 ^ 0x12613BB0;
		m_e704b67b91414e74941b79e0bc66fcaf.m_864f861b49a54ce8b9cb0cfbe242b02f = -325381562 ^ -325381562;
		m_e704b67b91414e74941b79e0bc66fcaf.m_b30803cf82684e938c47b64254157aea = -1700583660 ^ -1700583660;
		m_e704b67b91414e74941b79e0bc66fcaf.m_0cc248683079436c93981a542f719eae = -325381562 ^ -581161918;
		m_e704b67b91414e74941b79e0bc66fcaf.m_ad7b134bbd794b99b516d3b9f1c04884 = -442083508 ^ -442083508;
	}
}
