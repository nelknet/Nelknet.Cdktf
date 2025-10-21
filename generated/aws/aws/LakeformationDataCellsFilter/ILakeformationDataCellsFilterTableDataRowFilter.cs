using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationDataCellsFilter
{
    [JsiiInterface(nativeType: typeof(ILakeformationDataCellsFilterTableDataRowFilter), fullyQualifiedName: "aws.lakeformationDataCellsFilter.LakeformationDataCellsFilterTableDataRowFilter")]
    public interface ILakeformationDataCellsFilterTableDataRowFilter
    {
        /// <summary>all_rows_wildcard block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#all_rows_wildcard LakeformationDataCellsFilter#all_rows_wildcard}
        /// </remarks>
        [JsiiProperty(name: "allRowsWildcard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationDataCellsFilter.LakeformationDataCellsFilterTableDataRowFilterAllRowsWildcard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllRowsWildcard
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#filter_expression LakeformationDataCellsFilter#filter_expression}.</summary>
        [JsiiProperty(name: "filterExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FilterExpression
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationDataCellsFilterTableDataRowFilter), fullyQualifiedName: "aws.lakeformationDataCellsFilter.LakeformationDataCellsFilterTableDataRowFilter")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationDataCellsFilter.ILakeformationDataCellsFilterTableDataRowFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>all_rows_wildcard block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#all_rows_wildcard LakeformationDataCellsFilter#all_rows_wildcard}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allRowsWildcard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationDataCellsFilter.LakeformationDataCellsFilterTableDataRowFilterAllRowsWildcard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? AllRowsWildcard
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#filter_expression LakeformationDataCellsFilter#filter_expression}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "filterExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FilterExpression
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
