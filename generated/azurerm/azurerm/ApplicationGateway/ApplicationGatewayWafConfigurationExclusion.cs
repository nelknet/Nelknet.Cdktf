using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayWafConfigurationExclusion")]
    public class ApplicationGatewayWafConfigurationExclusion : azurerm.ApplicationGateway.IApplicationGatewayWafConfigurationExclusion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#match_variable ApplicationGateway#match_variable}.</summary>
        [JsiiProperty(name: "matchVariable", typeJson: "{\"primitive\":\"string\"}")]
        public string MatchVariable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#selector ApplicationGateway#selector}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Selector
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#selector_match_operator ApplicationGateway#selector_match_operator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "selectorMatchOperator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SelectorMatchOperator
        {
            get;
            set;
        }
    }
}
