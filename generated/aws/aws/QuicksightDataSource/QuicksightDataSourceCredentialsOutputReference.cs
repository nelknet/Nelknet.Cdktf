using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDataSource.QuicksightDataSourceCredentialsOutputReference), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceCredentialsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDataSourceCredentialsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDataSourceCredentialsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDataSourceCredentialsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceCredentialsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCredentialPair", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceCredentialsCredentialPair\"}}]")]
        public virtual void PutCredentialPair(aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCopySourceArn")]
        public virtual void ResetCopySourceArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCredentialPair")]
        public virtual void ResetCredentialPair()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretArn")]
        public virtual void ResetSecretArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "credentialPair", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceCredentialsCredentialPairOutputReference\"}")]
        public virtual aws.QuicksightDataSource.QuicksightDataSourceCredentialsCredentialPairOutputReference CredentialPair
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.QuicksightDataSourceCredentialsCredentialPairOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "copySourceArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CopySourceArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialPairInput", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceCredentialsCredentialPair\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair? CredentialPairInput
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceCredentialsCredentialPair?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "copySourceArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CopySourceArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "secretArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDataSource.QuicksightDataSourceCredentials\"}", isOptional: true)]
        public virtual aws.QuicksightDataSource.IQuicksightDataSourceCredentials? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDataSource.IQuicksightDataSourceCredentials?>();
            set => SetInstanceProperty(value);
        }
    }
}
