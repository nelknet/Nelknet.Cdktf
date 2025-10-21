using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectAction")]
    public class CdnFrontdoorRuleActionsUrlRedirectAction : azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirectAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_hostname CdnFrontdoorRule#destination_hostname}.</summary>
        [JsiiProperty(name: "destinationHostname", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationHostname
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#redirect_type CdnFrontdoorRule#redirect_type}.</summary>
        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        public string RedirectType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_fragment CdnFrontdoorRule#destination_fragment}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationFragment
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_path CdnFrontdoorRule#destination_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DestinationPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#query_string CdnFrontdoorRule#query_string}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? QueryString
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#redirect_protocol CdnFrontdoorRule#redirect_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RedirectProtocol
        {
            get;
            set;
        }
    }
}
