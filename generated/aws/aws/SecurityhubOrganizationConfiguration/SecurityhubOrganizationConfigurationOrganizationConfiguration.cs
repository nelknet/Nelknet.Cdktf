using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecurityhubOrganizationConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securityhubOrganizationConfiguration.SecurityhubOrganizationConfigurationOrganizationConfiguration")]
    public class SecurityhubOrganizationConfigurationOrganizationConfiguration : aws.SecurityhubOrganizationConfiguration.ISecurityhubOrganizationConfigurationOrganizationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_configuration#configuration_type SecurityhubOrganizationConfiguration#configuration_type}.</summary>
        [JsiiProperty(name: "configurationType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConfigurationType
        {
            get;
            set;
        }
    }
}
