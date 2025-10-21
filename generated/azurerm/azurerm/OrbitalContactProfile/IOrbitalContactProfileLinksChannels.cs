using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrbitalContactProfile
{
    [JsiiInterface(nativeType: typeof(IOrbitalContactProfileLinksChannels), fullyQualifiedName: "azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannels")]
    public interface IOrbitalContactProfileLinksChannels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#bandwidth_mhz OrbitalContactProfile#bandwidth_mhz}.</summary>
        [JsiiProperty(name: "bandwidthMhz", typeJson: "{\"primitive\":\"number\"}")]
        double BandwidthMhz
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#center_frequency_mhz OrbitalContactProfile#center_frequency_mhz}.</summary>
        [JsiiProperty(name: "centerFrequencyMhz", typeJson: "{\"primitive\":\"number\"}")]
        double CenterFrequencyMhz
        {
            get;
        }

        /// <summary>end_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#end_point OrbitalContactProfile#end_point}
        /// </remarks>
        [JsiiProperty(name: "endPoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannelsEndPoint\"},\"kind\":\"array\"}}]}}")]
        object EndPoint
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#name OrbitalContactProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#demodulation_configuration OrbitalContactProfile#demodulation_configuration}.</summary>
        [JsiiProperty(name: "demodulationConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DemodulationConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#modulation_configuration OrbitalContactProfile#modulation_configuration}.</summary>
        [JsiiProperty(name: "modulationConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ModulationConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IOrbitalContactProfileLinksChannels), fullyQualifiedName: "azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannels")]
        internal sealed class _Proxy : DeputyBase, azurerm.OrbitalContactProfile.IOrbitalContactProfileLinksChannels
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#bandwidth_mhz OrbitalContactProfile#bandwidth_mhz}.</summary>
            [JsiiProperty(name: "bandwidthMhz", typeJson: "{\"primitive\":\"number\"}")]
            public double BandwidthMhz
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#center_frequency_mhz OrbitalContactProfile#center_frequency_mhz}.</summary>
            [JsiiProperty(name: "centerFrequencyMhz", typeJson: "{\"primitive\":\"number\"}")]
            public double CenterFrequencyMhz
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>end_point block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#end_point OrbitalContactProfile#end_point}
            /// </remarks>
            [JsiiProperty(name: "endPoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannelsEndPoint\"},\"kind\":\"array\"}}]}}")]
            public object EndPoint
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#name OrbitalContactProfile#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#demodulation_configuration OrbitalContactProfile#demodulation_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "demodulationConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DemodulationConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#modulation_configuration OrbitalContactProfile#modulation_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "modulationConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ModulationConfiguration
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
