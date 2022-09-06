<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_05
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Lbl_Princiapl = New System.Windows.Forms.Label()
        Me.Lbl_Rendimento = New System.Windows.Forms.Label()
        Me.Txt_Principal = New System.Windows.Forms.TextBox()
        Me.Txt_Rendimento = New System.Windows.Forms.TextBox()
        Me.Lbl_periodos = New System.Windows.Forms.Label()
        Me.Txt_periodos = New System.Windows.Forms.TextBox()
        Me.Txt_extrato = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(335, 145)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(125, 43)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Clique aqui!"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "1 - Primeiro Projeto "
        '
        'Lbl_Princiapl
        '
        Me.Lbl_Princiapl.AutoSize = True
        Me.Lbl_Princiapl.Location = New System.Drawing.Point(12, 69)
        Me.Lbl_Princiapl.Name = "Lbl_Princiapl"
        Me.Lbl_Princiapl.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Princiapl.TabIndex = 2
        Me.Lbl_Princiapl.Text = "Label1"
        '
        'Lbl_Rendimento
        '
        Me.Lbl_Rendimento.AutoSize = True
        Me.Lbl_Rendimento.Location = New System.Drawing.Point(176, 69)
        Me.Lbl_Rendimento.Name = "Lbl_Rendimento"
        Me.Lbl_Rendimento.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Rendimento.TabIndex = 3
        Me.Lbl_Rendimento.Text = "Label2"
        '
        'Txt_Principal
        '
        Me.Txt_Principal.Location = New System.Drawing.Point(12, 85)
        Me.Txt_Principal.Name = "Txt_Principal"
        Me.Txt_Principal.Size = New System.Drawing.Size(81, 20)
        Me.Txt_Principal.TabIndex = 4
        '
        'Txt_Rendimento
        '
        Me.Txt_Rendimento.Location = New System.Drawing.Point(168, 85)
        Me.Txt_Rendimento.Name = "Txt_Rendimento"
        Me.Txt_Rendimento.Size = New System.Drawing.Size(80, 20)
        Me.Txt_Rendimento.TabIndex = 5
        '
        'Lbl_periodos
        '
        Me.Lbl_periodos.AutoSize = True
        Me.Lbl_periodos.Location = New System.Drawing.Point(320, 69)
        Me.Lbl_periodos.Name = "Lbl_periodos"
        Me.Lbl_periodos.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_periodos.TabIndex = 6
        Me.Lbl_periodos.Text = "Label1"
        '
        'Txt_periodos
        '
        Me.Txt_periodos.Location = New System.Drawing.Point(312, 85)
        Me.Txt_periodos.Name = "Txt_periodos"
        Me.Txt_periodos.Size = New System.Drawing.Size(72, 20)
        Me.Txt_periodos.TabIndex = 7
        '
        'Txt_extrato
        '
        Me.Txt_extrato.Location = New System.Drawing.Point(12, 120)
        Me.Txt_extrato.Multiline = True
        Me.Txt_extrato.Name = "Txt_extrato"
        Me.Txt_extrato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_extrato.Size = New System.Drawing.Size(278, 204)
        Me.Txt_extrato.TabIndex = 8
        '
        'Frm_Principal_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 336)
        Me.Controls.Add(Me.Txt_extrato)
        Me.Controls.Add(Me.Txt_periodos)
        Me.Controls.Add(Me.Lbl_periodos)
        Me.Controls.Add(Me.Txt_Rendimento)
        Me.Controls.Add(Me.Txt_Principal)
        Me.Controls.Add(Me.Lbl_Rendimento)
        Me.Controls.Add(Me.Lbl_Princiapl)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_Principal_05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Lbl_Princiapl As Label
    Friend WithEvents Lbl_Rendimento As Label
    Friend WithEvents Txt_Principal As TextBox
    Friend WithEvents Txt_Rendimento As TextBox
    Friend WithEvents Lbl_periodos As Label
    Friend WithEvents Txt_periodos As TextBox
    Friend WithEvents Txt_extrato As TextBox
End Class
