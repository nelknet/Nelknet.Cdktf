using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.TrafficManagerNestedEndpoint
{
    [JsiiInterface(nativeType: typeof(ITrafficManagerNestedEndpointSubnet), fullyQualifiedName: "azurerm.trafficManagerNestedEndpoint.TrafficManagerNestedEndpointSubnet")]
    public interface ITrafficManagerNestedEndpointSubnet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#first TrafficManagerNestedEndpoint#first}.</summary>
        [JsiiProperty(name: "first", typeJson: "{\"primitive\":\"string\"}")]
        string First
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#last TrafficManagerNestedEndpoint#last}.</summary>
        [JsiiProperty(name: "last", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Last
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#scope TrafficManagerNestedEndpoint#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Scope
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITrafficManagerNestedEndpointSubnet), fullyQualifiedName: "azurerm.trafficManagerNestedEndpoint.TrafficManagerNestedEndpointSubnet")]
        internal sealed class _Proxy : DeputyBase, azurerm.TrafficManagerNestedEndpoint.ITrafficManagerNestedEndpointSubnet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#first TrafficManagerNestedEndpoint#first}.</summary>
            [JsiiProperty(name: "first", typeJson: "{\"primitive\":\"string\"}")]
            public string First
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#last TrafficManagerNestedEndpoint#last}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "last", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Last
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/traffic_manager_nested_endpoint#scope TrafficManagerNestedEndpoint#scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Scope
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
