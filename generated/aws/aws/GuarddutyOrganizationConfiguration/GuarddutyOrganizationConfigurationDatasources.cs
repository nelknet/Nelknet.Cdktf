using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfiguration
{
    [JsiiByValue(fqn: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasources")]
    public class GuarddutyOrganizationConfigurationDatasources : aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources
    {
        /// <summary>kubernetes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#kubernetes GuarddutyOrganizationConfiguration#kubernetes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes\"}", isOptional: true)]
        public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes? Kubernetes
        {
            get;
            set;
        }

        /// <summary>malware_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#malware_protection GuarddutyOrganizationConfiguration#malware_protection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtection\"}", isOptional: true)]
        public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection? MalwareProtection
        {
            get;
            set;
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#s3_logs GuarddutyOrganizationConfiguration#s3_logs}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true)]
        public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3Logs
        {
            get;
            set;
        }
    }
}
