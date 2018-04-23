using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using WindowsApplication1.Custom_Ribbon_Control;

namespace WindowsApplication1 {
    public class MyRibbonPanelViewInfo : RibbonPanelViewInfo {
        public MyRibbonPanelViewInfo(RibbonViewInfo viewInfo)
            : base(viewInfo) {
        }
        protected override RibbonPageGroupViewInfo CreateGroupViewInfo(RibbonPageGroup group) {
            return new MyRibbonPageGroupViewInfo(ViewInfo, group);
        }
        protected override RibbonPanelLayoutCalculator CreatePanelLayoutCalculator() {
            return new MyRibbonPanelComplexLayoutCalculator(this);
        }
    }
}
