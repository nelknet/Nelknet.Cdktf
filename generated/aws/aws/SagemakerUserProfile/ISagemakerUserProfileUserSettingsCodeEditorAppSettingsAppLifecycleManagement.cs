using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagement), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagement")]
    public interface ISagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagement
    {
        /// <summary>idle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#idle_settings SagemakerUserProfile#idle_settings}
        /// </remarks>
        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagement), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagement")]
        internal sealed class _Proxy : DeputyBase, aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#idle_settings SagemakerUserProfile#idle_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
            public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
            {
                get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings?>();
            }
        }
    }
}
