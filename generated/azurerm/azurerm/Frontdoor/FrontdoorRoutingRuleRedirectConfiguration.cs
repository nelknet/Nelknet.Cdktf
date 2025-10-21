using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.frontdoor.FrontdoorRoutingRuleRedirectConfiguration")]
    public class FrontdoorRoutingRuleRedirectConfiguration : azurerm.Frontdoor.IFrontdoorRoutingRuleRedirectConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_protocol Frontdoor#redirect_protocol}.</summary>
        [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public string RedirectProtocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_type Frontdoor#redirect_type}.</summary>
        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        public string RedirectType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_fragment Frontdoor#custom_fragment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomFragment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_host Frontdoor#custom_host}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomHost
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_path Frontdoor#custom_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_query_string Frontdoor#custom_query_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customQueryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomQueryString
        {
            get;
            set;
        }
    }
}
