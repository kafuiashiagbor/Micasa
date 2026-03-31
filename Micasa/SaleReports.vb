Imports System.Data.SqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports Microsoft.Office.Interop


Public Class SaleReports
    Private dtSales As New System.Data.DataTable
    Private Sub SaleReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load realtorNames in to the ComboBox
        Dim query As String = "SELECT RealtorID, RealtorName FROM Agents"
        CmbRealtorName.DataSource = DBManager.GetDataTable(query)

        'Loads property types in to the combobox
        query = "SELECT PropertyTypeID, Description FROM PropertyType"
        CmbPropertyType.DataSource = DBManager.GetDataTable(query)

        DtpFrom.Value = Now.AddDays(-30)
    End Sub

    Private Sub LoadSaleReport() Handles DtpFrom.ValueChanged, DtpTo.ValueChanged, CmbPropertyType.SelectedIndexChanged, CmbRealtorName.SelectedIndexChanged

        Try
            Dim query As String = "SELECT pt.Description As PropertyType, SUM(s.Saleprice) As TotalSales, a.RealtorName " &
                               "FROM Sales as s, PropertyType as pt, Properties as p, Agents as a " &
                               "WHERE pt.PropertyTypeID = p.TypeID and s.propertyID = p.propertyID " &
                               "and s.saleDate >= @startDate and s.saleDate <= @EndDate and s.realtorID = a.realtorID "

            If CmbPropertyType.SelectedIndex > -1 Then
                query &= "and p.typeID = " & CmbPropertyType.SelectedValue()
            End If

            If CmbRealtorName.SelectedIndex > -1 Then
                query &= "and s.RealtorID = " & CmbRealtorName.SelectedValue()
            End If
            query &= " Group by pt.Description, a.RealtorName"

            Dim cmd As New SqlCommand(query, DBManager.GetConnection())
            cmd.Parameters.AddWithValue("@startDate", DtpFrom.Value.Date)
            cmd.Parameters.AddWithValue("@EndDate", DtpTo.Value.Date)

            Dim da As New SqlDataAdapter(cmd)
            'this is the result table
            dtSales.Rows.Clear()
            da.Fill(dtSales)
            DvgSalesReport.DataSource = dtSales
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnClearProp_Click(sender As Object, e As EventArgs) Handles btnClearProp.Click
        CmbPropertyType.SelectedIndex = -1

    End Sub

    Private Sub BtnClrName_Click(sender As Object, e As EventArgs) Handles btnClrName.Click
        CmbRealtorName.SelectedIndex = -1
    End Sub



    Private Sub BtnExportPDF_Click(sender As Object, e As EventArgs) Handles BtnExport.Click
        Try
            ' Open save file dialog
            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "PDF Files (*.pdf)|*.pdf"
            saveDialog.Title = "Save Sales Report"
            saveDialog.FileName = "SalesReport_" & DateTime.Now.ToString("yyyyMMdd") & ".pdf"

            If saveDialog.ShowDialog() = DialogResult.OK Then
                ' Create PDF document
                Dim doc As New Document(PageSize.A4, 10, 10, 20, 20)
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveDialog.FileName, FileMode.Create))
                doc.Open()

                ' Add company logo 
                Dim imagePath As String = "C:\Users\Owner\Documents\Kafui\IB DP\IB DP computer science\IA\MicasaNew\Resources"
                If File.Exists(imagePath) Then
                    Dim logo As Image = Image.GetInstance(imagePath)
                    logo.ScaleAbsolute(100, 50) ' Adjust size
                    logo.Alignment = Element.ALIGN_CENTER
                    doc.Add(logo)
                End If

                ' Title
                Dim titleFont As Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16, BaseColor.BLACK)
                Dim title As New Paragraph("Sales Report", titleFont)
                title.Alignment = Element.ALIGN_CENTER
                doc.Add(title)

                ' Add Date Range
                Dim dateFont As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK)
                doc.Add(New Paragraph("Report Date: " & DateTime.Now.ToString("MMMM dd, yyyy"), dateFont))
                doc.Add(New Paragraph("From: " & DtpFrom.Value.ToShortDateString() & "  To: " & DtpTo.Value.ToShortDateString(), dateFont))
                doc.Add(New Paragraph(" ")) ' Space

                ' Create PDF Table with Headers
                Dim table As New PdfPTable(3) ' 3 columns
                table.WidthPercentage = 100
                table.SetWidths({30, 30, 40}) ' Column Widths

                ' Add Table Headers
                Dim headerFont As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK)
                Dim cellBackground As BaseColor = BaseColor.LIGHT_GRAY

                Dim headers() As String = {"Property Type", "Total Sales", "RealtorName"}
                For Each header As String In headers
                    Dim cell As New PdfPCell(New Phrase(header, headerFont))
                    cell.BackgroundColor = cellBackground
                    cell.HorizontalAlignment = Element.ALIGN_CENTER
                    table.AddCell(cell)
                Next

                ' Add Data from DataGridView
                Dim DataFont As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK)
                For Each row As DataGridViewRow In DvgSalesReport.Rows
                    If Not row.IsNewRow Then
                        table.AddCell(New PdfPCell(New Phrase(row.Cells("PropertyType").Value.ToString(), DataFont)))
                        table.AddCell(New PdfPCell(New Phrase(row.Cells("TotalSales").Value.ToString(), DataFont)))
                        table.AddCell(New PdfPCell(New Phrase(row.Cells("RealtorName").Value.ToString(), DataFont)))
                    End If
                Next

                doc.Add(table) ' Add table to document

                ' Footer: Generated By
                doc.Add(New Paragraph(" "))
                Dim generatedBy As String = "Generated by: " & Mainpage.LoggedInRealtorName
                Dim FooterFont As Font = FontFactory.GetFont(FontFactory.HELVETICA, 12, BaseColor.BLACK)
                Dim footer As New Paragraph(generatedBy, FooterFont)
                footer.Alignment = Element.ALIGN_RIGHT
                doc.Add(footer)

                ' Footer: Timestamp
                doc.Add(New Paragraph("Generated on: " & DateTime.Now.ToString(), FooterFont))

                ' Close document
                doc.Close()
                writer.Close()

                MessageBox.Show("Sales report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show("Error exporting PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnMainpage_Click(sender As Object, e As EventArgs) Handles BtnMainpage.Click
        Dim mainpage As New Mainpage
        mainpage.Show()

        Me.Hide()

    End Sub
End Class