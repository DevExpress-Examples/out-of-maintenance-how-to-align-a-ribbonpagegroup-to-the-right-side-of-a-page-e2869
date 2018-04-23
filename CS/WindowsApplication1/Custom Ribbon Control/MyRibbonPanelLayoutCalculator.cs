using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using System.Drawing;

namespace WindowsApplication1.Custom_Ribbon_Control {
    public class MyRibbonPanelComplexLayoutCalculator : RibbonPanelComplexLayoutCalculator {
        public MyRibbonPanelComplexLayoutCalculator(RibbonPanelViewInfo panelInfo)
            : base(panelInfo) {
        }
        public override void UpdatePanelLayout() {
            int xPos = ContentBounds.Left - PanelInfo.PanelScrollOffset;

            for (int i = 0; i < PanelInfo.Groups.Count; i++) {
                RibbonPageGroup pageGroup = PanelInfo.Groups[i].PageGroup;

                PanelInfo.Groups[i].CalcViewInfo(new Rectangle(xPos, ContentBounds.Top, PanelInfo.Groups[i].PrecalculatedWidth, ContentBounds.Height));

                if (object.Equals(pageGroup.Tag, "AlignRight"))
                    continue;

                xPos += PanelInfo.Groups[i].PrecalculatedWidth + PanelInfo.DefaultIndentBetweenGroups;
            }
        }
    }
}
