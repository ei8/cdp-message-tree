using Microsoft.Extensions.Configuration;
using ei8.Cortex.Diary.Port.Adapter.UI.Views.Blazor.Common;

namespace ei8.Cortex.Diary.Plugins.MessageTree
{
    public class MessageTreePluginSettingsService : IPluginSettingsService
    {
        private const int DefaultUpdateCheckInterval = 2000;

        public int UpdateCheckInterval => int.TryParse(this.Configuration["UpdateCheckInterval"], out int uci) ? uci : MessageTreePluginSettingsService.DefaultUpdateCheckInterval;

        public int MediaScale => int.TryParse(this.Configuration["mediascale"], out int uci) ? uci : MessageTreePluginSettingsService.DefaultUpdateCheckInterval;

        private IConfiguration configuration;
        public IConfiguration Configuration 
        {
            get => this.configuration;
            set
            {
                this.configuration = value;

                if (this.configuration != null)
                {
                    this.PosterUrls = new PosterUrls(this.configuration);
                }
            } 
        }

        public PosterUrls PosterUrls { get; set; }
    }
}
