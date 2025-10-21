using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationRecorder
{
    [JsiiByValue(fqn: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingMode")]
    public class ConfigConfigurationRecorderRecordingMode : aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_frequency ConfigConfigurationRecorder#recording_frequency}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recordingFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecordingFrequency
        {
            get;
            set;
        }

        /// <summary>recording_mode_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_mode_override ConfigConfigurationRecorder#recording_mode_override}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "recordingModeOverride", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverride\"}", isOptional: true)]
        public aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride? RecordingModeOverride
        {
            get;
            set;
        }
    }
}
