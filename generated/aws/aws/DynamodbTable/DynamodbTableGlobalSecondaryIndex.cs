using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndex")]
    public class DynamodbTableGlobalSecondaryIndex : aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#hash_key DynamodbTable#hash_key}.</summary>
        [JsiiProperty(name: "hashKey", typeJson: "{\"primitive\":\"string\"}")]
        public string HashKey
        {
            get;
            set;
        }

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

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#non_key_attributes DynamodbTable#non_key_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "nonKeyAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NonKeyAttributes
        {
            get;
            set;
        }

        /// <summary>on_demand_throughput block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#on_demand_throughput DynamodbTable#on_demand_throughput}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "onDemandThroughput", typeJson: "{\"fqn\":\"aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexOnDemandThroughput\"}", isOptional: true)]
        public aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexOnDemandThroughput? OnDemandThroughput
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#range_key DynamodbTable#range_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "rangeKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RangeKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#read_capacity DynamodbTable#read_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ReadCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#write_capacity DynamodbTable#write_capacity}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "writeCapacity", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WriteCapacity
        {
            get;
            set;
        }
    }
}
