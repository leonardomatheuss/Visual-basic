Public Class Frm_Principal_05
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_NomeProjeto.Text = "5 - Laços de Repetição"
        Me.Text = "5 - Laços de Repetição"
        Lbl_Princiapl.Text = "Valor investido"
        Lbl_Rendimento.Text = "Juros (%)"
        Btm_Principal.Text = "Calcular valor"
        Lbl_periodos.Text = "Perídos"





    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim investimento As Double = Val(Txt_Principal.Text)
        Dim rendimento As Double = Val(Txt_Rendimento.Text)
        Dim periodos As Integer = Val(Txt_periodos.Text)
        Dim contador As Integer = 1
        Dim extrato As String = ""

        While contador <= periodos
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento do mês  " + contador.ToString + " é " + investimento.ToString + vbCrLf
            contador += 1
        End While


        Txt_extrato.Text = extrato




    End Sub
End Class
