using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsApplication1 {
    [System.ComponentModel.DesignerCategory("")]
    public class MyRibbonControl : RibbonControl {
        protected override RibbonViewInfo CreateViewInfo() {
            return new MyRibbonViewInfo(this);
        }
    }
}
