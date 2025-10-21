using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.trafficManagerProfile.TrafficManagerProfileDnsConfig")]
    public class TrafficManagerProfileDnsConfig : azurerm.TrafficManagerProfile.ITrafficManagerProfileDnsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#relative_name TrafficManagerProfile#relative_name}.</summary>
        [JsiiProperty(name: "relativeName", typeJson: "{\"primitive\":\"string\"}")]
        public string RelativeName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#ttl TrafficManagerProfile#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        public double Ttl
        {
            get;
            set;
        }
    }
}
