﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject2
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// Metodo de pruebas
        /// </summary>
        public void RecordedMethod1()
        {
            #region Variable Declarations
            WinTreeItem uIDesktopTreeItem = this.UIFileExplorerWindow.UITreeViewWindow.UIDesktopTreeItem.UIThisPCTreeItem.UIDesktopTreeItem;
            WinEdit uINameEdit = this.UIFileExplorerWindow.UIItemWindow.UIHerramientasListItem.UINameEdit;
            WinEdit uINameEdit1 = this.UIFileExplorerWindow.UIItemWindow1.UIApachejmeter40ListItem.UINameEdit;
            WinEdit uINameEdit2 = this.UIFileExplorerWindow.UIItemWindow2.UIBinListItem.UINameEdit;
            WinEdit uINameEdit3 = this.UIFileExplorerWindow.UIItemWindow3.UIApacheJMeterListItem.UINameEdit;
            WinClient uIApacheJMeter40r18234Client = this.UIApacheJMeter40r18234Window.UIApacheJMeter40r18234Client;
            WinButton uICloseButton = this.UIApacheJMeter40r18234Window.UIApacheJMeter40r18234TitleBar.UICloseButton;
            WinClient uISaveClient = this.UISaveWindow.UISaveClient;
            WinClient uITestPlanjmxClient = this.UITestPlanjmxWindow.UITestPlanjmxClient;
            #endregion

            // Last mouse action was not recorded.

            // Click 'Desktop' -> 'This PC' -> 'Desktop' tree item
            Mouse.Click(uIDesktopTreeItem, new Point(17, 13));

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit, new Point(72, 11));

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit1, new Point(74, 8));

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit2, new Point(71, 12));

            // Double-Click 'Name' text box
            Mouse.DoubleClick(uINameEdit3, new Point(73, 8));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(46, 78));

            // Right-Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, MouseButtons.Right, ModifierKeys.None, new Point(48, 78));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(429, 92));

            // Right-Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, MouseButtons.Right, ModifierKeys.None, new Point(48, 97));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(510, 366));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(94, 93));

            // Right-Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, MouseButtons.Right, ModifierKeys.None, new Point(95, 93));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(635, 350));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(112, 99));

            // Right-Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, MouseButtons.Right, ModifierKeys.None, new Point(112, 99));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(503, 291));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(172, 229));

            // Click 'Apache JMeter (4.0 r1823414)' client
            Mouse.Click(uIApacheJMeter40r18234Client, new Point(220, 82));

            // Click 'Close' button
        //    Mouse.Click(uICloseButton, new Point(29, 5));

            // Click 'Save?' client
         //   Mouse.Click(uISaveClient, new Point(207, 76));

            // Click 'Test Plan.jmx' client
          //  Mouse.Click(uITestPlanjmxClient, new Point(387, 304));
        }
        
        #region Properties
        public UIFileExplorerWindow UIFileExplorerWindow
        {
            get
            {
                if ((this.mUIFileExplorerWindow == null))
                {
                    this.mUIFileExplorerWindow = new UIFileExplorerWindow();
                }
                return this.mUIFileExplorerWindow;
            }
        }
        
        public UIApacheJMeter40r18234Window UIApacheJMeter40r18234Window
        {
            get
            {
                if ((this.mUIApacheJMeter40r18234Window == null))
                {
                    this.mUIApacheJMeter40r18234Window = new UIApacheJMeter40r18234Window();
                }
                return this.mUIApacheJMeter40r18234Window;
            }
        }
        
        public UISaveWindow UISaveWindow
        {
            get
            {
                if ((this.mUISaveWindow == null))
                {
                    this.mUISaveWindow = new UISaveWindow();
                }
                return this.mUISaveWindow;
            }
        }
        
        public UITestPlanjmxWindow UITestPlanjmxWindow
        {
            get
            {
                if ((this.mUITestPlanjmxWindow == null))
                {
                    this.mUITestPlanjmxWindow = new UITestPlanjmxWindow();
                }
                return this.mUITestPlanjmxWindow;
            }
        }
        #endregion
        
        #region Fields
        private UIFileExplorerWindow mUIFileExplorerWindow;
        
        private UIApacheJMeter40r18234Window mUIApacheJMeter40r18234Window;
        
        private UISaveWindow mUISaveWindow;
        
        private UITestPlanjmxWindow mUITestPlanjmxWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIFileExplorerWindow : WinWindow
    {
        
        public UIFileExplorerWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "File Explorer";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CabinetWClass";
            this.WindowTitles.Add("File Explorer");
            this.WindowTitles.Add("Desktop");
            this.WindowTitles.Add("Herramientas");
            this.WindowTitles.Add("apache-jmeter-4.0");
            this.WindowTitles.Add("bin");
            #endregion
        }
        
        #region Properties
        public UITreeViewWindow UITreeViewWindow
        {
            get
            {
                if ((this.mUITreeViewWindow == null))
                {
                    this.mUITreeViewWindow = new UITreeViewWindow(this);
                }
                return this.mUITreeViewWindow;
            }
        }
        
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow3 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow3(this);
                }
                return this.mUIItemWindow3;
            }
        }
        #endregion
        
        #region Fields
        private UITreeViewWindow mUITreeViewWindow;
        
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        
        private UIItemWindow3 mUIItemWindow3;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITreeViewWindow : WinWindow
    {
        
        public UITreeViewWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "100";
            this.WindowTitles.Add("File Explorer");
            #endregion
        }
        
        #region Properties
        public UIDesktopTreeItem UIDesktopTreeItem
        {
            get
            {
                if ((this.mUIDesktopTreeItem == null))
                {
                    this.mUIDesktopTreeItem = new UIDesktopTreeItem(this);
                }
                return this.mUIDesktopTreeItem;
            }
        }
        #endregion
        
        #region Fields
        private UIDesktopTreeItem mUIDesktopTreeItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIDesktopTreeItem : WinTreeItem
    {
        
        public UIDesktopTreeItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTreeItem.PropertyNames.Name] = "Desktop";
            this.SearchProperties["Value"] = "0";
            this.WindowTitles.Add("File Explorer");
            #endregion
        }
        
        #region Properties
        public UIThisPCTreeItem UIThisPCTreeItem
        {
            get
            {
                if ((this.mUIThisPCTreeItem == null))
                {
                    this.mUIThisPCTreeItem = new UIThisPCTreeItem(this);
                }
                return this.mUIThisPCTreeItem;
            }
        }
        #endregion
        
        #region Fields
        private UIThisPCTreeItem mUIThisPCTreeItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIThisPCTreeItem : WinTreeItem
    {
        
        public UIThisPCTreeItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTreeItem.PropertyNames.Name] = "This PC";
            this.SearchProperties["Value"] = "1";
            this.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
            this.SearchConfigurations.Add(SearchConfiguration.NextSibling);
            this.WindowTitles.Add("File Explorer");
            #endregion
        }
        
        #region Properties
        public WinTreeItem UIDesktopTreeItem
        {
            get
            {
                if ((this.mUIDesktopTreeItem == null))
                {
                    this.mUIDesktopTreeItem = new WinTreeItem(this);
                    #region Search Criteria
                    this.mUIDesktopTreeItem.SearchProperties[WinTreeItem.PropertyNames.Name] = "Desktop";
                    this.mUIDesktopTreeItem.SearchProperties["Value"] = "2";
                    this.mUIDesktopTreeItem.SearchConfigurations.Add(SearchConfiguration.ExpandWhileSearching);
                    this.mUIDesktopTreeItem.SearchConfigurations.Add(SearchConfiguration.NextSibling);
                    this.mUIDesktopTreeItem.WindowTitles.Add("File Explorer");
                    #endregion
                }
                return this.mUIDesktopTreeItem;
            }
        }
        #endregion
        
        #region Fields
        private WinTreeItem mUIDesktopTreeItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Desktop");
            #endregion
        }
        
        #region Properties
        public UIHerramientasListItem UIHerramientasListItem
        {
            get
            {
                if ((this.mUIHerramientasListItem == null))
                {
                    this.mUIHerramientasListItem = new UIHerramientasListItem(this);
                }
                return this.mUIHerramientasListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIHerramientasListItem mUIHerramientasListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIHerramientasListItem : WinListItem
    {
        
        public UIHerramientasListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "Herramientas";
            this.WindowTitles.Add("Desktop");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Desktop");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("Herramientas");
            #endregion
        }
        
        #region Properties
        public UIApachejmeter40ListItem UIApachejmeter40ListItem
        {
            get
            {
                if ((this.mUIApachejmeter40ListItem == null))
                {
                    this.mUIApachejmeter40ListItem = new UIApachejmeter40ListItem(this);
                }
                return this.mUIApachejmeter40ListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIApachejmeter40ListItem mUIApachejmeter40ListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIApachejmeter40ListItem : WinListItem
    {
        
        public UIApachejmeter40ListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "apache-jmeter-4.0";
            this.WindowTitles.Add("Herramientas");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("Herramientas");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("apache-jmeter-4.0");
            #endregion
        }
        
        #region Properties
        public UIBinListItem UIBinListItem
        {
            get
            {
                if ((this.mUIBinListItem == null))
                {
                    this.mUIBinListItem = new UIBinListItem(this);
                }
                return this.mUIBinListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIBinListItem mUIBinListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIBinListItem : WinListItem
    {
        
        public UIBinListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "bin";
            this.WindowTitles.Add("apache-jmeter-4.0");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("apache-jmeter-4.0");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.AccessibleName] = "Items View";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "DirectUIHWND";
            this.WindowTitles.Add("bin");
            #endregion
        }
        
        #region Properties
        public UIApacheJMeterListItem UIApacheJMeterListItem
        {
            get
            {
                if ((this.mUIApacheJMeterListItem == null))
                {
                    this.mUIApacheJMeterListItem = new UIApacheJMeterListItem(this);
                }
                return this.mUIApacheJMeterListItem;
            }
        }
        #endregion
        
        #region Fields
        private UIApacheJMeterListItem mUIApacheJMeterListItem;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIApacheJMeterListItem : WinListItem
    {
        
        public UIApacheJMeterListItem(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinListItem.PropertyNames.Name] = "ApacheJMeter";
            this.WindowTitles.Add("bin");
            #endregion
        }
        
        #region Properties
        public WinEdit UINameEdit
        {
            get
            {
                if ((this.mUINameEdit == null))
                {
                    this.mUINameEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUINameEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Name";
                    this.mUINameEdit.WindowTitles.Add("bin");
                    #endregion
                }
                return this.mUINameEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUINameEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIApacheJMeter40r18234Window : WinWindow
    {
        
        public UIApacheJMeter40r18234Window()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Apache JMeter (4.0 r1823414)";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SunAwtFrame";
            this.WindowTitles.Add("Apache JMeter (4.0 r1823414)");
            #endregion
        }
        
        #region Properties
        public WinClient UIApacheJMeter40r18234Client
        {
            get
            {
                if ((this.mUIApacheJMeter40r18234Client == null))
                {
                    this.mUIApacheJMeter40r18234Client = new WinClient(this);
                    #region Search Criteria
                    this.mUIApacheJMeter40r18234Client.SearchProperties[WinControl.PropertyNames.Name] = "Apache JMeter (4.0 r1823414)";
                    this.mUIApacheJMeter40r18234Client.WindowTitles.Add("Apache JMeter (4.0 r1823414)");
                    #endregion
                }
                return this.mUIApacheJMeter40r18234Client;
            }
        }
        
        public UIApacheJMeter40r18234TitleBar UIApacheJMeter40r18234TitleBar
        {
            get
            {
                if ((this.mUIApacheJMeter40r18234TitleBar == null))
                {
                    this.mUIApacheJMeter40r18234TitleBar = new UIApacheJMeter40r18234TitleBar(this);
                }
                return this.mUIApacheJMeter40r18234TitleBar;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUIApacheJMeter40r18234Client;
        
        private UIApacheJMeter40r18234TitleBar mUIApacheJMeter40r18234TitleBar;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UIApacheJMeter40r18234TitleBar : WinTitleBar
    {
        
        public UIApacheJMeter40r18234TitleBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Apache JMeter (4.0 r1823414)");
            #endregion
        }
        
        #region Properties
        public WinButton UICloseButton
        {
            get
            {
                if ((this.mUICloseButton == null))
                {
                    this.mUICloseButton = new WinButton(this);
                    #region Search Criteria
                    this.mUICloseButton.SearchProperties[WinButton.PropertyNames.Name] = "Close";
                    this.mUICloseButton.WindowTitles.Add("Apache JMeter (4.0 r1823414)");
                    #endregion
                }
                return this.mUICloseButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUICloseButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UISaveWindow : WinWindow
    {
        
        public UISaveWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Save?";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SunAwtDialog";
            this.WindowTitles.Add("Save?");
            #endregion
        }
        
        #region Properties
        public WinClient UISaveClient
        {
            get
            {
                if ((this.mUISaveClient == null))
                {
                    this.mUISaveClient = new WinClient(this);
                    #region Search Criteria
                    this.mUISaveClient.SearchProperties[WinControl.PropertyNames.Name] = "Save?";
                    this.mUISaveClient.WindowTitles.Add("Save?");
                    #endregion
                }
                return this.mUISaveClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUISaveClient;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class UITestPlanjmxWindow : WinWindow
    {
        
        public UITestPlanjmxWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Test Plan.jmx";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "SunAwtDialog";
            this.WindowTitles.Add("Test Plan.jmx");
            #endregion
        }
        
        #region Properties
        public WinClient UITestPlanjmxClient
        {
            get
            {
                if ((this.mUITestPlanjmxClient == null))
                {
                    this.mUITestPlanjmxClient = new WinClient(this);
                    #region Search Criteria
                    this.mUITestPlanjmxClient.SearchProperties[WinControl.PropertyNames.Name] = "Test Plan.jmx";
                    this.mUITestPlanjmxClient.WindowTitles.Add("Test Plan.jmx");
                    #endregion
                }
                return this.mUITestPlanjmxClient;
            }
        }
        #endregion
        
        #region Fields
        private WinClient mUITestPlanjmxClient;
        #endregion
    }
}
