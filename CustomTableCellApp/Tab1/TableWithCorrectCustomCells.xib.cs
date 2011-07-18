using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;

namespace CustomTableCellApp
{
    public partial class TableWithCorrectCustomCells : UITableViewController
    {
        #region Constructors

        [Export("initWithCoder:")]
        public TableWithCorrectCustomCells(NSCoder coder) : base(coder)
        {
        }

        #endregion
        
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            
            TableView.Source = new CustomTableSource();
        }
        
        public class CustomTableSource : UITableViewSource
        {
            public override int RowsInSection(UITableView tableview, int section)
            {
                return 15;
            }
            
            public override int NumberOfSections(UITableView tableView)
            {
                return 5;
            }
            
            public override string TitleForHeader(UITableView tableView, int section)
            {
                return "Section " + section;
            }
            
            public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
            {
                var cell = tableView.DequeueReusableCell("CustomCell1_ID") as CustomCell1;
                
                if (cell == null)
                {
                    cell = new CustomCell1();
                    var views = NSBundle.MainBundle.LoadNib("CustomCell1", cell, null);
                    cell = Runtime.GetNSObject( views.ValueAt(0) ) as CustomCell1;
                }
                
                cell.SetupCell(indexPath);
                
                return cell;
            }
        }
    }
}
