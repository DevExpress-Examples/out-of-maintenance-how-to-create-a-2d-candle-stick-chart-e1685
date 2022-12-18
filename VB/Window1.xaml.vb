Imports System
Imports System.Collections.ObjectModel
Imports System.Windows

Namespace CandleStick2DChart

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub
    End Class

    Public Class ChartViewModel

        Private _Data As ObservableCollection(Of CandleStick2DChart.DataPoint)

        Public Property Data As ObservableCollection(Of DataPoint)
            Get
                Return _Data
            End Get

            Private Set(ByVal value As ObservableCollection(Of DataPoint))
                _Data = value
            End Set
        End Property

        Public Sub New()
            Data = New ObservableCollection(Of DataPoint) From {New DataPoint(New DateTime(2019, 1, 1), 25, 28, 24, 27), New DataPoint(New DateTime(2019, 1, 2), 27, 35, 26, 32), New DataPoint(New DateTime(2019, 1, 3), 32, 35, 27, 29), New DataPoint(New DateTime(2019, 1, 4), 29, 37, 29, 36), New DataPoint(New DateTime(2019, 1, 5), 36, 37, 32, 33), New DataPoint(New DateTime(2019, 1, 6), 36, 37, 33, 35), New DataPoint(New DateTime(2019, 1, 8), 31, 37, 30, 33), New DataPoint(New DateTime(2019, 1, 9), 32, 38, 29, 37), New DataPoint(New DateTime(2019, 1, 10), 34, 35, 32, 33)}
        End Sub
    End Class

    Public Class DataPoint

        Public Property [Date] As Date

        Public Property Open As Double

        Public Property High As Double

        Public Property Low As Double

        Public Property Close As Double

        Public Sub New(ByVal arg As Date, ByVal open As Double, ByVal high As Double, ByVal low As Double, ByVal close As Double)
            [Date] = arg
            Me.Open = open
            Me.High = high
            Me.Low = low
            Me.Close = close
        End Sub
    End Class
End Namespace
