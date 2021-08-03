
Imports System.Data.OleDb
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1

    Dim Datas As New List(Of SingleData)
    Dim AllTotal As Integer
    Dim AllExtra As Integer
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV.Rows.Clear()
        DGV.ColumnCount = 5
        DGV.Columns(0).HeaderText = "Title"
        DGV.Columns(1).HeaderText = "Amount"
        DGV.Columns(2).HeaderText = "Cost"
        DGV.Columns(3).HeaderText = "Total"
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(3).DefaultCellStyle.BackColor = Color.LightGray
        DGV.Columns(4).HeaderText = "Extra"
        DGV.Columns(4).ReadOnly = True
        DGV.Columns(4).DefaultCellStyle.BackColor = Color.LightGray

        AllTotalText.ReadOnly = True
        AllExtraText.ReadOnly = True

        Datas = New List(Of SingleData)
        AllTotal = 0
        AllExtra = 0

    End Sub

    Private Sub DGV_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellValueChanged

        Dim data As SingleData
        If e.RowIndex >= 0 And e.RowIndex > Datas.Count - 1 Then
            data = New SingleData()
            Datas.Add(data)
        ElseIf (e.RowIndex >= 0) Then
            data = Datas(e.RowIndex)
        End If

        If e.RowIndex >= 0 And e.ColumnIndex = 1 Then
            data.Amount = DGV.Rows(e.RowIndex).Cells(1).Value.ToString
        ElseIf e.RowIndex >= 0 And e.ColumnIndex = 2 Then
            data.Cost = DGV.Rows(e.RowIndex).Cells(2).Value.ToString
        End If

        If e.RowIndex >= 0 Then
            data.calculate()
            DGV.Rows(e.RowIndex).Cells(3).Value = data.Total
            DGV.Rows(e.RowIndex).Cells(4).Value = data.Extra
            getAll()
            AllTotalText.Text = AllTotal.ToString
            AllExtraText.Text = AllExtra.ToString
            DGV.Refresh()
        End If

    End Sub

    Private Sub getAll()
        AllTotal = 0
        AllExtra = 0
        For Each data As SingleData In Datas
            AllTotal += data.Total
            AllExtra += data.Extra
        Next
    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        MyBase.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExportBtn.Click
        Dim pathExcel As String = "C:\Users\sjeon\Downloads\result.xls"
        Dim xlApp As Excel.Application = New Excel.Application
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim xlWorkBook As Excel.Workbook
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        Dim xlWorksheet As Excel.Worksheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To Datas.Count - 1
            Dim data As SingleData = Datas(i)
            For j = 0 To 4
                Dim cell As String = ""
                If j = 0 Then
                    cell = data.Amount
                ElseIf j = 1 Then
                    cell = data.Cost
                ElseIf j = 2 Then
                    cell = data.Total
                ElseIf j = 3 Then
                    cell = data.Extra
                Else
                    cell = "title"
                End If
                xlWorksheet.Cells(i + 1, j + 1) = cell.ToString()
            Next
        Next

        xlWorkBook.SaveAs(pathExcel)
        xlWorkBook.Close()

        releaseObject(xlWorksheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)


    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
            MessageBox.Show("Exception Occured while releasing object " + ex.ToString())
        Finally
            GC.Collect()
        End Try
    End Sub

End Class
