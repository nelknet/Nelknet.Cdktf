using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermCdnFrontdoorEndpoint
{
    [JsiiByValue(fqn: "azurerm.dataAzurermCdnFrontdoorEndpoint.DataAzurermCdnFrontdoorEndpointTimeouts")]
    public class DataAzurermCdnFrontdoorEndpointTimeouts : azurerm.DataAzurermCdnFrontdoorEndpoint.IDataAzurermCdnFrontdoorEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/cdn_frontdoor_endpoint#read DataAzurermCdnFrontdoorEndpoint#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
