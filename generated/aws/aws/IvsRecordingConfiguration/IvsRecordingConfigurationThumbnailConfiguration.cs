using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsRecordingConfiguration
{
    [JsiiByValue(fqn: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfiguration")]
    public class IvsRecordingConfigurationThumbnailConfiguration : aws.IvsRecordingConfiguration.IIvsRecordingConfigurationThumbnailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#recording_mode IvsRecordingConfiguration#recording_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordingMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#target_interval_seconds IvsRecordingConfiguration#target_interval_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TargetIntervalSeconds
        {
            get;
            set;
        }
    }
}
