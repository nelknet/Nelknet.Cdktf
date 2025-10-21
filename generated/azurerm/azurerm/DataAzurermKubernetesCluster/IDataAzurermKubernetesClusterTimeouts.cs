using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermKubernetesCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermKubernetesClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeouts")]
    public interface IDataAzurermKubernetesClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#read DataAzurermKubernetesCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermKubernetesClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermKubernetesCluster.DataAzurermKubernetesClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermKubernetesCluster.IDataAzurermKubernetesClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/kubernetes_cluster#read DataAzurermKubernetesCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
