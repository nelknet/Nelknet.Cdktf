using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterIngressApplicationGateway")]
    public class KubernetesClusterIngressApplicationGateway : azurerm.KubernetesCluster.IKubernetesClusterIngressApplicationGateway
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#gateway_id KubernetesCluster#gateway_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#gateway_name KubernetesCluster#gateway_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gatewayName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GatewayName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#subnet_cidr KubernetesCluster#subnet_cidr}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetCidr
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#subnet_id KubernetesCluster#subnet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SubnetId
        {
            get;
            set;
        }
    }
}
