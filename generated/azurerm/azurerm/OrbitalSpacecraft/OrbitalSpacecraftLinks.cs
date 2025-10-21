using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrbitalSpacecraft
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.orbitalSpacecraft.OrbitalSpacecraftLinks")]
    public class OrbitalSpacecraftLinks : azurerm.OrbitalSpacecraft.IOrbitalSpacecraftLinks
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#bandwidth_mhz OrbitalSpacecraft#bandwidth_mhz}.</summary>
        [JsiiProperty(name: "bandwidthMhz", typeJson: "{\"primitive\":\"number\"}")]
        public double BandwidthMhz
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#center_frequency_mhz OrbitalSpacecraft#center_frequency_mhz}.</summary>
        [JsiiProperty(name: "centerFrequencyMhz", typeJson: "{\"primitive\":\"number\"}")]
        public double CenterFrequencyMhz
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#direction OrbitalSpacecraft#direction}.</summary>
        [JsiiProperty(name: "direction", typeJson: "{\"primitive\":\"string\"}")]
        public string Direction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#name OrbitalSpacecraft#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_spacecraft#polarization OrbitalSpacecraft#polarization}.</summary>
        [JsiiProperty(name: "polarization", typeJson: "{\"primitive\":\"string\"}")]
        public string Polarization
        {
            get;
            set;
        }
    }
}
