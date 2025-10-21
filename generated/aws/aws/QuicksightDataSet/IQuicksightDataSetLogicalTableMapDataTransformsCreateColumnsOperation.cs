using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation")]
    public interface IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation
    {
        /// <summary>columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#columns QuicksightDataSet#columns}
        /// </remarks>
        [JsiiProperty(name: "columns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperationColumns\"},\"kind\":\"array\"}}]}}")]
        object Columns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#columns QuicksightDataSet#columns}
            /// </remarks>
            [JsiiProperty(name: "columns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperationColumns\"},\"kind\":\"array\"}}]}}")]
            public object Columns
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
