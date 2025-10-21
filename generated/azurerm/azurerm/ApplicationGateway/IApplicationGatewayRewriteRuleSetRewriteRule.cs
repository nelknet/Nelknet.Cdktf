using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    [JsiiInterface(nativeType: typeof(IApplicationGatewayRewriteRuleSetRewriteRule), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRule")]
    public interface IApplicationGatewayRewriteRuleSetRewriteRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_sequence ApplicationGateway#rule_sequence}.</summary>
        [JsiiProperty(name: "ruleSequence", typeJson: "{\"primitive\":\"number\"}")]
        double RuleSequence
        {
            get;
        }

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#condition ApplicationGateway#condition}
        /// </remarks>
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Condition
        {
            get
            {
                return null;
            }
        }

        /// <summary>request_header_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#request_header_configuration ApplicationGateway#request_header_configuration}
        /// </remarks>
        [JsiiProperty(name: "requestHeaderConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? RequestHeaderConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>response_header_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#response_header_configuration ApplicationGateway#response_header_configuration}
        /// </remarks>
        [JsiiProperty(name: "responseHeaderConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ResponseHeaderConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#url ApplicationGateway#url}
        /// </remarks>
        [JsiiProperty(name: "url", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleUrl\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleUrl? Url
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IApplicationGatewayRewriteRuleSetRewriteRule), fullyQualifiedName: "azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_sequence ApplicationGateway#rule_sequence}.</summary>
            [JsiiProperty(name: "ruleSequence", typeJson: "{\"primitive\":\"number\"}")]
            public double RuleSequence
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>condition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#condition ApplicationGateway#condition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Condition
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>request_header_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#request_header_configuration ApplicationGateway#request_header_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requestHeaderConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? RequestHeaderConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>response_header_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#response_header_configuration ApplicationGateway#response_header_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "responseHeaderConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ResponseHeaderConfiguration
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>url block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#url ApplicationGateway#url}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "url", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleUrl\"}", isOptional: true)]
            public azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleUrl? Url
            {
                get => GetInstanceProperty<azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleUrl?>();
            }
        }
    }
}
