using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    [JsiiClass(nativeType: typeof(aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig\"}}]")]
        public virtual void PutEncryptionConfig(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfigOutputReference\"}")]
        public virtual aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfigOutputReference EncryptionConfig
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigInput", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig? EncryptionConfigInput
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigEncryptionConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPeriodHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RetentionPeriodHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "retentionPeriodHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RetentionPeriodHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig? InternalValue
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
