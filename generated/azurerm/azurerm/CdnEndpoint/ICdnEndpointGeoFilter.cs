using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CdnEndpoint
{
    [JsiiInterface(nativeType: typeof(ICdnEndpointGeoFilter), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGeoFilter")]
    public interface ICdnEndpointGeoFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#action CdnEndpoint#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        string Action
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#country_codes CdnEndpoint#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CountryCodes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#relative_path CdnEndpoint#relative_path}.</summary>
        [JsiiProperty(name: "relativePath", typeJson: "{\"primitive\":\"string\"}")]
        string RelativePath
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICdnEndpointGeoFilter), fullyQualifiedName: "azurerm.cdnEndpoint.CdnEndpointGeoFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.CdnEndpoint.ICdnEndpointGeoFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#action CdnEndpoint#action}.</summary>
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
            public string Action
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#country_codes CdnEndpoint#country_codes}.</summary>
            [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CountryCodes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cdn_endpoint#relative_path CdnEndpoint#relative_path}.</summary>
            [JsiiProperty(name: "relativePath", typeJson: "{\"primitive\":\"string\"}")]
            public string RelativePath
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
