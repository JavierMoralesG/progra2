Module Module1
    Public Const mano_obra_small = 65.5
    Public Const mano_obra_medium = 85.99
    Public Const mano_obra_large = 99.99

    Public Const Precio_yarda_algodon = 15.0
    Public Const precio_yarda_seda = 23.99
    Public Const precio_yarda_lona = 30.99

    Public Const cantidad_yarda_small = 2
    Public Const cantidad_yarda_medium = 2.5
    Public Const cantidad_yarda_large = 3

    Public TOTALMATERIALES As Decimal
    Public SUMA As Decimal
    Public Const ChumpaSmall = 65.5
    Public Const ChumpaMedium = 85.99
    Public Const ChumpaLarge = 99.99
    Public Const PMatAlgodon = 15.0
    Public Const PMatSeda = 23.99
    Public Const PMatLona = 30.99


    Public preciocosto = 0
    Public precioventa = 0

    Public Sub calcular(material As String, tamaño As String, cantidad As Double)

        Select Case tamaño
            Case "small"
                Select Case material
                    Case "algodon"
                        preciocosto = cantidad * mano_obra_small + cantidad * precio_yarda_algodon * cantidad_yarda_small
                    Case "seda"
                        preciocosto = cantidad * mano_obra_small + cantidad * precio_yarda_seda * cantidad_yarda_small
                    Case "lona"
                        preciocosto = cantidad * mano_obra_small + cantidad * precio_yarda_lona * cantidad_yarda_small
                End Select

            Case "medium"
                Select Case material
                    Case "algodon"
                        preciocosto = cantidad * mano_obra_medium + cantidad * precio_yarda_algodon * cantidad_yarda_medium
                    Case "seda"
                        preciocosto = cantidad * mano_obra_medium + cantidad * precio_yarda_seda * cantidad_yarda_medium
                    Case "lona"
                        preciocosto = cantidad * mano_obra_medium + cantidad * precio_yarda_lona * cantidad_yarda_medium
                End Select

            Case "large"
                Select Case material
                    Case "algodon"
                        preciocosto = cantidad * mano_obra_large + cantidad * precio_yarda_algodon * cantidad_yarda_large
                    Case "seda"
                        preciocosto = cantidad * mano_obra_large + cantidad * precio_yarda_seda * cantidad_yarda_large
                    Case "lona"
                        preciocosto = cantidad * mano_obra_large + cantidad * precio_yarda_lona * cantidad_yarda_large
                End Select
        End Select

        precioventa = preciocosto + 0.65 * preciocosto

    End Sub
End Module
