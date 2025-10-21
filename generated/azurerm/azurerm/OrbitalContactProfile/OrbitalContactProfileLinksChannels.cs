using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrbitalContactProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannels")]
    public class OrbitalContactProfileLinksChannels : azurerm.OrbitalContactProfile.IOrbitalContactProfileLinksChannels
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#bandwidth_mhz OrbitalContactProfile#bandwidth_mhz}.</summary>
        [JsiiProperty(name: "bandwidthMhz", typeJson: "{\"primitive\":\"number\"}")]
        public double BandwidthMhz
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#center_frequency_mhz OrbitalContactProfile#center_frequency_mhz}.</summary>
        [JsiiProperty(name: "centerFrequencyMhz", typeJson: "{\"primitive\":\"number\"}")]
        public double CenterFrequencyMhz
        {
            get;
            set;
        }

        private object _endPoint;

        /// <summary>end_point block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#end_point OrbitalContactProfile#end_point}
        /// </remarks>
        [JsiiProperty(name: "endPoint", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannelsEndPoint\"},\"kind\":\"array\"}}]}}")]
        public object EndPoint
        {
            get => _endPoint;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.OrbitalContactProfile.IOrbitalContactProfileLinksChannelsEndPoint[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.OrbitalContactProfile.IOrbitalContactProfileLinksChannelsEndPoint).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.OrbitalContactProfile.IOrbitalContactProfileLinksChannelsEndPoint).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _endPoint = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#name OrbitalContactProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#demodulation_configuration OrbitalContactProfile#demodulation_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "demodulationConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DemodulationConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#modulation_configuration OrbitalContactProfile#modulation_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "modulationConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ModulationConfiguration
        {
            get;
            set;
        }
    }
}
