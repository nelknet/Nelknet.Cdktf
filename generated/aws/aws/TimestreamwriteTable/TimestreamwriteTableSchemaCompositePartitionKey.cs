using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamwriteTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreamwriteTable.TimestreamwriteTableSchemaCompositePartitionKey")]
    public class TimestreamwriteTableSchemaCompositePartitionKey : aws.TimestreamwriteTable.ITimestreamwriteTableSchemaCompositePartitionKey
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#type TimestreamwriteTable#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#enforcement_in_record TimestreamwriteTable#enforcement_in_record}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enforcementInRecord", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EnforcementInRecord
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#name TimestreamwriteTable#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
