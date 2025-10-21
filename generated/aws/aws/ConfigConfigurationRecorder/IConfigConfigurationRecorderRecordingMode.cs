using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationRecorder
{
    [JsiiInterface(nativeType: typeof(IConfigConfigurationRecorderRecordingMode), fullyQualifiedName: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingMode")]
    public interface IConfigConfigurationRecorderRecordingMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_frequency ConfigConfigurationRecorder#recording_frequency}.</summary>
        [JsiiProperty(name: "recordingFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordingFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>recording_mode_override block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_mode_override ConfigConfigurationRecorder#recording_mode_override}
        /// </remarks>
        [JsiiProperty(name: "recordingModeOverride", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverride\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride? RecordingModeOverride
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigurationRecorderRecordingMode), fullyQualifiedName: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingMode")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_frequency ConfigConfigurationRecorder#recording_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordingFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordingFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>recording_mode_override block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#recording_mode_override ConfigConfigurationRecorder#recording_mode_override}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recordingModeOverride", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverride\"}", isOptional: true)]
            public aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride? RecordingModeOverride
            {
                get => GetInstanceProperty<aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride?>();
            }
        }
    }
}
