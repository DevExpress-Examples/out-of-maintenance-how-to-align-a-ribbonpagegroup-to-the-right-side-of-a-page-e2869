<!-- default file list -->
*Files to look at*:

* [MyRibbonControl.cs](./CS/WindowsApplication1/Custom Ribbon Control/MyRibbonControl.cs) (VB: [MyRibbonControl.vb](./VB/WindowsApplication1/Custom Ribbon Control/MyRibbonControl.vb))
* [MyRibbonPageGroupViewInfo.cs](./CS/WindowsApplication1/Custom Ribbon Control/MyRibbonPageGroupViewInfo.cs) (VB: [MyRibbonPageGroupViewInfo.vb](./VB/WindowsApplication1/Custom Ribbon Control/MyRibbonPageGroupViewInfo.vb))
* [MyRibbonPanelLayoutCalculator.cs](./CS/WindowsApplication1/Custom Ribbon Control/MyRibbonPanelLayoutCalculator.cs) (VB: [MyRibbonPanelLayoutCalculator.vb](./VB/WindowsApplication1/Custom Ribbon Control/MyRibbonPanelLayoutCalculator.vb))
* [MyRibbonPanelViewInfo.cs](./CS/WindowsApplication1/Custom Ribbon Control/MyRibbonPanelViewInfo.cs) (VB: [MyRibbonPanelViewInfo.vb](./VB/WindowsApplication1/Custom Ribbon Control/MyRibbonPanelViewInfo.vb))
* [MyRibbonViewInfo.cs](./CS/WindowsApplication1/Custom Ribbon Control/MyRibbonViewInfo.cs) (VB: [MyRibbonViewInfo.vb](./VB/WindowsApplication1/Custom Ribbon Control/MyRibbonViewInfo.vb))
* [RibbonForm1.cs](./CS/WindowsApplication1/RibbonForm1.cs) (VB: [RibbonForm1.vb](./VB/WindowsApplication1/RibbonForm1.vb))
<!-- default file list end -->
# How to align a RibbonPageGroup to the right side of a page?

<p>Starting with version 18.2, you can use the RibbonPageGroup.Alignment property to align RibbonPageGroup to the right side. In previous versions, you can use the previous approach:</p>

<p>This example demonstrates how to create a custom <strong>RibbonControl</strong> that displays a group with the "AlignRight" tag assigned on the right side.<br>Note that if you need to use your custom <strong>RibbonControl </strong>on one form with <strong>DockManager,</strong> it is necessary to add the complete type name (with its namespace) of your custom ribbon control to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDockingDockManager_TopZIndexControlstopic">DockManager.TopZIndexControls</a> collection because by default, <strong>DockPanels</strong> overlap all controls except the ones listed in this collection.<br><br>Here are steps that illustrate how to implement this functionality.<br><br>1. Create descendants of the <strong>RibbonControl, RibbonViewInfo and RibbonPanelViewInfo</strong> classes, and override the corresponding <strong>Create~</strong> methods to create instances of other descendants See the corresponding <strong>MyRibbonControl, MyRibbonViewInfo</strong> and<strong> MyRibbonPanelViewInfo </strong>classes.</p>
<p>2. Create a custom <strong>RibbonPageGroupViewInfo</strong> descendant<strong> </strong>and override its<strong> CalcViewInfo</strong> method to calculate bounds of the <strong>RibbonPageGroup</strong> marked with the <strong>"AlignRight" </strong>tag:</p>


```cs
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
```




```vb
    Public Class MyRibbonPageGroupViewInfo
        Inherits RibbonPageGroupViewInfo

        Public Sub New(ByVal viewInfo As RibbonViewInfo, ByVal group As RibbonPageGroup)
            MyBase.New(viewInfo, group)
        End Sub
        Public Overrides Sub CalcViewInfo(ByVal bounds As Rectangle)
            If Object.Equals(PageGroup.Tag, "AlignRight") Then
                Dim offset As Integer = ViewInfo.Bounds.Right - bounds.Right
                If offset > 5 Then
                    bounds.Offset(offset, 0)
                End If
            End If
            MyBase.CalcViewInfo(bounds)
        End Sub
    End Class
```


<p><strong>Updated:</strong></p>
<p>3. The example was slightly modified to dispose of a gap which is created after merging (see <a href="https://www.devexpress.com/Support/Center/p/T111317"> Support correct RibbonPageGroups alignment with no gap on ribbon merging</a>).<br>To enable correct operation, a <strong>RibbonPanelComplexLayoutCalculator</strong> descendant was created, and the <strong>UpdatePanelLayout</strong> method was overridden in it:</p>


```cs
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
```




```vb
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
```


<p><br>4. Finally, to change the alignment of <strong>RibbonPageGroup,</strong> set its Tag property to <strong>"AlignRight":</strong></p>


```cs
            RibbonPageGroup.Tag = "AlignRight";
```




```vb
            RibbonPageGroup.Tag = "AlignRight"
```



<br/>


