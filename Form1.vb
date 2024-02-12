Imports System.IO
Imports ExcelDataReader
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim tables As DataTableCollection
    Sub tampilData()
        Konek()

        da = New MySqlDataAdapter("select * from tmahasiswa", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        dgv.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgv.Rows.Add(dt.Rows(i).Item(0))
            dgv.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            dgv.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            dgv.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            dgv.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
        Next


        Diskonek()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        Dim jekel As String
        If rpria.Checked = True Then
            jekel = "Pria"
        ElseIf rwanita.Checked = True Then
            jekel = "Wanita"
        End If

        If isExist = True Then
            Try
                Konek()
                cmd = New MySqlCommand("UPDATE tmahasiswa SET nama = '" & tnama.Text & "', jekel = '" & jekel & "', prodi = '" & cprodi.Text & "', alamat = '" & talamat.Text & "' WHERE nim = '" & tnim.Text & "'", Koneksi)

                cmd.ExecuteNonQuery()
                MsgBox("Ubah data berhasil")

                Diskonek()
                tampilData()
                bkosongkan_Click(sender, e)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                Konek()
                cmd = New MySqlCommand("INSERT INTO tmahasiswa (nim,nama,jekel,prodi,alamat) 
            VALUES ('" & tnim.Text & "'
            ,'" & tnama.Text & "','" & jekel & "'
            ,'" & cprodi.Text & "','" & talamat.Text & "')", Koneksi)

                cmd.ExecuteNonQuery()
                MsgBox("Data berhasil di simpan")

                Diskonek()
                tampilData()
                bkosongkan_Click(sender, e)


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        If isExist = True Then
            Try
                Konek()

                If MessageBox.Show("Apakah anda yakin ingin menghapus data ini ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    cmd = New MySqlCommand("DELETE FROM tmahasiswa where nim = '" & tnim.Text & "'", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Hapus data sukses")
                    tampilData()
                    bkosongkan_Click(sender, e)
                End If

                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cprodi.SelectedIndexChanged

    End Sub

    Private Sub bkeluar_Click(sender As Object, e As EventArgs) Handles bkeluar.Click
        Me.Close()
    End Sub

    Private Sub bkosongkan_Click(sender As Object, e As EventArgs) Handles bkosongkan.Click
        tnim.Text = ""
        tnama.Text = ""
        rpria.Checked = False
        rwanita.Checked = False
        cprodi.Text = ""
        talamat.Text = ""
        tnim.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData()
    End Sub


    Private Sub tnim_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tnim.KeyPress
        If e.KeyChar = Chr(13) Then
            Konek()
            Dim jekel As String
            cmd = New MySqlCommand("select * from tmahasiswa where nim = '" & tnim.Text & "'", Koneksi)

            dr = cmd.ExecuteReader
            If dr.Read Then
                tnim.Text = dr.Item(0)
                tnama.Text = dr.Item(1)
                jekel = dr.Item(2)
                If jekel = "Pria" Then
                    rpria.Checked = True
                ElseIf jekel = "Wanita" Then
                    rwanita.Checked = True
                End If
                cprodi.Text = dr.Item(3)
                talamat.Text = dr.Item(4)
                MsgBox("Data ditemukan")
                isExist = True
            Else
                isExist = False
                MsgBox("Maaf Data tidak ditemukan")
                bkosongkan_Click(sender, e)
                tnim.Focus()

            End If
            Diskonek()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using ofd As OpenFileDialog = New OpenFileDialog() With {.Filter = "Excel 97-2003 Workbook|*.xls|Excel Workbook|*.xlsx"}
            If ofd.ShowDialog = DialogResult.OK Then
                Using stream = File.Open(ofd.FileName, FileMode.Open, FileAccess.Read)
                    Using reader As IExcelDataReader = ExcelReaderFactory.CreateReader(stream)
                        Dim result As DataSet = reader.AsDataSet(New ExcelDataSetConfiguration() With {
                                                                 .ConfigureDataTable = Function(__) New ExcelDataTableConfiguration() With {
                                                                 .UseHeaderRow = True}})
                        tables = result.Tables
                        For Each table As DataTable In tables
                            Using dt1 As DataTable = tables(table.TableName)
                                For Each row As DataRow In dt1.Rows
                                    ' Access individual columns using column names or indices
                                    Dim nim As String = row("NIM").ToString()
                                    Dim nama As String = CStr(row("Nama"))
                                    Dim jk As String = CStr(row("JK"))
                                    Dim prodi As String = CStr(row("Prodi"))
                                    Dim alamat As String = CStr(row("Alamat"))
                                      Konek()

                                    If Not String.IsNullOrEmpty(nim) Then
                                        cmd = New MySqlCommand("select * from tmahasiswa where nim = '" & nim & "'", Koneksi)

                                        dr = cmd.ExecuteReader
                                        If dr.Read Then
                                            MsgBox("Data mahasiswa dari '" & nama & "' dengan NIM '" & nim & "' sudah ada di database")
                                        Else
                                            Try

                                                cmd = New MySqlCommand("INSERT INTO tmahasiswa (nim,nama,jekel,prodi,alamat) 
                                        VALUES ('" & nim & "'
                                        ,'" & nama & "','" & jk & "'
                                        ,'" & prodi & "','" & alamat & "')", Koneksi)

                                                cmd.ExecuteNonQuery()
                                                MsgBox("Data mahasiswa dari '" & nama & "' dengan NIM '" & nim & "' berhasil di simpan")

                                                Diskonek()
                                                tampilData()
                                                bkosongkan_Click(sender, e)


                                            Catch ex As Exception
                                                MsgBox(ex.Message)
                                            End Try
                                        End If
                                    Else
                                        MsgBox("NIM tidak boleh kosong", MsgBoxStyle.Exclamation)
                                    End If
                                Next
                            End Using
                        Next
                    End Using
                End Using
            End If
        End Using
    End Sub
End Class
