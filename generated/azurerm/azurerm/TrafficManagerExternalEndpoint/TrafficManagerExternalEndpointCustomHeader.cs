using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerExternalEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.trafficManagerExternalEndpoint.TrafficManagerExternalEndpointCustomHeader")]
    public class TrafficManagerExternalEndpointCustomHeader : azurerm.TrafficManagerExternalEndpoint.ITrafficManagerExternalEndpointCustomHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#name TrafficManagerExternalEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#value TrafficManagerExternalEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
