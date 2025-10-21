using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsRecordingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationS3")]
    public class IvsRecordingConfigurationDestinationConfigurationS3 : aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#bucket_name IvsRecordingConfiguration#bucket_name}.</summary>
        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public string BucketName
        {
            get;
            set;
        }
    }
}
