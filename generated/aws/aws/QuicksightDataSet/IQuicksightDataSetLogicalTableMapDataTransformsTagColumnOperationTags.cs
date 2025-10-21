using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags")]
    public interface IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags
    {
        /// <summary>column_description block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_description QuicksightDataSet#column_description}
        /// </remarks>
        [JsiiProperty(name: "columnDescription", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription? ColumnDescription
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_geographic_role QuicksightDataSet#column_geographic_role}.</summary>
        [JsiiProperty(name: "columnGeographicRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ColumnGeographicRole
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTags
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>column_description block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_description QuicksightDataSet#column_description}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "columnDescription", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription? ColumnDescription
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperationTagsColumnDescription?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#column_geographic_role QuicksightDataSet#column_geographic_role}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "columnGeographicRole", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ColumnGeographicRole
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
