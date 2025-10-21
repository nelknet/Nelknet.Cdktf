using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiClass(nativeType: typeof(aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdleSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings\"}}]")]
        public virtual void PutIdleSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdleSettings")]
        public virtual void ResetIdleSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettingsOutputReference IdleSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement?>();
            set => SetInstanceProperty(value);
        }
    }
}
