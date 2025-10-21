using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamwriteTable
{
    [JsiiInterface(nativeType: typeof(ITimestreamwriteTableSchema), fullyQualifiedName: "aws.timestreamwriteTable.TimestreamwriteTableSchema")]
    public interface ITimestreamwriteTableSchema
    {
        /// <summary>composite_partition_key block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#composite_partition_key TimestreamwriteTable#composite_partition_key}
        /// </remarks>
        [JsiiProperty(name: "compositePartitionKey", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKey\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey? CompositePartitionKey
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ITimestreamwriteTableSchema), fullyQualifiedName: "aws.timestreamwriteTable.TimestreamwriteTableSchema")]
        internal sealed class _Proxy : DeputyBase, aws.TimestreamwriteTable.ITimestreamwriteTableSchema
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>composite_partition_key block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#composite_partition_key TimestreamwriteTable#composite_partition_key}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "compositePartitionKey", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKey\"}", isOptional: true)]
            public aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey? CompositePartitionKey
            {
                get => GetInstanceProperty<aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey?>();
            }
        }
    }
}
