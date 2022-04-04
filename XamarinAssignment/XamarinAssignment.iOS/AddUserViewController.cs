using System;

using UIKit;

namespace XamarinAssignment.iOS
{
    public partial class AddUserViewController : UIViewController
    {
        public AddUserViewController() : base("AddUserViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

