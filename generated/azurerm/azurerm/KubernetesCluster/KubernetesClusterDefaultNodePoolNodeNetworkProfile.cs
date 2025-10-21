using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfile")]
    public class KubernetesClusterDefaultNodePoolNodeNetworkProfile : azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfile
    {
        private object? _allowedHostPorts;

        /// <summary>allowed_host_ports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#allowed_host_ports KubernetesCluster#allowed_host_ports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedHostPorts", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllowedHostPorts
        {
            get => _allowedHostPorts;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowedHostPorts = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#application_security_group_ids KubernetesCluster#application_security_group_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationSecurityGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ApplicationSecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#node_public_ip_tags KubernetesCluster#node_public_ip_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nodePublicIpTags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? NodePublicIpTags
        {
            get;
            set;
        }
    }
}
