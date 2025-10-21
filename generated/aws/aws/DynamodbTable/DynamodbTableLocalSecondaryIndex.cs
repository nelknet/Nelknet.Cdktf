using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableLocalSecondaryIndex")]
    public class DynamodbTableLocalSecondaryIndex : aws.DynamodbTable.IDynamodbTableLocalSecondaryIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#name DynamodbTable#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#projection_type DynamodbTable#projection_type}.</summary>
        [JsiiProperty(name: "projectionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ProjectionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#range_key DynamodbTable#range_key}.</summary>
        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}")]
        public string RangeKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#non_key_attributes DynamodbTable#non_key_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NonKeyAttributes
        {
            get;
            set;
        }
    }
}
