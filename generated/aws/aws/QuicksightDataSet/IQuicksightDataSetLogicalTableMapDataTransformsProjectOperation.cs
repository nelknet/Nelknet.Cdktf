using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation")]
    public interface IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#projected_columns QuicksightDataSet#projected_columns}.</summary>
        [JsiiProperty(name: "projectedColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] ProjectedColumns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#projected_columns QuicksightDataSet#projected_columns}.</summary>
            [JsiiProperty(name: "projectedColumns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] ProjectedColumns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
