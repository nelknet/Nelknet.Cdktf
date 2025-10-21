using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes")]
    public class GuarddutyOrganizationConfigurationDatasourcesKubernetes : aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes
    {
        /// <summary>audit_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#audit_logs GuarddutyOrganizationConfiguration#audit_logs}
        /// </remarks>
        [JsiiProperty(name: "auditLogs", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs\"}")]
        public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs AuditLogs
        {
            get;
            set;
        }
    }
}
