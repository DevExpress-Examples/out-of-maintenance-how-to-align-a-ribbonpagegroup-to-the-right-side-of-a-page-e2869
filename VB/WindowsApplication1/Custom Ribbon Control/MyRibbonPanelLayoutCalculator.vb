Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing

Namespace WindowsApplication1.Custom_Ribbon_Control
    Public Class MyRibbonPanelComplexLayoutCalculator
        Inherits RibbonPanelComplexLayoutCalculator

        Public Sub New(ByVal panelInfo As RibbonPanelViewInfo)
            MyBase.New(panelInfo)
        End Sub
        Public Overrides Sub UpdatePanelLayout()
            Dim xPos As Integer = ContentBounds.Left - PanelInfo.PanelScrollOffset

            For i As Integer = 0 To PanelInfo.Groups.Count - 1
                Dim pageGroup As RibbonPageGroup = PanelInfo.Groups(i).PageGroup

                PanelInfo.Groups(i).CalcViewInfo(New Rectangle(xPos, ContentBounds.Top, PanelInfo.Groups(i).PrecalculatedWidth, ContentBounds.Height))

                If Object.Equals(pageGroup.Tag, "AlignRight") Then
                    Continue For
                End If

                xPos += PanelInfo.Groups(i).PrecalculatedWidth + PanelInfo.DefaultIndentBetweenGroups
            Next i
        End Sub
    End Class
End Namespace
