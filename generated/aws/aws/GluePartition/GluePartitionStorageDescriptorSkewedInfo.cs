using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GluePartition
{
    [JsiiByValue(fqn: "aws.gluePartition.GluePartitionStorageDescriptorSkewedInfo")]
    public class GluePartitionStorageDescriptorSkewedInfo : aws.GluePartition.IGluePartitionStorageDescriptorSkewedInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#skewed_column_names GluePartition#skewed_column_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SkewedColumnNames
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#skewed_column_value_location_maps GluePartition#skewed_column_value_location_maps}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnValueLocationMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? SkewedColumnValueLocationMaps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_partition#skewed_column_values GluePartition#skewed_column_values}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "skewedColumnValues", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? SkewedColumnValues
        {
            get;
            set;
        }
    }
}
