using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnFrontdoorRule
{
    [JsiiInterface(nativeType: typeof(ICdnFrontdoorRuleActionsUrlRedirectAction), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectAction")]
    public interface ICdnFrontdoorRuleActionsUrlRedirectAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_hostname CdnFrontdoorRule#destination_hostname}.</summary>
        [JsiiProperty(name: "destinationHostname", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationHostname
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#redirect_type CdnFrontdoorRule#redirect_type}.</summary>
        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_fragment CdnFrontdoorRule#destination_fragment}.</summary>
        [JsiiProperty(name: "destinationFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationFragment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_path CdnFrontdoorRule#destination_path}.</summary>
        [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DestinationPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#query_string CdnFrontdoorRule#query_string}.</summary>
        [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#redirect_protocol CdnFrontdoorRule#redirect_protocol}.</summary>
        [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RedirectProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnFrontdoorRuleActionsUrlRedirectAction), fullyQualifiedName: "azurerm.cdnFrontdoorRule.CdnFrontdoorRuleActionsUrlRedirectAction")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnFrontdoorRule.ICdnFrontdoorRuleActionsUrlRedirectAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_hostname CdnFrontdoorRule#destination_hostname}.</summary>
            [JsiiProperty(name: "destinationHostname", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationHostname
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#redirect_type CdnFrontdoorRule#redirect_type}.</summary>
            [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_fragment CdnFrontdoorRule#destination_fragment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationFragment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#destination_path CdnFrontdoorRule#destination_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "destinationPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DestinationPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#query_string CdnFrontdoorRule#query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? QueryString
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_frontdoor_rule#redirect_protocol CdnFrontdoorRule#redirect_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RedirectProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
