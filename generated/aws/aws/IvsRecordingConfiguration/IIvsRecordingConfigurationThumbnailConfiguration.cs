using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvsRecordingConfiguration
{
    [JsiiInterface(nativeType: typeof(IIvsRecordingConfigurationThumbnailConfiguration), fullyQualifiedName: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfiguration")]
    public interface IIvsRecordingConfigurationThumbnailConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#recording_mode IvsRecordingConfiguration#recording_mode}.</summary>
        [JsiiProperty(name: "recordingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecordingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#target_interval_seconds IvsRecordingConfiguration#target_interval_seconds}.</summary>
        [JsiiProperty(name: "targetIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TargetIntervalSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIvsRecordingConfigurationThumbnailConfiguration), fullyQualifiedName: "aws.ivsRecordingConfiguration.IvsRecordingConfigurationThumbnailConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.IvsRecordingConfiguration.IIvsRecordingConfigurationThumbnailConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#recording_mode IvsRecordingConfiguration#recording_mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recordingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecordingMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivs_recording_configuration#target_interval_seconds IvsRecordingConfiguration#target_interval_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetIntervalSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TargetIntervalSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
