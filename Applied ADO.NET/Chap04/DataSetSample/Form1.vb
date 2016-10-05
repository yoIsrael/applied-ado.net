Imports System.Data
Imports System.Data.SqlClient

Public Class Form1
  Inherits System.Windows.Forms.Form
  Private ConnectionString As String = "Integrated Security=SSPI;" & _
     "Initial Catalog=Northwind;Data Source=MCB;"
  Private conn As SqlConnection
  Private cmd As SqlCommand
  Private adapter As SqlDataAdapter
  Private SQL As String
  Private ds As DataSet


#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents OpenDbMenu As System.Windows.Forms.MenuItem
  <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
    Me.MainMenu1 = New System.Windows.Forms.MainMenu()
    Me.MenuItem1 = New System.Windows.Forms.MenuItem()
    Me.OpenDbMenu = New System.Windows.Forms.MenuItem()
    '
    'MainMenu1
    '
    Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1})
    '
    'MenuItem1
    '
    Me.MenuItem1.Index = 0
    Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.OpenDbMenu})
    Me.MenuItem1.Text = "File Menu"
    '
    'OpenDbMenu
    '
    Me.OpenDbMenu.Index = 0
    Me.OpenDbMenu.Text = "Open Database"
    '
    'Form1
    '
    Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
    Me.ClientSize = New System.Drawing.Size(432, 341)
    Me.Name = "Form1"
    Me.Text = "DataSet Operations"

  End Sub

#End Region

  Private Sub OpenMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


  End Sub

  Private Sub CloseMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub

  Private Sub FillDataBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

  End Sub


  Private Sub OpenDbMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenDbMenu.Click
    SQL = "SELECT Name FROM SysObjects WHERE Type='U'"
    conn = New SqlConnection(ConnectionString)
    ' open a connection and create a data adapter
    conn.Open()
    adapter = New SqlDataAdapter(SQL, conn)
    ' Create a dataset object
    ds = New DataSet("Tables")
    adapter.Fill(ds)
    'DataGrid1.DataSource = ds.DefaultViewManager

    ' Dispose
    conn.Close()
    conn.Dispose()
  End Sub
End Class
