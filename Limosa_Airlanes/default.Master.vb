Imports System.Data.SqlClient
Imports System.Data
Public Class _default
    Inherits System.Web.UI.MasterPage
    Dim baglan As New SqlConnection("Data Source=DESKTOP-FA80685; initial Catalog=airlanes; Integrated Security=true")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        listelekampanya() '
    End Sub

    Public Sub listelekampanya() '
        baglan.Open() '' VERİTABANI BAĞLANTI KODU
        Dim kmt As New SqlCommand("Select * from Kampanyalar order by id desc", baglan)

        Dim cek As SqlDataReader = kmt.ExecuteReader() ''kodu cek ile okutturduk
        datalist11.DataSource = cek
        datalist11.DataBind() ''dataliste aktardık artık datalistimiz evaller ile gerekli alanları çekebilecek.
        cek.Close()

        baglan.Close() ''bağlantıda kapattık

    End Sub
End Class