using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSet
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransforms), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransforms")]
    public interface IQuicksightDataSetLogicalTableMapDataTransforms
    {
        /// <summary>cast_column_type_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#cast_column_type_operation QuicksightDataSet#cast_column_type_operation}
        /// </remarks>
        [JsiiProperty(name: "castColumnTypeOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation? CastColumnTypeOperation
        {
            get
            {
                return null;
            }
        }

        /// <summary>create_columns_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#create_columns_operation QuicksightDataSet#create_columns_operation}
        /// </remarks>
        [JsiiProperty(name: "createColumnsOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation? CreateColumnsOperation
        {
            get
            {
                return null;
            }
        }

        /// <summary>filter_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#filter_operation QuicksightDataSet#filter_operation}
        /// </remarks>
        [JsiiProperty(name: "filterOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation? FilterOperation
        {
            get
            {
                return null;
            }
        }

        /// <summary>project_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#project_operation QuicksightDataSet#project_operation}
        /// </remarks>
        [JsiiProperty(name: "projectOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation? ProjectOperation
        {
            get
            {
                return null;
            }
        }

        /// <summary>rename_column_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#rename_column_operation QuicksightDataSet#rename_column_operation}
        /// </remarks>
        [JsiiProperty(name: "renameColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation? RenameColumnOperation
        {
            get
            {
                return null;
            }
        }

        /// <summary>tag_column_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_column_operation QuicksightDataSet#tag_column_operation}
        /// </remarks>
        [JsiiProperty(name: "tagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation? TagColumnOperation
        {
            get
            {
                return null;
            }
        }

        /// <summary>untag_column_operation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#untag_column_operation QuicksightDataSet#untag_column_operation}
        /// </remarks>
        [JsiiProperty(name: "untagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation? UntagColumnOperation
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSetLogicalTableMapDataTransforms), fullyQualifiedName: "aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransforms")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransforms
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>cast_column_type_operation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#cast_column_type_operation QuicksightDataSet#cast_column_type_operation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "castColumnTypeOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation? CastColumnTypeOperation
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCastColumnTypeOperation?>();
            }

            /// <summary>create_columns_operation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#create_columns_operation QuicksightDataSet#create_columns_operation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "createColumnsOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation? CreateColumnsOperation
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsCreateColumnsOperation?>();
            }

            /// <summary>filter_operation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#filter_operation QuicksightDataSet#filter_operation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filterOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsFilterOperation\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation? FilterOperation
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsFilterOperation?>();
            }

            /// <summary>project_operation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#project_operation QuicksightDataSet#project_operation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projectOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsProjectOperation\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation? ProjectOperation
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsProjectOperation?>();
            }

            /// <summary>rename_column_operation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#rename_column_operation QuicksightDataSet#rename_column_operation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "renameColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation? RenameColumnOperation
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsRenameColumnOperation?>();
            }

            /// <summary>tag_column_operation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#tag_column_operation QuicksightDataSet#tag_column_operation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation? TagColumnOperation
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsTagColumnOperation?>();
            }

            /// <summary>untag_column_operation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_set#untag_column_operation QuicksightDataSet#untag_column_operation}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "untagColumnOperation", typeJson: "{\"fqn\":\"aws.quicksightDataSet.QuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation\"}", isOptional: true)]
            public aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation? UntagColumnOperation
            {
                get => GetInstanceProperty<aws.QuicksightDataSet.IQuicksightDataSetLogicalTableMapDataTransformsUntagColumnOperation?>();
            }
        }
    }
}
