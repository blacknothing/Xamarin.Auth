using System;
using Windows.UI.Xaml;
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
            this.InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            _auth = (WebRedirectAuthenticator)e.Parameter;

            browser.NavigationStarting += Web_NavigationStarting;
            browser.NavigationCompleted += Web_NavigationCompleted;

            Uri uri = await _auth.GetInitialUrlAsync();
            this.browser.Source = uri;

            /*
            string key = NavigationContext.QueryString["key"];

            this.auth = (WebAuthenticator)PhoneApplicationService.Current.State[key];
            //this.auth.Completed += (sender, args) => NavigationService.GoBack(); // throws on BackButton
            this.auth.Completed += auth_Completed;
            this.auth.Error += OnAuthError;

            PhoneApplicationService.Current.State.Remove(key);

            if (this.auth.ClearCookiesBeforeLogin)
                await this.browser.ClearCookiesAsync();

            Uri uri = await this.auth.GetInitialUrlAsync();
            this.browser.Source = uri;
            */
            base.OnNavigatedTo(e);
        }

        private void Web_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            _auth.OnPageLoaded(args.Uri);
        }

        private void Web_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            _auth.OnPageLoading(args.Uri);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();

            return;
        }
    }
}
