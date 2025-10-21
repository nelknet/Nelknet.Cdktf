using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiClass(nativeType: typeof(aws.SagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDomainSettingsRStudioServerProDomainSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultResourceSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec\"}}]")]
        public virtual void PutDefaultResourceSpec(aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultResourceSpec")]
        public virtual void ResetDefaultResourceSpec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRStudioConnectUrl")]
        public virtual void ResetRStudioConnectUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRStudioPackageManagerUrl")]
        public virtual void ResetRStudioPackageManagerUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpecOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpecOutputReference DefaultResourceSpec
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpecInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec? DefaultResourceSpecInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettingsDefaultResourceSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainExecutionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rStudioConnectUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RStudioConnectUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rStudioPackageManagerUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RStudioPackageManagerUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "domainExecutionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rStudioConnectUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RStudioConnectUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rStudioPackageManagerUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RStudioPackageManagerUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDomainSettingsRStudioServerProDomainSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDomainSettingsRStudioServerProDomainSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
