using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerAzureEndpoint
{
    [JsiiInterface(nativeType: typeof(ITrafficManagerAzureEndpointCustomHeader), fullyQualifiedName: "azurerm.trafficManagerAzureEndpoint.TrafficManagerAzureEndpointCustomHeader")]
    public interface ITrafficManagerAzureEndpointCustomHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#name TrafficManagerAzureEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#value TrafficManagerAzureEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITrafficManagerAzureEndpointCustomHeader), fullyQualifiedName: "azurerm.trafficManagerAzureEndpoint.TrafficManagerAzureEndpointCustomHeader")]
        internal sealed class _Proxy : DeputyBase, azurerm.TrafficManagerAzureEndpoint.ITrafficManagerAzureEndpointCustomHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#name TrafficManagerAzureEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_azure_endpoint#value TrafficManagerAzureEndpoint#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
