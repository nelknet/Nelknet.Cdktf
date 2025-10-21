using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterWindowsProfileGmsa), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWindowsProfileGmsa")]
    public interface IKubernetesClusterWindowsProfileGmsa
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_server KubernetesCluster#dns_server}.</summary>
        [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}")]
        string DnsServer
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#root_domain KubernetesCluster#root_domain}.</summary>
        [JsiiProperty(name: "rootDomain", typeJson: "{\"primitive\":\"string\"}")]
        string RootDomain
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterWindowsProfileGmsa), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWindowsProfileGmsa")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterWindowsProfileGmsa
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_server KubernetesCluster#dns_server}.</summary>
            [JsiiProperty(name: "dnsServer", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsServer
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#root_domain KubernetesCluster#root_domain}.</summary>
            [JsiiProperty(name: "rootDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string RootDomain
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
