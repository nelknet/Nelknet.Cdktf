using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ApplicationGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.applicationGateway.ApplicationGatewayUrlPathMap")]
    public class ApplicationGatewayUrlPathMap : azurerm.ApplicationGateway.IApplicationGatewayUrlPathMap
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#name ApplicationGateway#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        private object _pathRule;

        /// <summary>path_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#path_rule ApplicationGateway#path_rule}
        /// </remarks>
        [JsiiProperty(name: "pathRule", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.applicationGateway.ApplicationGatewayUrlPathMapPathRule\"},\"kind\":\"array\"}}]}}")]
        public object PathRule
        {
            get => _pathRule;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.ApplicationGateway.IApplicationGatewayUrlPathMapPathRule[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayUrlPathMapPathRule).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ApplicationGateway.IApplicationGatewayUrlPathMapPathRule).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _pathRule = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_backend_address_pool_name ApplicationGateway#default_backend_address_pool_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultBackendAddressPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultBackendAddressPoolName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_backend_http_settings_name ApplicationGateway#default_backend_http_settings_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultBackendHttpSettingsName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultBackendHttpSettingsName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_redirect_configuration_name ApplicationGateway#default_redirect_configuration_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRedirectConfigurationName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultRedirectConfigurationName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_gateway#default_rewrite_rule_set_name ApplicationGateway#default_rewrite_rule_set_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultRewriteRuleSetName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultRewriteRuleSetName
        {
            get;
            set;
        }
    }
}
