using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.OrbitalContactProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.orbitalContactProfile.OrbitalContactProfileLinksChannelsEndPoint")]
    public class OrbitalContactProfileLinksChannelsEndPoint : azurerm.OrbitalContactProfile.IOrbitalContactProfileLinksChannelsEndPoint
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#end_point_name OrbitalContactProfile#end_point_name}.</summary>
        [JsiiProperty(name: "endPointName", typeJson: "{\"primitive\":\"string\"}")]
        public string EndPointName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#port OrbitalContactProfile#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"string\"}")]
        public string Port
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#protocol OrbitalContactProfile#protocol}.</summary>
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}")]
        public string Protocol
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/orbital_contact_profile#ip_address OrbitalContactProfile#ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IpAddress
        {
            get;
            set;
        }
    }
}
