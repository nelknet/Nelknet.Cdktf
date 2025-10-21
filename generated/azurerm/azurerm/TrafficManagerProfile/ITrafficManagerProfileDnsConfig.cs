using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerProfile
{
    [JsiiInterface(nativeType: typeof(ITrafficManagerProfileDnsConfig), fullyQualifiedName: "azurerm.trafficManagerProfile.TrafficManagerProfileDnsConfig")]
    public interface ITrafficManagerProfileDnsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#relative_name TrafficManagerProfile#relative_name}.</summary>
        [JsiiProperty(name: "relativeName", typeJson: "{\"primitive\":\"string\"}")]
        string RelativeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#ttl TrafficManagerProfile#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
        double Ttl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITrafficManagerProfileDnsConfig), fullyQualifiedName: "azurerm.trafficManagerProfile.TrafficManagerProfileDnsConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.TrafficManagerProfile.ITrafficManagerProfileDnsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#relative_name TrafficManagerProfile#relative_name}.</summary>
            [JsiiProperty(name: "relativeName", typeJson: "{\"primitive\":\"string\"}")]
            public string RelativeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_profile#ttl TrafficManagerProfile#ttl}.</summary>
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}")]
            public double Ttl
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
