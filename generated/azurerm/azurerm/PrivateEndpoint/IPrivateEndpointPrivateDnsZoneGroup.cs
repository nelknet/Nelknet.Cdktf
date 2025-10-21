using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    [JsiiInterface(nativeType: typeof(IPrivateEndpointPrivateDnsZoneGroup), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointPrivateDnsZoneGroup")]
    public interface IPrivateEndpointPrivateDnsZoneGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_dns_zone_ids PrivateEndpoint#private_dns_zone_ids}.</summary>
        [JsiiProperty(name: "privateDnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PrivateDnsZoneIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IPrivateEndpointPrivateDnsZoneGroup), fullyQualifiedName: "azurerm.privateEndpoint.PrivateEndpointPrivateDnsZoneGroup")]
        internal sealed class _Proxy : DeputyBase, azurerm.PrivateEndpoint.IPrivateEndpointPrivateDnsZoneGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_dns_zone_ids PrivateEndpoint#private_dns_zone_ids}.</summary>
            [JsiiProperty(name: "privateDnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PrivateDnsZoneIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
