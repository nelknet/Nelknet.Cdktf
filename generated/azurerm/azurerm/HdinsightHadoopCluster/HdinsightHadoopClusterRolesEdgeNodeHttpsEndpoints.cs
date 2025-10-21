using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.HdinsightHadoopCluster
{
    [JsiiByValue(fqn: "azurerm.hdinsightHadoopCluster.HdinsightHadoopClusterRolesEdgeNodeHttpsEndpoints")]
    public class HdinsightHadoopClusterRolesEdgeNodeHttpsEndpoints : azurerm.HdinsightHadoopCluster.IHdinsightHadoopClusterRolesEdgeNodeHttpsEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#access_modes HdinsightHadoopCluster#access_modes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AccessModes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#destination_port HdinsightHadoopCluster#destination_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "destinationPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DestinationPort
        {
            get;
            set;
        }

        private object? _disableGatewayAuth;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#disable_gateway_auth HdinsightHadoopCluster#disable_gateway_auth}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "disableGatewayAuth", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? DisableGatewayAuth
        {
            get => _disableGatewayAuth;
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
                _disableGatewayAuth = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#private_ip_address HdinsightHadoopCluster#private_ip_address}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "privateIpAddress", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PrivateIpAddress
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hdinsight_hadoop_cluster#sub_domain_suffix HdinsightHadoopCluster#sub_domain_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subDomainSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubDomainSuffix
        {
            get;
            set;
        }
    }
}
