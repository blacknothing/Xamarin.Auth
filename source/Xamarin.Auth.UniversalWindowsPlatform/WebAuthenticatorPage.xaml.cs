using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Xamarin.Auth
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WebAuthenticatorPage : Page
    {
        private WebRedirectAuthenticator _auth;

        public WebAuthenticatorPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            _auth = (WebRedirectAuthenticator)e.Parameter;

            browser.NavigationStarting += this.WebNavigationStarting;
            browser.NavigationCompleted += this.WebNavigationCompleted;

            var uri = await _auth.GetInitialUrlAsync();
            browser.Source = uri;

            base.OnNavigatedTo(e);
        }

        private void WebNavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            _auth.OnPageLoaded(args.Uri);
        }

        private void WebNavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            _auth.OnPageLoading(args.Uri);
        }
    }
}
