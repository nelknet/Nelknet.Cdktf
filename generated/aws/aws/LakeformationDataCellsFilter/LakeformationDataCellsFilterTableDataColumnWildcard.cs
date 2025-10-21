using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationDataCellsFilter
{
    [JsiiByValue(fqn: "aws.lakeformationDataCellsFilter.LakeformationDataCellsFilterTableDataColumnWildcard")]
    public class LakeformationDataCellsFilterTableDataColumnWildcard : aws.LakeformationDataCellsFilter.ILakeformationDataCellsFilterTableDataColumnWildcard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_data_cells_filter#excluded_column_names LakeformationDataCellsFilter#excluded_column_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "excludedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ExcludedColumnNames
        {
            get;
            set;
        }
    }
}
