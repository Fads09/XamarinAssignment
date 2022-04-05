using System;
using System.Linq;
using System.Text.RegularExpressions;
using UIKit;
using Xamarin.Essentials;

namespace XamarinAssignment.iOS
{
    public partial class AddUserViewController : UIViewController
    {
        public Action<UserModel> OnSubmitSucceed {get; set;}

        public AddUserViewController() : base("AddUserViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SubmitButton.TouchUpInside += SubmitButton_TouchUpInside;
        }

        private void SubmitButton_TouchUpInside(object sender, EventArgs e)
        {
            SaveCredentials();
            if (ValidatePassword())
            {
                var storyboard = UIStoryboard.FromName("Main", null);
                var listviewcontroller = storyboard.InstantiateViewController("ViewController") as ViewController;
                var user = new UserModel { Name = NameEntry.Text, Email = EmailEntry.Text };
                OnSubmitSucceed?.Invoke(user);
                this.NavigationController.PopViewController(true);
            }
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
        }

        public void SaveCredentials()
        {
            ValidatePassword();
        }

        public bool ValidatePassword()
        {
            Match repeatedSequence = Regex.Match(PasswordEntry.Text, @"(\w+)\1", RegexOptions.IgnoreCase);
            Match lettersAndNumbers = Regex.Match(PasswordEntry.Text, @"^[a-zA-Z0-9]*$");
            if ((PasswordEntry.Text.Length >= 5 && PasswordEntry.Text.Length <= 12) && PasswordEntry.Text.Any(char.IsDigit) && !repeatedSequence.Success && lettersAndNumbers.Success)
            {
                Preferences.Set("Password", PasswordEntry.Text);
                return true;
            }
            else
            {
                var okAlertController = UIAlertController.Create("Check your password", "* Your password should be between 5 & 12 letters\r\n * Your password should only contain numbers and letters \r\n * Your password should not contain repeated sequence characters", UIAlertControllerStyle.Alert);

                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, null));

                PresentViewController(okAlertController, true, null);
                return false;
            }
        }
    }
}

