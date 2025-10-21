using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedaccessInstanceLoggingConfiguration
{
    [JsiiClass(nativeType: typeof(aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsOutputReference), fullyQualifiedName: "aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VerifiedaccessInstanceLoggingConfigurationAccessLogsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VerifiedaccessInstanceLoggingConfigurationAccessLogsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VerifiedaccessInstanceLoggingConfigurationAccessLogsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VerifiedaccessInstanceLoggingConfigurationAccessLogsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs\"}}]")]
        public virtual void PutCloudwatchLogs(aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisDataFirehose", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose\"}}]")]
        public virtual void PutKinesisDataFirehose(aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsS3\"}}]")]
        public virtual void PutS3(aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsS3)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogs")]
        public virtual void ResetCloudwatchLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIncludeTrustContext")]
        public virtual void ResetIncludeTrustContext()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisDataFirehose")]
        public virtual void ResetKinesisDataFirehose()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLogVersion")]
        public virtual void ResetLogVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3")]
        public virtual void ResetS3()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogs", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogsOutputReference\"}")]
        public virtual aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogsOutputReference CloudwatchLogs
        {
            get => GetInstanceProperty<aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogsOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisDataFirehose", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehoseOutputReference\"}")]
        public virtual aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehoseOutputReference KinesisDataFirehose
        {
            get => GetInstanceProperty<aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehoseOutputReference>()!;
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsS3OutputReference\"}")]
        public virtual aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsS3OutputReference S3
        {
            get => GetInstanceProperty<aws.VerifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogsInput", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs\"}", isOptional: true)]
        public virtual aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs? CloudwatchLogsInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsCloudwatchLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "includeTrustContextInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? IncludeTrustContextInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisDataFirehoseInput", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose\"}", isOptional: true)]
        public virtual aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose? KinesisDataFirehoseInput
        {
            get => GetInstanceProperty<aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsKinesisDataFirehose?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "logVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogsS3\"}", isOptional: true)]
        public virtual aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsS3? S3Input
        {
            get => GetInstanceProperty<aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogsS3?>();
        }

        [JsiiProperty(name: "includeTrustContext", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object IncludeTrustContext
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "logVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.verifiedaccessInstanceLoggingConfiguration.VerifiedaccessInstanceLoggingConfigurationAccessLogs\"}", isOptional: true)]
        public virtual aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogs? InternalValue
        {
            get => GetInstanceProperty<aws.VerifiedaccessInstanceLoggingConfiguration.IVerifiedaccessInstanceLoggingConfigurationAccessLogs?>();
            set => SetInstanceProperty(value);
        }
    }
}
