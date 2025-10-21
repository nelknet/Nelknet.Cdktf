using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfiguration
{
    [JsiiInterface(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasources), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasources")]
    public interface IGuarddutyOrganizationConfigurationDatasources
    {
        /// <summary>kubernetes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#kubernetes GuarddutyOrganizationConfiguration#kubernetes}
        /// </remarks>
        [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes? Kubernetes
        {
            get
            {
                return null;
            }
        }

        /// <summary>malware_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#malware_protection GuarddutyOrganizationConfiguration#malware_protection}
        /// </remarks>
        [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection? MalwareProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#s3_logs GuarddutyOrganizationConfiguration#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3Logs
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasources), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasources")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>kubernetes block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#kubernetes GuarddutyOrganizationConfiguration#kubernetes}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kubernetes", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetes\"}", isOptional: true)]
            public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes? Kubernetes
            {
                get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetes?>();
            }

            /// <summary>malware_protection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#malware_protection GuarddutyOrganizationConfiguration#malware_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "malwareProtection", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesMalwareProtection\"}", isOptional: true)]
            public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection? MalwareProtection
            {
                get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesMalwareProtection?>();
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#s3_logs GuarddutyOrganizationConfiguration#s3_logs}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesS3Logs\"}", isOptional: true)]
            public aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs? S3Logs
            {
                get => GetInstanceProperty<aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesS3Logs?>();
            }
        }
    }
}
