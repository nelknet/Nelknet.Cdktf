using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    [JsiiClass(nativeType: typeof(aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigOutputReference), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConnectInstanceStorageConfigStorageConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConnectInstanceStorageConfigStorageConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConnectInstanceStorageConfigStorageConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectInstanceStorageConfigStorageConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKinesisFirehoseConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig\"}}]")]
        public virtual void PutKinesisFirehoseConfig(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisStreamConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfig\"}}]")]
        public virtual void PutKinesisStreamConfig(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKinesisVideoStreamConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig\"}}]")]
        public virtual void PutKinesisVideoStreamConfig(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Config", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3Config\"}}]")]
        public virtual void PutS3Config(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKinesisFirehoseConfig")]
        public virtual void ResetKinesisFirehoseConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisStreamConfig")]
        public virtual void ResetKinesisStreamConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKinesisVideoStreamConfig")]
        public virtual void ResetKinesisVideoStreamConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetS3Config")]
        public virtual void ResetS3Config()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "kinesisFirehoseConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfigOutputReference\"}")]
        public virtual aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfigOutputReference KinesisFirehoseConfig
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfigOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfigOutputReference\"}")]
        public virtual aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfigOutputReference KinesisStreamConfig
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfigOutputReference>()!;
        }

        [JsiiProperty(name: "kinesisVideoStreamConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference\"}")]
        public virtual aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference KinesisVideoStreamConfig
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfigOutputReference>()!;
        }

        [JsiiProperty(name: "s3Config", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference\"}")]
        public virtual aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference S3Config
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisFirehoseConfigInput", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig? KinesisFirehoseConfigInput
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisFirehoseConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisStreamConfigInput", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisStreamConfig\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig? KinesisStreamConfigInput
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisStreamConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kinesisVideoStreamConfigInput", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig? KinesisVideoStreamConfigInput
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigKinesisVideoStreamConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3ConfigInput", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3Config\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config? S3ConfigInput
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StorageTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfig\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfig? InternalValue
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
