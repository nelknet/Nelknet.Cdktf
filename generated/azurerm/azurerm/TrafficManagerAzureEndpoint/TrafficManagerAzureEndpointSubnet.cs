using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerAzureEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.trafficManagerAzureEndpoint.TrafficManagerAzureEndpointSubnet")]
    public class TrafficManagerAzureEndpointSubnet : azurerm.TrafficManagerAzureEndpoint.ITrafficManagerAzureEndpointSubnet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#first TrafficManagerAzureEndpoint#first}.</summary>
        [JsiiProperty(name: "first", typeJson: "{\"primitive\":\"string\"}")]
        public string First
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#last TrafficManagerAzureEndpoint#last}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "last", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Last
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#scope TrafficManagerAzureEndpoint#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Scope
        {
            get;
            set;
        }
    }
}
