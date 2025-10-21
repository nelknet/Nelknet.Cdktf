using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesClusterExtension
{
    [JsiiInterface(nativeType: typeof(IArcKubernetesClusterExtensionIdentity), fullyQualifiedName: "azurerm.arcKubernetesClusterExtension.ArcKubernetesClusterExtensionIdentity")]
    public interface IArcKubernetesClusterExtensionIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#type ArcKubernetesClusterExtension#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcKubernetesClusterExtensionIdentity), fullyQualifiedName: "azurerm.arcKubernetesClusterExtension.ArcKubernetesClusterExtensionIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ArcKubernetesClusterExtension.IArcKubernetesClusterExtensionIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster_extension#type ArcKubernetesClusterExtension#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
