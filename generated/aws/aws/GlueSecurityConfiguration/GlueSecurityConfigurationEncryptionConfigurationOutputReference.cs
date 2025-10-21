using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlueSecurityConfiguration
{
    [JsiiClass(nativeType: typeof(aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationOutputReference), fullyQualifiedName: "aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class GlueSecurityConfigurationEncryptionConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public GlueSecurityConfigurationEncryptionConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected GlueSecurityConfigurationEncryptionConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GlueSecurityConfigurationEncryptionConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}}]")]
        public virtual void PutCloudwatchEncryption(aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putJobBookmarksEncryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}}]")]
        public virtual void PutJobBookmarksEncryption(aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption)}, new object[]{@value});
        }

        [JsiiMethod(name: "putS3Encryption", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}}]")]
        public virtual void PutS3Encryption(aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption)}, new object[]{@value});
        }

        [JsiiProperty(name: "cloudwatchEncryption", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryptionOutputReference\"}")]
        public virtual aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryptionOutputReference CloudwatchEncryption
        {
            get => GetInstanceProperty<aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "jobBookmarksEncryption", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryptionOutputReference\"}")]
        public virtual aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryptionOutputReference JobBookmarksEncryption
        {
            get => GetInstanceProperty<aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryptionOutputReference>()!;
        }

        [JsiiProperty(name: "s3Encryption", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationS3EncryptionOutputReference\"}")]
        public virtual aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationS3EncryptionOutputReference S3Encryption
        {
            get => GetInstanceProperty<aws.GlueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationS3EncryptionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchEncryptionInput", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption\"}", isOptional: true)]
        public virtual aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption? CloudwatchEncryptionInput
        {
            get => GetInstanceProperty<aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationCloudwatchEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jobBookmarksEncryptionInput", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption\"}", isOptional: true)]
        public virtual aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption? JobBookmarksEncryptionInput
        {
            get => GetInstanceProperty<aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationJobBookmarksEncryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3EncryptionInput", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfigurationS3Encryption\"}", isOptional: true)]
        public virtual aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption? S3EncryptionInput
        {
            get => GetInstanceProperty<aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfigurationS3Encryption?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.glueSecurityConfiguration.GlueSecurityConfigurationEncryptionConfiguration\"}", isOptional: true)]
        public virtual aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.GlueSecurityConfiguration.IGlueSecurityConfigurationEncryptionConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
