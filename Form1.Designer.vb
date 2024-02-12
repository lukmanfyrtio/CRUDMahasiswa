<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        bkosongkan = New Button()
        bsimpan = New Button()
        bhapus = New Button()
        bkeluar = New Button()
        tnim = New TextBox()
        tnama = New TextBox()
        talamat = New TextBox()
        rpria = New RadioButton()
        rwanita = New RadioButton()
        cprodi = New ComboBox()
        dgv = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(119, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 18)
        Label1.TabIndex = 0
        Label1.Text = "Nim :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(106, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 18)
        Label2.TabIndex = 1
        Label2.Text = "Nama :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(54, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 18)
        Label3.TabIndex = 2
        Label3.Text = "Jenis Kelamin :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 166)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 18)
        Label4.TabIndex = 3
        Label4.Text = "Program Studi :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(101, 205)
        Label5.Name = "Label5"
        Label5.Size = New Size(61, 18)
        Label5.TabIndex = 4
        Label5.Text = "Alamat :"
        ' 
        ' bkosongkan
        ' 
        bkosongkan.Location = New Point(18, 307)
        bkosongkan.Name = "bkosongkan"
        bkosongkan.Size = New Size(113, 28)
        bkosongkan.TabIndex = 5
        bkosongkan.Text = "Kosongkan"
        bkosongkan.UseVisualStyleBackColor = True
        ' 
        ' bsimpan
        ' 
        bsimpan.Location = New Point(137, 307)
        bsimpan.Name = "bsimpan"
        bsimpan.Size = New Size(70, 28)
        bsimpan.TabIndex = 6
        bsimpan.Text = "Simpan"
        bsimpan.TextAlign = ContentAlignment.MiddleRight
        bsimpan.UseVisualStyleBackColor = True
        ' 
        ' bhapus
        ' 
        bhapus.Location = New Point(213, 307)
        bhapus.Name = "bhapus"
        bhapus.Size = New Size(80, 28)
        bhapus.TabIndex = 7
        bhapus.Text = "Hapus"
        bhapus.UseVisualStyleBackColor = True
        ' 
        ' bkeluar
        ' 
        bkeluar.Location = New Point(426, 307)
        bkeluar.Name = "bkeluar"
        bkeluar.Size = New Size(86, 28)
        bkeluar.TabIndex = 8
        bkeluar.Text = "Keluar"
        bkeluar.UseVisualStyleBackColor = True
        ' 
        ' tnim
        ' 
        tnim.Location = New Point(172, 49)
        tnim.Name = "tnim"
        tnim.Size = New Size(139, 24)
        tnim.TabIndex = 9
        ' 
        ' tnama
        ' 
        tnama.Location = New Point(172, 88)
        tnama.Name = "tnama"
        tnama.Size = New Size(139, 24)
        tnama.TabIndex = 10
        ' 
        ' talamat
        ' 
        talamat.Location = New Point(172, 202)
        talamat.Multiline = True
        talamat.Name = "talamat"
        talamat.Size = New Size(262, 51)
        talamat.TabIndex = 11
        ' 
        ' rpria
        ' 
        rpria.AutoSize = True
        rpria.Location = New Point(171, 125)
        rpria.Name = "rpria"
        rpria.Size = New Size(52, 22)
        rpria.TabIndex = 12
        rpria.TabStop = True
        rpria.Text = "Pria"
        rpria.UseVisualStyleBackColor = True
        ' 
        ' rwanita
        ' 
        rwanita.AutoSize = True
        rwanita.Location = New Point(229, 125)
        rwanita.Name = "rwanita"
        rwanita.Size = New Size(72, 22)
        rwanita.TabIndex = 13
        rwanita.TabStop = True
        rwanita.Text = "Wanita"
        rwanita.UseVisualStyleBackColor = True
        ' 
        ' cprodi
        ' 
        cprodi.FormattingEnabled = True
        cprodi.Items.AddRange(New Object() {"S1 - PJJ Informatika", "S1 - PJJ Sistem Informasi", "S1 - PJJ Manajemen", "S1 - PJJ Komunikasi", "S1 - PJJ Akuntansi"})
        cprodi.Location = New Point(172, 163)
        cprodi.Name = "cprodi"
        cprodi.Size = New Size(229, 26)
        cprodi.TabIndex = 14
        ' 
        ' dgv
        ' 
        dgv.BackgroundColor = SystemColors.ActiveCaption
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column5, Column4})
        dgv.Location = New Point(12, 364)
        dgv.Name = "dgv"
        dgv.RowTemplate.Height = 25
        dgv.Size = New Size(500, 191)
        dgv.TabIndex = 15
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "NIM"
        Column1.Name = "Column1"
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Nama"
        Column2.Name = "Column2"
        Column2.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "JK"
        Column3.Name = "Column3"
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Prodi"
        Column5.Name = "Column5"
        Column5.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Alamat"
        Column4.Name = "Column4"
        Column4.Width = 150
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(299, 307)
        Button1.Name = "Button1"
        Button1.Size = New Size(121, 28)
        Button1.TabIndex = 16
        Button1.Text = "Import Data"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(9F, 18F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DodgerBlue
        ClientSize = New Size(524, 567)
        Controls.Add(Button1)
        Controls.Add(dgv)
        Controls.Add(cprodi)
        Controls.Add(rwanita)
        Controls.Add(rpria)
        Controls.Add(talamat)
        Controls.Add(tnama)
        Controls.Add(tnim)
        Controls.Add(bkeluar)
        Controls.Add(bhapus)
        Controls.Add(bsimpan)
        Controls.Add(bkosongkan)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "Form1"
        Text = "Form Data Mahasiswa"
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bkosongkan As Button
    Friend WithEvents bsimpan As Button
    Friend WithEvents bhapus As Button
    Friend WithEvents bkeluar As Button
    Friend WithEvents tnim As TextBox
    Friend WithEvents tnama As TextBox
    Friend WithEvents talamat As TextBox
    Friend WithEvents rpria As RadioButton
    Friend WithEvents rwanita As RadioButton
    Friend WithEvents cprodi As ComboBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
