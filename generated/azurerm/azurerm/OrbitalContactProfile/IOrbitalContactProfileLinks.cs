using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrbitalContactProfile
{
    [JsiiInterface(nativeType: typeof(IOrbitalContactProfileLinks), fullyQualifiedName: "azurerm.orbitalContactProfile.OrbitalContactProfileLinks")]
    public interface IOrbitalContactProfileLinks
    {
        /// <summary>channels block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#channels OrbitalContactProfile#channels}
        /// </remarks>
        [JsiiProperty(name: "channels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannels\"},\"kind\":\"array\"}}]}}")]
        object Channels
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#direction OrbitalContactProfile#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        string Direction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#name OrbitalContactProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#polarization OrbitalContactProfile#polarization}.</summary>
        [JsiiProperty(name: "polarization", typeJson: "{\"primitive\":\"string\"}")]
        string Polarization
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOrbitalContactProfileLinks), fullyQualifiedName: "azurerm.orbitalContactProfile.OrbitalContactProfileLinks")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrbitalContactProfile.IOrbitalContactProfileLinks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>channels block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#channels OrbitalContactProfile#channels}
            /// </remarks>
            [JsiiProperty(name: "channels", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannels\"},\"kind\":\"array\"}}]}}")]
            public object Channels
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#direction OrbitalContactProfile#direction}.</summary>
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
            public string Direction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#name OrbitalContactProfile#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#polarization OrbitalContactProfile#polarization}.</summary>
            [JsiiProperty(name: "polarization", typeJson: "{\"primitive\":\"string\"}")]
            public string Polarization
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
