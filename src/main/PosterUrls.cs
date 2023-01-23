using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ei8.Cortex.Diary.Plugins.MessageTree
{
    public class PosterUrls
    {
        private IConfiguration configuration;
        
        public PosterUrls(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string InstantiatesMessage => this.configuration["PosterUrls:InstantiatesMessage"];

        public bool HasValue
        {
            get => !string.IsNullOrWhiteSpace(this.InstantiatesMessage);
        }

        public string ToUrlEncodedString()
        {
            var result = new StringBuilder();

            if (!string.IsNullOrWhiteSpace(this.InstantiatesMessage))
            {
                result.Append("posterurl=");
                result.Append(HttpUtility.UrlEncode(this.InstantiatesMessage));
            }

            return result.ToString();
        }
    }
}
