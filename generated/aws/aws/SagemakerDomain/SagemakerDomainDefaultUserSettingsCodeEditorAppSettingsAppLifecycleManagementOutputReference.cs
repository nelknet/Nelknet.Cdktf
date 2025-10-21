using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiClass(nativeType: typeof(aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementOutputReference), fullyQualifiedName: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdleSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings\"}}]")]
        public virtual void PutIdleSettings(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdleSettings")]
        public virtual void ResetIdleSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettingsOutputReference\"}")]
        public virtual aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettingsOutputReference IdleSettings
        {
            get => GetInstanceProperty<aws.SagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        public virtual aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement?>();
            set => SetInstanceProperty(value);
        }
    }
}
