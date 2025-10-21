using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterHttpProxyConfig), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig")]
    public interface IKubernetesClusterHttpProxyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_proxy KubernetesCluster#http_proxy}.</summary>
        [JsiiProperty(name: "httpProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#https_proxy KubernetesCluster#https_proxy}.</summary>
        [JsiiProperty(name: "httpsProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HttpsProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#no_proxy KubernetesCluster#no_proxy}.</summary>
        [JsiiProperty(name: "noProxy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NoProxy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#trusted_ca KubernetesCluster#trusted_ca}.</summary>
        [JsiiProperty(name: "trustedCa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TrustedCa
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterHttpProxyConfig), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterHttpProxyConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterHttpProxyConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#http_proxy KubernetesCluster#http_proxy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#https_proxy KubernetesCluster#https_proxy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpsProxy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HttpsProxy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#no_proxy KubernetesCluster#no_proxy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "noProxy", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NoProxy
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#trusted_ca KubernetesCluster#trusted_ca}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "trustedCa", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TrustedCa
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
