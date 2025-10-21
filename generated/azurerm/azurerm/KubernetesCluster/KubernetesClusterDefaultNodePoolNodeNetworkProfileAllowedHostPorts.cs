using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts")]
    public class KubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts : azurerm.KubernetesCluster.IKubernetesClusterDefaultNodePoolNodeNetworkProfileAllowedHostPorts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#port_end KubernetesCluster#port_end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "portEnd", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PortEnd
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#port_start KubernetesCluster#port_start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "portStart", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PortStart
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#protocol KubernetesCluster#protocol}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "protocol", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Protocol
        {
            get;
            set;
        }
    }
}
