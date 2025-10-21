using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTableExport
{
    [JsiiByValue(fqn: "aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecification")]
    public class DynamodbTableExportIncrementalExportSpecification : aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_from_time DynamodbTableExport#export_from_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exportFromTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExportFromTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_to_time DynamodbTableExport#export_to_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exportToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExportToTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_view_type DynamodbTableExport#export_view_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exportViewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExportViewType
        {
            get;
            set;
        }
    }
}
