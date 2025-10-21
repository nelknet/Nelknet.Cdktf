using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbTableGlobalSecondaryIndexOnDemandThroughput), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexOnDemandThroughput")]
    public interface IDynamodbTableGlobalSecondaryIndexOnDemandThroughput
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#max_read_request_units DynamodbTable#max_read_request_units}.</summary>
        [JsiiProperty(name: "maxReadRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxReadRequestUnits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#max_write_request_units DynamodbTable#max_write_request_units}.</summary>
        [JsiiProperty(name: "maxWriteRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxWriteRequestUnits
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbTableGlobalSecondaryIndexOnDemandThroughput), fullyQualifiedName: "aws.dynamodbTable.DynamodbTableGlobalSecondaryIndexOnDemandThroughput")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbTable.IDynamodbTableGlobalSecondaryIndexOnDemandThroughput
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#max_read_request_units DynamodbTable#max_read_request_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxReadRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxReadRequestUnits
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_table#max_write_request_units DynamodbTable#max_write_request_units}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxWriteRequestUnits", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxWriteRequestUnits
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
