using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderInfrastructureConfiguration
{
    [JsiiClass(nativeType: typeof(aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingOutputReference), fullyQualifiedName: "aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ImagebuilderInfrastructureConfigurationLoggingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ImagebuilderInfrastructureConfigurationLoggingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ImagebuilderInfrastructureConfigurationLoggingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderInfrastructureConfigurationLoggingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLoggingS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLoggingS3Logs)}, new object[]{@value});
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingS3LogsOutputReference\"}")]
        public virtual aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.ImagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}", isOptional: true)]
        public virtual aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLoggingS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLoggingS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.imagebuilderInfrastructureConfiguration.ImagebuilderInfrastructureConfigurationLogging\"}", isOptional: true)]
        public virtual aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLogging? InternalValue
        {
            get => GetInstanceProperty<aws.ImagebuilderInfrastructureConfiguration.IImagebuilderInfrastructureConfigurationLogging?>();
            set => SetInstanceProperty(value);
        }
    }
}
