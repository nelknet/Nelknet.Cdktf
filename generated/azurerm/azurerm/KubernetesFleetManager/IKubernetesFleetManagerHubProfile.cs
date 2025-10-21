using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.KubernetesFleetManager
{
    [JsiiInterface(nativeType: typeof(IKubernetesFleetManagerHubProfile), fullyQualifiedName: "azurerm.kubernetesFleetManager.KubernetesFleetManagerHubProfile")]
    public interface IKubernetesFleetManagerHubProfile
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#dns_prefix KubernetesFleetManager#dns_prefix}.</summary>
        [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}")]
        string DnsPrefix
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKubernetesFleetManagerHubProfile), fullyQualifiedName: "azurerm.kubernetesFleetManager.KubernetesFleetManagerHubProfile")]
        internal sealed class _Proxy : DeputyBase, azurerm.KubernetesFleetManager.IKubernetesFleetManagerHubProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kubernetes_fleet_manager#dns_prefix KubernetesFleetManager#dns_prefix}.</summary>
            [JsiiProperty(name: "dnsPrefix", typeJson: "{\"primitive\":\"string\"}")]
            public string DnsPrefix
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
