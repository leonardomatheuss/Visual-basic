<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal03
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
        Me.Btm_Char = New System.Windows.Forms.Button()
        Me.Txt_Numero_Char = New System.Windows.Forms.TextBox()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btm_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.Btm_MostraLista = New System.Windows.Forms.Button()
        Me.Btm_GuardarVariaveis = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(12, 30)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(131, 74)
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
        'Btm_Char
        '
        Me.Btm_Char.Location = New System.Drawing.Point(252, 38)
        Me.Btm_Char.Name = "Btm_Char"
        Me.Btm_Char.Size = New System.Drawing.Size(154, 37)
        Me.Btm_Char.TabIndex = 2
        Me.Btm_Char.Text = "Clique aqui!"
        Me.Btm_Char.UseVisualStyleBackColor = True
        '
        'Txt_Numero_Char
        '
        Me.Txt_Numero_Char.Location = New System.Drawing.Point(252, 12)
        Me.Txt_Numero_Char.Name = "Txt_Numero_Char"
        Me.Txt_Numero_Char.Size = New System.Drawing.Size(154, 20)
        Me.Txt_Numero_Char.TabIndex = 3
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Location = New System.Drawing.Point(12, 117)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Curso.TabIndex = 4
        Me.Lbl_Curso.Text = "Label1"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Location = New System.Drawing.Point(12, 144)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(192, 20)
        Me.Txt_Curso.TabIndex = 5
        '
        'Btm_Adicionar
        '
        Me.Btm_Adicionar.Location = New System.Drawing.Point(268, 135)
        Me.Btm_Adicionar.Name = "Btm_Adicionar"
        Me.Btm_Adicionar.Size = New System.Drawing.Size(169, 36)
        Me.Btm_Adicionar.TabIndex = 6
        Me.Btm_Adicionar.Text = "Button1"
        Me.Btm_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(12, 186)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(192, 138)
        Me.Txt_Lista.TabIndex = 7
        '
        'Btm_MostraLista
        '
        Me.Btm_MostraLista.Location = New System.Drawing.Point(268, 177)
        Me.Btm_MostraLista.Name = "Btm_MostraLista"
        Me.Btm_MostraLista.Size = New System.Drawing.Size(169, 29)
        Me.Btm_MostraLista.TabIndex = 8
        Me.Btm_MostraLista.Text = "Button1"
        Me.Btm_MostraLista.UseVisualStyleBackColor = True
        '
        'Btm_GuardarVariaveis
        '
        Me.Btm_GuardarVariaveis.Location = New System.Drawing.Point(268, 254)
        Me.Btm_GuardarVariaveis.Name = "Btm_GuardarVariaveis"
        Me.Btm_GuardarVariaveis.Size = New System.Drawing.Size(169, 23)
        Me.Btm_GuardarVariaveis.TabIndex = 9
        Me.Btm_GuardarVariaveis.Text = "Button1"
        Me.Btm_GuardarVariaveis.UseVisualStyleBackColor = True
        '
        'Frm_Principal03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 336)
        Me.Controls.Add(Me.Btm_GuardarVariaveis)
        Me.Controls.Add(Me.Btm_MostraLista)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Btm_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Txt_Numero_Char)
        Me.Controls.Add(Me.Btm_Char)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Name = "Frm_Principal03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_Char As Button
    Friend WithEvents Txt_Numero_Char As TextBox
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
    Friend WithEvents Btm_MostraLista As Button
    Friend WithEvents Btm_GuardarVariaveis As Button
End Class
