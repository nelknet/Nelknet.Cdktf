using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermEventhubCluster
{
    [JsiiInterface(nativeType: typeof(IDataAzurermEventhubClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventhubCluster.DataAzurermEventhubClusterTimeouts")]
    public interface IDataAzurermEventhubClusterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster#read DataAzurermEventhubCluster#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermEventhubClusterTimeouts), fullyQualifiedName: "azurerm.dataAzurermEventhubCluster.DataAzurermEventhubClusterTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermEventhubCluster.IDataAzurermEventhubClusterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_cluster#read DataAzurermEventhubCluster#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
