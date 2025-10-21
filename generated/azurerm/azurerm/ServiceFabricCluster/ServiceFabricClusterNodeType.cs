using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ServiceFabricCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.serviceFabricCluster.ServiceFabricClusterNodeType")]
    public class ServiceFabricClusterNodeType : azurerm.ServiceFabricCluster.IServiceFabricClusterNodeType
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#client_endpoint_port ServiceFabricCluster#client_endpoint_port}.</summary>
        [JsiiProperty(name: "clientEndpointPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ClientEndpointPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#http_endpoint_port ServiceFabricCluster#http_endpoint_port}.</summary>
        [JsiiProperty(name: "httpEndpointPort", typeJson: "{\"primitive\":\"number\"}")]
        public double HttpEndpointPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#instance_count ServiceFabricCluster#instance_count}.</summary>
        [JsiiProperty(name: "instanceCount", typeJson: "{\"primitive\":\"number\"}")]
        public double InstanceCount
        {
            get;
            set;
        }

        private object _isPrimary;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_primary ServiceFabricCluster#is_primary}.</summary>
        [JsiiProperty(name: "isPrimary", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object IsPrimary
        {
            get => _isPrimary;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isPrimary = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#name ServiceFabricCluster#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>application_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#application_ports ServiceFabricCluster#application_ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "applicationPorts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeApplicationPorts\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeApplicationPorts? ApplicationPorts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#capacities ServiceFabricCluster#capacities}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "capacities", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Capacities
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#durability_level ServiceFabricCluster#durability_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "durabilityLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DurabilityLevel
        {
            get;
            set;
        }

        /// <summary>ephemeral_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#ephemeral_ports ServiceFabricCluster#ephemeral_ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ephemeralPorts", typeJson: "{\"fqn\":\"azurerm.serviceFabricCluster.ServiceFabricClusterNodeTypeEphemeralPorts\"}", isOptional: true)]
        public azurerm.ServiceFabricCluster.IServiceFabricClusterNodeTypeEphemeralPorts? EphemeralPorts
        {
            get;
            set;
        }

        private object? _isStateless;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#is_stateless ServiceFabricCluster#is_stateless}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "isStateless", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? IsStateless
        {
            get => _isStateless;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isStateless = value;
            }
        }

        private object? _multipleAvailabilityZones;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#multiple_availability_zones ServiceFabricCluster#multiple_availability_zones}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "multipleAvailabilityZones", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? MultipleAvailabilityZones
        {
            get => _multipleAvailabilityZones;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _multipleAvailabilityZones = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#placement_properties ServiceFabricCluster#placement_properties}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "placementProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? PlacementProperties
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_fabric_cluster#reverse_proxy_endpoint_port ServiceFabricCluster#reverse_proxy_endpoint_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "reverseProxyEndpointPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReverseProxyEndpointPort
        {
            get;
            set;
        }
    }
}
