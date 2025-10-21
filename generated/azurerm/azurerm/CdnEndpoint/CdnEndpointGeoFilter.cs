using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnEndpoint.CdnEndpointGeoFilter")]
    public class CdnEndpointGeoFilter : azurerm.CdnEndpoint.ICdnEndpointGeoFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#action CdnEndpoint#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#country_codes CdnEndpoint#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] CountryCodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#relative_path CdnEndpoint#relative_path}.</summary>
        [JsiiProperty(name: "relativePath", typeJson: "{\"primitive\":\"string\"}")]
        public string RelativePath
        {
            get;
            set;
        }
    }
}
