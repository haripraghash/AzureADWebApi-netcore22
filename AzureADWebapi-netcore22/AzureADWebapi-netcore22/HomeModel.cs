using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AzureADWebapi_netcore22
{
    public class HomeModel
    {
        public string ClientId { get; set; }

        public string TenantId { get; set; }

        public string BuildVersion { get; set; }
    }
}
