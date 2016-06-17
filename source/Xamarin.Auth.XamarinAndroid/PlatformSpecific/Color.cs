namespace Xamarin.Auth
{
	public partial struct Color
	{
		public global::Android.Graphics.Color ToNativeColor()
		{
			return new global::Android.Graphics.Color(_r, _g, _b, _a);
		}

		public void WriteTo(Java.IO.ObjectOutputStream stream)
		{
			stream.Write(new[] { _r, _g, _b, _a });
		}

		public static Color ReadFrom(Java.IO.ObjectInputStream stream)
		{
			return new Color((byte)stream.ReadUnsignedByte(), (byte)stream.ReadUnsignedByte(), (byte)stream.ReadUnsignedByte(), (byte)stream.ReadUnsignedByte());
		}
	}
}
