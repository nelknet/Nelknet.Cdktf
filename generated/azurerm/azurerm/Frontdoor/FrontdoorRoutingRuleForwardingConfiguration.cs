using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.frontdoor.FrontdoorRoutingRuleForwardingConfiguration")]
    public class FrontdoorRoutingRuleForwardingConfiguration : azurerm.Frontdoor.IFrontdoorRoutingRuleForwardingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pool_name Frontdoor#backend_pool_name}.</summary>
        [JsiiProperty(name: "backendPoolName", typeJson: "{\"primitive\":\"string\"}")]
        public string BackendPoolName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_duration Frontdoor#cache_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheDuration
        {
            get;
            set;
        }

        private object? _cacheEnabled;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_enabled Frontdoor#cache_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CacheEnabled
        {
            get => _cacheEnabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cacheEnabled = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_query_parameters Frontdoor#cache_query_parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? CacheQueryParameters
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_query_parameter_strip_directive Frontdoor#cache_query_parameter_strip_directive}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheQueryParameterStripDirective", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CacheQueryParameterStripDirective
        {
            get;
            set;
        }

        private object? _cacheUseDynamicCompression;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_use_dynamic_compression Frontdoor#cache_use_dynamic_compression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheUseDynamicCompression", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? CacheUseDynamicCompression
        {
            get => _cacheUseDynamicCompression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cacheUseDynamicCompression = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_forwarding_path Frontdoor#custom_forwarding_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customForwardingPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomForwardingPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#forwarding_protocol Frontdoor#forwarding_protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ForwardingProtocol
        {
            get;
            set;
        }
    }
}
