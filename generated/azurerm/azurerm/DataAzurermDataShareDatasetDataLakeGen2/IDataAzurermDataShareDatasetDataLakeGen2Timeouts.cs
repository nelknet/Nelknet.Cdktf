using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataShareDatasetDataLakeGen2
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataShareDatasetDataLakeGen2Timeouts), fullyQualifiedName: "azurerm.dataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2Timeouts")]
    public interface IDataAzurermDataShareDatasetDataLakeGen2Timeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2#read DataAzurermDataShareDatasetDataLakeGen2#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataShareDatasetDataLakeGen2Timeouts), fullyQualifiedName: "azurerm.dataAzurermDataShareDatasetDataLakeGen2.DataAzurermDataShareDatasetDataLakeGen2Timeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataShareDatasetDataLakeGen2.IDataAzurermDataShareDatasetDataLakeGen2Timeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_dataset_data_lake_gen2#read DataAzurermDataShareDatasetDataLakeGen2#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
