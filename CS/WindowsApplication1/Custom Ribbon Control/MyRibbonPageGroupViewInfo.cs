using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;

namespace WindowsApplication1 {
    public class MyRibbonPageGroupViewInfo : RibbonPageGroupViewInfo {
        public MyRibbonPageGroupViewInfo(RibbonViewInfo viewInfo, RibbonPageGroup group)
            : base(viewInfo, group) {
        }
        public override void CalcViewInfo(Rectangle bounds) {
            if (object.Equals(PageGroup.Tag, "AlignRight")) {
                int offset = ViewInfo.Bounds.Right - bounds.Right;
                if (offset > 5)
                    bounds.Offset(offset, 0);
            }
            base.CalcViewInfo(bounds);
        }
    }
}
