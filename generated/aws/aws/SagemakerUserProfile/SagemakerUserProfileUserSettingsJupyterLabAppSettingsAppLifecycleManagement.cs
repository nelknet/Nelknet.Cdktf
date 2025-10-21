using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiByValue(fqn: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement")]
    public class SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement : aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement
    {
        /// <summary>idle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_user_profile#idle_settings SagemakerUserProfile#idle_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        public aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
        {
            get;
            set;
        }
    }
}
