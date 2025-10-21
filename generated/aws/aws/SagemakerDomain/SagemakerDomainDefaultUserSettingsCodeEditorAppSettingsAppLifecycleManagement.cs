using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement")]
    public class SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagement
    {
        /// <summary>idle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#idle_settings SagemakerDomain#idle_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsCodeEditorAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
        {
            get;
            set;
        }
    }
}
