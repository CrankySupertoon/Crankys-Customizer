using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using SPLAT.My;

namespace SPLAT
{
	// Token: 0x0200000B RID: 11
	[DesignerGenerated]
	public partial class ContentPack : Form
	{
		// Token: 0x06000025 RID: 37 RVA: 0x0007BFC4 File Offset: 0x0007A3C4
		[DebuggerNonUserCode]
		public ContentPack()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000028 RID: 40 RVA: 0x0007D5EC File Offset: 0x0007B9EC
		// (set) Token: 0x06000029 RID: 41 RVA: 0x0007D600 File Offset: 0x0007BA00
		internal virtual Button DIP
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DIP;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DIP_Click);
				if (this._DIP != null)
				{
					this._DIP.Click -= value2;
				}
				this._DIP = value;
				if (this._DIP != null)
				{
					this._DIP.Click += value2;
				}
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002A RID: 42 RVA: 0x0007D64C File Offset: 0x0007BA4C
		// (set) Token: 0x0600002B RID: 43 RVA: 0x0007D660 File Offset: 0x0007BA60
		internal virtual Button Retooned
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Retooned;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Retooned_Click);
				if (this._Retooned != null)
				{
					this._Retooned.Click -= value2;
				}
				this._Retooned = value;
				if (this._Retooned != null)
				{
					this._Retooned.Click += value2;
				}
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0007D6AC File Offset: 0x0007BAAC
		// (set) Token: 0x0600002D RID: 45 RVA: 0x0007D6C0 File Offset: 0x0007BAC0
		internal virtual Button Nightlife
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Nightlife;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Nightlife_Click);
				if (this._Nightlife != null)
				{
					this._Nightlife.Click -= value2;
				}
				this._Nightlife = value;
				if (this._Nightlife != null)
				{
					this._Nightlife.Click += value2;
				}
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0007D70C File Offset: 0x0007BB0C
		// (set) Token: 0x0600002F RID: 47 RVA: 0x0007D720 File Offset: 0x0007BB20
		internal virtual Button HappyDays
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HappyDays;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HappyDays_Click);
				if (this._HappyDays != null)
				{
					this._HappyDays.Click -= value2;
				}
				this._HappyDays = value;
				if (this._HappyDays != null)
				{
					this._HappyDays.Click += value2;
				}
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000030 RID: 48 RVA: 0x0007D76C File Offset: 0x0007BB6C
		// (set) Token: 0x06000031 RID: 49 RVA: 0x0007D780 File Offset: 0x0007BB80
		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000032 RID: 50 RVA: 0x0007D78C File Offset: 0x0007BB8C
		// (set) Token: 0x06000033 RID: 51 RVA: 0x0007D7A0 File Offset: 0x0007BBA0
		internal virtual Label Label4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label4 = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000034 RID: 52 RVA: 0x0007D7AC File Offset: 0x0007BBAC
		// (set) Token: 0x06000035 RID: 53 RVA: 0x0007D7C0 File Offset: 0x0007BBC0
		internal virtual Label Label5
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label5;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label5 = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000036 RID: 54 RVA: 0x0007D7CC File Offset: 0x0007BBCC
		// (set) Token: 0x06000037 RID: 55 RVA: 0x0007D7E0 File Offset: 0x0007BBE0
		internal virtual Label Label6
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label6;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label6 = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000038 RID: 56 RVA: 0x0007D7EC File Offset: 0x0007BBEC
		// (set) Token: 0x06000039 RID: 57 RVA: 0x0007D800 File Offset: 0x0007BC00
		internal virtual Label Label7
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label7;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label7 = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600003A RID: 58 RVA: 0x0007D80C File Offset: 0x0007BC0C
		// (set) Token: 0x0600003B RID: 59 RVA: 0x0007D820 File Offset: 0x0007BC20
		internal virtual Button RetoonedTTPA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RetoonedTTPA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RetoonedTTPA_Click);
				if (this._RetoonedTTPA != null)
				{
					this._RetoonedTTPA.Click -= value2;
				}
				this._RetoonedTTPA = value;
				if (this._RetoonedTTPA != null)
				{
					this._RetoonedTTPA.Click += value2;
				}
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600003C RID: 60 RVA: 0x0007D86C File Offset: 0x0007BC6C
		// (set) Token: 0x0600003D RID: 61 RVA: 0x0007D880 File Offset: 0x0007BC80
		internal virtual Button DIPTTPA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DIPTTPA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DIPTTPA_Click);
				if (this._DIPTTPA != null)
				{
					this._DIPTTPA.Click -= value2;
				}
				this._DIPTTPA = value;
				if (this._DIPTTPA != null)
				{
					this._DIPTTPA.Click += value2;
				}
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600003E RID: 62 RVA: 0x0007D8CC File Offset: 0x0007BCCC
		// (set) Token: 0x0600003F RID: 63 RVA: 0x0007D8E0 File Offset: 0x0007BCE0
		internal virtual Button NightlifeTTPA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NightlifeTTPA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NightlifeTTPA_Click);
				if (this._NightlifeTTPA != null)
				{
					this._NightlifeTTPA.Click -= value2;
				}
				this._NightlifeTTPA = value;
				if (this._NightlifeTTPA != null)
				{
					this._NightlifeTTPA.Click += value2;
				}
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000040 RID: 64 RVA: 0x0007D92C File Offset: 0x0007BD2C
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0007D940 File Offset: 0x0007BD40
		internal virtual Button HappyDaysTTPA
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HappyDaysTTPA;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HappyDaysTTPA_Click);
				if (this._HappyDaysTTPA != null)
				{
					this._HappyDaysTTPA.Click -= value2;
				}
				this._HappyDaysTTPA = value;
				if (this._HappyDaysTTPA != null)
				{
					this._HappyDaysTTPA.Click += value2;
				}
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000042 RID: 66 RVA: 0x0007D98C File Offset: 0x0007BD8C
		// (set) Token: 0x06000043 RID: 67 RVA: 0x0007D9A0 File Offset: 0x0007BDA0
		internal virtual Button RetoonedTTR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._RetoonedTTR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.RetoonedTTR_Click);
				if (this._RetoonedTTR != null)
				{
					this._RetoonedTTR.Click -= value2;
				}
				this._RetoonedTTR = value;
				if (this._RetoonedTTR != null)
				{
					this._RetoonedTTR.Click += value2;
				}
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0007D9EC File Offset: 0x0007BDEC
		// (set) Token: 0x06000045 RID: 69 RVA: 0x0007DA00 File Offset: 0x0007BE00
		internal virtual Button DIPTTR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DIPTTR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.DIPTTR_Click);
				if (this._DIPTTR != null)
				{
					this._DIPTTR.Click -= value2;
				}
				this._DIPTTR = value;
				if (this._DIPTTR != null)
				{
					this._DIPTTR.Click += value2;
				}
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000046 RID: 70 RVA: 0x0007DA4C File Offset: 0x0007BE4C
		// (set) Token: 0x06000047 RID: 71 RVA: 0x0007DA60 File Offset: 0x0007BE60
		internal virtual Button Button3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button3 = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0007DA6C File Offset: 0x0007BE6C
		// (set) Token: 0x06000049 RID: 73 RVA: 0x0007DA80 File Offset: 0x0007BE80
		internal virtual Button NIGHTLIFETTR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._NIGHTLIFETTR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.NIGHTLIFETTR_Click);
				if (this._NIGHTLIFETTR != null)
				{
					this._NIGHTLIFETTR.Click -= value2;
				}
				this._NIGHTLIFETTR = value;
				if (this._NIGHTLIFETTR != null)
				{
					this._NIGHTLIFETTR.Click += value2;
				}
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0007DACC File Offset: 0x0007BECC
		// (set) Token: 0x0600004B RID: 75 RVA: 0x0007DAE0 File Offset: 0x0007BEE0
		internal virtual Button HappyDaysTTR
		{
			[DebuggerNonUserCode]
			get
			{
				return this._HappyDaysTTR;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.HappyDaysTTR_Click);
				if (this._HappyDaysTTR != null)
				{
					this._HappyDaysTTR.Click -= value2;
				}
				this._HappyDaysTTR = value;
				if (this._HappyDaysTTR != null)
				{
					this._HappyDaysTTR.Click += value2;
				}
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600004C RID: 76 RVA: 0x0007DB2C File Offset: 0x0007BF2C
		// (set) Token: 0x0600004D RID: 77 RVA: 0x0007DB40 File Offset: 0x0007BF40
		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label8_Click);
				if (this._Label2 != null)
				{
					this._Label2.Click -= value2;
				}
				this._Label2 = value;
				if (this._Label2 != null)
				{
					this._Label2.Click += value2;
				}
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600004E RID: 78 RVA: 0x0007DB8C File Offset: 0x0007BF8C
		// (set) Token: 0x0600004F RID: 79 RVA: 0x0007DBA0 File Offset: 0x0007BFA0
		internal virtual Label Label3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.Label3_Click);
				if (this._Label3 != null)
				{
					this._Label3.Click -= value2;
				}
				this._Label3 = value;
				if (this._Label3 != null)
				{
					this._Label3.Click += value2;
				}
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000050 RID: 80 RVA: 0x0007DBEC File Offset: 0x0007BFEC
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0007DC00 File Offset: 0x0007C000
		internal virtual Label Label8
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label8;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label8 = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000052 RID: 82 RVA: 0x0007DC0C File Offset: 0x0007C00C
		// (set) Token: 0x06000053 RID: 83 RVA: 0x0007DC20 File Offset: 0x0007C020
		internal virtual Label Label9
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label9;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label9 = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000054 RID: 84 RVA: 0x0007DC2C File Offset: 0x0007C02C
		// (set) Token: 0x06000055 RID: 85 RVA: 0x0007DC40 File Offset: 0x0007C040
		internal virtual Label Label10
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label10;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label10 = value;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000056 RID: 86 RVA: 0x0007DC4C File Offset: 0x0007C04C
		// (set) Token: 0x06000057 RID: 87 RVA: 0x0007DC60 File Offset: 0x0007C060
		internal virtual Label Label11
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label11;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label11 = value;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000058 RID: 88 RVA: 0x0007DC6C File Offset: 0x0007C06C
		// (set) Token: 0x06000059 RID: 89 RVA: 0x0007DC80 File Offset: 0x0007C080
		internal virtual Label Label12
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label12;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label12 = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600005A RID: 90 RVA: 0x0007DC8C File Offset: 0x0007C08C
		// (set) Token: 0x0600005B RID: 91 RVA: 0x0007DCA0 File Offset: 0x0007C0A0
		internal virtual Button TTRUnistall
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TTRUnistall;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TTRUnistall_Click);
				if (this._TTRUnistall != null)
				{
					this._TTRUnistall.Click -= value2;
				}
				this._TTRUnistall = value;
				if (this._TTRUnistall != null)
				{
					this._TTRUnistall.Click += value2;
				}
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600005C RID: 92 RVA: 0x0007DCEC File Offset: 0x0007C0EC
		// (set) Token: 0x0600005D RID: 93 RVA: 0x0007DD00 File Offset: 0x0007C100
		internal virtual Button TTPAUnistall
		{
			[DebuggerNonUserCode]
			get
			{
				return this._TTPAUnistall;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler value2 = new EventHandler(this.TTPAUnistall_Click);
				if (this._TTPAUnistall != null)
				{
					this._TTPAUnistall.Click -= value2;
				}
				this._TTPAUnistall = value;
				if (this._TTPAUnistall != null)
				{
					this._TTPAUnistall.Click += value2;
				}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0007DD4C File Offset: 0x0007C14C
		private void RetoonedTTPA_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.CopyFile("ContentPack\\ToontownRetooned.mf", "C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownRetooned.mf");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0007DD68 File Offset: 0x0007C168
		private void HappyDays_Click(object sender, EventArgs e)
		{
			MyProject.Computer.Network.DownloadFile("http://download1485.mediafire.com/acag0a7hg1ag/l99e85e9p0qbax4/TTHappyDays.mf", "ContentPack\\ToontownHappyDays.mf");
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0007DD84 File Offset: 0x0007C184
		private void Retooned_Click(object sender, EventArgs e)
		{
			MyProject.Computer.Network.DownloadFile("http://download2166.mediafire.com/d3coa4z3nfmg/vrdv37t2uk9979u/TTRetooned.mf", "ContentPack\\ToontownRetooned.mf");
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0007DDA0 File Offset: 0x0007C1A0
		private void Nightlife_Click(object sender, EventArgs e)
		{
			MyProject.Computer.Network.DownloadFile("http://download1608.mediafire.com/x6i5wk4de2rg/c8jw0tbg2uoctaa/TTNightlife.mf", "ContentPack\\ToontownNightlife.mf");
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0007DDBC File Offset: 0x0007C1BC
		private void DIP_Click(object sender, EventArgs e)
		{
			MyProject.Computer.Network.DownloadFile("http://download2124.mediafire.com/w33lfr48u78g/8x9jwyghwl6g2p3/TTDIP.mf", "ContentPack\\ToontownDIP.mf");
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0007DDD8 File Offset: 0x0007C1D8
		private void HappyDaysTTPA_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.CopyFile("ContentPack\\ToontownHappyDays.mf", "C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownHappyDays.mf");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0007DDF4 File Offset: 0x0007C1F4
		private void DIPTTPA_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.CopyFile("ContentPack\\ToontownDIP.mf", "C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownDIP.mf");
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0007DE10 File Offset: 0x0007C210
		private void NightlifeTTPA_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.CopyFile("ContentPack\\ToontownNightlife.mf", "C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownNightlife.mf");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0007DE2C File Offset: 0x0007C22C
		private void RetoonedTTR_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0007DE30 File Offset: 0x0007C230
		private void NIGHTLIFETTR_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.CopyFile("ContentPack\\ToontownNightlife.mf", "C:\\Program Files (x86)\\Toontown Rewritten\\resources\\ToontownNightlife.mf");
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0007DE4C File Offset: 0x0007C24C
		private void DIPTTR_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.CopyFile("ContentPack\\ToontownDIP.mf", "C:\\Program Files (x86)\\Toontown Rewritten\\resources\\ToontownDIP.mf");
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0007DE68 File Offset: 0x0007C268
		private void HappyDaysTTR_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.CopyFile("ContentPack\\ToontownHappyDays.mf", "C:\\Program Files (x86)\\Toontown Rewritten\\resources\\ToontownHappyDays.mf");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0007DE84 File Offset: 0x0007C284
		private void Label8_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0007DE88 File Offset: 0x0007C288
		private void Label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0007DE8C File Offset: 0x0007C28C
		private void TTRUnistall_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownHappyDays.mf");
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownDIP.mf");
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownNightlife.mf");
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Project Altis\\resources\\default\\ToontownRetooned.mf");
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0007DEEC File Offset: 0x0007C2EC
		private void TTPAUnistall_Click(object sender, EventArgs e)
		{
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Toontown Rewritten\\resources\\ToontownHappyDays.mf");
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Toontown Rewritten\\resources\\ToontownDIP.mf");
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Toontown Rewritten\\resources\\ToontownNightlife.mf");
			MyProject.Computer.FileSystem.DeleteFile("C:\\Program Files (x86)\\Toontown Rewritten\\resources\\ToontownRetooned.mf");
		}

		// Token: 0x0400000F RID: 15
		[AccessedThroughProperty("DIP")]
		private Button _DIP;

		// Token: 0x04000010 RID: 16
		[AccessedThroughProperty("Retooned")]
		private Button _Retooned;

		// Token: 0x04000011 RID: 17
		[AccessedThroughProperty("Nightlife")]
		private Button _Nightlife;

		// Token: 0x04000012 RID: 18
		[AccessedThroughProperty("HappyDays")]
		private Button _HappyDays;

		// Token: 0x04000013 RID: 19
		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		// Token: 0x04000014 RID: 20
		[AccessedThroughProperty("Label4")]
		private Label _Label4;

		// Token: 0x04000015 RID: 21
		[AccessedThroughProperty("Label5")]
		private Label _Label5;

		// Token: 0x04000016 RID: 22
		[AccessedThroughProperty("Label6")]
		private Label _Label6;

		// Token: 0x04000017 RID: 23
		[AccessedThroughProperty("Label7")]
		private Label _Label7;

		// Token: 0x04000018 RID: 24
		[AccessedThroughProperty("RetoonedTTPA")]
		private Button _RetoonedTTPA;

		// Token: 0x04000019 RID: 25
		[AccessedThroughProperty("DIPTTPA")]
		private Button _DIPTTPA;

		// Token: 0x0400001A RID: 26
		[AccessedThroughProperty("NightlifeTTPA")]
		private Button _NightlifeTTPA;

		// Token: 0x0400001B RID: 27
		[AccessedThroughProperty("HappyDaysTTPA")]
		private Button _HappyDaysTTPA;

		// Token: 0x0400001C RID: 28
		[AccessedThroughProperty("RetoonedTTR")]
		private Button _RetoonedTTR;

		// Token: 0x0400001D RID: 29
		[AccessedThroughProperty("DIPTTR")]
		private Button _DIPTTR;

		// Token: 0x0400001E RID: 30
		[AccessedThroughProperty("Button3")]
		private Button _Button3;

		// Token: 0x0400001F RID: 31
		[AccessedThroughProperty("NIGHTLIFETTR")]
		private Button _NIGHTLIFETTR;

		// Token: 0x04000020 RID: 32
		[AccessedThroughProperty("HappyDaysTTR")]
		private Button _HappyDaysTTR;

		// Token: 0x04000021 RID: 33
		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		// Token: 0x04000022 RID: 34
		[AccessedThroughProperty("Label3")]
		private Label _Label3;

		// Token: 0x04000023 RID: 35
		[AccessedThroughProperty("Label8")]
		private Label _Label8;

		// Token: 0x04000024 RID: 36
		[AccessedThroughProperty("Label9")]
		private Label _Label9;

		// Token: 0x04000025 RID: 37
		[AccessedThroughProperty("Label10")]
		private Label _Label10;

		// Token: 0x04000026 RID: 38
		[AccessedThroughProperty("Label11")]
		private Label _Label11;

		// Token: 0x04000027 RID: 39
		[AccessedThroughProperty("Label12")]
		private Label _Label12;

		// Token: 0x04000028 RID: 40
		[AccessedThroughProperty("TTRUnistall")]
		private Button _TTRUnistall;

		// Token: 0x04000029 RID: 41
		[AccessedThroughProperty("TTPAUnistall")]
		private Button _TTPAUnistall;
	}
}
