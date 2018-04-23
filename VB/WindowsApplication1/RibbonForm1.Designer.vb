Namespace WindowsApplication1
    Partial Public Class RibbonForm1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.ribbon = New WindowsApplication1.MyRibbonControl()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem9 = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemMarqueeProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            CType(Me.ribbon, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' ribbon
            ' 
            Me.ribbon.ApplicationButtonText = Nothing
            Me.ribbon.ExpandCollapseItem.Id = 0
            Me.ribbon.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbon.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barCheckItem1, Me.barButtonItem7, Me.barButtonItem8, Me.barButtonItem9, Me.barEditItem1})
            Me.ribbon.Location = New System.Drawing.Point(0, 0)
            Me.ribbon.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ribbon.MaxItemId = 12
            Me.ribbon.MdiMergeStyle = DevExpress.XtraBars.Ribbon.RibbonMdiMergeStyle.OnlyWhenMaximized
            Me.ribbon.Name = "ribbon"
            Me.ribbon.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbon.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemMarqueeProgressBar1})
            Me.ribbon.Size = New System.Drawing.Size(910, 144)
            Me.ribbon.StatusBar = Me.ribbonStatusBar
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "barButtonItem2"
            Me.barButtonItem2.Id = 2
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "barButtonItem3"
            Me.barButtonItem3.Id = 3
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "barButtonItem4"
            Me.barButtonItem4.Id = 4
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "barButtonItem5"
            Me.barButtonItem5.Id = 5
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.Caption = "barCheckItem1"
            Me.barCheckItem1.Id = 7
            Me.barCheckItem1.Name = "barCheckItem1"
            ' 
            ' barButtonItem7
            ' 
            Me.barButtonItem7.Caption = "barButtonItem7"
            Me.barButtonItem7.Id = 8
            Me.barButtonItem7.Name = "barButtonItem7"
            ' 
            ' barButtonItem8
            ' 
            Me.barButtonItem8.Caption = "barButtonItem8"
            Me.barButtonItem8.Id = 9
            Me.barButtonItem8.Name = "barButtonItem8"
            ' 
            ' barButtonItem9
            ' 
            Me.barButtonItem9.Caption = "barButtonItem9"
            Me.barButtonItem9.Id = 10
            Me.barButtonItem9.Name = "barButtonItem9"
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Caption = "barEditItem1"
            Me.barEditItem1.Edit = Me.repositoryItemMarqueeProgressBar1
            Me.barEditItem1.Id = 11
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' repositoryItemMarqueeProgressBar1
            ' 
            Me.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1"
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem1)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem2)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem3)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem4)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "ribbonPageGroup2"
            ' 
            ' ribbonPageGroup3
            ' 
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barButtonItem5)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barEditItem1)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Tag = "AlignRight"
            Me.ribbonPageGroup3.Text = "ribbonPageGroup3"
            ' 
            ' ribbonPage2
            ' 
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup4, Me.ribbonPageGroup5, Me.ribbonPageGroup6, Me.ribbonPageGroup7})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "ribbonPage2"
            ' 
            ' ribbonPageGroup4
            ' 
            Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem7)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "ribbonPageGroup4"
            ' 
            ' ribbonPageGroup5
            ' 
            Me.ribbonPageGroup5.ItemLinks.Add(Me.barButtonItem8)
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.Text = "ribbonPageGroup5"
            ' 
            ' ribbonPageGroup6
            ' 
            Me.ribbonPageGroup6.ItemLinks.Add(Me.barButtonItem9)
            Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
            Me.ribbonPageGroup6.Text = "ribbonPageGroup6"
            ' 
            ' ribbonPageGroup7
            ' 
            Me.ribbonPageGroup7.ItemLinks.Add(Me.barCheckItem1)
            Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
            Me.ribbonPageGroup7.Tag = "AlignRight"
            Me.ribbonPageGroup7.Text = "ribbonPageGroup7"
            ' 
            ' ribbonStatusBar
            ' 
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 512)
            Me.ribbonStatusBar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbon
            Me.ribbonStatusBar.Size = New System.Drawing.Size(910, 31)
            ' 
            ' RibbonForm1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(910, 543)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Controls.Add(Me.ribbon)
            Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
            Me.Name = "RibbonForm1"
            Me.Ribbon = Me.ribbon
            Me.StatusBar = Me.ribbonStatusBar
            Me.Text = "RibbonForm1"
            CType(Me.ribbon, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemMarqueeProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private ribbon As MyRibbonControl
        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar
        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem
        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private ribbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem
        Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem8 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem9 As DevExpress.XtraBars.BarButtonItem
        Private barEditItem1 As DevExpress.XtraBars.BarEditItem
        Private repositoryItemMarqueeProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar
    End Class
End Namespace