using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerExternalEndpoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.trafficManagerExternalEndpoint.TrafficManagerExternalEndpointSubnet")]
    public class TrafficManagerExternalEndpointSubnet : azurerm.TrafficManagerExternalEndpoint.ITrafficManagerExternalEndpointSubnet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#first TrafficManagerExternalEndpoint#first}.</summary>
        [JsiiProperty(name: "first", typeJson: "{\"primitive\":\"string\"}")]
        public string First
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#last TrafficManagerExternalEndpoint#last}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "last", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Last
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#scope TrafficManagerExternalEndpoint#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Scope
        {
            get;
            set;
        }
    }
}
