using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    [JsiiInterface(nativeType: typeof(IFrontdoorRoutingRule), fullyQualifiedName: "azurerm.frontdoor.FrontdoorRoutingRule")]
    public interface IFrontdoorRoutingRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#accepted_protocols Frontdoor#accepted_protocols}.</summary>
        [JsiiProperty(name: "acceptedProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AcceptedProtocols
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#frontend_endpoints Frontdoor#frontend_endpoints}.</summary>
        [JsiiProperty(name: "frontendEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] FrontendEndpoints
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#patterns_to_match Frontdoor#patterns_to_match}.</summary>
        [JsiiProperty(name: "patternsToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PatternsToMatch
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#enabled Frontdoor#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Enabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>forwarding_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#forwarding_configuration Frontdoor#forwarding_configuration}
        /// </remarks>
        [JsiiProperty(name: "forwardingConfiguration", typeJson: "{\"fqn\":\"azurerm.frontdoor.FrontdoorRoutingRuleForwardingConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.Frontdoor.IFrontdoorRoutingRuleForwardingConfiguration? ForwardingConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>redirect_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_configuration Frontdoor#redirect_configuration}
        /// </remarks>
        [JsiiProperty(name: "redirectConfiguration", typeJson: "{\"fqn\":\"azurerm.frontdoor.FrontdoorRoutingRuleRedirectConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.Frontdoor.IFrontdoorRoutingRuleRedirectConfiguration? RedirectConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorRoutingRule), fullyQualifiedName: "azurerm.frontdoor.FrontdoorRoutingRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.Frontdoor.IFrontdoorRoutingRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#accepted_protocols Frontdoor#accepted_protocols}.</summary>
            [JsiiProperty(name: "acceptedProtocols", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AcceptedProtocols
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#frontend_endpoints Frontdoor#frontend_endpoints}.</summary>
            [JsiiProperty(name: "frontendEndpoints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] FrontendEndpoints
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#name Frontdoor#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#patterns_to_match Frontdoor#patterns_to_match}.</summary>
            [JsiiProperty(name: "patternsToMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PatternsToMatch
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#enabled Frontdoor#enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Enabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>forwarding_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#forwarding_configuration Frontdoor#forwarding_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardingConfiguration", typeJson: "{\"fqn\":\"azurerm.frontdoor.FrontdoorRoutingRuleForwardingConfiguration\"}", isOptional: true)]
            public azurerm.Frontdoor.IFrontdoorRoutingRuleForwardingConfiguration? ForwardingConfiguration
            {
                get => GetInstanceProperty<azurerm.Frontdoor.IFrontdoorRoutingRuleForwardingConfiguration?>();
            }

            /// <summary>redirect_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#redirect_configuration Frontdoor#redirect_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "redirectConfiguration", typeJson: "{\"fqn\":\"azurerm.frontdoor.FrontdoorRoutingRuleRedirectConfiguration\"}", isOptional: true)]
            public azurerm.Frontdoor.IFrontdoorRoutingRuleRedirectConfiguration? RedirectConfiguration
            {
                get => GetInstanceProperty<azurerm.Frontdoor.IFrontdoorRoutingRuleRedirectConfiguration?>();
            }
        }
    }
}
