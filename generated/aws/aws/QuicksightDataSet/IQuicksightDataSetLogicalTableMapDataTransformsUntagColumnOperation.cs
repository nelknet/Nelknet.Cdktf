using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation")]
    public interface IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
        [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
        string ColumnName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_names QuicksightDataSet#tag_names}.</summary>
        [JsiiProperty(name: "tagNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] TagNames
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_name QuicksightDataSet#column_name}.</summary>
            [JsiiProperty(name: "columnName", typeJson: "{\"primitive\":\"string\"}")]
            public string ColumnName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_names QuicksightDataSet#tag_names}.</summary>
            [JsiiProperty(name: "tagNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] TagNames
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
