using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubOrganizationConfiguration
{
    [JsiiInterface(nativeType: typeof(ISecurityhubOrganizationConfigurationOrganizationConfiguration), fullyQualifiedName: "aws.securityhubOrganizationConfiguration.SecurityhubOrganizationConfigurationOrganizationConfiguration")]
    public interface ISecurityhubOrganizationConfigurationOrganizationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#configuration_type SecurityhubOrganizationConfiguration#configuration_type}.</summary>
        [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
        string ConfigurationType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISecurityhubOrganizationConfigurationOrganizationConfiguration), fullyQualifiedName: "aws.securityhubOrganizationConfiguration.SecurityhubOrganizationConfigurationOrganizationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.SecurityhubOrganizationConfiguration.ISecurityhubOrganizationConfigurationOrganizationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#configuration_type SecurityhubOrganizationConfiguration#configuration_type}.</summary>
            [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConfigurationType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
