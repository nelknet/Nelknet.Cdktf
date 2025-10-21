using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.trafficManagerProfile.TrafficManagerProfileMonitorConfigCustomHeader")]
    public class TrafficManagerProfileMonitorConfigCustomHeader : azurerm.TrafficManagerProfile.ITrafficManagerProfileMonitorConfigCustomHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#name TrafficManagerProfile#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#value TrafficManagerProfile#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
