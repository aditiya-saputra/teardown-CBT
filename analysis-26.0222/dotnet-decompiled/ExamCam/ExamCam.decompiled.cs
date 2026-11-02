using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
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
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ExamCam;
using ExamCam.Properties;
using LibraryExam;
using Newtonsoft.Json.Linq;
using RestSharp;
using fmqMvAFLAJh1RBBBBdw;
using lea45fRkMrnErfZSUlX;

[assembly: AssemblyTrademark("")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: AssemblyProduct("ExamCam")]
[assembly: ComVisible(false)]
[assembly: SuppressIldasm]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: Guid("5b24c047-e945-46fa-a631-a67fa575e750")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.DisableOptimizations | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints | DebuggableAttribute.DebuggingModes.EnableEditAndContinue)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyTitle("ExamCam")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyVersion("1.0.0.0")]
internal class <Module>
{
	private static bool f8DCB4D826AB6A71;

	internal static void m8DCB4D826AB6A71()
	{
		if (!f8DCB4D826AB6A71)
		{
			f8DCB4D826AB6A71 = true;
			if (Math.Sign((DateTime.Now - new DateTime(2024, 8, 4)).Days) >= 14)
			{
				throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
			}
		}
	}

	static <Module>()
	{
		m8DCB4D826AB6A71();
	}
}
namespace ExamCam
{
	public class Form1 : Form
	{
		public delegate void CaptureSnapshotManifast(Bitmap image);

		private FilterInfoCollection bKDUNFL9H;

		private VideoCaptureDevice IuXvNvo0N;

		private VideoCapabilities[] kHDN38qlx;

		private ArrayList HEIMcMnIT;

		public string pathFolder;

		private BackgroundWorker soMtl0d5u;

		private Stopwatch zybZhx3gE;

		private static bool A3mpRyuSQ;

		public string namafotosimpan;

		public string namaImage;

		private int XQwBLY6PT;

		private string cjO8xx9gW;

		public const SslProtocols _Tls12 = (SslProtocols)3072;

		public const SecurityProtocolType Tls12 = (SecurityProtocolType)3072;

		private static string UJyJbjESC;

		private string wcihcl2Xi;

		private IContainer wioHRdEZ9;

		private Panel xysyQjDyc;

		private Button eeyjSGrnP;

		private PictureBox ymWil21hB;

		private BackgroundWorker agLSXhXRi;

		private System.Windows.Forms.Timer KEA6BatUA;

		public string usbcamera
		{
			get
			{
				return UJyJbjESC;
			}
			set
			{
				UJyJbjESC = value;
			}
		}

		public Form1()
		{
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			HEIMcMnIT = new ArrayList();
			pathFolder = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x2D2B9055 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c0d6c5ba75554d0c9b9f44239137eb2b);
			zybZhx3gE = null;
			wcihcl2Xi = "";
			wioHRdEZ9 = null;
			base..ctor();
			U1j5WwGyh();
			TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x3FE6C3C2 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_431465af734a44679100076610fb698b));
		}

		private void VpRl4hUT9(object P_0, EventArgs P_1)
		{
			if (eeyjSGrnP.Tag.ToString() == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x47A18A50 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_975652dd350f409cadedf7ce7925aa1b))
			{
				Height = 33;
				eeyjSGrnP.Tag = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x12840EA1 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_48705551457045cf9e2c2f222f96f7cc);
			}
			else
			{
				Height = 187;
				eeyjSGrnP.Tag = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x6E132DC6 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c50d087b4bf64c2ab02de7d9a5c3826f);
			}
		}

		private void RqxG77xRL()
		{
			try
			{
				GetConfigure getConfigure = new GetConfigure();
				GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
				wcihcl2Xi = appConfig.ModeUjian;
				usbcamera = appConfig.namaWebcam;
				bKDUNFL9H = new FilterInfoCollection(FilterCategory.VideoInputDevice);
				if (bKDUNFL9H.Count != 0)
				{
					foreach (FilterInfo item in bKDUNFL9H)
					{
						HEIMcMnIT.Add(item.Name);
					}
				}
				else
				{
					try
					{
						Process[] processesByName = Process.GetProcessesByName(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(-801290702 ^ -1822120883 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4d551909784346a7b40161671b3cc259));
						foreach (Process process in processesByName)
						{
							process.Kill();
						}
					}
					catch
					{
					}
				}
				IuXvNvo0N = new VideoCaptureDevice(bKDUNFL9H[Convert.ToInt32(usbcamera)].MonikerString);
				kHDN38qlx = IuXvNvo0N.SnapshotCapabilities;
				if (kHDN38qlx.Length == 0)
				{
				}
				IuXvNvo0N.NewFrame += ierEKjDq1;
				IuXvNvo0N.Start();
				Thread.Sleep(7000);
				if (ymWil21hB.Image == null || ymWil21hB.Image.Width == 1)
				{
					Thread thread = new Thread(() =>
					{
						MessageBox.Show(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(-801290702 ^ -986213035 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_fb1f581aa21749f6b436f705bb702049), hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5FE155BD ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0260d5c31e634cce86323a1b230c41f8));
					});
					thread.Start();
					Thread.Sleep(15000);
					Process[] processesByName2 = Process.GetProcessesByName(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x6948B8DA ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae01ae78a7944cad96133fd0f7262991));
					foreach (Process process2 in processesByName2)
					{
						process2.Kill();
					}
				}
			}
			catch (Exception ex)
			{
				TulisLog(ex.ToString());
				MessageBox.Show(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5A16D354 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_45f85c7a24624948ac8d1e2d9d91fcdb) + ex.Message);
				Process[] processesByName3 = Process.GetProcessesByName(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x1A271533 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_2cdaf700d452430f8b7937a2df3c14ab));
				foreach (Process process3 in processesByName3)
				{
					process3.Kill();
				}
				Process.GetCurrentProcess().Kill();
			}
		}

		public void UpdateCaptureSnapshotManifast(Bitmap image)
		{
			try
			{
				A3mpRyuSQ = false;
				string text = namaImage + hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5A16D3E6 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_45f85c7a24624948ac8d1e2d9d91fcdb) + DateTime.Now.ToString(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x3FE6C356 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_431465af734a44679100076610fb698b)) + hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x512EC9AB ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_db9fde00cee841ca8bc26eac2c4289d1);
				if (Directory.Exists(pathFolder))
				{
					image.Save(pathFolder + text, ImageFormat.Jpeg);
					namafotosimpan = text;
				}
				else
				{
					Directory.CreateDirectory(pathFolder);
					image.Save(pathFolder + text, ImageFormat.Jpeg);
					namafotosimpan = text;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x2CC1DD99 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_74a228a407aa4a72902a9bea5b1a6dae) + ex.Message);
				Process[] processesByName = Process.GetProcessesByName(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x6948B8DA ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae01ae78a7944cad96133fd0f7262991));
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
				TulisLog(ex.ToString());
			}
		}

		public static Bitmap ResizeImage(Bitmap image, int width, int height)
		{
			using Bitmap bitmap = new Bitmap(width, height);
			using (Graphics graphics = Graphics.FromImage(bitmap))
			{
				graphics.CompositingMode = CompositingMode.SourceCopy;
				graphics.CompositingQuality = CompositingQuality.HighQuality;
				graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
				graphics.SmoothingMode = SmoothingMode.HighQuality;
				graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
				graphics.DrawImage(image, 0, 0, width, height);
			}
			return new Bitmap(bitmap);
		}

		private void ierEKjDq1(object P_0, NewFrameEventArgs P_1)
		{
			try
			{
				using Bitmap bitmap = (Bitmap)P_1.Frame.Clone();
				int num = ymWil21hB.Width;
				int num2 = ymWil21hB.Height;
				using Bitmap bitmap2 = ResizeImage(bitmap, num, num2);
				if (ymWil21hB.Image != null)
				{
					ymWil21hB.Image.Dispose();
				}
				ymWil21hB.Image = (Image)bitmap2.Clone();
				if (A3mpRyuSQ)
				{
					Bitmap image = (Bitmap)bitmap.Clone();
					Invoke(new CaptureSnapshotManifast(UpdateCaptureSnapshotManifast), ResizeImage(image, 640, 480));
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x611D5E0 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae556f08b158445a966f2251347dd6e5) + ex.Message);
				Process[] processesByName = Process.GetProcessesByName(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0xB684E73 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_305943fedccc4694af3b7c7d8ba81fff));
				foreach (Process process in processesByName)
				{
					process.Kill();
				}
				TulisLog(ex.ToString());
			}
		}

		public static void TulisLog(string logMessage)
		{
			File.AppendAllText(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x47A18B98 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_975652dd350f409cadedf7ce7925aa1b), DateTime.Now.ToString(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x7ADDB1F0 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_09041336954d44aa8ec29555dcdc7372)) + logMessage + Environment.NewLine);
		}

		private void RlD21VLwx()
		{
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			string baseUrl = appConfig.FRUrl + hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x6E791AC5 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_d5a748ff66e44a84906f4d303f5a262d);
			string path = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x4EBC5695 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_dc27d6aced424efd9dcfa9dddbdd8c8a) + namafotosimpan;
			if (!(cjO8xx9gW == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(-801290702 ^ -1931706530 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3f3feaa4ea4c4745bc1164f526843ff9)))
			{
				return;
			}
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)3264;
				RestClient client = new RestClient(baseUrl);
				RestRequest restRequest = new RestRequest(Method.POST);
				restRequest.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x6E791937 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_d5a748ff66e44a84906f4d303f5a262d), namaImage);
				restRequest.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x773C2729 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_324c6aed27fe46649d8967f09897123e), GetConfigure.keyfrku);
				restRequest.AddFile(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x4CF64B5 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_7e8c963ee0c84c82b284848300471c9d), path);
				restRequest.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x401E6CD2 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_12d08711f24b45aeb025242de6bdf201), hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5C8719D9 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_530f584a7e264d7f9ba00d31e0f2d3a6));
				restRequest.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(-(-101418157) ^ 0x31A96037 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ebd46b1882a14ffdbe389425ae97292d), appConfig.Kegiatan);
				restRequest.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x1C143A4F ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c9e09e8039e44f658f1c68d6b170b3c0), GetConfigure.tokenfrku);
				restRequest.AlwaysMultipartFormData = true;
				client.ExecuteAsync(restRequest, (IRestResponse response) =>
				{
					if (response.StatusCode.ToString() == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x1E5F610E ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_548fadf6f488427c87fd86e2c422f0ed))
					{
						TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x258502A ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_999d058f5d524287a796281866e6f8e3));
					}
				});
			}
			catch (NotSupportedException)
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
				RestClient client2 = new RestClient(baseUrl);
				RestRequest restRequest2 = new RestRequest(Method.POST);
				restRequest2.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x6E132F80 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c50d087b4bf64c2ab02de7d9a5c3826f), namaImage);
				restRequest2.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(-(-1548741411) ^ 0x4BDD9705 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4a1438034cc84d7c8968498e7520a583), GetConfigure.keyfrku);
				restRequest2.AddFile(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x90A6125 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_856b64606aac4ca69abc3044ba4601bc), path);
				restRequest2.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x4CF64A5 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_7e8c963ee0c84c82b284848300471c9d), hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(-(-757132505) ^ 0x3707F9D4 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_2cdaf700d452430f8b7937a2df3c14ab));
				restRequest2.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x7DDBFE42 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_a6ae5352d56f4091966d41b1207c37c3), appConfig.Kegiatan);
				restRequest2.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x64ACEEAE ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_8408b83f5ed14a5793851ceceeec159f), GetConfigure.tokenfrku);
				restRequest2.AlwaysMultipartFormData = true;
				client2.ExecuteAsync(restRequest2, (IRestResponse response) =>
				{
					if (response.StatusCode.ToString() == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x4E2A5BC2 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_bebf881a079d4a7496932f7318496671))
					{
						TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x11F4936 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0466e48aa993460f860ca336733363d4));
					}
					else
					{
						TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x7DDBF916 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_a6ae5352d56f4091966d41b1207c37c3));
					}
				});
			}
			catch (Exception ex2)
			{
				TulisLog(ex2.ToString());
			}
		}

		private void msGYoLVoD()
		{
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			string baseUrl = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x27EF4A94 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_efcc946ac9a7496881d438f0cd5eed7d);
			string path = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x512EC959 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_db9fde00cee841ca8bc26eac2c4289d1) + namafotosimpan;
			if (!(cjO8xx9gW == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5C8719D9 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_530f584a7e264d7f9ba00d31e0f2d3a6)))
			{
				return;
			}
			try
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				ServicePointManager.SecurityProtocol = (SecurityProtocolType)3264;
				RestClient client = new RestClient(baseUrl);
				RestRequest restRequest = new RestRequest(Method.POST);
				restRequest.AddHeader(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0xB684CE3 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_305943fedccc4694af3b7c7d8ba81fff), hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5AA5F68B ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_69f2e73aa7364c2d861ef1dff92976d6));
				restRequest.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x4359E103 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4d551909784346a7b40161671b3cc259), namaImage);
				restRequest.AddFile(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x2D2B9367 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c0d6c5ba75554d0c9b9f44239137eb2b), path);
				restRequest.AlwaysMultipartFormData = true;
				client.ExecuteAsync(restRequest, (IRestResponse response) =>
				{
					if (response.StatusCode.ToString() == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x17927AFA ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4a1438034cc84d7c8968498e7520a583))
					{
						TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x69747224 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_34dba5a19f7c43f1884d825778c0d820));
					}
					else
					{
						TulisLog(response.StatusCode.ToString());
					}
				});
			}
			catch (NotSupportedException)
			{
				ServicePointManager.ServerCertificateValidationCallback = (RemoteCertificateValidationCallback)Delegate.Combine(ServicePointManager.ServerCertificateValidationCallback, (RemoteCertificateValidationCallback)((object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true));
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;
				RestClient client2 = new RestClient(baseUrl);
				RestRequest restRequest2 = new RestRequest(Method.POST);
				restRequest2.AddHeader(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x2CC1DE6B ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_74a228a407aa4a72902a9bea5b1a6dae), hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x67886207 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0b5edac9fd494507a2df84fa68a1ad5b));
				restRequest2.AddParameter(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5A16D034 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_45f85c7a24624948ac8d1e2d9d91fcdb), namaImage);
				restRequest2.AddFile(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(-(-757132505) ^ 0x4A69FC4B ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_fc3c43d5ece44796b51e0b7a7e15b5be), path);
				restRequest2.AlwaysMultipartFormData = true;
				client2.ExecuteAsync(restRequest2, (IRestResponse response) =>
				{
					if (response.StatusCode.ToString() == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5EA45EF7 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_283001a380f24857821833e8f3885f08))
					{
						TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x1F282FF1 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_df8b92ad925543d28f184b38da986b0e));
					}
					else
					{
						TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x2CC1D983 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_74a228a407aa4a72902a9bea5b1a6dae));
					}
				});
			}
			catch (Exception ex2)
			{
				TulisLog(ex2.ToString());
			}
		}

		private static string Y3l9wRbxF(string P_0)
		{
			using FileStream stream = new FileStream(P_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			using StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}

		private void GBvrZPZHy(object P_0, DoWorkEventArgs P_1)
		{
			try
			{
				TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x11F4F08 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0466e48aa993460f860ca336733363d4) + File.Exists(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x2CC1DFC5 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_74a228a407aa4a72902a9bea5b1a6dae)));
				if (!File.Exists(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x773C2651 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_324c6aed27fe46649d8967f09897123e)))
				{
					return;
				}
				string json = Y3l9wRbxF(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x6E79187B ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_d5a748ff66e44a84906f4d303f5a262d));
				namaImage = JObject.Parse(json)[hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x674911B0 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_fc3c43d5ece44796b51e0b7a7e15b5be)].Value<string>();
				cjO8xx9gW = JObject.Parse(json)[hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x5CE13A4A ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3f3feaa4ea4c4745bc1164f526843ff9)].Value<string>();
				A3mpRyuSQ = true;
				Thread.Sleep(4000);
				TulisLog(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0xB684D85 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_305943fedccc4694af3b7c7d8ba81fff) + namaImage + hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x3A170C39 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_dcca42573756400b8f6f41d288be7ab1) + cjO8xx9gW + hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x4CF653F ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_7e8c963ee0c84c82b284848300471c9d) + wcihcl2Xi);
				if (namaImage != "")
				{
					if (wcihcl2Xi == hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x12840EA1 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_48705551457045cf9e2c2f222f96f7cc))
					{
						msGYoLVoD();
					}
					else
					{
						RlD21VLwx();
					}
				}
			}
			catch (Exception ex)
			{
				TulisLog(ex.ToString());
			}
		}

		private void OhFa2wKsD(object P_0, EventArgs P_1)
		{
			if (!soMtl0d5u.IsBusy)
			{
				soMtl0d5u.RunWorkerAsync();
			}
		}

		private void MaEAKuKn3(object P_0, EventArgs P_1)
		{
			GetConfigure getConfigure = new GetConfigure();
			GetConfigure.AppConfig appConfig = getConfigure.ReadConfig(Load_List: false);
			XQwBLY6PT = appConfig.imageInt;
			KEA6BatUA.Interval = appConfig.imageInt;
			RqxG77xRL();
		}

		private void iTV08Ukd7(object P_0, FormClosingEventArgs P_1)
		{
			if (IuXvNvo0N != null && IuXvNvo0N.IsRunning)
			{
				IuXvNvo0N.SignalToStop();
				IuXvNvo0N.WaitForStop();
				IuXvNvo0N = null;
			}
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && wioHRdEZ9 != null)
			{
				wioHRdEZ9.Dispose();
			}
			base.Dispose(disposing);
		}

		private void U1j5WwGyh()
		{
			wioHRdEZ9 = new Container();
			soMtl0d5u = new BackgroundWorker();
			xysyQjDyc = new Panel();
			eeyjSGrnP = new Button();
			ymWil21hB = new PictureBox();
			agLSXhXRi = new BackgroundWorker();
			KEA6BatUA = new System.Windows.Forms.Timer(wioHRdEZ9);
			xysyQjDyc.SuspendLayout();
			((ISupportInitialize)ymWil21hB).BeginInit();
			SuspendLayout();
			soMtl0d5u.DoWork += GBvrZPZHy;
			xysyQjDyc.BackColor = SystemColors.Highlight;
			xysyQjDyc.Controls.Add(eeyjSGrnP);
			xysyQjDyc.Location = new Point(0, 0);
			xysyQjDyc.Margin = new Padding(4);
			xysyQjDyc.Name = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x17B5F78C ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_44937069ef704349b01107d6ac5c029f);
			xysyQjDyc.Size = new Size(276, 41);
			xysyQjDyc.TabIndex = 6;
			eeyjSGrnP.FlatAppearance.MouseDownBackColor = Color.Transparent;
			eeyjSGrnP.FlatAppearance.MouseOverBackColor = Color.Transparent;
			eeyjSGrnP.FlatStyle = FlatStyle.Flat;
			eeyjSGrnP.Image = Resources.botarrow3;
			eeyjSGrnP.Location = new Point(0, -1);
			eeyjSGrnP.Margin = new Padding(4);
			eeyjSGrnP.Name = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x2F07D052 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_24f5c35a2b9647d6b4d76afdc6e15626);
			eeyjSGrnP.Size = new Size(57, 41);
			eeyjSGrnP.TabIndex = 0;
			eeyjSGrnP.Tag = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x3E09A891 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_76fb8ae174dd497196ffc333290473ba);
			eeyjSGrnP.UseVisualStyleBackColor = true;
			eeyjSGrnP.Click += VpRl4hUT9;
			ymWil21hB.Location = new Point(0, 41);
			ymWil21hB.Name = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x1E5F6624 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_548fadf6f488427c87fd86e2c422f0ed);
			ymWil21hB.Size = new Size(276, 190);
			ymWil21hB.TabIndex = 7;
			ymWil21hB.TabStop = false;
			KEA6BatUA.Enabled = true;
			KEA6BatUA.Tick += OhFa2wKsD;
			AutoScaleDimensions = new SizeF(8f, 16f);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(276, 230);
			Controls.Add(ymWil21hB);
			Controls.Add(xysyQjDyc);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(4);
			Name = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x678862E9 ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0b5edac9fd494507a2df84fa68a1ad5b);
			StartPosition = FormStartPosition.Manual;
			Text = hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x1C143BCF ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c9e09e8039e44f658f1c68d6b170b3c0);
			TopMost = true;
			FormClosing += iTV08Ukd7;
			Load += MaEAKuKn3;
			xysyQjDyc.ResumeLayout(performLayout: false);
			((ISupportInitialize)ymWil21hB).EndInit();
			ResumeLayout(performLayout: false);
		}
	}
}
namespace g0jK0c19Nk9AYuUwHU
{
	internal static class OrYtn1gVye1Qam4R6i
	{
		[STAThread]
		private static void dq3cN1Tmi()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(defaultValue: false);
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			Application.Run(new Form1());
		}
	}
}
namespace ExamCam.Properties
{
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	internal class Resources
	{
		private static ResourceManager CC0qB8D8s;

		private static CultureInfo kEr4CC8yw;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (CC0qB8D8s == null)
				{
					ResourceManager cC0qB8D8s = new ResourceManager("ExamCam.Properties.Resources", typeof(Resources).Assembly);
					CC0qB8D8s = cC0qB8D8s;
				}
				return CC0qB8D8s;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return kEr4CC8yw;
			}
			set
			{
				kEr4CC8yw = value;
			}
		}

		internal static Bitmap botarrow3
		{
			get
			{
				object obj = ResourceManager.GetObject(hKjZs2FC0P6hG9iYqHv.nRtFZKeQPU(0x611D74E ^ <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}.m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae556f08b158445a966f2251347dd6e5), kEr4CC8yw);
				return (Bitmap)obj;
			}
		}

		internal Resources()
		{
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			base..ctor();
		}
	}
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.3.0.0")]
	[CompilerGenerated]
	internal sealed class Settings : ApplicationSettingsBase
	{
		private static Settings defaultInstance;

		public static Settings Default => defaultInstance;

		public Settings()
		{
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			base..ctor();
		}

		static Settings()
		{
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
		}
	}
}
internal class <Module>{6B48735F-B9AB-46C4-A19B-9664F24DE959}
{
}
namespace J497sIF3gpBybTL6d2O
{
	internal class iyynE7Fm7EIOmvU3Jsv
	{
		internal delegate void txkLUoFxUhP57WRObtY(object o);

		internal static Module hypFfWJm2I;

		internal static void GcKm49Ltjy(int typemdt)
		{
			Type type = hypFfWJm2I.ResolveType(33554432 + typemdt);
			FieldInfo[] fields = type.GetFields();
			foreach (FieldInfo fieldInfo in fields)
			{
				MethodInfo method = (MethodInfo)hypFfWJm2I.ResolveMethod(fieldInfo.MetadataToken + 100663296);
				fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
			}
		}

		public iyynE7Fm7EIOmvU3Jsv()
		{
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			base..ctor();
		}

		static iyynE7Fm7EIOmvU3Jsv()
		{
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			hypFfWJm2I = typeof(iyynE7Fm7EIOmvU3Jsv).Assembly.ManifestModule;
		}
	}
}
namespace fmqMvAFLAJh1RBBBBdw
{
	internal class hKjZs2FC0P6hG9iYqHv
	{
		private delegate void F2CRlFRhaWI0ddM5Jfl(object o);

		internal class MgxhwgRH5DvNMTFAS9K : Attribute
		{
			internal class zcsXiuRyn5a4BNUTXoL<HFTBSeRjPpVFSr6mP0I>
			{
				public zcsXiuRyn5a4BNUTXoL()
				{
					bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
					base..ctor();
				}
			}

			public MgxhwgRH5DvNMTFAS9K(object P_0)
			{
			}
		}

		internal class xFte8QRiETd8PhswuSA
		{
			internal static string aYpRSTwHBG(string P_0, string P_1)
			{
				byte[] bytes = Encoding.Unicode.GetBytes(P_0);
				byte[] key = new byte[32]
				{
					82, 102, 104, 110, 32, 77, 24, 34, 118, 181,
					51, 17, 18, 51, 12, 109, 10, 32, 77, 24,
					34, 158, 161, 41, 97, 28, 118, 181, 5, 25,
					1, 88
				};
				byte[] iV = EXPFrM1Vvj(Encoding.Unicode.GetBytes(P_1));
				MemoryStream memoryStream = new MemoryStream();
				SymmetricAlgorithm symmetricAlgorithm = FhJFYq4EIl();
				symmetricAlgorithm.Key = key;
				symmetricAlgorithm.IV = iV;
				CryptoStream cryptoStream = new CryptoStream(memoryStream, symmetricAlgorithm.CreateEncryptor(), CryptoStreamMode.Write);
				cryptoStream.Write(bytes, 0, bytes.Length);
				cryptoStream.Close();
				return Convert.ToBase64String(memoryStream.ToArray());
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint N5FlvWR6KUMO4c2xrIL(IntPtr classthis, IntPtr comp, IntPtr info, [MarshalAs(UnmanagedType.U4)] uint flags, IntPtr nativeEntry, ref uint nativeSizeOfCode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr i0E7lxRgtB6cU7dSdHa();

		internal struct Nu2nryR1p3PCn26wuwl
		{
			internal bool qTURclhr00;

			internal byte[] Ds4RqdhIM5;
		}

		internal class Aqbje3R4pxmmxaoqrBd
		{
			private BinaryReader CGuRelUBwY;

			public Aqbje3R4pxmmxaoqrBd(Stream P_0)
			{
				CGuRelUBwY = new BinaryReader(P_0);
			}

			[SpecialName]
			internal Stream f9UtU12u5A()
			{
				return CGuRelUBwY.BaseStream;
			}

			internal byte[] ngTRQ5lr60(int P_0)
			{
				return CGuRelUBwY.ReadBytes(P_0);
			}

			internal int L9wRT2fpj8(byte[] P_0, int P_1, int P_2)
			{
				return CGuRelUBwY.Read(P_0, P_1, P_2);
			}

			internal int tTYRKXdZYb()
			{
				return CGuRelUBwY.ReadInt32();
			}

			internal void y0LRPDiN5E()
			{
				CGuRelUBwY.Close();
			}
		}

		[UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi)]
		private delegate IntPtr VRRmjuRoU0hfdwdCCSk(IntPtr hModule, string lpName, uint lpType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr ixOowKROVJkvwIEY3tU(IntPtr lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int GNK61GRVAbdDKENMcn4(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int T6haf8Rb0fgW3hJTCnb(IntPtr lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate IntPtr gSqMZHRISDfpm15VhCK(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		private delegate int sKR4sQRW94ZrB02fyMa(IntPtr ptr);

		[Flags]
		private enum sf3ZAORsGClfq6CnFtk
		{

		}

		private static uint[] PHmFdVPN69;

		private static bool eWsFnN60m0;

		internal static RSACryptoServiceProvider VmqFzLAEIm;

		private static byte[] V1dRxhaOqf;

		private static IntPtr WivRLxN0H7;

		private static IntPtr vgQR7T4aMm;

		private static int dk9RXGS2F1;

		private static int U4aREJkdKG;

		internal static N5FlvWR6KUMO4c2xrIL SkkRYjwUPL;

		private static int kdORaJl90y;

		private static bool xKCR0POVty;

		private static IntPtr yNoRUJwEj6;

		internal static Hashtable O4cRNb9nvJ;

		private static GNK61GRVAbdDKENMcn4 XCtRZnfDgY;

		private static T6haf8Rb0fgW3hJTCnb LGsRpAE61j;

		private static IntPtr VBkRJDU77f;

		internal static N5FlvWR6KUMO4c2xrIL dJIR9BnJ9m;

		private static VRRmjuRoU0hfdwdCCSk XbaRM3YiTV;

		private static long YwfRriHJdM;

		private static int[] UIXRwimFvU;

		private static byte[] PKYRCRp9Xs;

		private static ixOowKROVJkvwIEY3tU gh4Rt85nxA;

		private static bool yabFkauTx2;

		[MgxhwgRH5DvNMTFAS9K(typeof(MgxhwgRH5DvNMTFAS9K.zcsXiuRyn5a4BNUTXoL<object>[]))]
		private static bool YPpRvvBI2T;

		private static object KhTRmBlJVM;

		private static long MGCR2WsgsK;

		private static int ciORRPouSO;

		internal static Assembly H6HFsaaMmY;

		private static bool sNJRA2uMQt;

		private static object rXxRup0gmk;

		private static List<int> EnCRfvQ3XX;

		private static Dictionary<int, int> amVRD7VaPr;

		private static int fR7R5HrwJY;

		private static List<string> wPbR3fgIdB;

		private static object RgbRFr5yL0;

		private static sKR4sQRW94ZrB02fyMa YX2R8ncyLg;

		private static SortedList a5QRG3cJa9;

		private static bool n39RlOgA6P;

		private static gSqMZHRISDfpm15VhCK aV2RB5VJEq;

		static hKjZs2FC0P6hG9iYqHv()
		{
			H6HFsaaMmY = typeof(hKjZs2FC0P6hG9iYqHv).Assembly;
			PHmFdVPN69 = new uint[64]
			{
				3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
				4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
				3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
				1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
				681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
				2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
				4149444226u, 3174756917u, 718787259u, 3951481745u
			};
			yabFkauTx2 = false;
			eWsFnN60m0 = false;
			VmqFzLAEIm = null;
			amVRD7VaPr = null;
			RgbRFr5yL0 = new object();
			ciORRPouSO = 0;
			KhTRmBlJVM = new object();
			wPbR3fgIdB = null;
			EnCRfvQ3XX = null;
			V1dRxhaOqf = new byte[0];
			PKYRCRp9Xs = new byte[0];
			WivRLxN0H7 = IntPtr.Zero;
			vgQR7T4aMm = IntPtr.Zero;
			rXxRup0gmk = new string[0];
			UIXRwimFvU = new int[0];
			dk9RXGS2F1 = 1;
			n39RlOgA6P = false;
			a5QRG3cJa9 = new SortedList();
			U4aREJkdKG = 0;
			MGCR2WsgsK = 0L;
			SkkRYjwUPL = null;
			dJIR9BnJ9m = null;
			YwfRriHJdM = 0L;
			kdORaJl90y = 0;
			sNJRA2uMQt = false;
			xKCR0POVty = false;
			fR7R5HrwJY = 0;
			yNoRUJwEj6 = IntPtr.Zero;
			YPpRvvBI2T = false;
			O4cRNb9nvJ = new Hashtable();
			XbaRM3YiTV = null;
			gh4Rt85nxA = null;
			XCtRZnfDgY = null;
			LGsRpAE61j = null;
			aV2RB5VJEq = null;
			YX2R8ncyLg = null;
			VBkRJDU77f = IntPtr.Zero;
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private void c7omQIyx3g()
		{
		}

		internal static byte[] ULLF7h2dK8(byte[] P_0)
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
				uS8FuPmyp9(ref num6, num7, num8, num9, 0u, 7, 1u, array);
				uS8FuPmyp9(ref num9, num6, num7, num8, 1u, 12, 2u, array);
				uS8FuPmyp9(ref num8, num9, num6, num7, 2u, 17, 3u, array);
				uS8FuPmyp9(ref num7, num8, num9, num6, 3u, 22, 4u, array);
				uS8FuPmyp9(ref num6, num7, num8, num9, 4u, 7, 5u, array);
				uS8FuPmyp9(ref num9, num6, num7, num8, 5u, 12, 6u, array);
				uS8FuPmyp9(ref num8, num9, num6, num7, 6u, 17, 7u, array);
				uS8FuPmyp9(ref num7, num8, num9, num6, 7u, 22, 8u, array);
				uS8FuPmyp9(ref num6, num7, num8, num9, 8u, 7, 9u, array);
				uS8FuPmyp9(ref num9, num6, num7, num8, 9u, 12, 10u, array);
				uS8FuPmyp9(ref num8, num9, num6, num7, 10u, 17, 11u, array);
				uS8FuPmyp9(ref num7, num8, num9, num6, 11u, 22, 12u, array);
				uS8FuPmyp9(ref num6, num7, num8, num9, 12u, 7, 13u, array);
				uS8FuPmyp9(ref num9, num6, num7, num8, 13u, 12, 14u, array);
				uS8FuPmyp9(ref num8, num9, num6, num7, 14u, 17, 15u, array);
				uS8FuPmyp9(ref num7, num8, num9, num6, 15u, 22, 16u, array);
				XMXFwbLtaf(ref num6, num7, num8, num9, 1u, 5, 17u, array);
				XMXFwbLtaf(ref num9, num6, num7, num8, 6u, 9, 18u, array);
				XMXFwbLtaf(ref num8, num9, num6, num7, 11u, 14, 19u, array);
				XMXFwbLtaf(ref num7, num8, num9, num6, 0u, 20, 20u, array);
				XMXFwbLtaf(ref num6, num7, num8, num9, 5u, 5, 21u, array);
				XMXFwbLtaf(ref num9, num6, num7, num8, 10u, 9, 22u, array);
				XMXFwbLtaf(ref num8, num9, num6, num7, 15u, 14, 23u, array);
				XMXFwbLtaf(ref num7, num8, num9, num6, 4u, 20, 24u, array);
				XMXFwbLtaf(ref num6, num7, num8, num9, 9u, 5, 25u, array);
				XMXFwbLtaf(ref num9, num6, num7, num8, 14u, 9, 26u, array);
				XMXFwbLtaf(ref num8, num9, num6, num7, 3u, 14, 27u, array);
				XMXFwbLtaf(ref num7, num8, num9, num6, 8u, 20, 28u, array);
				XMXFwbLtaf(ref num6, num7, num8, num9, 13u, 5, 29u, array);
				XMXFwbLtaf(ref num9, num6, num7, num8, 2u, 9, 30u, array);
				XMXFwbLtaf(ref num8, num9, num6, num7, 7u, 14, 31u, array);
				XMXFwbLtaf(ref num7, num8, num9, num6, 12u, 20, 32u, array);
				RkrFXj6S6g(ref num6, num7, num8, num9, 5u, 4, 33u, array);
				RkrFXj6S6g(ref num9, num6, num7, num8, 8u, 11, 34u, array);
				RkrFXj6S6g(ref num8, num9, num6, num7, 11u, 16, 35u, array);
				RkrFXj6S6g(ref num7, num8, num9, num6, 14u, 23, 36u, array);
				RkrFXj6S6g(ref num6, num7, num8, num9, 1u, 4, 37u, array);
				RkrFXj6S6g(ref num9, num6, num7, num8, 4u, 11, 38u, array);
				RkrFXj6S6g(ref num8, num9, num6, num7, 7u, 16, 39u, array);
				RkrFXj6S6g(ref num7, num8, num9, num6, 10u, 23, 40u, array);
				RkrFXj6S6g(ref num6, num7, num8, num9, 13u, 4, 41u, array);
				RkrFXj6S6g(ref num9, num6, num7, num8, 0u, 11, 42u, array);
				RkrFXj6S6g(ref num8, num9, num6, num7, 3u, 16, 43u, array);
				RkrFXj6S6g(ref num7, num8, num9, num6, 6u, 23, 44u, array);
				RkrFXj6S6g(ref num6, num7, num8, num9, 9u, 4, 45u, array);
				RkrFXj6S6g(ref num9, num6, num7, num8, 12u, 11, 46u, array);
				RkrFXj6S6g(ref num8, num9, num6, num7, 15u, 16, 47u, array);
				RkrFXj6S6g(ref num7, num8, num9, num6, 2u, 23, 48u, array);
				TJhFl46rfA(ref num6, num7, num8, num9, 0u, 6, 49u, array);
				TJhFl46rfA(ref num9, num6, num7, num8, 7u, 10, 50u, array);
				TJhFl46rfA(ref num8, num9, num6, num7, 14u, 15, 51u, array);
				TJhFl46rfA(ref num7, num8, num9, num6, 5u, 21, 52u, array);
				TJhFl46rfA(ref num6, num7, num8, num9, 12u, 6, 53u, array);
				TJhFl46rfA(ref num9, num6, num7, num8, 3u, 10, 54u, array);
				TJhFl46rfA(ref num8, num9, num6, num7, 10u, 15, 55u, array);
				TJhFl46rfA(ref num7, num8, num9, num6, 1u, 21, 56u, array);
				TJhFl46rfA(ref num6, num7, num8, num9, 8u, 6, 57u, array);
				TJhFl46rfA(ref num9, num6, num7, num8, 15u, 10, 58u, array);
				TJhFl46rfA(ref num8, num9, num6, num7, 6u, 15, 59u, array);
				TJhFl46rfA(ref num7, num8, num9, num6, 13u, 21, 60u, array);
				TJhFl46rfA(ref num6, num7, num8, num9, 4u, 6, 61u, array);
				TJhFl46rfA(ref num9, num6, num7, num8, 11u, 10, 62u, array);
				TJhFl46rfA(ref num8, num9, num6, num7, 2u, 15, 63u, array);
				TJhFl46rfA(ref num7, num8, num9, num6, 9u, 21, 64u, array);
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

		private static void uS8FuPmyp9(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + XqOFGRnwnh(P_0 + ((P_1 & P_2) | (~P_1 & P_3)) + P_7[P_4] + PHmFdVPN69[P_6 - 1], P_5);
		}

		private static void XMXFwbLtaf(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + XqOFGRnwnh(P_0 + ((P_1 & P_3) | (P_2 & ~P_3)) + P_7[P_4] + PHmFdVPN69[P_6 - 1], P_5);
		}

		private static void RkrFXj6S6g(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + XqOFGRnwnh(P_0 + (P_1 ^ P_2 ^ P_3) + P_7[P_4] + PHmFdVPN69[P_6 - 1], P_5);
		}

		private static void TJhFl46rfA(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, uint[] P_7)
		{
			P_0 = P_1 + XqOFGRnwnh(P_0 + (P_2 ^ (P_1 | ~P_3)) + P_7[P_4] + PHmFdVPN69[P_6 - 1], P_5);
		}

		private static uint XqOFGRnwnh(uint P_0, ushort P_1)
		{
			return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
		}

		internal static bool fi6FE95ohT()
		{
			if (!yabFkauTx2)
			{
				oiIF9Oi6bs();
				yabFkauTx2 = true;
			}
			return eWsFnN60m0;
		}

		internal hKjZs2FC0P6hG9iYqHv()
		{
		}

		private void UJpF2jdOdB(byte[] P_0, byte[] P_1, byte[] P_2)
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
			V1dRxhaOqf = array;
		}

		internal static SymmetricAlgorithm FhJFYq4EIl()
		{
			SymmetricAlgorithm symmetricAlgorithm = null;
			if (fi6FE95ohT())
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

		internal static void oiIF9Oi6bs()
		{
			try
			{
				new RijndaelManaged();
				eWsFnN60m0 = false;
			}
			catch
			{
				eWsFnN60m0 = true;
			}
		}

		internal static byte[] EXPFrM1Vvj(byte[] P_0)
		{
			if (!fi6FE95ohT())
			{
				return new MD5CryptoServiceProvider().ComputeHash(P_0);
			}
			return ULLF7h2dK8(P_0);
		}

		internal static void hueFa5deUa(HashAlgorithm P_0, Stream P_1, uint P_2, byte[] P_3)
		{
			while (P_2 != 0)
			{
				int num = ((P_2 > (uint)P_3.Length) ? P_3.Length : ((int)P_2));
				P_1.Read(P_3, 0, num);
				ldYFAbmwL2(P_0, P_3, 0, num);
				P_2 -= (uint)num;
			}
		}

		internal static void ldYFAbmwL2(HashAlgorithm P_0, byte[] P_1, int P_2, int P_3)
		{
			P_0.TransformBlock(P_1, P_2, P_3, P_1, P_2);
		}

		internal static uint G0TF0S0Knl(uint P_0, int P_1, long P_2, BinaryReader P_3)
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

		public static void GqEF5N8Y0X(RuntimeTypeHandle P_0)
		{
			try
			{
				Type typeFromHandle = Type.GetTypeFromHandle(P_0);
				if (amVRD7VaPr == null)
				{
					lock (RgbRFr5yL0)
					{
						Dictionary<int, int> dictionary = new Dictionary<int, int>();
						BinaryReader binaryReader = new BinaryReader(typeof(hKjZs2FC0P6hG9iYqHv).Assembly.GetManifestResourceStream("FIrbnbwDCf1T0hMwrL.VvDmJLXwOhpPigah57"));
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
								num3 += u40FNm0uRA(num3);
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
							Aqbje3R4pxmmxaoqrBd aqbje3R4pxmmxaoqrBd = new Aqbje3R4pxmmxaoqrBd(new MemoryStream(array));
							for (int l = 0; l < num11; l++)
							{
								int key = aqbje3R4pxmmxaoqrBd.tTYRKXdZYb();
								int value = aqbje3R4pxmmxaoqrBd.tTYRKXdZYb();
								dictionary.Add(key, value);
							}
							aqbje3R4pxmmxaoqrBd.y0LRPDiN5E();
						}
						amVRD7VaPr = dictionary;
					}
				}
				FieldInfo[] fields = typeFromHandle.GetFields(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.GetField);
				for (int m = 0; m < fields.Length; m++)
				{
					try
					{
						FieldInfo fieldInfo = fields[m];
						int metadataToken = fieldInfo.MetadataToken;
						int num12 = amVRD7VaPr[metadataToken];
						bool flag = (num12 & 0x40000000) > 0;
						num12 &= 0x3FFFFFFF;
						MethodInfo methodInfo = (MethodInfo)typeof(hKjZs2FC0P6hG9iYqHv).Module.ResolveMethod(num12, typeFromHandle.GetGenericArguments(), new Type[0]);
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

		private static uint y4mFvvbKU4(uint P_0)
		{
			return (uint)"{11111-22222-10009-11112}".Length;
		}

		private static uint u40FNm0uRA(uint P_0)
		{
			return 0u;
		}

		internal static void VqvFM1i8IZ()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		private static void J9cFti2oeg(Stream P_0, int P_1)
		{
			int num = 105;
			byte[] array = default;
			int num4 = default;
			int num3 = default;
			int num5 = default;
			int num6 = default;
			byte[] array2 = default;
			byte[] array4 = default;
			byte[] array3 = default;
			byte[] array6 = default;
			byte[] array5 = default;
			ICryptoTransform transform = default;
			Stream stream = default;
			int num7 = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 49:
						array[25] = (byte)num4;
						num2 = 334;
						continue;
					case 270:
						num3 = 77 + 115;
						num2 = 93;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 5;
						}
						continue;
					case 124:
						array[9] = (byte)num5;
						num2 = 103;
						continue;
					case 153:
						array[20] = (byte)num5;
						num2 = 95;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 275;
						}
						continue;
					case 345:
						array[15] = 101;
						num2 = 195;
						continue;
					case 354:
						num6 = 83 + 44;
						num = 263;
						break;
					case 34:
						array2[3] = 11;
						num2 = 212;
						continue;
					case 165:
						num4 = 29 + 36;
						num2 = 281;
						continue;
					case 59:
						array[7] = 138;
						num2 = 67;
						continue;
					case 223:
						array[24] = (byte)num4;
						num = 40;
						break;
					case 156:
						num5 = 11 + 3;
						num = 356;
						break;
					case 302:
						array2[2] = 173;
						num2 = 280;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 190;
						}
						continue;
					case 80:
						array2[7] = 169;
						num2 = 210;
						continue;
					case 17:
						num5 = 60 + 73;
						num2 = 10;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 8;
						}
						continue;
					case 236:
						array[11] = 118;
						num2 = 23;
						continue;
					case 284:
						array2[4] = (byte)num6;
						num = 137;
						break;
					case 259:
						array[22] = (byte)num4;
						num2 = 277;
						continue;
					case 195:
						num5 = 112 + 24;
						num2 = 44;
						continue;
					case 62:
						array2[5] = 167;
						num2 = 140;
						continue;
					case 16:
						array2[14] = (byte)num3;
						num2 = 23;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 245;
						}
						continue;
					case 175:
						array4 = (byte[])xQEMiLmHuxDxRn9ls6m(yh7pVmmhv0KncKef98u(H6HFsaaMmY));
						num2 = 201;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 315;
						}
						continue;
					case 333:
						array[20] = (byte)num4;
						num2 = 251;
						continue;
					case 22:
						array2[1] = 216;
						num2 = 60;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 307;
						}
						continue;
					case 343:
						array3[3] = array4[1];
						num2 = 260;
						continue;
					case 350:
						array[9] = 29;
						num2 = 19;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 32;
						}
						continue;
					case 225:
						array2[10] = 152;
						num2 = 189;
						continue;
					case 51:
						array[25] = 136;
						num2 = 293;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 102;
						}
						continue;
					case 180:
						array2[8] = 29;
						num = 199;
						break;
					case 279:
						array[20] = 180;
						num2 = 40;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 63;
						}
						continue;
					case 41:
						array[17] = 120;
						num2 = 261;
						continue;
					case 351:
						array2[1] = (byte)num6;
						num = 22;
						break;
					case 84:
						array[13] = 165;
						num2 = 336;
						continue;
					case 163:
						num4 = 103 + 6;
						num2 = 260;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 333;
						}
						continue;
					case 289:
						num4 = 76 + 68;
						num2 = 157;
						continue;
					case 261:
						num4 = 62 + 30;
						num2 = 138;
						continue;
					case 68:
						array[23] = 197;
						num2 = 314;
						continue;
					case 353:
						num4 = 124 + 15;
						num2 = 117;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 128;
						}
						continue;
					case 214:
						num4 = 98 + 118;
						num2 = 13;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 15;
						}
						continue;
					case 137:
						num3 = 29 + 98;
						num2 = 179;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 102;
						}
						continue;
					case 142:
						array[12] = 137;
						num2 = 24;
						continue;
					case 162:
						array[22] = 129;
						num2 = 186;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 41;
						}
						continue;
					case 231:
						array[20] = 92;
						num2 = 163;
						continue;
					case 276:
						num4 = 142 - 47;
						num2 = 160;
						continue;
					case 75:
						array[4] = 145;
						num2 = 11;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 289;
						}
						continue;
					case 258:
						array[8] = 113;
						num2 = 25;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 159;
						}
						continue;
					case 29:
						num5 = 243 - 81;
						num2 = 155;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 167;
						}
						continue;
					case 272:
						num5 = 121 + 112;
						num2 = 304;
						continue;
					case 235:
						array[0] = (byte)num5;
						num = 341;
						break;
					case 255:
						array[2] = (byte)num5;
						num2 = 8;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 7;
						}
						continue;
					case 58:
						array[8] = 87;
						num2 = 258;
						continue;
					case 56:
						num4 = 4 + 58;
						num2 = 213;
						continue;
					case 148:
						array[5] = (byte)num4;
						num2 = 335;
						continue;
					case 315:
						if (array4 == null)
						{
							num2 = 141;
							if (iyPJ2DmMDBEWrUg8LXb() == null)
							{
								num2 = 262;
							}
							continue;
						}
						goto case 241;
					case 324:
						num4 = 69 + 77;
						num = 228;
						break;
					case 145:
						array[14] = (byte)num4;
						num2 = 39;
						continue;
					case 60:
						num4 = 234 - 78;
						num2 = 85;
						continue;
					case 130:
						array[16] = (byte)num4;
						num2 = 288;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 8;
						}
						continue;
					case 322:
						array2[15] = (byte)num3;
						num2 = 347;
						continue;
					case 266:
						num5 = 89 - 89;
						num2 = 91;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 153;
						}
						continue;
					case 53:
						array[18] = 107;
						num2 = 323;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 106;
						}
						continue;
					case 44:
						array[15] = (byte)num5;
						num2 = 119;
						continue;
					case 211:
						array2[4] = (byte)num3;
						num2 = 269;
						continue;
					case 243:
						array[30] = 161;
						num2 = 110;
						continue;
					case 33:
						array2[6] = 138;
						num2 = 116;
						continue;
					case 55:
						num5 = 30 + 15;
						num2 = 187;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 67;
						}
						continue;
					case 331:
						num3 = 95 - 60;
						num2 = 201;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 151;
						}
						continue;
					case 115:
					case 274:
						new hKjZs2FC0P6hG9iYqHv().UJpF2jdOdB(array6, array3, array5);
						num2 = 28;
						continue;
					case 88:
						array[8] = 92;
						num = 295;
						break;
					case 291:
						num6 = 161 - 53;
						num2 = 113;
						continue;
					case 263:
						array2[5] = (byte)num6;
						num2 = 118;
						continue;
					case 346:
						array[11] = 33;
						num2 = 171;
						continue;
					case 206:
						array2[7] = 128;
						num2 = 242;
						continue;
					case 118:
						num6 = 4 + 58;
						num2 = 4;
						continue;
					case 147:
						num5 = 193 - 64;
						num2 = 216;
						continue;
					case 337:
						array2[15] = (byte)num3;
						num2 = 98;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 33;
						}
						continue;
					case 112:
						array[25] = (byte)num4;
						num2 = 264;
						continue;
					case 176:
						array[9] = 117;
						num2 = 233;
						continue;
					case 187:
						array[4] = (byte)num5;
						num2 = 7;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 75;
						}
						continue;
					case 135:
						array2[7] = (byte)num3;
						num2 = 80;
						continue;
					case 240:
						array2[0] = (byte)num6;
						num = 326;
						break;
					case 122:
						num6 = 75 - 6;
						num2 = 303;
						continue;
					case 30:
						num3 = 225 - 75;
						num = 337;
						break;
					case 307:
						array2[1] = 105;
						num2 = 60;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 72;
						}
						continue;
					case 25:
						array2[13] = (byte)num3;
						num2 = 3;
						continue;
					case 220:
						array2[12] = 222;
						num2 = 50;
						continue;
					case 249:
						array[28] = (byte)num4;
						num = 86;
						break;
					case 133:
						array[5] = 109;
						num2 = 61;
						continue;
					case 86:
						array[28] = 56;
						num2 = 79;
						continue;
					case 305:
						array[26] = 135;
						num2 = 5;
						continue;
					case 178:
						array2[14] = (byte)num6;
						num2 = 195;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 207;
						}
						continue;
					case 94:
					{
						object obj = IrbrAumyewvTa4034mB();
						JJCU6amj0AaFtFOvFIF(obj, CipherMode.CBC);
						transform = (ICryptoTransform)Ody6Hbmi5XorcT2UdPc(obj, array6, array3);
						num2 = 204;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 54;
						}
						continue;
					}
					case 181:
						array[0] = (byte)num4;
						num2 = 276;
						continue;
					case 103:
						num5 = 100 + 56;
						num2 = 217;
						continue;
					case 232:
						array2[6] = 105;
						num2 = 206;
						continue;
					case 24:
						num5 = 45 + 116;
						num2 = 168;
						continue;
					case 205:
						num5 = 247 - 82;
						num2 = 255;
						continue;
					case 82:
						num5 = 5 + 53;
						num2 = 153;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 170;
						}
						continue;
					case 76:
						array[27] = 90;
						num2 = 353;
						continue;
					case 330:
						Juce31mJC4ZVfjyOyKL(array3);
						num2 = 175;
						continue;
					case 173:
						array[29] = (byte)num4;
						num2 = 192;
						continue;
					case 139:
						num4 = 155 - 51;
						num = 49;
						break;
					case 78:
						array2[3] = (byte)num6;
						num2 = 34;
						continue;
					case 183:
						num4 = 24 + 61;
						num2 = 145;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 75;
						}
						continue;
					case 101:
						num4 = 175 - 53;
						num2 = 117;
						continue;
					case 246:
						num4 = 104 + 50;
						num2 = 121;
						continue;
					case 13:
						array2[11] = (byte)num3;
						num = 290;
						break;
					case 99:
						array[2] = 114;
						num2 = 205;
						continue;
					default:
						array2[10] = (byte)num6;
						num2 = 316;
						continue;
					case 326:
						array2[0] = 50;
						num2 = 196;
						continue;
					case 342:
						num4 = 48 - 44;
						num2 = 18;
						continue;
					case 245:
						num6 = 203 - 67;
						num2 = 165;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 273;
						}
						continue;
					case 141:
						array[23] = (byte)num4;
						num2 = 193;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 81;
						}
						continue;
					case 38:
						array2[1] = (byte)num3;
						num2 = 247;
						continue;
					case 230:
						array5 = V1dRxhaOqf;
						num2 = 344;
						continue;
					case 71:
						num4 = 93 - 62;
						num2 = 223;
						continue;
					case 9:
						array[5] = 172;
						num2 = 244;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 298;
						}
						continue;
					case 238:
						array[21] = 24;
						num2 = 29;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 6;
						}
						continue;
					case 104:
						array = new byte[32];
						num2 = 256;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 172;
						}
						continue;
					case 126:
						array2[12] = 162;
						num2 = 108;
						continue;
					case 14:
					{
						CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Write);
						RMg63Pm6EewUctpGsB8(cryptoStream, array5, 0, array5.Length);
						eDrPSZmg4AIH1ymxb68(cryptoStream);
						V1dRxhaOqf = (byte[])Ok16Pbm1o0jFn4Nb6oK(stream);
						AdH3sBmcbGjVcFKbRJi(stream);
						AdH3sBmcbGjVcFKbRJi(cryptoStream);
						num2 = 230;
						continue;
					}
					case 151:
						array2 = new byte[16];
						num2 = 184;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 136;
						}
						continue;
					case 198:
						array[23] = (byte)num5;
						num2 = 70;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 66;
						}
						continue;
					case 3:
						array2[13] = 135;
						num2 = 283;
						continue;
					case 316:
						num3 = 107 + 52;
						num2 = 95;
						continue;
					case 269:
						array2[4] = 165;
						num2 = 1;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 65;
						}
						continue;
					case 45:
						num3 = 131 - 43;
						num2 = 135;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 48;
						}
						continue;
					case 329:
						array2[9] = 125;
						num2 = 252;
						continue;
					case 32:
						array[9] = 123;
						num2 = 197;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 14;
						}
						continue;
					case 253:
						array[14] = (byte)num4;
						num2 = 36;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 150;
						}
						continue;
					case 338:
						array2[14] = (byte)num3;
						num2 = 30;
						continue;
					case 174:
						array2[11] = (byte)num6;
						num2 = 120;
						continue;
					case 8:
						num4 = 23 + 55;
						num2 = 222;
						continue;
					case 327:
						num6 = 251 - 83;
						num2 = 78;
						continue;
					case 159:
						array[8] = 227;
						num2 = 350;
						continue;
					case 89:
						array2[3] = (byte)num6;
						num2 = 249;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 327;
						}
						continue;
					case 213:
						array[7] = (byte)num4;
						num2 = 59;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 18;
						}
						continue;
					case 114:
						array[21] = (byte)num5;
						num2 = 238;
						continue;
					case 355:
						num4 = 21 + 47;
						num2 = 188;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 49;
						}
						continue;
					case 292:
						array[27] = (byte)num5;
						num = 272;
						break;
					case 297:
						array2[0] = (byte)num6;
						num2 = 229;
						continue;
					case 127:
						num3 = 181 - 118;
						num2 = 338;
						continue;
					case 197:
						num5 = 68 + 43;
						num2 = 124;
						continue;
					case 356:
						array[10] = (byte)num5;
						num = 155;
						break;
					case 209:
						array2[15] = (byte)num3;
						num2 = 30;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 47;
						}
						continue;
					case 320:
						array[24] = 85;
						num = 71;
						break;
					case 247:
						array2[2] = 203;
						num2 = 302;
						continue;
					case 304:
						array[27] = (byte)num5;
						num2 = 76;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 76;
						}
						continue;
					case 20:
						array3[9] = array4[4];
						num = 54;
						break;
					case 12:
						num3 = 21 + 100;
						num = 37;
						break;
					case 280:
						array2[2] = 92;
						num2 = 28;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 208;
						}
						continue;
					case 332:
						array[6] = (byte)num5;
						num2 = 342;
						continue;
					case 96:
						array[9] = (byte)num5;
						num2 = 74;
						continue;
					case 136:
						num3 = 56 + 46;
						num2 = 211;
						continue;
					case 290:
						num6 = 63 + 115;
						num2 = 174;
						continue;
					case 344:
						if (CnQP2Gmqn6hTejt0tJb(H6HFsaaMmY) != null)
						{
							num2 = 274;
							continue;
						}
						goto case 339;
					case 242:
						num6 = 170 - 56;
						num2 = 191;
						continue;
					case 352:
						num3 = 1 + 92;
						num2 = 16;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 1;
						}
						continue;
					case 228:
						array[19] = (byte)num4;
						num2 = 155;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 328;
						}
						continue;
					case 64:
						array[26] = (byte)num5;
						num2 = 226;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 349;
						}
						continue;
					case 202:
						num6 = 24 + 7;
						num2 = 351;
						continue;
					case 66:
						array[28] = 22;
						num2 = 147;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 133;
						}
						continue;
					case 160:
						array[0] = (byte)num4;
						num2 = 286;
						continue;
					case 61:
						num4 = 41 + 120;
						num2 = 148;
						continue;
					case 341:
						num4 = 27 + 40;
						num2 = 310;
						continue;
					case 252:
						num3 = 186 - 62;
						num2 = 36;
						continue;
					case 110:
						array[30] = 142;
						num2 = 36;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 340;
						}
						continue;
					case 250:
						array[25] = (byte)num5;
						num2 = 139;
						continue;
					case 50:
						num3 = 184 - 61;
						num2 = 25;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 8;
						}
						continue;
					case 120:
						array2[11] = 50;
						num2 = 122;
						continue;
					case 18:
						array[6] = (byte)num4;
						num2 = 56;
						continue;
					case 317:
						array2[14] = 100;
						num2 = 352;
						continue;
					case 132:
						array2[8] = (byte)num3;
						num2 = 12;
						continue;
					case 271:
						array[12] = (byte)num5;
						num2 = 142;
						continue;
					case 155:
						array[10] = 233;
						num = 236;
						break;
					case 36:
						array2[9] = (byte)num3;
						num2 = 271;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 348;
						}
						continue;
					case 72:
						num3 = 158 + 73;
						num2 = 38;
						continue;
					case 189:
						num3 = 200 - 66;
						num2 = 257;
						continue;
					case 203:
						num4 = 117 + 1;
						num2 = 249;
						continue;
					case 65:
						num6 = 88 + 106;
						num2 = 284;
						continue;
					case 256:
						num4 = 98 + 31;
						num2 = 181;
						continue;
					case 143:
						num5 = 98 - 7;
						num2 = 270;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 308;
						}
						continue;
					case 129:
						array[24] = 107;
						num2 = 320;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 139;
						}
						continue;
					case 39:
						num5 = 56 + 96;
						num2 = 144;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 55;
						}
						continue;
					case 267:
						num5 = 220 - 73;
						num2 = 200;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 183;
						}
						continue;
					case 196:
						num6 = 245 - 81;
						num2 = 297;
						continue;
					case 19:
						num4 = 220 - 108;
						num2 = 173;
						continue;
					case 146:
						num3 = 109 + 25;
						num2 = 239;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 265;
						}
						continue;
					case 312:
						array[5] = (byte)num4;
						num2 = 9;
						continue;
					case 319:
						array[26] = (byte)num5;
						num2 = 154;
						continue;
					case 201:
						array2[9] = (byte)num3;
						num2 = 287;
						continue;
					case 83:
						array2[0] = 64;
						num2 = 202;
						continue;
					case 303:
						array2[11] = (byte)num6;
						num2 = 126;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 7;
						}
						continue;
					case 157:
						array[4] = (byte)num4;
						num2 = 55;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 90;
						}
						continue;
					case 221:
						array[14] = 109;
						num2 = 182;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 69;
						}
						continue;
					case 296:
						array[22] = (byte)num5;
						num2 = 218;
						continue;
					case 63:
						array[20] = 94;
						num2 = 231;
						continue;
					case 100:
						num5 = 201 - 67;
						num2 = 325;
						continue;
					case 116:
						array2[6] = 56;
						num2 = 232;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 218;
						}
						continue;
					case 321:
						array6 = array;
						num2 = 151;
						continue;
					case 119:
						array[16] = 93;
						num2 = 69;
						continue;
					case 113:
						array2[8] = (byte)num6;
						num2 = 180;
						continue;
					case 281:
						array[29] = (byte)num4;
						num2 = 5;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 19;
						}
						continue;
					case 227:
						num5 = 238 - 79;
						num2 = 309;
						continue;
					case 306:
						array2[12] = 228;
						num2 = 189;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 357;
						}
						continue;
					case 204:
						stream = (Stream)pTiNJJmSTZZ6vjXrrgB();
						num2 = 14;
						continue;
					case 164:
						array[1] = (byte)num5;
						num2 = 100;
						continue;
					case 314:
						num5 = 72 - 30;
						num2 = 198;
						continue;
					case 21:
						array[14] = 84;
						num2 = 172;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 221;
						}
						continue;
					case 208:
						array2[2] = 73;
						num2 = 226;
						continue;
					case 216:
						array[28] = (byte)num5;
						num2 = 203;
						continue;
					case 85:
						array[31] = (byte)num4;
						num2 = 166;
						continue;
					case 251:
						array[20] = 148;
						num2 = 266;
						continue;
					case 349:
						num5 = 233 + 16;
						num2 = 319;
						continue;
					case 26:
						array[17] = (byte)num5;
						num2 = 194;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 22;
						}
						continue;
					case 4:
						array2[6] = (byte)num6;
						num2 = 33;
						continue;
					case 121:
						array[30] = (byte)num4;
						num2 = 60;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 39;
						}
						continue;
					case 234:
						num6 = 244 - 81;
						num2 = 89;
						continue;
					case 212:
						array2[4] = 105;
						num2 = 136;
						continue;
					case 188:
						array[31] = (byte)num4;
						num2 = 97;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 143;
						}
						continue;
					case 138:
						array[18] = (byte)num4;
						num2 = 53;
						continue;
					case 248:
						array3 = array2;
						num2 = 330;
						continue;
					case 11:
						array[2] = 150;
						num2 = 185;
						continue;
					case 283:
						array2[13] = 98;
						num2 = 146;
						continue;
					case 10:
						array[10] = (byte)num5;
						num2 = 156;
						continue;
					case 168:
						array[13] = (byte)num5;
						num2 = 84;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 58;
						}
						continue;
					case 167:
						array[22] = (byte)num5;
						num2 = 162;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 147;
						}
						continue;
					case 357:
						array2[12] = 145;
						num2 = 207;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 220;
						}
						continue;
					case 264:
						array[25] = 110;
						num2 = 51;
						continue;
					case 277:
						num5 = 137 - 52;
						num2 = 296;
						continue;
					case 185:
						array[3] = 163;
						num2 = 134;
						continue;
					case 182:
						num4 = 237 - 79;
						num2 = 253;
						continue;
					case 108:
						num6 = 132 - 44;
						num = 152;
						break;
					case 193:
						num4 = 99 + 93;
						num2 = 0;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 1;
						}
						continue;
					case 70:
						array[24] = 31;
						num2 = 129;
						continue;
					case 28:
						return;
					case 171:
						array[12] = 114;
						num2 = 111;
						continue;
					case 95:
						array2[10] = (byte)num3;
						num = 92;
						break;
					case 98:
						num3 = 12 + 75;
						num2 = 322;
						continue;
					case 244:
						array[1] = (byte)num5;
						num2 = 55;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 214;
						}
						continue;
					case 2:
						array3[13] = array4[6];
						num2 = 96;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 109;
						}
						continue;
					case 241:
						if (array4.Length != 0)
						{
							num2 = 73;
							continue;
						}
						goto case 102;
					case 184:
						num6 = 98 + 31;
						num2 = 240;
						continue;
					case 15:
						array[1] = (byte)num4;
						num2 = 106;
						continue;
					case 268:
						num4 = 205 - 68;
						num2 = 107;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 0;
						}
						continue;
					case 328:
						num5 = 67 + 90;
						num2 = 158;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 131;
						}
						continue;
					case 6:
						array[19] = 151;
						num2 = 279;
						continue;
					case 308:
						array[31] = (byte)num5;
						num2 = 321;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 278;
						}
						continue;
					case 48:
						num5 = 132 - 44;
						num = 244;
						break;
					case 194:
						num5 = 97 + 40;
						num2 = 52;
						continue;
					case 74:
						array[10] = 137;
						num2 = 17;
						continue;
					case 219:
						array[7] = (byte)num5;
						num2 = 131;
						continue;
					case 5:
						array[26] = 121;
						num2 = 282;
						continue;
					case 282:
						num5 = 218 - 72;
						num2 = 64;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 29;
						}
						continue;
					case 46:
						array[6] = 200;
						num2 = 254;
						continue;
					case 275:
						num5 = 164 - 54;
						num2 = 299;
						continue;
					case 294:
						num3 = 202 - 67;
						num2 = 13;
						continue;
					case 224:
						num4 = 83 + 21;
						num2 = 311;
						continue;
					case 140:
						array2[5] = 200;
						num2 = 177;
						continue;
					case 79:
						array[29] = 162;
						num2 = 82;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 8;
						}
						continue;
					case 43:
						num6 = 236 - 78;
						num2 = 146;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 178;
						}
						continue;
					case 186:
						num4 = 93 + 108;
						num2 = 259;
						continue;
					case 31:
						array[13] = 101;
						num2 = 301;
						continue;
					case 111:
						num5 = 72 + 45;
						num2 = 271;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 108;
						}
						continue;
					case 27:
						num3 = 144 + 68;
						num2 = 132;
						continue;
					case 347:
						num3 = 156 - 52;
						num2 = 209;
						continue;
					case 158:
						array[19] = (byte)num5;
						num2 = 6;
						continue;
					case 90:
						array[4] = 10;
						num2 = 133;
						continue;
					case 154:
						num5 = 169 - 56;
						num2 = 292;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 280;
						}
						continue;
					case 40:
						num4 = 57 + 90;
						num2 = 112;
						continue;
					case 217:
						array[9] = (byte)num5;
						num2 = 176;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 131;
						}
						continue;
					case 295:
						array[8] = 114;
						num = 58;
						break;
					case 144:
						array[14] = (byte)num5;
						num2 = 224;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 31;
						}
						continue;
					case 92:
						array2[10] = 183;
						num = 225;
						break;
					case 152:
						array2[12] = (byte)num6;
						num2 = 306;
						continue;
					case 318:
						array6[num7] ^= array3[num7];
						num2 = 7;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 1;
						}
						continue;
					case 335:
						num4 = 212 - 70;
						num2 = 312;
						continue;
					case 161:
						num5 = 131 - 43;
						num = 114;
						break;
					case 7:
						num7++;
						num2 = 87;
						continue;
					case 149:
						array[11] = (byte)num4;
						num2 = 346;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 263;
						}
						continue;
					case 117:
						array[3] = (byte)num4;
						num2 = 23;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 55;
						}
						continue;
					case 257:
						array2[10] = (byte)num3;
						num = 270;
						break;
					case 222:
						array[2] = (byte)num4;
						num2 = 11;
						continue;
					case 325:
						array[1] = (byte)num5;
						num2 = 267;
						continue;
					case 348:
						array2[9] = 137;
						num2 = 331;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 10;
						}
						continue;
					case 125:
						array2[11] = 161;
						num2 = 294;
						continue;
					case 97:
						num4 = 111 - 76;
						num2 = 130;
						continue;
					case 239:
						if (P_1 == -1)
						{
							num2 = 94;
							if (!vtQGklmNSMWZRuMKOqI())
							{
								num2 = 69;
							}
							continue;
						}
						goto case 344;
					case 190:
						array2[3] = 205;
						num2 = 234;
						continue;
					case 336:
						num4 = 115 + 39;
						num2 = 300;
						continue;
					case 105:
					{
						Aqbje3R4pxmmxaoqrBd aqbje3R4pxmmxaoqrBd = new Aqbje3R4pxmmxaoqrBd(P_0);
						yWU3GbmZbPepPsfO73B(BQ5jTJmty2J5W2RisKg(aqbje3R4pxmmxaoqrBd), 0L);
						array5 = (byte[])c4sJfemBUm46T7sRLea(aqbje3R4pxmmxaoqrBd, (int)VXioI8mpQWJCVRCvNHK(BQ5jTJmty2J5W2RisKg(aqbje3R4pxmmxaoqrBd)));
						zWUtFIm8NY6NFu6rGEp(aqbje3R4pxmmxaoqrBd);
						num2 = 104;
						continue;
					}
					case 128:
						array[27] = (byte)num4;
						num2 = 66;
						continue;
					case 278:
						array3[7] = array4[3];
						num2 = 20;
						continue;
					case 170:
						array[29] = (byte)num5;
						num2 = 165;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 155;
						}
						continue;
					case 254:
						num5 = 205 - 68;
						num2 = 332;
						continue;
					case 35:
						array[1] = 114;
						num2 = 16;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 268;
						}
						continue;
					case 311:
						array[15] = (byte)num4;
						num2 = 237;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 345;
						}
						continue;
					case 310:
						array[0] = (byte)num4;
						num2 = 227;
						continue;
					case 260:
						array3[5] = array4[2];
						num2 = 278;
						continue;
					case 77:
						array2[15] = 98;
						num2 = 169;
						continue;
					case 47:
						array2[15] = 104;
						num2 = 77;
						continue;
					case 192:
						array[30] = 96;
						num2 = 218;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 243;
						}
						continue;
					case 340:
						array[30] = 144;
						num2 = 81;
						continue;
					case 91:
						array[6] = (byte)num4;
						num2 = 46;
						continue;
					case 169:
						array2[15] = 193;
						num2 = 248;
						continue;
					case 102:
					case 262:
						num7 = 0;
						num2 = 15;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 57;
						}
						continue;
					case 109:
						array3[15] = array4[7];
						num2 = 102;
						continue;
					case 200:
						array[1] = (byte)num5;
						num2 = 35;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 27;
						}
						continue;
					case 237:
						array[7] = 143;
						num2 = 88;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 8;
						}
						continue;
					case 265:
						array2[13] = (byte)num3;
						num2 = 317;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 104;
						}
						continue;
					case 199:
						num6 = 80 + 43;
						num2 = 172;
						continue;
					case 207:
						array2[14] = 97;
						num2 = 127;
						continue;
					case 309:
						array[0] = (byte)num5;
						num2 = 313;
						continue;
					case 298:
						num4 = 182 - 60;
						num2 = 2;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 91;
						}
						continue;
					case 52:
						array[17] = (byte)num5;
						num2 = 41;
						continue;
					case 42:
						array[16] = (byte)num4;
						num2 = 97;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 52;
						}
						continue;
					case 81:
						array[30] = 186;
						num2 = 246;
						continue;
					case 226:
						array2[3] = 78;
						num2 = 65;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 190;
						}
						continue;
					case 288:
						num5 = 18 + 118;
						num2 = 26;
						continue;
					case 233:
						num5 = 153 + 58;
						num = 96;
						break;
					case 73:
						array3[1] = array4[0];
						num2 = 335;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 343;
						}
						continue;
					case 300:
						array[13] = (byte)num4;
						num2 = 31;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 10;
						}
						continue;
					case 191:
						array2[7] = (byte)num6;
						num2 = 45;
						continue;
					case 150:
						array[14] = 144;
						num2 = 183;
						continue;
					case 215:
						array2[5] = 142;
						num2 = 14;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 62;
						}
						continue;
					case 57:
					case 87:
						if (num7 >= array3.Length)
						{
							num = 239;
							break;
						}
						goto case 318;
					case 293:
						num5 = 100 + 106;
						num2 = 250;
						continue;
					case 299:
						array[21] = (byte)num5;
						num2 = 161;
						continue;
					case 131:
						array[7] = 104;
						num2 = 68;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 237;
						}
						continue;
					case 54:
						array3[11] = array4[5];
						num2 = 2;
						continue;
					case 179:
						array2[4] = (byte)num3;
						num2 = 285;
						continue;
					case 286:
						num5 = 190 - 63;
						num2 = 235;
						continue;
					case 93:
						array2[10] = (byte)num3;
						num = 125;
						break;
					case 37:
						array2[9] = (byte)num3;
						num2 = 329;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 297;
						}
						continue;
					case 339:
						ciORRPouSO = 80;
						num2 = 52;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 115;
						}
						continue;
					case 334:
						array[25] = 46;
						num2 = 305;
						continue;
					case 67:
						num5 = 159 - 53;
						num2 = 219;
						continue;
					case 177:
						array2[5] = 137;
						num2 = 354;
						continue;
					case 172:
						array2[8] = (byte)num6;
						num2 = 27;
						continue;
					case 69:
						num4 = 75 + 69;
						num2 = 42;
						continue;
					case 313:
						array[0] = 131;
						num = 48;
						break;
					case 23:
						num4 = 225 - 75;
						num2 = 52;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 149;
						}
						continue;
					case 287:
						num6 = 12 + 11;
						num2 = 0;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 0;
						}
						continue;
					case 166:
						array[31] = 122;
						num2 = 355;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 181;
						}
						continue;
					case 229:
						array2[0] = 102;
						num2 = 83;
						continue;
					case 210:
						array2[7] = 42;
						num2 = 291;
						continue;
					case 218:
						num4 = 118 + 124;
						num2 = 141;
						continue;
					case 123:
						array2[5] = (byte)num3;
						num2 = 215;
						continue;
					case 107:
						array[2] = (byte)num4;
						num2 = 99;
						continue;
					case 323:
						array[18] = 208;
						num2 = 324;
						continue;
					case 273:
						array2[14] = (byte)num6;
						num2 = 43;
						continue;
					case 134:
						array[3] = 180;
						num2 = 6;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 101;
						}
						continue;
					case 106:
						num5 = 157 - 52;
						num2 = 4;
						if (vtQGklmNSMWZRuMKOqI())
						{
							num2 = 164;
						}
						continue;
					case 1:
						array[23] = (byte)num4;
						num2 = 14;
						if (iyPJ2DmMDBEWrUg8LXb() == null)
						{
							num2 = 68;
						}
						continue;
					case 285:
						num3 = 250 - 83;
						num2 = 123;
						if (!vtQGklmNSMWZRuMKOqI())
						{
							num2 = 6;
						}
						continue;
					case 301:
						array[13] = 11;
						num2 = 21;
						if (iyPJ2DmMDBEWrUg8LXb() != null)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static string nRtFZKeQPU(int P_0)
		{
			if (V1dRxhaOqf.Length == 0)
			{
				wPbR3fgIdB = new List<string>();
				EnCRfvQ3XX = new List<int>();
				J9cFti2oeg(H6HFsaaMmY.GetManifestResourceStream("k0U9WuFLG0gah7upy8.eNWKsDRxdhqL7DZUL9"), P_0);
			}
			if (ciORRPouSO < 75)
			{
				if ((object)H6HFsaaMmY != new StackFrame(1).GetMethod().DeclaringType.Assembly)
				{
					throw new Exception();
				}
				ciORRPouSO++;
			}
			lock (KhTRmBlJVM)
			{
				int num = BitConverter.ToInt32(V1dRxhaOqf, P_0);
				if (num < EnCRfvQ3XX.Count && EnCRfvQ3XX[num] == P_0)
				{
					return wPbR3fgIdB[num];
				}
				try
				{
					bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
					byte[] array = new byte[num];
					Array.Copy(V1dRxhaOqf, P_0 + 4, array, 0, num);
					string text = Encoding.Unicode.GetString(array, 0, array.Length);
					wPbR3fgIdB.Add(text);
					EnCRfvQ3XX.Add(P_0);
					Array.Copy(BitConverter.GetBytes(wPbR3fgIdB.Count - 1), 0, V1dRxhaOqf, P_0, 4);
					return text;
				}
				catch
				{
				}
			}
			return "";
		}

		internal static string mj7FpXME5K(string P_0)
		{
			"{11111-22222-50001-00000}".Trim();
			byte[] array = Convert.FromBase64String(P_0);
			return Encoding.Unicode.GetString(array, 0, array.Length);
		}

		private static int xM5FBApMhh()
		{
			return 5;
		}

		private static void AUaF8FhFFh()
		{
			try
			{
				RSACryptoServiceProvider.UseMachineKeyStore = true;
			}
			catch
			{
			}
		}

		private static Delegate tPjFJNnSIy(IntPtr P_0, Type P_1)
		{
			return (Delegate)typeof(Marshal).GetMethod("GetDelegateForFunctionPointer", new Type[2]
			{
				typeof(IntPtr),
				typeof(Type)
			}).Invoke(null, new object[2] { P_0, P_1 });
		}

		internal static object jcGFhdc2Ts(object P_0)
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
		public static extern IntPtr sXKFH3O3dS(string P_0);

		[DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress")]
		public static extern IntPtr wgeFyBSLys(IntPtr P_0, string P_1);

		private static IntPtr XedFjt7R2x(IntPtr P_0, string P_1, uint P_2)
		{
			if (XbaRM3YiTV == null)
			{
				XbaRM3YiTV = (VRRmjuRoU0hfdwdCCSk)Marshal.GetDelegateForFunctionPointer(wgeFyBSLys(xMpiFL8WN(), "Find ".Trim() + "ResourceA"), typeof(VRRmjuRoU0hfdwdCCSk));
			}
			return XbaRM3YiTV(P_0, P_1, P_2);
		}

		private static IntPtr U1xFivDbqU(IntPtr P_0, uint P_1, uint P_2, uint P_3)
		{
			if (gh4Rt85nxA == null)
			{
				gh4Rt85nxA = (ixOowKROVJkvwIEY3tU)Marshal.GetDelegateForFunctionPointer(wgeFyBSLys(xMpiFL8WN(), "Virtual ".Trim() + "Alloc"), typeof(ixOowKROVJkvwIEY3tU));
			}
			return gh4Rt85nxA(P_0, P_1, P_2, P_3);
		}

		private static int AvcFSCumN1(IntPtr P_0, IntPtr P_1, [In][Out] byte[] P_2, uint P_3, out IntPtr P_4)
		{
			if (XCtRZnfDgY == null)
			{
				XCtRZnfDgY = (GNK61GRVAbdDKENMcn4)Marshal.GetDelegateForFunctionPointer(wgeFyBSLys(xMpiFL8WN(), "Write ".Trim() + "Process ".Trim() + "Memory"), typeof(GNK61GRVAbdDKENMcn4));
			}
			return XCtRZnfDgY(P_0, P_1, P_2, P_3, out P_4);
		}

		private static int k3lF6AU1Qq(IntPtr P_0, int P_1, int P_2, ref int P_3)
		{
			if (LGsRpAE61j == null)
			{
				LGsRpAE61j = (T6haf8Rb0fgW3hJTCnb)Marshal.GetDelegateForFunctionPointer(wgeFyBSLys(xMpiFL8WN(), "Virtual ".Trim() + "Protect"), typeof(T6haf8Rb0fgW3hJTCnb));
			}
			return LGsRpAE61j(P_0, P_1, P_2, ref P_3);
		}

		private static IntPtr N5CFg677sY(uint P_0, int P_1, uint P_2)
		{
			if (aV2RB5VJEq == null)
			{
				aV2RB5VJEq = (gSqMZHRISDfpm15VhCK)Marshal.GetDelegateForFunctionPointer(wgeFyBSLys(xMpiFL8WN(), "Open ".Trim() + "Process"), typeof(gSqMZHRISDfpm15VhCK));
			}
			return aV2RB5VJEq(P_0, P_1, P_2);
		}

		private static int HLWF1WFrTe(IntPtr P_0)
		{
			if (YX2R8ncyLg == null)
			{
				YX2R8ncyLg = (sKR4sQRW94ZrB02fyMa)Marshal.GetDelegateForFunctionPointer(wgeFyBSLys(xMpiFL8WN(), "Close ".Trim() + "Handle"), typeof(sKR4sQRW94ZrB02fyMa));
			}
			return YX2R8ncyLg(P_0);
		}

		[SpecialName]
		private static IntPtr xMpiFL8WN()
		{
			if (VBkRJDU77f == IntPtr.Zero)
			{
				VBkRJDU77f = sXKFH3O3dS("kernel ".Trim() + "32.dll");
			}
			return VBkRJDU77f;
		}

		private static byte[] AHKFcR0mW9(string P_0)
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

		internal static Stream b1YFqnkHJC()
		{
			return new MemoryStream();
		}

		internal static byte[] lgMF4GAGqe(Stream P_0)
		{
			return ((MemoryStream)P_0).ToArray();
		}

		private static byte[] usdFQCkhjb(byte[] P_0)
		{
			Stream stream = b1YFqnkHJC();
			SymmetricAlgorithm symmetricAlgorithm = FhJFYq4EIl();
			symmetricAlgorithm.Key = new byte[32]
			{
				198, 219, 226, 53, 196, 247, 203, 250, 62, 93,
				1, 105, 181, 251, 182, 242, 131, 206, 210, 205,
				140, 10, 117, 45, 223, 17, 134, 61, 119, 6,
				133, 36
			};
			symmetricAlgorithm.IV = new byte[16]
			{
				91, 101, 9, 167, 125, 152, 206, 168, 0, 124,
				249, 226, 228, 121, 247, 202
			};
			CryptoStream cryptoStream = new CryptoStream(stream, symmetricAlgorithm.CreateDecryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(P_0, 0, P_0.Length);
			cryptoStream.Close();
			byte[] result = lgMF4GAGqe(stream);
			bcWtvFRdllaQ3U39Nte.PDkmTPFrns();
			return result;
		}

		private byte[] RdQFTtuZ6S()
		{
			return null;
		}

		private byte[] yYtFK4O6Jl()
		{
			return null;
		}

		private byte[] h1YFPkFlR3()
		{
			_ = "{11111-22222-20001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] y0ZFeXKNRt()
		{
			_ = "{11111-22222-20001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] aUlFo7kRde()
		{
			_ = "{11111-22222-30001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		private byte[] OoLFOdGvBQ()
		{
			_ = "{11111-22222-30001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] YqnFV42qd5()
		{
			_ = "{11111-22222-40001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] fN1FbCTFAn()
		{
			_ = "{11111-22222-40001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] I96FIL7dXJ()
		{
			_ = "{11111-22222-50001-00001}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal byte[] Y9JFWroeRT()
		{
			_ = "{11111-22222-50001-00002}".Length;
			_ = 0;
			return new byte[2] { 1, 2 };
		}

		internal static object BQ5jTJmty2J5W2RisKg(object P_0)
		{
			return ((Aqbje3R4pxmmxaoqrBd)P_0).f9UtU12u5A();
		}

		internal static void yWU3GbmZbPepPsfO73B(object P_0, long P_1)
		{
			((Stream)P_0).Position = P_1;
		}

		internal static long VXioI8mpQWJCVRCvNHK(object P_0)
		{
			return ((Stream)P_0).Length;
		}

		internal static object c4sJfemBUm46T7sRLea(object P_0, int P_1)
		{
			return ((Aqbje3R4pxmmxaoqrBd)P_0).ngTRQ5lr60(P_1);
		}

		internal static void zWUtFIm8NY6NFu6rGEp(object P_0)
		{
			((Aqbje3R4pxmmxaoqrBd)P_0).y0LRPDiN5E();
		}

		internal static void Juce31mJC4ZVfjyOyKL(object P_0)
		{
			Array.Reverse((Array)P_0);
		}

		internal static object yh7pVmmhv0KncKef98u(object P_0)
		{
			return ((Assembly)P_0).GetName();
		}

		internal static object xQEMiLmHuxDxRn9ls6m(object P_0)
		{
			return ((AssemblyName)P_0).GetPublicKeyToken();
		}

		internal static object IrbrAumyewvTa4034mB()
		{
			return FhJFYq4EIl();
		}

		internal static void JJCU6amj0AaFtFOvFIF(object P_0, CipherMode P_1)
		{
			((SymmetricAlgorithm)P_0).Mode = P_1;
		}

		internal static object Ody6Hbmi5XorcT2UdPc(object P_0, object P_1, object P_2)
		{
			return ((SymmetricAlgorithm)P_0).CreateDecryptor((byte[])P_1, (byte[])P_2);
		}

		internal static object pTiNJJmSTZZ6vjXrrgB()
		{
			return b1YFqnkHJC();
		}

		internal static void RMg63Pm6EewUctpGsB8(object P_0, object P_1, int P_2, int P_3)
		{
			((Stream)P_0).Write((byte[])P_1, P_2, P_3);
		}

		internal static void eDrPSZmg4AIH1ymxb68(object P_0)
		{
			((CryptoStream)P_0).FlushFinalBlock();
		}

		internal static object Ok16Pbm1o0jFn4Nb6oK(object P_0)
		{
			return lgMF4GAGqe((Stream)P_0);
		}

		internal static void AdH3sBmcbGjVcFKbRJi(object P_0)
		{
			((Stream)P_0).Close();
		}

		internal static object CnQP2Gmqn6hTejt0tJb(object P_0)
		{
			return ((Assembly)P_0).EntryPoint;
		}

		internal static bool vtQGklmNSMWZRuMKOqI()
		{
			return null == null;
		}

		internal static object iyPJ2DmMDBEWrUg8LXb()
		{
			return null;
		}
	}
}
namespace lea45fRkMrnErfZSUlX
{
	internal class bcWtvFRdllaQ3U39Nte
	{
		private static bool gWORnhTvA7;

		internal static void PDkmTPFrns()
		{
			if (!gWORnhTvA7)
			{
				gWORnhTvA7 = true;
				if (Math.Sign((DateTime.Now - new DateTime(2024, 8, 4)).Days) >= 14)
				{
					throw new Exception("This assembly is protected by an unregistered version of Eziriz's \".NET Reactor\"! This assembly won't further work.");
				}
			}
		}
	}
}
internal sealed class <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}
{
	internal int m_305943fedccc4694af3b7c7d8ba81fff;

	internal int m_3525d20eb35d4d2ebb9de8216eecc96d;

	internal int m_4cdf08a787fa46f6ad1ac1a349eb0c66;

	internal int m_2cdaf700d452430f8b7937a2df3c14ab;

	internal int m_12278168a7dd460a9d76302e6746538e;

	internal int m_3f3feaa4ea4c4745bc1164f526843ff9;

	internal int m_f0d7f5763e0b41369037110a8e966fff;

	internal int m_44937069ef704349b01107d6ac5c029f;

	internal int m_d2abd16e73af48508c51a02e08a3b86e;

	internal int m_3c6f27b9a01743a391e93a7ed10d48d7;

	internal int m_d3c8ee9d3abe49229295d188af1ea5c4;

	internal int m_0f852641438548279b3374c7696ca48d;

	internal int m_10806a5d8d3c43cdb347123341c4a124;

	internal int m_3fc8bda115744a9194e9511a9d190dfa;

	internal int m_f93a4a8a4b6948ec93de732c2026a4f9;

	internal int m_2de3808eb5e74ff98b4f8303b45f7b2a;

	internal int m_0dbed6424fae410cb4d09c0e568a6d0a;

	internal int m_c3e0e965608a480595a07728c95593ca;

	internal int m_4a1438034cc84d7c8968498e7520a583;

	internal int m_3f0b022e5276431d89b41e9a8e236e4a;

	internal int m_6a1b127434024a51984afeb81aa17f7e;

	internal int m_ae556f08b158445a966f2251347dd6e5;

	internal int m_ebd46b1882a14ffdbe389425ae97292d;

	internal int m_dc465dfc7f7e47b69d0f5975655d640a;

	internal int m_856b64606aac4ca69abc3044ba4601bc;

	internal int m_6f12f56af2764cb090fa3ad2f20cac49;

	internal int m_ea9e2dc1f06e4f1f85abdf49fcc2cbf8;

	internal int m_bebf881a079d4a7496932f7318496671;

	internal int m_69f2e73aa7364c2d861ef1dff92976d6;

	internal int m_c50d087b4bf64c2ab02de7d9a5c3826f;

	internal int m_1cdaed15ec2b4142bfd3b8ed8232877d;

	internal int m_c7b47942e9a7477db75fe28ac0b2a164;

	internal int m_db9fde00cee841ca8bc26eac2c4289d1;

	internal int m_1ea567c36ed34193b84158b86c192316;

	internal int m_58a1c4685aed4f6c8425754ca88bd778;

	internal int m_a39c9730be1747b29b109634c6b9e019;

	internal int m_483046811ad841a399f88a400fb321a1;

	internal int m_09041336954d44aa8ec29555dcdc7372;

	internal int m_df8b92ad925543d28f184b38da986b0e;

	internal int m_a6ae5352d56f4091966d41b1207c37c3;

	internal int m_ae54eb74d1d64b939d5c344d29e154e8;

	internal int m_f2f1c15f4322463d86275ef75836f753;

	internal int m_203b9afcfabf450788f3d9e58c04f921;

	internal int m_ae2fe929ae1642509f71a46a8869630c;

	internal int m_324c6aed27fe46649d8967f09897123e;

	internal int m_0744a4e44f454939b4f59b117e0e34b1;

	internal int m_29bef0c6f4ce4c2a992543bc95f15eff;

	internal int m_3c5fc839cf2f47ba8a902e2adb37983a;

	internal int m_0466e48aa993460f860ca336733363d4;

	internal static <Module>{bc451bce-102b-41ff-97a9-745e19bf326f} m_27ee0b34dbdd41f6a97c971e3a929d6d;

	internal int m_4f4455ffd8f5482fbfcda1eddd8a324d;

	internal int m_48705551457045cf9e2c2f222f96f7cc;

	internal int m_ae01ae78a7944cad96133fd0f7262991;

	internal int m_dcca42573756400b8f6f41d288be7ab1;

	internal int m_2dd9cc63b5d94fbcbbf7131e4531a1b2;

	internal int m_3baab05ef215495ea406a709ec20fa09;

	internal int m_bd31fb283a30484a906a93799db8baf8;

	internal int m_04a530b5f3fd4a4590d932fb61015c44;

	internal int m_12d08711f24b45aeb025242de6bdf201;

	internal int m_993d108a651d45a6ae5049a3c7401f7f;

	internal int m_65174a8264aa4fc3a86f0babd3e6fbd6;

	internal int m_9a0d5436dfd84c21b3b369a39ea84993;

	internal int m_530f584a7e264d7f9ba00d31e0f2d3a6;

	internal int m_1bc3edf5fbfe47e1afcfa2939332c1cc;

	internal int m_975652dd350f409cadedf7ce7925aa1b;

	internal int m_7c7afd11aeff488095933084973cfed6;

	internal int m_8408b83f5ed14a5793851ceceeec159f;

	internal int m_76fb8ae174dd497196ffc333290473ba;

	internal int m_00e11a0e689d4a3a892817b336ed611e;

	internal int m_0b5edac9fd494507a2df84fa68a1ad5b;

	internal int m_4313618cb35b48668b0149423a2baac8;

	internal int m_46a2b85a980141949398afee3bb64984;

	internal int m_585391b38ff5476295021a21b49d6327;

	internal int m_7cf4d753c3ee45738a016c05321956af;

	internal int m_24f5c35a2b9647d6b4d76afdc6e15626;

	internal int m_7c647daad1d044758fb5b81d01099e6b;

	internal int m_0fdc50d290be43888d76c6ab23e4daac;

	internal int m_49cceedf82564dd6ac4d3f4ca247767c;

	internal int m_c0d6c5ba75554d0c9b9f44239137eb2b;

	internal int m_2806009bc4b947a0b229a5d5dcbab7d8;

	internal int m_efcc946ac9a7496881d438f0cd5eed7d;

	internal int m_f056e5b57f324161853f9fd34ad5defb;

	internal int m_f1f27de5046541fa90329c1cd2a9ff22;

	internal int m_999d058f5d524287a796281866e6f8e3;

	internal int m_0546a7aaf9a1432a80ceb9bd6208f120;

	internal int m_cb7bccec28ce421e80ee924d712e6917;

	internal int m_a5686d36bbc647feb4e0993f6489f3f0;

	internal int m_3d979e370c414c0fb7c345adc12f6de8;

	internal int m_45f85c7a24624948ac8d1e2d9d91fcdb;

	internal int m_548fadf6f488427c87fd86e2c422f0ed;

	internal int m_a8965b17cd1d424b923d9a39fbe9e2e8;

	internal int m_88e80f2af9a9495aaa62353b97368b4d;

	internal int m_431465af734a44679100076610fb698b;

	internal int m_0260d5c31e634cce86323a1b230c41f8;

	internal int m_fb1f581aa21749f6b436f705bb702049;

	internal int m_96d243f12c8d4979802276052cc8ad5b;

	internal int m_97b3326518e84e0fb1f54462099f0c8b;

	internal int m_c9e09e8039e44f658f1c68d6b170b3c0;

	internal int m_36c7c0918c0e47e48a4c17fe309a8888;

	internal int m_34dba5a19f7c43f1884d825778c0d820;

	internal int m_fbe205cd4a6642cb897f66ef64b311f6;

	internal int m_283001a380f24857821833e8f3885f08;

	internal int m_4d551909784346a7b40161671b3cc259;

	internal int m_f3858a3319c346f385f2de82d19cb863;

	internal int m_b0c481608fb042b29454cf269aedf639;

	internal int m_3e52682f8b6b44ae956439bed246f839;

	internal int m_05b92f5c97f94d6a956ac3b5966fbb6b;

	internal int m_87efaae4c80f424d94c65416bc641a4a;

	internal int m_dc27d6aced424efd9dcfa9dddbdd8c8a;

	internal int m_9ed05a6d2642425e95a90a5597a8dfc1;

	internal int m_e010b982d79844f0a0ad44b93a5ff74a;

	internal int m_26b689b281eb4ebbbb29db4ea630e39f;

	internal int m_afe6eed4d027491abe6d98f730bf8dd0;

	internal int m_b9df54da1843468090510c830172fc5b;

	internal int m_fc3c43d5ece44796b51e0b7a7e15b5be;

	internal int m_d5a748ff66e44a84906f4d303f5a262d;

	internal int m_2f7c3a097cb543339e1f9d4620425d26;

	internal int m_97f39efe74614bf1a3be32c2615f9577;

	internal int m_7e8c963ee0c84c82b284848300471c9d;

	internal int m_74a228a407aa4a72902a9bea5b1a6dae;

	internal int m_92636064a4e1483493ee58fcad7de0b4;

	internal int m_0c2ff0ecd123410b8472a6c17420fb81;

	internal int m_d4c6cba2983840c09edfb40cbcbd76cd;

	static <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}()
	{
		fb66a62b765af4e5688d51c993916cbfb();
	}

	internal static void fb66a62b765af4e5688d51c993916cbfb()
	{
		m_27ee0b34dbdd41f6a97c971e3a929d6d = new <Module>{bc451bce-102b-41ff-97a9-745e19bf326f}();
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_fbe205cd4a6642cb897f66ef64b311f6 = -2018237347 ^ -2018237347;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_d2abd16e73af48508c51a02e08a3b86e = -950358175 ^ -240999620;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_97f39efe74614bf1a3be32c2615f9577 = -1745288902 ^ -178131197;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_431465af734a44679100076610fb698b = ~(-1069878398) ^ 0x23CFF9;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_6f12f56af2764cb090fa3ad2f20cac49 = -(-884254470) ^ 0x124F48C6;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_fc3c43d5ece44796b51e0b7a7e15b5be = -(-405925340 - 235409559) ^ 0x4170EDD3;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3525d20eb35d4d2ebb9de8216eecc96d = -525773579 ^ -525773579;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_a8965b17cd1d424b923d9a39fbe9e2e8 = 0x59E394B ^ 0x59E394B;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_2dd9cc63b5d94fbcbbf7131e4531a1b2 = -1565556138 ^ -1565556138;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c0d6c5ba75554d0c9b9f44239137eb2b = -unchecked(-1947804249 + -972628121) ^ -2093362521;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_df8b92ad925543d28f184b38da986b0e = -1851235226 ^ -1904193897;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_10806a5d8d3c43cdb347123341c4a124 = -929037838 ^ -929037838;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_46a2b85a980141949398afee3bb64984 = -538418944 ^ -538418944;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_d3c8ee9d3abe49229295d188af1ea5c4 = 0x18B5EA0B ^ 0x18B5EA0B;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_96d243f12c8d4979802276052cc8ad5b = 0x81DE24E ^ 0x18707C3E;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_24f5c35a2b9647d6b4d76afdc6e15626 = -128393514 ^ -681636538;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_1cdaed15ec2b4142bfd3b8ed8232877d = -1565556138 ^ -1774979427;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3e52682f8b6b44ae956439bed246f839 = -1917014 ^ -1917014;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_fb1f581aa21749f6b436f705bb702049 = 0xF39135 ^ 0x15F94642;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0f852641438548279b3374c7696ca48d = -2145489008 ^ -2145489008;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_bd31fb283a30484a906a93799db8baf8 = -1565556138 ^ -1565556138;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0466e48aa993460f860ca336733363d4 = -(288504065 - 1354734158) ^ 0x3E922D7B;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_305943fedccc4694af3b7c7d8ba81fff = -1826491606 ^ -1739997893;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_34dba5a19f7c43f1884d825778c0d820 = 0xF39135 ^ 0x6987E611;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0546a7aaf9a1432a80ceb9bd6208f120 = -(-735973547) ^ 0x2BDE10AB;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_a6ae5352d56f4091966d41b1207c37c3 = -1745288902 ^ -366805706;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0fdc50d290be43888d76c6ab23e4daac = -341838094 ^ -341838094;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0b5edac9fd494507a2df84fa68a1ad5b = -696415370 ^ -1309283725;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_203b9afcfabf450788f3d9e58c04f921 = -(-173689621 ^ -945007185) ^ -839508292;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_975652dd350f409cadedf7ce7925aa1b = -525773579 ^ -1492590861;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_7c647daad1d044758fb5b81d01099e6b = -unchecked(-1947804249 + -972628121) ^ -1374534926;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4a1438034cc84d7c8968498e7520a583 = 0xE6D4E0B ^ 0x19FF3009;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_993d108a651d45a6ae5049a3c7401f7f = 0x3764657D ^ 0x3764657D;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_04a530b5f3fd4a4590d932fb61015c44 = 0x2EE52EDD ^ 0xBDFE783;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_dc27d6aced424efd9dcfa9dddbdd8c8a = -unchecked(-1678195234 - 2063435055) ^ -1850152508;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_58a1c4685aed4f6c8425754ca88bd778 = -355009895 ^ -355009895;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_283001a380f24857821833e8f3885f08 = -1868665771 ^ -835045798;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_45f85c7a24624948ac8d1e2d9d91fcdb = 0x23A1612D ^ 0x79B7B207;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_9a0d5436dfd84c21b3b369a39ea84993 = -119414673 ^ -119414673;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_b0c481608fb042b29454cf269aedf639 = -340511085 ^ -340511085;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_7cf4d753c3ee45738a016c05321956af = -(-884254470) ^ 0x34B4A706;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_f1f27de5046541fa90329c1cd2a9ff22 = -(-405925340 - 235409559) ^ 0x2639FE73;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3f0b022e5276431d89b41e9a8e236e4a = -2107799170 ^ -2107799170;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae556f08b158445a966f2251347dd6e5 = -538418944 ^ -637946444;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4f4455ffd8f5482fbfcda1eddd8a324d = -(-884254470) ^ 0x256C2454;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_97b3326518e84e0fb1f54462099f0c8b = 0x8698520 ^ 0x27D64F91;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_dcca42573756400b8f6f41d288be7ab1 = 0xF3E59EB ^ 0x35295676;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0260d5c31e634cce86323a1b230c41f8 = 0x2CDB32A4 ^ 0x733A63F9;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3baab05ef215495ea406a709ec20fa09 = -2145489008 ^ -2145489008;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_26b689b281eb4ebbbb29db4ea630e39f = -31394773 ^ -31394773;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_6a1b127434024a51984afeb81aa17f7e = -86520077 ^ -86520077;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_1ea567c36ed34193b84158b86c192316 = -950358175 ^ -950358175;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_44937069ef704349b01107d6ac5c029f = 0x1050BE1D ^ 0x7E54A23;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3c5fc839cf2f47ba8a902e2adb37983a = 0xDF73973 ^ 0x64015FA;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c7b47942e9a7477db75fe28ac0b2a164 = -(552185944 >> 5) ^ -17255810;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_d5a748ff66e44a84906f4d303f5a262d = -1826491606 ^ -44505075;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_1bc3edf5fbfe47e1afcfa2939332c1cc = -1745288902 ^ -1745288902;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_efcc946ac9a7496881d438f0cd5eed7d = -1482286804 ^ -2142678590;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_48705551457045cf9e2c2f222f96f7cc = -903410432 ^ -660405251;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_09041336954d44aa8ec29555dcdc7372 = -903410432 ^ -1325744820;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0744a4e44f454939b4f59b117e0e34b1 = -903410432 ^ -903410432;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae54eb74d1d64b939d5c344d29e154e8 = 0x5855D2C2 ^ 0x5855D2C2;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_bebf881a079d4a7496932f7318496671 = -119414673 ^ -1228161195;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_856b64606aac4ca69abc3044ba4601bc = 0x270E40A5 ^ 0x2E0423AE;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_9ed05a6d2642425e95a90a5597a8dfc1 = -136366395 ^ -136366395;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_8408b83f5ed14a5793851ceceeec159f = -unchecked(-1678195234 - 2063435055) ^ -1146596461;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_999d058f5d524287a796281866e6f8e3 = -1917014 ^ -38081920;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_2cdaf700d452430f8b7937a2df3c14ab = 0x81DE24E ^ 0x123AF71F;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c3e0e965608a480595a07728c95593ca = -340511085 ^ -1841151708;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_00e11a0e689d4a3a892817b336ed611e = 0x5F843D54 ^ 0x5F843D54;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0dbed6424fae410cb4d09c0e568a6d0a = -696415370 ^ -696415370;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c50d087b4bf64c2ab02de7d9a5c3826f = 0xC44F292 ^ 0x6257DF02;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_12278168a7dd460a9d76302e6746538e = -31394773 ^ -31394773;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae2fe929ae1642509f71a46a8869630c = 0x12DFF7B0 ^ 0x12DFF7B0;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_a5686d36bbc647feb4e0993f6489f3f0 = 0xF3E59EB ^ 0xF3E59EB;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_29bef0c6f4ce4c2a992543bc95f15eff = -136366395 ^ -136366395;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_f93a4a8a4b6948ec93de732c2026a4f9 = -896319692 ^ -896319692;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_76fb8ae174dd497196ffc333290473ba = 0x2ABD101 ^ 0x3CA279C6;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_483046811ad841a399f88a400fb321a1 = -1581409127 ^ -1581409127;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_dc465dfc7f7e47b69d0f5975655d640a = 0xDF73973 ^ 0x224BC802;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4d551909784346a7b40161671b3cc259 = -1496421357 ^ -443052530;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_f0d7f5763e0b41369037110a8e966fff = -233588960 ^ -233588960;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ebd46b1882a14ffdbe389425ae97292d = -538418944 ^ -397768748;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_88e80f2af9a9495aaa62353b97368b4d = -594633998 ^ -594633998;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_cb7bccec28ce421e80ee924d712e6917 = -866803704 ^ -1352356546;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_a39c9730be1747b29b109634c6b9e019 = -950358175 ^ -950358175;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_db9fde00cee841ca8bc26eac2c4289d1 = -1784238080 ^ -997688999;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_7c7afd11aeff488095933084973cfed6 = -136366395 ^ -136366395;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4cdf08a787fa46f6ad1ac1a349eb0c66 = -866803704 ^ -866803704;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_69f2e73aa7364c2d861ef1dff92976d6 = -903410432 ^ -1870464887;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_548fadf6f488427c87fd86e2c422f0ed = -1917014 ^ -507651492;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_2f7c3a097cb543339e1f9d4620425d26 = 0x5F843D54 ^ 0x5F843D54;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ae01ae78a7944cad96133fd0f7262991 = -1482286804 ^ -823221868;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_12d08711f24b45aeb025242de6bdf201 = -903410432 ^ -1975950356;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_585391b38ff5476295021a21b49d6327 = -(-173689621 ^ -945007185) ^ -839508292;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_ea9e2dc1f06e4f1f85abdf49fcc2cbf8 = -unchecked(-1947804249 + -972628121) ^ -1374534926;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_b9df54da1843468090510c830172fc5b = -9686480 ^ -9686480;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_c9e09e8039e44f658f1c68d6b170b3c0 = 0xE6D4E0B ^ 0x12797628;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3d979e370c414c0fb7c345adc12f6de8 = -1784238080 ^ -1784238080;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_92636064a4e1483493ee58fcad7de0b4 = -929037838 ^ -929037838;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_2de3808eb5e74ff98b4f8303b45f7b2a = 0x270E40A5 ^ 0x727DAF45;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_74a228a407aa4a72902a9bea5b1a6dae = 0x8698520 ^ 0x24A859B9;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3fc8bda115744a9194e9511a9d190dfa = -128393514 ^ -1218968904;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_4313618cb35b48668b0149423a2baac8 = -31394773 ^ -31394773;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_7e8c963ee0c84c82b284848300471c9d = 0x75B787B8 ^ 0x7178E123;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_65174a8264aa4fc3a86f0babd3e6fbd6 = 0x71E85A2C ^ 0x71E85A2C;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_f3858a3319c346f385f2de82d19cb863 = -2107799170 ^ -2107799170;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3f3feaa4ea4c4745bc1164f526843ff9 = -1482286804 ^ -79224804;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_530f584a7e264d7f9ba00d31e0f2d3a6 = -594633998 ^ -2146860169;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_d4c6cba2983840c09edfb40cbcbd76cd = -891836976 ^ -891836976;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_36c7c0918c0e47e48a4c17fe309a8888 = -1772028290 ^ -1772028290;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_2806009bc4b947a0b229a5d5dcbab7d8 = 0x8698520 ^ 0x8698520;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_3c6f27b9a01743a391e93a7ed10d48d7 = 0x3175055F ^ 0x1F7B456D;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_05b92f5c97f94d6a956ac3b5966fbb6b = -1905701888 ^ -1905701888;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_324c6aed27fe46649d8967f09897123e = -1496421357 ^ -772650722;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_afe6eed4d027491abe6d98f730bf8dd0 = 0x3AA3305A ^ 0x3AA3305A;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_f056e5b57f324161853f9fd34ad5defb = -525773579 ^ -525773579;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_f2f1c15f4322463d86275ef75836f753 = 0x6DC90F60 ^ 0x6DC90F60;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_e010b982d79844f0a0ad44b93a5ff74a = -340511085 ^ -964283753;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_49cceedf82564dd6ac4d3f4ca247767c = -(-884254470) ^ 0x79FE99F3;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_0c2ff0ecd123410b8472a6c17420fb81 = 0x12DFF7B0 ^ 0x12DFF7B0;
		m_27ee0b34dbdd41f6a97c971e3a929d6d.m_87efaae4c80f424d94c65416bc641a4a = -1917014 ^ -1917014;
	}
}
