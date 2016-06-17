namespace Xamarin.Auth
{
	/// <summary>
	/// Desribes a simple color value, comprising RGBA values.
	/// </summary>
	public partial struct Color
	{
		private byte _r;
		private byte _g;
		private byte _b;
		private byte _a;

		public Color(byte r, byte g, byte b, byte a = 0xFF)
		{
			_r = r;
			_g = g;
			_b = b;
			_a = a;
		}
	}
}