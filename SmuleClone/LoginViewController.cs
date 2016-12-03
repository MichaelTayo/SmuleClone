using Foundation;
using System;
using UIKit;

namespace SmuleClone
{
	public partial class LoginViewController : UIViewController
	{
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			var textDelegate = new LoginTextFieldDelegatee
			{
				OnShouldReturn = (sender, textField) =>
				{
					if (textField.Tag == txtUsername.Tag)
					{
						txtPassword.BecomeFirstResponder();
				}
				else if (textField.Tag == txtPassword.Tag)
				{
						txtPassword.ResignFirstResponder();

					// TODO: put your login validation code here  
					if (txtPassword.Text == "4995" &&
							txtUsername.Text.ToLower() == "inte")
					{
							// TODO: navigate to the tabViewController which will in turncall FirstViewController
		 				TabController tabViewController =  
								this.Storyboard.InitiateViewControllr("TabControllerID") as TabController;

							//create an instance of our Appdelegate
							var appDelegate = 
								UIApplication.SharedApplication.Delegate as AppDelegate;

							//TODO: set the "Username prpoperty on the firstvew controller her e

							appDelegate.Username = txtUsername.Text;

							if (tabViewController != null)

								PresentViewController(tabViewController,true,null);
						}
						else
						{
							//new UIAlertView("Access Denied!" , "Enter a valid username and password", null,"OK").Show():
						}
					}
				}
			};
			txtPassword.Delegate = textDelegate;
			txtUsername.Delegate = textDelegate;

		}

        public LoginViewController (IntPtr handle) : base (handle)
        {
        }
    }
}