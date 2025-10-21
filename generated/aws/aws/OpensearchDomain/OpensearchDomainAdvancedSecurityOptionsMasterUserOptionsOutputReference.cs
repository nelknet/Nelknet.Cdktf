using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.OpensearchDomain
{
    [JsiiClass(nativeType: typeof(aws.OpensearchDomain.OpensearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference), fullyQualifiedName: "aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchDomainAdvancedSecurityOptionsMasterUserOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMasterUserArn")]
        public virtual void ResetMasterUserArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterUserName")]
        public virtual void ResetMasterUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterUserPassword")]
        public virtual void ResetMasterUserPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterUserArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterUserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterUserPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "masterUserArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterUserArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterUserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterUserPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterUserPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.opensearchDomain.OpensearchDomainAdvancedSecurityOptionsMasterUserOptions\"}", isOptional: true)]
        public virtual aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptionsMasterUserOptions? InternalValue
        {
            get => GetInstanceProperty<aws.OpensearchDomain.IOpensearchDomainAdvancedSecurityOptionsMasterUserOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
