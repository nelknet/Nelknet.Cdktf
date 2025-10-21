using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsRecordingConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfiguration")]
    public class IvsRecordingConfigurationDestinationConfiguration : aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfiguration
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#s3 IvsRecordingConfiguration#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.ivsRecordingConfiguration.IvsRecordingConfigurationDestinationConfigurationS3\"}")]
        public aws.IvsRecordingConfiguration.IIvsRecordingConfigurationDestinationConfigurationS3 S3
        {
            get;
            set;
        }
    }
}
