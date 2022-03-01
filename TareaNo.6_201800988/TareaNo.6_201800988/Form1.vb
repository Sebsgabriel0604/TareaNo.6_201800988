Public Class Form1
    Private Sub Menos1_Click(sender As Object, e As EventArgs) Handles Menos1.Click
        Dim numeroEntrante As String = Num1.Text
        numeroEntrante = Restar(numeroEntrante)
        Num1.Text = numeroEntrante
    End Sub
    Function Restar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim NuevoTexto As String
        numero = numero - 1
        NuevoTexto = numero.ToString()
        Return numero
    End Function
    Private Sub Mas1_Click(sender As Object, e As EventArgs) Handles Mas1.Click
        Dim numeroEntrante As String = Num1.Text
        numeroEntrante = Aumentar(numeroEntrante)
        Num1.Text = numeroEntrante
    End Sub
    Function Aumentar(texto As String) As String
        Dim numero As Integer = Int32.Parse(texto)
        Dim NuevoTexto As String
        numero = numero + 1
        NuevoTexto = numero.ToString()
        Return numero
    End Function

    Private Sub Menos2_Click(sender As Object, e As EventArgs) Handles Menos2.Click
        Num2.Text = Restar(Num2.Text)
    End Sub

    Private Sub Mas2_Click(sender As Object, e As EventArgs) Handles Mas2.Click
        Num2.Text = Aumentar(Num2.Text)
    End Sub

    Private Sub Suma1_Click(sender As Object, e As EventArgs) Handles Suma1.Click
        Dim txtA = Num1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Num2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoSuma = Suma(numA, numB)

        ResultadoTotal.Text = "El resultado de A + B es " + resultadoSuma.ToString()
    End Sub

    Function Suma(Num1 As Integer, Num2 As Integer) As Integer
        Dim resultado As Integer
        resultado = Num1 + Num2
        Return resultado
    End Function

    Private Sub Resta1_Click(sender As Object, e As EventArgs) Handles Resta1.Click
        Dim txtA = Num1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Num2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoResta = Resta(numA, numB)

        ResultadoTotal.Text = "El resultado de A - B es " + resultadoResta.ToString()
    End Sub

    Function Resta(Num1 As Integer, Num2 As Integer) As Integer
        Dim resultado As Integer
        resultado = Num1 - Num2
        Return resultado
    End Function

    Private Sub Multiplicación1_Click(sender As Object, e As EventArgs) Handles Multiplicación1.Click
        Dim txtA = Num1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Num2.Text
        Dim numB = Int32.Parse(txtB)

        Dim resultadoMultiplicacion = Multiplicacion(numA, numB)

        ResultadoTotal.Text = "El resultado de A * B es " + resultadoMultiplicacion.ToString()
    End Sub

    Function Multiplicacion(Num1 As Integer, Num2 As Integer) As Integer
        Dim resultado As Integer
        resultado = Num1 * Num2
        Return resultado
    End Function

    Private Sub División1_Click(sender As Object, e As EventArgs) Handles División1.Click
        Dim txtA = Num1.Text
        Dim numA = Int32.Parse(txtA)

        Dim txtB = Num2.Text
        Dim numB = Int32.Parse(txtB)
        If Num2.Text = 0 Then
            MsgBox("Ingresar un numero mayor a 0")
        End If
        Dim resultadoDivision = División(numA, numB)
        ResultadoTotal.Text = "El resultado de A / B es " + resultadoDivision.ToString()
    End Sub
    Function División(Num1 As Double, Num2 As Double) As Double
        Dim resultado As Double
        resultado = Num1 / Num2
        Return resultado
    End Function

    Private Sub Limpiar_Click(sender As Object, e As EventArgs) Handles Limpiar.Click
        Num1.Text = "0"
        Num2.Text = "0"
        ResultadoTotal.Text = "El resultado es:"
    End Sub
End Class
