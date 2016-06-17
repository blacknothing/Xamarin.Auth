namespace Xamarin.Auth
{
	/// <summary>
	/// Provides configurable options that control how various UI aspects of the authenticator
	/// are presented.
	/// </summary>
	public partial class AuthenticatorUiOptions
	{
		/// <summary>
		/// Gets or sets the color of the background when a page is loading
		/// </summary>
		/// <value>The color of the loading background.</value>
		public Color LoadingBackgroundColor { get; set; }

		/// <summary>
		/// Gets or sets the color of the background when a page has finished loading
		/// </summary>
		/// <value>The color of the loaded background.</value>
		public Color LoadedBackgroundColor { get; set; }
	}
}