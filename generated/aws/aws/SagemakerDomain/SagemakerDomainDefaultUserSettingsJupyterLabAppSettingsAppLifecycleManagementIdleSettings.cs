using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerDomain
{
    [JsiiByValue(fqn: "aws.sagemakerDomain.SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings")]
    public class SagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings : aws.SagemakerDomain.ISagemakerDomainDefaultUserSettingsJupyterLabAppSettingsAppLifecycleManagementIdleSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#idle_timeout_in_minutes SagemakerDomain#idle_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "idleTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? IdleTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#lifecycle_management SagemakerDomain#lifecycle_management}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycleManagement", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LifecycleManagement
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#max_idle_timeout_in_minutes SagemakerDomain#max_idle_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxIdleTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxIdleTimeoutInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_domain#min_idle_timeout_in_minutes SagemakerDomain#min_idle_timeout_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minIdleTimeoutInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinIdleTimeoutInMinutes
        {
            get;
            set;
        }
    }
}
