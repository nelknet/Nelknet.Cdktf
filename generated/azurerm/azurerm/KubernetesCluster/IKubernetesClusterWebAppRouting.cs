using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IKubernetesClusterWebAppRouting), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWebAppRouting")]
    public interface IKubernetesClusterWebAppRouting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_zone_ids KubernetesCluster#dns_zone_ids}.</summary>
        [JsiiProperty(name: "dnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DnsZoneIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesClusterWebAppRouting), fullyQualifiedName: "azurerm.kubernetesCluster.KubernetesClusterWebAppRouting")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesCluster.IKubernetesClusterWebAppRouting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_cluster#dns_zone_ids KubernetesCluster#dns_zone_ids}.</summary>
            [JsiiProperty(name: "dnsZoneIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DnsZoneIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
