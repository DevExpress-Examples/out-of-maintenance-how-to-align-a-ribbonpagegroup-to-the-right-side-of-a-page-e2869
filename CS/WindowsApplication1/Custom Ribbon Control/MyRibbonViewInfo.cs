using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;

namespace WindowsApplication1 {
    public class MyRibbonViewInfo : RibbonViewInfo {
        public MyRibbonViewInfo(RibbonControl ribbon)
            : base(ribbon) {
        }
        protected override RibbonPanelViewInfo CreatePanelInfo() {
            return new MyRibbonPanelViewInfo(this);
        }
    }
}
