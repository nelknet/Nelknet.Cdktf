using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.launchTemplate.LaunchTemplateLicenseSpecification")]
    public class LaunchTemplateLicenseSpecification : aws.LaunchTemplate.ILaunchTemplateLicenseSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/launch_template#license_configuration_arn LaunchTemplate#license_configuration_arn}.</summary>
        [JsiiProperty(name: "licenseConfigurationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LicenseConfigurationArn
        {
            get;
            set;
        }
    }
}
