using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiClass(nativeType: typeof(aws.SagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsOutputReference), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultEbsStorageSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings\"}}]")]
        public virtual void PutDefaultEbsStorageSettings(aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultEbsStorageSettings")]
        public virtual void ResetDefaultEbsStorageSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultEbsStorageSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettingsOutputReference DefaultEbsStorageSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultEbsStorageSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings? DefaultEbsStorageSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettingsDefaultEbsStorageSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultSpaceSettingsSpaceStorageSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultSpaceSettingsSpaceStorageSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
