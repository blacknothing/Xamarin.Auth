using System;
using UIKit;

namespace Xamarin.Auth
{
	public partial struct Color
	{
		public UIColor ToUIColor()
		{
			return new UIColor((nfloat)_r / 255, (nfloat)_g / 255, (nfloat)_b / 255, (nfloat)_a / 255);
		}
	}
}