// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Eye_Rest
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Funny Booton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Welcome Label { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView Welcome Label { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (Funny Booton != null) {
                Funny Booton.Dispose ();
                Funny Booton = null;
            }

            if (Welcome Label != null) {
                Welcome Label.Dispose ();
                Welcome Label = null;
            }

            if (Welcome Label != null) {
                Welcome Label.Dispose ();
                Welcome Label = null;
            }
        }
    }
}