using System.Windows;
using System.Windows.Controls;
using System.IO;
namespace ChatGptWeb
{
    public partial class MyToolWindowControl : UserControl
    {
        public MyToolWindowControl()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            Random rnd = new Random();
            string subFolder = rnd.Next().ToString();
            var env = await Microsoft.Web.WebView2.Core.CoreWebView2Environment.CreateAsync(userDataFolder: Path.Combine(Path.GetTempPath(), $"{Environment.UserName}", subFolder));
            await YouTubeWebView.EnsureCoreWebView2Async(env);
            var request = YouTubeWebView.CoreWebView2.Environment.CreateWebResourceRequest("https://www.Chatgpt.com", "GET", null, null);
            YouTubeWebView.CoreWebView2.NavigateWithWebResourceRequest(request);
        }
    }
}