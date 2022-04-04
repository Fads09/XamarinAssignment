using Foundation;
using System;
using UIKit;

namespace XamarinAssignment.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Users List";

            NavigationItem.RightBarButtonItem = new UIBarButtonItem("+", UIBarButtonItemStyle.Plain, AddUser);
        }

        private void AddUser(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
