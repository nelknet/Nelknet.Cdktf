using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConfigConfigurationRecorder
{
    [JsiiClass(nativeType: typeof(aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingModeOutputReference), fullyQualifiedName: "aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConfigConfigurationRecorderRecordingModeOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConfigConfigurationRecorderRecordingModeOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorderRecordingModeOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConfigConfigurationRecorderRecordingModeOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putRecordingModeOverride", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverride\"}}]")]
        public virtual void PutRecordingModeOverride(aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRecordingFrequency")]
        public virtual void ResetRecordingFrequency()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecordingModeOverride")]
        public virtual void ResetRecordingModeOverride()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "recordingModeOverride", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverrideOutputReference\"}")]
        public virtual aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverrideOutputReference RecordingModeOverride
        {
            get => GetInstanceProperty<aws.ConfigConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverrideOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordingFrequencyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RecordingFrequencyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recordingModeOverrideInput", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingModeRecordingModeOverride\"}", isOptional: true)]
        public virtual aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride? RecordingModeOverrideInput
        {
            get => GetInstanceProperty<aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingModeRecordingModeOverride?>();
        }

        [JsiiProperty(name: "recordingFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RecordingFrequency
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.configConfigurationRecorder.ConfigConfigurationRecorderRecordingMode\"}", isOptional: true)]
        public virtual aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode? InternalValue
        {
            get => GetInstanceProperty<aws.ConfigConfigurationRecorder.IConfigConfigurationRecorderRecordingMode?>();
            set => SetInstanceProperty(value);
        }
    }
}
