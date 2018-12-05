// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Timer
{
	[Register ("TimerDetailViewController")]
	partial class TimerDetailViewController
	{
		[Outlet]
		UIKit.UILabel durationLabel { get; set; }

		[Outlet]
		UIKit.UILabel nameLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (nameLabel != null) {
				nameLabel.Dispose ();
				nameLabel = null;
			}

			if (durationLabel != null) {
				durationLabel.Dispose ();
				durationLabel = null;
			}
		}
	}
}
