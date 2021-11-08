using System.Threading.Tasks;
using Statiq.App;
using Statiq.Common;
using Statiq.Web;

namespace MMEnSite {
    public class Program {
        public static async Task<int> Main(string[] args) =>
            await Bootstrapper
                .Factory
                .CreateWeb(args)
                .DeployToGitHubPagesBranch("think-mm", "enblog", Config.FromSetting<string>("GITHUB_TOKEN"), "web")
                .RunAsync();
    }
}
