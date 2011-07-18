using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomTableCellApp
{
    public partial class CustomCell2 : UITableViewCell
    {
        public CustomCell2() : base()
        {
        }
        
        public CustomCell2(IntPtr handle) : base(handle)
        {
        }
        
        public void SetupCell(NSIndexPath indexPath)
        {
            mainLabel.Text = "Row " + indexPath.Row;
            subLabel.Text = "Section " + indexPath.Section;
        }
    }
}
