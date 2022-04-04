using System;
using System.Collections.Generic;
using System.Linq;
using Foundation;
using UIKit;
namespace XamarinAssignment.iOS
{
    public class Source : UITableViewSource
    {
        List<UserModel> _list;
        private string _cellId = "AnyText";
        public Source(List<UserModel> list)
        {
            _list = list;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(_cellId);
            if (cell == null) cell = new UITableViewCell(UITableViewCellStyle.Subtitle, _cellId);
            cell.TextLabel.Text = _list[indexPath.Row].Name;
            cell.DetailTextLabel.Text = _list[indexPath.Row].Email;
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
           return _list.Count();
        }
    }
}
