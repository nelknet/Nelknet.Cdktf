using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ArcKubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IArcKubernetesClusterIdentity), fullyQualifiedName: "azurerm.arcKubernetesCluster.ArcKubernetesClusterIdentity")]
    public interface IArcKubernetesClusterIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#type ArcKubernetesCluster#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IArcKubernetesClusterIdentity), fullyQualifiedName: "azurerm.arcKubernetesCluster.ArcKubernetesClusterIdentity")]
        internal sealed class _Proxy : DeputyBase, azurerm.ArcKubernetesCluster.IArcKubernetesClusterIdentity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/arc_kubernetes_cluster#type ArcKubernetesCluster#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
