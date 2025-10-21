using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrCluster
{
    [JsiiClass(nativeType: typeof(aws.EmrCluster.EmrClusterKerberosAttributesOutputReference), fullyQualifiedName: "aws.emrCluster.EmrClusterKerberosAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrClusterKerberosAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrClusterKerberosAttributesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrClusterKerberosAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterKerberosAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdDomainJoinPassword")]
        public virtual void ResetAdDomainJoinPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdDomainJoinUser")]
        public virtual void ResetAdDomainJoinUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrossRealmTrustPrincipalPassword")]
        public virtual void ResetCrossRealmTrustPrincipalPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdDomainJoinPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinUserInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdDomainJoinUserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossRealmTrustPrincipalPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CrossRealmTrustPrincipalPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kdcAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KdcAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "realmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RealmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdDomainJoinPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdDomainJoinUser
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossRealmTrustPrincipalPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KdcAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Realm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrCluster.EmrClusterKerberosAttributes\"}", isOptional: true)]
        public virtual aws.EmrCluster.IEmrClusterKerberosAttributes? InternalValue
        {
            get => GetInstanceProperty<aws.EmrCluster.IEmrClusterKerberosAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
