using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamwriteTable
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.timestreamwriteTable.TimestreamwriteTableRetentionProperties")]
    public class TimestreamwriteTableRetentionProperties : aws.TimestreamwriteTable.ITimestreamwriteTableRetentionProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#magnetic_store_retention_period_in_days TimestreamwriteTable#magnetic_store_retention_period_in_days}.</summary>
        [JsiiProperty(name: "magneticStoreRetentionPeriodInDays", typeJson: "{\"primitive\":\"number\"}")]
        public double MagneticStoreRetentionPeriodInDays
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#memory_store_retention_period_in_hours TimestreamwriteTable#memory_store_retention_period_in_hours}.</summary>
        [JsiiProperty(name: "memoryStoreRetentionPeriodInHours", typeJson: "{\"primitive\":\"number\"}")]
        public double MemoryStoreRetentionPeriodInHours
        {
            get;
            set;
        }
    }
}
