using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace XamarinAssignment.iOS
{
    public partial class ViewController : UIViewController
    {
        public List<UserModel> _userList = new List<UserModel>();
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            Title = "Users List";
            _userList.Add(new UserModel { Email = "User@test.com", Name = "User1" });
            _userList.Add(new UserModel { Email = "User@email.com", Name = "User2" });
            Source source = new Source(_userList);
            ListView.Source = source;
            NavigationItem.RightBarButtonItem = new UIBarButtonItem("+", UIBarButtonItemStyle.Plain, AddUser);
        }

        private void AddUser(object sender, EventArgs e)
        {
            var vc = new AddUserViewController();
            vc.OnSubmitSucceed = ((obj) =>
            {
                var user = new UserModel { Email = obj.Email, Name = obj.Name };
                _userList.Add(user);
                ListView.ReloadData();

            });
            this.NavigationController.PushViewController(vc, true);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
