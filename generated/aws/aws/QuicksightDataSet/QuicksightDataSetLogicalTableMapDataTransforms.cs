using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiByValue(fqn: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransforms")]
    public class QuicksightDataSetLogicalTableMapDataTransforms : aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransforms
    {
        /// <summary>cast_column_type_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#cast_column_type_operation QuicksightDataSet#cast_column_type_operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "castColumnTypeOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation? CastColumnTypeOperation
        {
            get;
            set;
        }

        /// <summary>create_columns_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#create_columns_operation QuicksightDataSet#create_columns_operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "createColumnsOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation? CreateColumnsOperation
        {
            get;
            set;
        }

        /// <summary>filter_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#filter_operation QuicksightDataSet#filter_operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filterOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation? FilterOperation
        {
            get;
            set;
        }

        /// <summary>project_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#project_operation QuicksightDataSet#project_operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "projectOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation? ProjectOperation
        {
            get;
            set;
        }

        /// <summary>rename_column_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#rename_column_operation QuicksightDataSet#rename_column_operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "renameColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation? RenameColumnOperation
        {
            get;
            set;
        }

        /// <summary>tag_column_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_column_operation QuicksightDataSet#tag_column_operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation? TagColumnOperation
        {
            get;
            set;
        }

        /// <summary>untag_column_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#untag_column_operation QuicksightDataSet#untag_column_operation}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "untagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation\"}", isOptional: true)]
        public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation? UntagColumnOperation
        {
            get;
            set;
        }
    }
}
