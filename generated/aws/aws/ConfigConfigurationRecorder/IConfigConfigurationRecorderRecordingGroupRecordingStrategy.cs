using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationRecorder
{
    [JsiiInterface(nativeType: typeof(IConfigConfigurationRecorderRecordingGroupRecordingStrategy), fullyQualifiedName: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingGroupRecordingStrategy")]
    public interface IConfigConfigurationRecorderRecordingGroupRecordingStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#use_only ConfigConfigurationRecorder#use_only}.</summary>
        [JsiiProperty(name: "useOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UseOnly
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConfigConfigurationRecorderRecordingGroupRecordingStrategy), fullyQualifiedName: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingGroupRecordingStrategy")]
        internal sealed class _Proxy : DeputyBase, aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingGroupRecordingStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/config_configuration_recorder#use_only ConfigConfigurationRecorder#use_only}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "useOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UseOnly
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
