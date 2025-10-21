using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerAzureEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.trafficManagerAzureEndpoint.TrafficManagerAzureEndpointCustomHeader")]
    public class TrafficManagerAzureEndpointCustomHeader : azurerm.TrafficManagerAzureEndpoint.ITrafficManagerAzureEndpointCustomHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#name TrafficManagerAzureEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#value TrafficManagerAzureEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
