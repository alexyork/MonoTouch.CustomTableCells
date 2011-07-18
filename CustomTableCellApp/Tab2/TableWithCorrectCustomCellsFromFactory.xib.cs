using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomTableCellApp
{
    public partial class TableWithCorrectCustomCellsFromFactory : UITableViewController
    {
        #region Constructors
        
        [Export("initWithCoder:")]
        public TableWithCorrectCustomCellsFromFactory(NSCoder coder) : base(coder)
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
            private TableCellFactory<CustomCell2> factory = new TableCellFactory<CustomCell2>("CustomCell2_ID", "CustomCell2");
            
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
                var cell = factory.GetCell(tableView);
                cell.SetupCell(indexPath);
                
                return cell;
            }
        }
    }
}
