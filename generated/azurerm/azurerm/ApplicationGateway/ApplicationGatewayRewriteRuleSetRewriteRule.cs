using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRule")]
    public class ApplicationGatewayRewriteRuleSetRewriteRule : azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#rule_sequence ApplicationGateway#rule_sequence}.</summary>
        [JsiiProperty(name: "ruleSequence", typeJson: "{\"primitive\":\"number\"}")]
        public double RuleSequence
        {
            get;
            set;
        }

        private object? _condition;

        /// <summary>condition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#condition ApplicationGateway#condition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "condition", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleCondition\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Condition
        {
            get => _condition;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleCondition[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleCondition).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _condition = value;
            }
        }

        private object? _requestHeaderConfiguration;

        /// <summary>request_header_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#request_header_configuration ApplicationGateway#request_header_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requestHeaderConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? RequestHeaderConfiguration
        {
            get => _requestHeaderConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleRequestHeaderConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _requestHeaderConfiguration = value;
            }
        }

        private object? _responseHeaderConfiguration;

        /// <summary>response_header_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#response_header_configuration ApplicationGateway#response_header_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "responseHeaderConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ResponseHeaderConfiguration
        {
            get => _responseHeaderConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleResponseHeaderConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _responseHeaderConfiguration = value;
            }
        }

        /// <summary>url block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#url ApplicationGateway#url}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayRewriteRuleSetRewriteRuleUrl\"}", isOptional: true)]
        public azurerm.ApplicationGateway.IApplicationGatewayRewriteRuleSetRewriteRuleUrl? Url
        {
            get;
            set;
        }
    }
}
