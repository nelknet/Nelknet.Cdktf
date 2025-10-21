using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrbitalContactProfile
{
    [JsiiInterface(nativeType: typeof(IOrbitalContactProfileLinksChannelsEndPoint), fullyQualifiedName: "azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannelsEndPoint")]
    public interface IOrbitalContactProfileLinksChannelsEndPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#end_point_name OrbitalContactProfile#end_point_name}.</summary>
        [JsiiProperty(name: "endPointName", typeJson: "{\"primitive\":\"string\"}")]
        string EndPointName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#port OrbitalContactProfile#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        string Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#protocol OrbitalContactProfile#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        string Protocol
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#ip_address OrbitalContactProfile#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? IpAddress
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrbitalContactProfileLinksChannelsEndPoint), fullyQualifiedName: "azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannelsEndPoint")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrbitalContactProfile.IOrbitalContactProfileLinksChannelsEndPoint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#end_point_name OrbitalContactProfile#end_point_name}.</summary>
            [JsiiProperty(name: "endPointName", typeJson: "{\"primitive\":\"string\"}")]
            public string EndPointName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#port OrbitalContactProfile#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
            public string Port
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#protocol OrbitalContactProfile#protocol}.</summary>
            [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
            public string Protocol
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#ip_address OrbitalContactProfile#ip_address}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? IpAddress
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
