using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrbitalSpacecraft
{
    [JsiiInterface(nativeType: typeof(IOrbitalSpacecraftLinks), fullyQualifiedName: "azurerm.orbitalSpacecraft.OrbitalSpacecraftLinks")]
    public interface IOrbitalSpacecraftLinks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#bandwidth_mhz OrbitalSpacecraft#bandwidth_mhz}.</summary>
        [JsiiProperty(name: "bandwidthMhz", typeJson: "{\"primitive\":\"number\"}")]
        double BandwidthMhz
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#center_frequency_mhz OrbitalSpacecraft#center_frequency_mhz}.</summary>
        [JsiiProperty(name: "centerFrequencyMhz", typeJson: "{\"primitive\":\"number\"}")]
        double CenterFrequencyMhz
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#direction OrbitalSpacecraft#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        string Direction
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#name OrbitalSpacecraft#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#polarization OrbitalSpacecraft#polarization}.</summary>
        [JsiiProperty(name: "polarization", typeJson: "{\"primitive\":\"string\"}")]
        string Polarization
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IOrbitalSpacecraftLinks), fullyQualifiedName: "azurerm.orbitalSpacecraft.OrbitalSpacecraftLinks")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrbitalSpacecraft.IOrbitalSpacecraftLinks
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#bandwidth_mhz OrbitalSpacecraft#bandwidth_mhz}.</summary>
            [JsiiProperty(name: "bandwidthMhz", typeJson: "{\"primitive\":\"number\"}")]
            public double BandwidthMhz
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#center_frequency_mhz OrbitalSpacecraft#center_frequency_mhz}.</summary>
            [JsiiProperty(name: "centerFrequencyMhz", typeJson: "{\"primitive\":\"number\"}")]
            public double CenterFrequencyMhz
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#direction OrbitalSpacecraft#direction}.</summary>
            [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
            public string Direction
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#name OrbitalSpacecraft#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#polarization OrbitalSpacecraft#polarization}.</summary>
            [JsiiProperty(name: "polarization", typeJson: "{\"primitive\":\"string\"}")]
            public string Polarization
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
