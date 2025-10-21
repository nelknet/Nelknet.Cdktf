using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiByValue(fqn: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexOnDemandThroughput")]
    public class DynamodbTableGlobalSecondaryIndexOnDemandThroughput : aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexOnDemandThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#max_read_request_units DynamodbTable#max_read_request_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxReadRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxReadRequestUnits
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#max_write_request_units DynamodbTable#max_write_request_units}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxWriteRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxWriteRequestUnits
        {
            get;
            set;
        }
    }
}
