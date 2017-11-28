<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Giris
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGoster = New System.Windows.Forms.Button()
        Me.lblKullanıcıAdı = New System.Windows.Forms.Label()
        Me.txtKullaniciAdi = New System.Windows.Forms.TextBox()
        Me.lblSifre = New System.Windows.Forms.Label()
        Me.txtSifre = New System.Windows.Forms.TextBox()
        Me.btnKayıt = New System.Windows.Forms.Button()
        Me.lblBaslik = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGoster
        '
        Me.btnGoster.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGoster.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnGoster.Location = New System.Drawing.Point(82, 166)
        Me.btnGoster.Name = "btnGoster"
        Me.btnGoster.Size = New System.Drawing.Size(88, 37)
        Me.btnGoster.TabIndex = 0
        Me.btnGoster.Text = "Giriş Yap"
        Me.btnGoster.UseVisualStyleBackColor = False
        '
        'lblKullanıcıAdı
        '
        Me.lblKullanıcıAdı.AutoSize = True
        Me.lblKullanıcıAdı.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblKullanıcıAdı.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblKullanıcıAdı.Location = New System.Drawing.Point(91, 84)
        Me.lblKullanıcıAdı.Name = "lblKullanıcıAdı"
        Me.lblKullanıcıAdı.Size = New System.Drawing.Size(93, 17)
        Me.lblKullanıcıAdı.TabIndex = 1
        Me.lblKullanıcıAdı.Text = "Kullancı Adı"
        '
        'txtKullaniciAdi
        '
        Me.txtKullaniciAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtKullaniciAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtKullaniciAdi.Location = New System.Drawing.Point(195, 81)
        Me.txtKullaniciAdi.MaxLength = 20
        Me.txtKullaniciAdi.Name = "txtKullaniciAdi"
        Me.txtKullaniciAdi.Size = New System.Drawing.Size(100, 22)
        Me.txtKullaniciAdi.TabIndex = 2
        '
        'lblSifre
        '
        Me.lblSifre.AutoSize = True
        Me.lblSifre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblSifre.Location = New System.Drawing.Point(91, 126)
        Me.lblSifre.Name = "lblSifre"
        Me.lblSifre.Size = New System.Drawing.Size(42, 17)
        Me.lblSifre.TabIndex = 3
        Me.lblSifre.Text = "Şifre"
        '
        'txtSifre
        '
        Me.txtSifre.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSifre.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.txtSifre.Location = New System.Drawing.Point(195, 123)
        Me.txtSifre.MaxLength = 20
        Me.txtSifre.Name = "txtSifre"
        Me.txtSifre.Size = New System.Drawing.Size(100, 22)
        Me.txtSifre.TabIndex = 4
        Me.txtSifre.UseSystemPasswordChar = True
        '
        'btnKayıt
        '
        Me.btnKayıt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnKayıt.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.btnKayıt.Location = New System.Drawing.Point(206, 177)
        Me.btnKayıt.Name = "btnKayıt"
        Me.btnKayıt.Size = New System.Drawing.Size(88, 37)
        Me.btnKayıt.TabIndex = 5
        Me.btnKayıt.Text = "Kayıt Ol"
        Me.btnKayıt.UseVisualStyleBackColor = False
        '
        'lblBaslik
        '
        Me.lblBaslik.AutoSize = True
        Me.lblBaslik.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblBaslik.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblBaslik.Location = New System.Drawing.Point(43, 18)
        Me.lblBaslik.Name = "lblBaslik"
        Me.lblBaslik.Size = New System.Drawing.Size(635, 24)
        Me.lblBaslik.TabIndex = 6
        Me.lblBaslik.Text = "Taktığınız Cihazı Aktif Hale Getirebilmek İçin Kullanıcı Girişi Yapınız!"
        '
        'Giris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(757, 363)
        Me.Controls.Add(Me.lblBaslik)
        Me.Controls.Add(Me.btnKayıt)
        Me.Controls.Add(Me.txtSifre)
        Me.Controls.Add(Me.lblSifre)
        Me.Controls.Add(Me.txtKullaniciAdi)
        Me.Controls.Add(Me.lblKullanıcıAdı)
        Me.Controls.Add(Me.btnGoster)
        Me.Name = "Giris"
        Me.Text = "Kullanıcı Girişi"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnGoster As Button
    Friend WithEvents lblKullanıcıAdı As Label
    Friend WithEvents txtKullaniciAdi As TextBox
    Friend WithEvents lblSifre As Label
    Friend WithEvents txtSifre As TextBox
    Friend WithEvents btnKayıt As Button
    Friend WithEvents lblBaslik As Label
End Class
