// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IndoorNavigation.iOS
{
    [Register ("HomeLocationController")]
    partial class HomeLocationController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView AutosuggestionsTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField HomeLocationTextField { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (AutosuggestionsTableView != null) {
                AutosuggestionsTableView.Dispose ();
                AutosuggestionsTableView = null;
            }

            if (HomeLocationTextField != null) {
                HomeLocationTextField.Dispose ();
                HomeLocationTextField = null;
            }
        }
    }
}