using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsServiceServiceConnectConfigurationServiceTlsOutputReference), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsServiceServiceConnectConfigurationServiceTlsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsServiceServiceConnectConfigurationServiceTlsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsServiceServiceConnectConfigurationServiceTlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceServiceConnectConfigurationServiceTlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIssuerCertAuthority", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority\"}}]")]
        public virtual void PutIssuerCertAuthority(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKmsKey")]
        public virtual void ResetKmsKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRoleArn")]
        public virtual void ResetRoleArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "issuerCertAuthority", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthorityOutputReference\"}")]
        public virtual aws.EcsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthorityOutputReference IssuerCertAuthority
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthorityOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerCertAuthorityInput", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority? IssuerCertAuthorityInput
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTlsIssuerCertAuthority?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "kmsKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationServiceTls\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls? InternalValue
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationServiceTls?>();
            set => SetInstanceProperty(value);
        }
    }
}
