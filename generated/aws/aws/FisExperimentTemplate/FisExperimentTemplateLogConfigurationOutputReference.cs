using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FisExperimentTemplate
{
    [JsiiClass(nativeType: typeof(aws.FisExperimentTemplate.FisExperimentTemplateLogConfigurationOutputReference), fullyQualifiedName: "aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FisExperimentTemplateLogConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FisExperimentTemplateLogConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FisExperimentTemplateLogConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FisExperimentTemplateLogConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration\"}}]")]
        public virtual void PutCloudwatchLogsConfiguration(aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Configuration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationS3Configuration\"}}]")]
        public virtual void PutS3Configuration(aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogsConfiguration")]
        public virtual void ResetCloudwatchLogsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Configuration")]
        public virtual void ResetS3Configuration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogsConfiguration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfigurationOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfigurationOutputReference CloudwatchLogsConfiguration
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "s3Configuration", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationS3ConfigurationOutputReference\"}")]
        public virtual aws.FisExperimentTemplate.FisExperimentTemplateLogConfigurationS3ConfigurationOutputReference S3Configuration
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.FisExperimentTemplateLogConfigurationS3ConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsConfigurationInput", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration? CloudwatchLogsConfigurationInput
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationCloudwatchLogsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logSchemaVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? LogSchemaVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConfigurationInput", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfigurationS3Configuration\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration? S3ConfigurationInput
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateLogConfigurationS3Configuration?>();
        }

        [JsiiProperty(name: "logSchemaVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double LogSchemaVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fisExperimentTemplate.FisExperimentTemplateLogConfiguration\"}", isOptional: true)]
        public virtual aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.FisExperimentTemplate.IFisExperimentTemplateLogConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
