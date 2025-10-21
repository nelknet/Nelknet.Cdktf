using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchPool
{
    [JsiiInterface(nativeType: typeof(IDataAzurermBatchPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermBatchPool.DataAzurermBatchPoolTimeouts")]
    public interface IDataAzurermBatchPoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#read DataAzurermBatchPool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermBatchPoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermBatchPool.DataAzurermBatchPoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermBatchPool.IDataAzurermBatchPoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_pool#read DataAzurermBatchPool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
