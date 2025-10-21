using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBatchApplication
{
    [JsiiInterface(nativeType: typeof(IDataAzurermBatchApplicationTimeouts), fullyQualifiedName: "azurerm.dataAzurermBatchApplication.DataAzurermBatchApplicationTimeouts")]
    public interface IDataAzurermBatchApplicationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application#read DataAzurermBatchApplication#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermBatchApplicationTimeouts), fullyQualifiedName: "azurerm.dataAzurermBatchApplication.DataAzurermBatchApplicationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermBatchApplication.IDataAzurermBatchApplicationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_application#read DataAzurermBatchApplication#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
