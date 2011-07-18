using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomTableCellApp
{
    public partial class CustomCell1 : UITableViewCell
    {
        public CustomCell1() : base()
        {
        }
        
        public CustomCell1(IntPtr handle) : base(handle)
        {
        }
        
        public void SetupCell(NSIndexPath indexPath)
        {
            mainLabel.Text = "This is row " + indexPath.Row;
            subLabel.Text = "... and section " + indexPath.Section;
        }
    }
}
