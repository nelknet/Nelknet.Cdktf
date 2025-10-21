using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerNestedEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.trafficManagerNestedEndpoint.TrafficManagerNestedEndpointCustomHeader")]
    public class TrafficManagerNestedEndpointCustomHeader : azurerm.TrafficManagerNestedEndpoint.ITrafficManagerNestedEndpointCustomHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#name TrafficManagerNestedEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#value TrafficManagerNestedEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
