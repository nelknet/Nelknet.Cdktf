using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfiguration
{
    [JsiiInterface(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs")]
    public interface IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#enable GuarddutyOrganizationConfiguration#enable}.</summary>
        [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object Enable
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs), fullyQualifiedName: "aws.guarddutyOrganizationConfiguration.GuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs")]
        internal sealed class _Proxy : DeputyBase, aws.GuarddutyOrganizationConfiguration.IGuarddutyOrganizationConfigurationDatasourcesKubernetesAuditLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration#enable GuarddutyOrganizationConfiguration#enable}.</summary>
            [JsiiProperty(name: "enable", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object Enable
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
