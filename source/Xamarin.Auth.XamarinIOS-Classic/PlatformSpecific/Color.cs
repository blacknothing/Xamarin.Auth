using MonoTouch.UIKit;

namespace Xamarin.Auth
{
	public partial struct Color
	{
		public UIColor ToUIColor()
		{
			return new UIColor((float)_r / 255, (float)_g / 255, (float)_b / 255, (float)_a / 255);
		}
	}
}