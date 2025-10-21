using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GuarddutyOrganizationConfigurationFeature
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guarddutyOrganizationConfigurationFeature.GuarddutyOrganizationConfigurationFeatureAdditionalConfiguration")]
    public class GuarddutyOrganizationConfigurationFeatureAdditionalConfiguration : aws.GuarddutyOrganizationConfigurationFeature.IGuarddutyOrganizationConfigurationFeatureAdditionalConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature#auto_enable GuarddutyOrganizationConfigurationFeature#auto_enable}.</summary>
        [JsiiProperty(name: "autoEnable", typeJson: "{\"primitive\":\"string\"}")]
        public string AutoEnable
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_configuration_feature#name GuarddutyOrganizationConfigurationFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
