using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DynamodbGlobalTable
{
    [JsiiInterface(nativeType: typeof(IDynamodbGlobalTableReplica), fullyQualifiedName: "aws.dynamodbGlobalTable.DynamodbGlobalTableReplica")]
    public interface IDynamodbGlobalTableReplica
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table#region_name DynamodbGlobalTable#region_name}.</summary>
        [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
        string RegionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDynamodbGlobalTableReplica), fullyQualifiedName: "aws.dynamodbGlobalTable.DynamodbGlobalTableReplica")]
        internal sealed class _Proxy : DeputyBase, aws.DynamodbGlobalTable.IDynamodbGlobalTableReplica
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dynamodb_global_table#region_name DynamodbGlobalTable#region_name}.</summary>
            [JsiiProperty(name: "regionName", typeJson: "{\"primitive\":\"string\"}")]
            public string RegionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
