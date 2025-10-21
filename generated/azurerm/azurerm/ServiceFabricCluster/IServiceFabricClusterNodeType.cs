using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    [JsiiInterface(nativeType: typeof(IServiceFabricClusterNodeType), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterNodeType")]
    public interface IServiceFabricClusterNodeType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_endpoint_port ServiceFabricCluster#client_endpoint_port}.</summary>
        [JsiiProperty(name: "clientEndpointPort", typeJson: "{\"primitive\":\"number\"}")]
        double ClientEndpointPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#http_endpoint_port ServiceFabricCluster#http_endpoint_port}.</summary>
        [JsiiProperty(name: "httpEndpointPort", typeJson: "{\"primitive\":\"number\"}")]
        double HttpEndpointPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#instance_count ServiceFabricCluster#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        double InstanceCount
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_primary ServiceFabricCluster#is_primary}.</summary>
        [JsiiProperty(name: "isPrimary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object IsPrimary
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#name ServiceFabricCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>application_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#application_ports ServiceFabricCluster#application_ports}
        /// </remarks>
        [JsiiProperty(name: "applicationPorts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeApplicationPorts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeApplicationPorts? ApplicationPorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#capacities ServiceFabricCluster#capacities}.</summary>
        [JsiiProperty(name: "capacities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Capacities
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#durability_level ServiceFabricCluster#durability_level}.</summary>
        [JsiiProperty(name: "durabilityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DurabilityLevel
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#ephemeral_ports ServiceFabricCluster#ephemeral_ports}
        /// </remarks>
        [JsiiProperty(name: "ephemeralPorts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeEphemeralPorts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeEphemeralPorts? EphemeralPorts
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_stateless ServiceFabricCluster#is_stateless}.</summary>
        [JsiiProperty(name: "isStateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IsStateless
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#multiple_availability_zones ServiceFabricCluster#multiple_availability_zones}.</summary>
        [JsiiProperty(name: "multipleAvailabilityZones", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? MultipleAvailabilityZones
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#placement_properties ServiceFabricCluster#placement_properties}.</summary>
        [JsiiProperty(name: "placementProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? PlacementProperties
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reverse_proxy_endpoint_port ServiceFabricCluster#reverse_proxy_endpoint_port}.</summary>
        [JsiiProperty(name: "reverseProxyEndpointPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ReverseProxyEndpointPort
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IServiceFabricClusterNodeType), fullyQualifiedName: "azurerm.serviceFabricCluster.ServiceFabricClusterNodeType")]
        internal sealed class _Proxy : DeputyBase, azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_endpoint_port ServiceFabricCluster#client_endpoint_port}.</summary>
            [JsiiProperty(name: "clientEndpointPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ClientEndpointPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#http_endpoint_port ServiceFabricCluster#http_endpoint_port}.</summary>
            [JsiiProperty(name: "httpEndpointPort", typeJson: "{\"primitive\":\"number\"}")]
            public double HttpEndpointPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#instance_count ServiceFabricCluster#instance_count}.</summary>
            [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
            public double InstanceCount
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_primary ServiceFabricCluster#is_primary}.</summary>
            [JsiiProperty(name: "isPrimary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object IsPrimary
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#name ServiceFabricCluster#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>application_ports block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#application_ports ServiceFabricCluster#application_ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "applicationPorts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeApplicationPorts\"}", isOptional: true)]
            public azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeApplicationPorts? ApplicationPorts
            {
                get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeApplicationPorts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#capacities ServiceFabricCluster#capacities}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "capacities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Capacities
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#durability_level ServiceFabricCluster#durability_level}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "durabilityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DurabilityLevel
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ephemeral_ports block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#ephemeral_ports ServiceFabricCluster#ephemeral_ports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeralPorts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeEphemeralPorts\"}", isOptional: true)]
            public azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeEphemeralPorts? EphemeralPorts
            {
                get => GetInstanceProperty<azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeEphemeralPorts?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_stateless ServiceFabricCluster#is_stateless}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "isStateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IsStateless
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#multiple_availability_zones ServiceFabricCluster#multiple_availability_zones}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "multipleAvailabilityZones", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? MultipleAvailabilityZones
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#placement_properties ServiceFabricCluster#placement_properties}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "placementProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? PlacementProperties
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reverse_proxy_endpoint_port ServiceFabricCluster#reverse_proxy_endpoint_port}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "reverseProxyEndpointPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ReverseProxyEndpointPort
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
