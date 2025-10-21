using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraExperience
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraExperience.KendraExperienceConfigurationUserIdentityConfiguration")]
    public class KendraExperienceConfigurationUserIdentityConfiguration : aws.KendraExperience.IKendraExperienceConfigurationUserIdentityConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#identity_attribute_name KendraExperience#identity_attribute_name}.</summary>
        [JsiiProperty(name: "identityAttributeName", typeJson: "{\"primitive\":\"string\"}")]
        public string IdentityAttributeName
        {
            get;
            set;
        }
    }
}
