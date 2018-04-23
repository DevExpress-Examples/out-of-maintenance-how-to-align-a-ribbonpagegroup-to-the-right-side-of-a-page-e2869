Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports WindowsApplication1.Custom_Ribbon_Control

Namespace WindowsApplication1
    Public Class MyRibbonPanelViewInfo
        Inherits RibbonPanelViewInfo

        Public Sub New(ByVal viewInfo As RibbonViewInfo)
            MyBase.New(viewInfo)
        End Sub
        Protected Overrides Function CreateGroupViewInfo(ByVal group As RibbonPageGroup) As RibbonPageGroupViewInfo
            Return New MyRibbonPageGroupViewInfo(ViewInfo, group)
        End Function
        Protected Overrides Function CreatePanelLayoutCalculator() As RibbonPanelLayoutCalculator
            Return New MyRibbonPanelComplexLayoutCalculator(Me)
        End Function
    End Class
End Namespace
