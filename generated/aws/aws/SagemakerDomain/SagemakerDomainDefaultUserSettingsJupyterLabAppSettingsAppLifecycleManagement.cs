using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement")]
    public class SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagement
    {
        /// <summary>idle_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#idle_settings SagemakerDomain#idle_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "idleSettings", typeJson: "{\"fqn\":\"aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings\"}", isOptional: true)]
        public aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings? IdleSettings
        {
            get;
            set;
        }
    }
}
