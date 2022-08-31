Public Class Form1
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_NumersInteiros.Click

        Dim idade As Integer

        idade = 12

        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * 5
        MsgBox("O valor da idade multiplicado por 5 é " + idade.ToString, MsgBoxStyle.Critical)

        idade = (12 * 5) + 10
        MsgBox("O valor da idade multiplicado por 5 e somado de 10 é " + idade.ToString, MsgBoxStyle.Critical)







    End Sub

    Private Sub Btm_NumerosInteiros_Click(sender As Object, e As EventArgs) Handles Btm_PontoFlutuante.Click

        Dim valor As Double

        valor = 9.5

        MsgBox("A variável valor é igual a " + valor.ToString, MsgBoxStyle.Critical)

        valor = 5 / 2

        MsgBox("O valor de 5/2 é " + valor.ToString, MsgBoxStyle.Critical)
        Dim numerador As Integer = 5
        Dim denominador As Integer = 2


        valor = numerador / denominador


        MsgBox("O valor de 5/2 é " + valor.ToString, MsgBoxStyle.Critical)



    End Sub

    Private Sub Btm_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btm_ConversaoNumeros.Click

        Dim salario As Double
        salario = 1300.45

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O valor do salário é " + salario.ToString + "e do salário inteiro é " + salarioInteiro.ToString, MsgBoxStyle.Critical)


        Dim salariogrande As Long
        salariogrande = 1300000000000000000

        MsgBox("O valor do salario longo é " + salariogrande.ToString, MsgBoxStyle.Critical)


        Dim salariopequeno As Short
        salariopequeno = 10000

        MsgBox("O valor do salario pequeno  é " + salariopequeno.ToString, MsgBoxStyle.Critical)

        Dim salariominusculo As SByte
        salariominusculo = 10

        MsgBox("O valor do salario minusculo é " + salariominusculo.ToString, MsgBoxStyle.Critical)

        Dim valordouble As Double
        valordouble = 9.23983892245

        MsgBox("O valor da variável Double é " + valordouble.ToString, MsgBoxStyle.Critical)

        Dim valordecimal As Decimal
        valordecimal = 9.23983892245

        MsgBox("O valor da variável Decimal  é " + valordecimal.ToString, MsgBoxStyle.Critical)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btm_Resultado_Click(sender As Object, e As EventArgs) Handles Btm_Resultado.Click

        Dim numerador As Double
        Dim denominador As Double

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text

        Dim resultado As Double

        resultado = numerador / denominador

        MsgBox("O resultado entre a divisão de " + numerador.ToString + " por " _
               + denominador.ToString + " é " + resultado.ToString, MsgBoxStyle.Critical)


        Dim resultadoDecimal As Decimal
        resultadoDecimal = numerador / denominador

        MsgBox("O resultado entre a divisão (Decimal) de " + numerador.ToString + " por " _
        + denominador.ToString + " é " + resultadoDecimal.ToString, MsgBoxStyle.Critical)

        Dim resultadoDouble As Double
        resultadoDouble = numerador / denominador

        MsgBox("O resultado entre a divisão (Double) de " + numerador.ToString + " por " _
        + denominador.ToString + " é " + resultadoDouble.ToString, MsgBoxStyle.Critical)

        Txt_ResultadoDecimal.Text = resultadodecimal.ToString
        Txt_ResultadoDouble.Text = resultadoDouble.ToString


    End Sub



End Class
