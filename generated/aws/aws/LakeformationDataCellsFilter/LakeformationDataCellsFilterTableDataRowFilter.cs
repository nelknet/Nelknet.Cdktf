using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationDataCellsFilter
{
    [JsiiByValue(fqn: "aws.lakeformationDataCellsFilter.LakeformationDataCellsFilterTableDataRowFilter")]
    public class LakeformationDataCellsFilterTableDataRowFilter : aws.LakeformationDataCellsFilter.ILakeformationDataCellsFilterTableDataRowFilter
    {
        private object? _allRowsWildcard;

        /// <summary>all_rows_wildcard block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#all_rows_wildcard LakeformationDataCellsFilter#all_rows_wildcard}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allRowsWildcard", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationDataCellsFilter.LakeformationDataCellsFilterTableDataRowFilterAllRowsWildcard\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? AllRowsWildcard
        {
            get => _allRowsWildcard;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationDataCellsFilter.ILakeformationDataCellsFilterTableDataRowFilterAllRowsWildcard[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationDataCellsFilter.ILakeformationDataCellsFilterTableDataRowFilterAllRowsWildcard).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allRowsWildcard = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#filter_expression LakeformationDataCellsFilter#filter_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "filterExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FilterExpression
        {
            get;
            set;
        }
    }
}
