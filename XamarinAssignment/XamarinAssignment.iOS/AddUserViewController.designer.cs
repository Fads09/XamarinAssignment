// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace XamarinAssignment.iOS
{
	[Register ("AddUserViewController")]
	partial class AddUserViewController
	{
		[Outlet]
		UIKit.UITextField EmailEntry { get; set; }

		[Outlet]
		UIKit.UILabel EmailLabel { get; set; }

		[Outlet]
		UIKit.UITextField NameEntry { get; set; }

		[Outlet]
		UIKit.UILabel NameLabel { get; set; }

		[Outlet]
		UIKit.UITextField PasswordEntry { get; set; }

		[Outlet]
		UIKit.UILabel PasswordLabel { get; set; }

		[Outlet]
		UIKit.UIButton SubmitButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NameLabel != null) {
				NameLabel.Dispose ();
				NameLabel = null;
			}

			if (NameEntry != null) {
				NameEntry.Dispose ();
				NameEntry = null;
			}

			if (EmailLabel != null) {
				EmailLabel.Dispose ();
				EmailLabel = null;
			}

			if (EmailEntry != null) {
				EmailEntry.Dispose ();
				EmailEntry = null;
			}

			if (PasswordLabel != null) {
				PasswordLabel.Dispose ();
				PasswordLabel = null;
			}

			if (PasswordEntry != null) {
				PasswordEntry.Dispose ();
				PasswordEntry = null;
			}

			if (SubmitButton != null) {
				SubmitButton.Dispose ();
				SubmitButton = null;
			}
		}
	}
}
