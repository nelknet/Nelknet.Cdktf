using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VpnSite
{
    [JsiiInterface(nativeType: typeof(IVpnSiteO365PolicyTrafficCategory), fullyQualifiedName: "azurerm.vpnSite.VpnSiteO365PolicyTrafficCategory")]
    public interface IVpnSiteO365PolicyTrafficCategory
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#allow_endpoint_enabled VpnSite#allow_endpoint_enabled}.</summary>
        [JsiiProperty(name: "allowEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowEndpointEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#default_endpoint_enabled VpnSite#default_endpoint_enabled}.</summary>
        [JsiiProperty(name: "defaultEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DefaultEndpointEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#optimize_endpoint_enabled VpnSite#optimize_endpoint_enabled}.</summary>
        [JsiiProperty(name: "optimizeEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OptimizeEndpointEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpnSiteO365PolicyTrafficCategory), fullyQualifiedName: "azurerm.vpnSite.VpnSiteO365PolicyTrafficCategory")]
        internal sealed class _Proxy : DeputyBase, azurerm.VpnSite.IVpnSiteO365PolicyTrafficCategory
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#allow_endpoint_enabled VpnSite#allow_endpoint_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowEndpointEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#default_endpoint_enabled VpnSite#default_endpoint_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? DefaultEndpointEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/vpn_site#optimize_endpoint_enabled VpnSite#optimize_endpoint_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "optimizeEndpointEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OptimizeEndpointEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
