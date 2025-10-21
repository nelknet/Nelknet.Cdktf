using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTableExport
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableExportIncrementalExportSpecification), fullyQualifiedName: "aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecification")]
    public interface IDynamodbTableExportIncrementalExportSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_from_time DynamodbTableExport#export_from_time}.</summary>
        [JsiiProperty(name: "exportFromTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportFromTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_to_time DynamodbTableExport#export_to_time}.</summary>
        [JsiiProperty(name: "exportToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportToTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_view_type DynamodbTableExport#export_view_type}.</summary>
        [JsiiProperty(name: "exportViewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExportViewType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableExportIncrementalExportSpecification), fullyQualifiedName: "aws.dynamodbTableExport.DynamodbTableExportIncrementalExportSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTableExport.IDynamodbTableExportIncrementalExportSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_from_time DynamodbTableExport#export_from_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportFromTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportFromTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_to_time DynamodbTableExport#export_to_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportToTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportToTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table_export#export_view_type DynamodbTableExport#export_view_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "exportViewType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExportViewType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
