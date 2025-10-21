using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableImportTableInputFormatOptions), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions")]
    public interface IDynamodbTableImportTableInputFormatOptions
    {
        /// <summary>csv block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#csv DynamodbTable#csv}
        /// </remarks>
        [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv? Csv
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableImportTableInputFormatOptions), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableInputFormatOptions")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>csv block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#csv DynamodbTable#csv}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csv", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsv\"}", isOptional: true)]
            public aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv? Csv
            {
                get => GetInstanceProperty<aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv?>();
            }
        }
    }
}
