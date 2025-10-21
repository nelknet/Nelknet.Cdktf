using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerExternalEndpoint
{
    [JsiiInterface(nativeType: typeof(ITrafficManagerExternalEndpointCustomHeader), fullyQualifiedName: "azurerm.trafficManagerExternalEndpoint.TrafficManagerExternalEndpointCustomHeader")]
    public interface ITrafficManagerExternalEndpointCustomHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#name TrafficManagerExternalEndpoint#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#value TrafficManagerExternalEndpoint#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ITrafficManagerExternalEndpointCustomHeader), fullyQualifiedName: "azurerm.trafficManagerExternalEndpoint.TrafficManagerExternalEndpointCustomHeader")]
        internal sealed class _Proxy : DeputyBase, azurerm.TrafficManagerExternalEndpoint.ITrafficManagerExternalEndpointCustomHeader
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#name TrafficManagerExternalEndpoint#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_external_endpoint#value TrafficManagerExternalEndpoint#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
