using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectInstanceStorageConfig
{
    [JsiiClass(nativeType: typeof(aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference), fullyQualifiedName: "aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectInstanceStorageConfigStorageConfigS3ConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEncryptionConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig\"}}]")]
        public virtual void PutEncryptionConfig(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEncryptionConfig")]
        public virtual void ResetEncryptionConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "encryptionConfig", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfigOutputReference\"}")]
        public virtual aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfigOutputReference EncryptionConfig
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketPrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketPrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "encryptionConfigInput", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig? EncryptionConfigInput
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3ConfigEncryptionConfig?>();
        }

        [JsiiProperty(name: "bucketName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "bucketPrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketPrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.connectInstanceStorageConfig.ConnectInstanceStorageConfigStorageConfigS3Config\"}", isOptional: true)]
        public virtual aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config? InternalValue
        {
            get => GetInstanceProperty<aws.ConnectInstanceStorageConfig.IConnectInstanceStorageConfigStorageConfigS3Config?>();
            set => SetInstanceProperty(value);
        }
    }
}
