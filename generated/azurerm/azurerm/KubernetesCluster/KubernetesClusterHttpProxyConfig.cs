using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiByValue(fqn: "azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig")]
    public class KubernetesClusterHttpProxyConfig : azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_proxy KubernetesCluster#http_proxy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpProxy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#https_proxy KubernetesCluster#https_proxy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpsProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HttpsProxy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#no_proxy KubernetesCluster#no_proxy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "noProxy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NoProxy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#trusted_ca KubernetesCluster#trusted_ca}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "trustedCa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TrustedCa
        {
            get;
            set;
        }
    }
}
