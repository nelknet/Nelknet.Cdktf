using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Frontdoor
{
    [JsiiInterface(nativeType: typeof(IFrontdoorRoutingRuleForwardingConfiguration), fullyQualifiedName: "azurerm.frontdoor.FrontdoorRoutingRuleForwardingConfiguration")]
    public interface IFrontdoorRoutingRuleForwardingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pool_name Frontdoor#backend_pool_name}.</summary>
        [JsiiProperty(name: "backendPoolName", typeJson: "{\"primitive\":\"string\"}")]
        string BackendPoolName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_duration Frontdoor#cache_duration}.</summary>
        [JsiiProperty(name: "cacheDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_enabled Frontdoor#cache_enabled}.</summary>
        [JsiiProperty(name: "cacheEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_query_parameters Frontdoor#cache_query_parameters}.</summary>
        [JsiiProperty(name: "cacheQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CacheQueryParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_query_parameter_strip_directive Frontdoor#cache_query_parameter_strip_directive}.</summary>
        [JsiiProperty(name: "cacheQueryParameterStripDirective", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CacheQueryParameterStripDirective
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_use_dynamic_compression Frontdoor#cache_use_dynamic_compression}.</summary>
        [JsiiProperty(name: "cacheUseDynamicCompression", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CacheUseDynamicCompression
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_forwarding_path Frontdoor#custom_forwarding_path}.</summary>
        [JsiiProperty(name: "customForwardingPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CustomForwardingPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#forwarding_protocol Frontdoor#forwarding_protocol}.</summary>
        [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ForwardingProtocol
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFrontdoorRoutingRuleForwardingConfiguration), fullyQualifiedName: "azurerm.frontdoor.FrontdoorRoutingRuleForwardingConfiguration")]
        internal sealed class _Proxy : DeputyBase, azurerm.Frontdoor.IFrontdoorRoutingRuleForwardingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#backend_pool_name Frontdoor#backend_pool_name}.</summary>
            [JsiiProperty(name: "backendPoolName", typeJson: "{\"primitive\":\"string\"}")]
            public string BackendPoolName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_duration Frontdoor#cache_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_enabled Frontdoor#cache_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CacheEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_query_parameters Frontdoor#cache_query_parameters}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheQueryParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CacheQueryParameters
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_query_parameter_strip_directive Frontdoor#cache_query_parameter_strip_directive}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheQueryParameterStripDirective", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CacheQueryParameterStripDirective
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#cache_use_dynamic_compression Frontdoor#cache_use_dynamic_compression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cacheUseDynamicCompression", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CacheUseDynamicCompression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#custom_forwarding_path Frontdoor#custom_forwarding_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "customForwardingPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CustomForwardingPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/frontdoor#forwarding_protocol Frontdoor#forwarding_protocol}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "forwardingProtocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ForwardingProtocol
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
