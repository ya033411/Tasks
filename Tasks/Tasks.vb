Imports Oracle.ManagedDataAccess
Imports Oracle.ManagedDataAccess.Client

Public Class Tasks
    'not initialized until the form loads
    Dim curr_list As ListBox

    Dim curr_day As Day
    Dim sun As New Day("Sunday")
    Dim mon As New Day("Monday")
    Dim tue As New Day("Tuesday")
    Dim wed As New Day("Wednesday")
    Dim thur As New Day("Thursday")
    Dim fri As New Day("Friday")
    Dim sat As New Day("Saturday")
    Dim cols() As Brush = {Brushes.LightSeaGreen, Brushes.LightSalmon, Brushes.Tan}
    Private Sub WeekTabs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles WeekTabs.SelectedIndexChanged
        If WeekTabs.SelectedIndex = 0 Then
            curr_list = sunList
            curr_day = sun
        ElseIf WeekTabs.SelectedIndex = 1 Then
            curr_list = monList
            curr_day = mon
        ElseIf WeekTabs.SelectedIndex = 2 Then
            curr_list = tueList
            curr_day = tue
        ElseIf WeekTabs.SelectedIndex = 3 Then
            curr_list = wedList
            curr_day = wed
        ElseIf WeekTabs.SelectedIndex = 4 Then
            curr_list = thurList
            curr_day = thur
        ElseIf WeekTabs.SelectedIndex = 5 Then
            curr_list = friList
            curr_day = fri
        Else
            curr_list = satList
            curr_day = sat
        End If
    End Sub

    Private Sub addEventBtn_Click(sender As Object, e As EventArgs) Handles addEventBtn.Click
        Dim evnt As String = InputBox("Event Description:")
        If evnt <> "" Then
            curr_list.Items.Add(evnt)
        End If

        curr_day.color_pos = 0
    End Sub

    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conString As String = "Data Source=(description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.us-ashburn-1.oraclecloud.com))(connect_data=(service_name=g14db0a857bf52c_databaseyousof_high.adb.oraclecloud.com))(security=(ssl_server_dn_match=yes)));User ID=ADMIN;Password=Jvyhas123456"
        Dim con As New OracleConnection(conString)
        con.Open()
        Dim cmd As New OracleCommand("select * from login", con)
        Dim adapter As New OracleDataAdapter(cmd)
        Dim ds As New DataSet()
        adapter.Fill(ds)
        For Each row As DataRow In ds.Tables(0).Rows()
            Dim username As String = row("username")
            MessageBox.Show("Hello," & vbNewLine & vbNewLine & username)
        Next
        curr_list = sunList
        curr_day = sun
    End Sub
    Private Sub List_DrawItem(sender As Object, e As DrawItemEventArgs) Handles sunList.DrawItem,
                                                                                monList.DrawItem,
                                                                                tueList.DrawItem,
                                                                                wedList.DrawItem,
                                                                                thurList.DrawItem,
                                                                                friList.DrawItem,
                                                                               satList.DrawItem
        e.Graphics.FillRectangle(cols(curr_day.color_pos), e.Bounds)
        If curr_day.color_pos = 2 Then
            curr_day.color_pos = 0
        Else
            curr_day.color_pos = curr_day.color_pos + 1
        End If
        Dim text As String = curr_list.Items(e.Index).ToString()
        e.Graphics.DrawString(text, e.Font, Brushes.Black, e.Bounds)
    End Sub

End Class
