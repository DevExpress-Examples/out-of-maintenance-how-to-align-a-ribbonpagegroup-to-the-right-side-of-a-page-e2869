Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace WindowsApplication1
    <System.ComponentModel.DesignerCategory("")> _
    Public Class MyRibbonControl
        Inherits RibbonControl

        Protected Overrides Function CreateViewInfo() As RibbonViewInfo
            Return New MyRibbonViewInfo(Me)
        End Function
    End Class
End Namespace
