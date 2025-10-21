using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dynamodbGlobalTable.DynamodbGlobalTableReplica")]
    public class DynamodbGlobalTableReplica : aws.DynamodbGlobalTable.IDynamodbGlobalTableReplica
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table#region_name DynamodbGlobalTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        public string RegionName
        {
            get;
            set;
        }
    }
}
