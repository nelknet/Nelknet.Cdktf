using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GluePartitionIndex
{
    [JsiiByValue(fqn: "aws.gluePartitionIndex.GluePartitionIndexPartitionIndex")]
    public class GluePartitionIndexPartitionIndex : aws.GluePartitionIndex.IGluePartitionIndexPartitionIndex
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#index_name GluePartitionIndex#index_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition_index#keys GluePartitionIndex#keys}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Keys
        {
            get;
            set;
        }
    }
}
