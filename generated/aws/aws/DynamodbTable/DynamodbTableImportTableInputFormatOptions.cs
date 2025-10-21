using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions")]
    public class DynamodbTableImportTableInputFormatOptions : aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions
    {
        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#csv DynamodbTable#csv}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsv\"}", isOptional: true)]
        public aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv? Csv
        {
            get;
            set;
        }
    }
}
