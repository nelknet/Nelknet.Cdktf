using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    [JsiiInterface(nativeType: typeof(IFrontdoorRoutingRuleRedirectConfiguration), fullyQualifiedName: "azurerm.frontdoor.FrontdoorRoutingRuleRedirectConfiguration")]
    public interface IFrontdoorRoutingRuleRedirectConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_protocol Frontdoor#redirect_protocol}.</summary>
        [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectProtocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_type Frontdoor#redirect_type}.</summary>
        [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
        string RedirectType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_fragment Frontdoor#custom_fragment}.</summary>
        [JsiiProperty(name: "customFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomFragment
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_host Frontdoor#custom_host}.</summary>
        [JsiiProperty(name: "customHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomHost
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_path Frontdoor#custom_path}.</summary>
        [JsiiProperty(name: "customPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_query_string Frontdoor#custom_query_string}.</summary>
        [JsiiProperty(name: "customQueryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomQueryString
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorRoutingRuleRedirectConfiguration), fullyQualifiedName: "azurerm.frontdoor.FrontdoorRoutingRuleRedirectConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.Frontdoor.IFrontdoorRoutingRuleRedirectConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_protocol Frontdoor#redirect_protocol}.</summary>
            [JsiiProperty(name: "redirectProtocol", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectProtocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_type Frontdoor#redirect_type}.</summary>
            [JsiiProperty(name: "redirectType", typeJson: "{\"primitive\":\"string\"}")]
            public string RedirectType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_fragment Frontdoor#custom_fragment}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customFragment", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomFragment
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_host Frontdoor#custom_host}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customHost", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomHost
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_path Frontdoor#custom_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_query_string Frontdoor#custom_query_string}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customQueryString", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomQueryString
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
