using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GluePartition
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.gluePartition.GluePartitionStorageDescriptorSortColumns")]
    public class GluePartitionStorageDescriptorSortColumns : aws.GluePartition.IGluePartitionStorageDescriptorSortColumns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#column GluePartition#column}.</summary>
        [JsiiProperty(name: "column", typeJson: "{\"primitive\":\"string\"}")]
        public string Column
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#sort_order GluePartition#sort_order}.</summary>
        [JsiiProperty(name: "sortOrder", typeJson: "{\"primitive\":\"number\"}")]
        public double SortOrder
        {
            get;
            set;
        }
    }
}
