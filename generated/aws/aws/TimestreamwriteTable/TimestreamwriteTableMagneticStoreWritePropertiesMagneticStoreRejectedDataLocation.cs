using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamwriteTable
{
    [JsiiByValue(fqn: "aws.timestreamwriteTable.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation")]
    public class TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation : aws.TimestreamwriteTable.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocation
    {
        /// <summary>s3_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#s3_configuration TimestreamwriteTable#s3_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocationS3Configuration\"}", isOptional: true)]
        public aws.TimestreamwriteTable.ITimestreamwriteTableMagneticStoreWritePropertiesMagneticStoreRejectedDataLocationS3Configuration? S3Configuration
        {
            get;
            set;
        }
    }
}
