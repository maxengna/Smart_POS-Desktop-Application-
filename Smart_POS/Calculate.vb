Public Class Calculate

    Private result As Double


    Public Function Add(ByRef val As Double, ByRef val2 As Double)

        result = val + val2

        Return result

    End Function


    Public Function Minus(ByRef val As Double, ByRef val2 As Double)

        result = val - val2

        Return result

    End Function

    Public Function Multiply(ByRef val As Double, ByRef val2 As Double)

        result = val * val2

        Return result

    End Function

    Public Function Divide(ByRef val As Double, ByRef val2 As Double)

        result = val / val2

        Return result

    End Function

    Public Function Percentage(ByRef val As Double, ByRef num_percent As Integer)

        result = (val * num_percent) / 100

        Return result

    End Function









End Class
