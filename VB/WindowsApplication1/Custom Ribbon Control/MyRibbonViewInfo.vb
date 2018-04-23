Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsApplication1
    Public Class MyRibbonViewInfo
        Inherits RibbonViewInfo

        Public Sub New(ByVal ribbon As RibbonControl)
            MyBase.New(ribbon)
        End Sub
        Protected Overrides Function CreatePanelInfo() As RibbonPanelViewInfo
            Return New MyRibbonPanelViewInfo(Me)
        End Function
    End Class
End Namespace
