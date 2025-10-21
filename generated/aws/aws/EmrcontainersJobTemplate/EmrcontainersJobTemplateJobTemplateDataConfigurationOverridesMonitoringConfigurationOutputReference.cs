using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiClass(nativeType: typeof(aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudWatchMonitoringConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfiguration\"}}]")]
        public virtual void PutCloudWatchMonitoringConfiguration(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3MonitoringConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration\"}}]")]
        public virtual void PutS3MonitoringConfiguration(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudWatchMonitoringConfiguration")]
        public virtual void ResetCloudWatchMonitoringConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPersistentAppUi")]
        public virtual void ResetPersistentAppUi()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3MonitoringConfiguration")]
        public virtual void ResetS3MonitoringConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudWatchMonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfigurationOutputReference\"}")]
        public virtual aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfigurationOutputReference CloudWatchMonitoringConfiguration
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3MonitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfigurationOutputReference\"}")]
        public virtual aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfigurationOutputReference S3MonitoringConfiguration
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchMonitoringConfigurationInput", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfiguration? CloudWatchMonitoringConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationCloudWatchMonitoringConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "persistentAppUiInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PersistentAppUiInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3MonitoringConfigurationInput", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration? S3MonitoringConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationS3MonitoringConfiguration?>();
        }

        [JsiiProperty(name: "persistentAppUi", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PersistentAppUi
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
