using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableImportTableInputFormatOptionsCsv), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsv")]
    public interface IDynamodbTableImportTableInputFormatOptionsCsv
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#delimiter DynamodbTable#delimiter}.</summary>
        [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delimiter
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#header_list DynamodbTable#header_list}.</summary>
        [JsiiProperty(name: "headerList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HeaderList
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableImportTableInputFormatOptionsCsv), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableImportTableInputFormatOptionsCsv")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableImportTableInputFormatOptionsCsv
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#delimiter DynamodbTable#delimiter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delimiter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delimiter
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#header_list DynamodbTable#header_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "headerList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HeaderList
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
