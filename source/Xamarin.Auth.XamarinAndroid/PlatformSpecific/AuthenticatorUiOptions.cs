using System;
using Android.Runtime;
using Java.Interop;

namespace Xamarin.Auth
{
	public partial class AuthenticatorUiOptions : Java.Lang.Object, Java.IO.ISerializable
	{
		public AuthenticatorUiOptions()
		{
		}

		public AuthenticatorUiOptions(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer)
		{
		}

		[Export("readObject", Throws = new[] {
			typeof (Java.IO.IOException),
			typeof (Java.Lang.ClassNotFoundException)})]
		private void ReadObject(Java.IO.ObjectInputStream source)
		{
			// first 4 bytes are loaded bg color, next 4 are loading color
			LoadedBackgroundColor = Color.ReadFrom(source);
			LoadingBackgroundColor = Color.ReadFrom(source);
		}

		[Export("writeObject", Throws = new[] {
			typeof (Java.IO.IOException),
			typeof (Java.Lang.ClassNotFoundException)})]
		private void WriteObject(Java.IO.ObjectOutputStream destination)
		{
			LoadedBackgroundColor.WriteTo(destination);
			LoadingBackgroundColor.WriteTo(destination);
		}
	}
}

