using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfiguration
{
    [JsiiInterface(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasourcesKubernetes), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes")]
    public interface IGuarddutyOrganizationConfigurationDatasourcesKubernetes
    {
        /// <summary>audit_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#audit_logs GuarddutyOrganizationConfiguration#audit_logs}
        /// </remarks>
        [JsiiProperty(name: "auditLogs", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs\"}")]
        aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs AuditLogs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasourcesKubernetes), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audit_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#audit_logs GuarddutyOrganizationConfiguration#audit_logs}
            /// </remarks>
            [JsiiProperty(name: "auditLogs", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs\"}")]
            public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs AuditLogs
            {
                get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs>()!;
            }
        }
    }
}
