using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.PrivateEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.privateEndpoint.PrivateEndpointPrivateDnsZoneGroup")]
    public class PrivateEndpointPrivateDnsZoneGroup : azurerm.PrivateEndpoint.IPrivateEndpointPrivateDnsZoneGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#name PrivateEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/private_endpoint#private_dns_zone_ids PrivateEndpoint#private_dns_zone_ids}.</summary>
        [JsiiProperty(name: "privateDnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] PrivateDnsZoneIds
        {
            get;
            set;
        }
    }
}
