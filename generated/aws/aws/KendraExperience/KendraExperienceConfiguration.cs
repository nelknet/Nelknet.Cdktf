using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraExperience
{
    [JsiiByValue(fqn: "aws.kendraExperience.KendraExperienceConfiguration")]
    public class KendraExperienceConfiguration : aws.KendraExperience.IKendraExperienceConfiguration
    {
        /// <summary>content_source_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#content_source_configuration KendraExperience#content_source_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentSourceConfiguration", typeJson: "{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationContentSourceConfiguration\"}", isOptional: true)]
        public aws.KendraExperience.IKendraExperienceConfigurationContentSourceConfiguration? ContentSourceConfiguration
        {
            get;
            set;
        }

        /// <summary>user_identity_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#user_identity_configuration KendraExperience#user_identity_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userIdentityConfiguration", typeJson: "{\"fqn\":\"aws.kendraExperience.KendraExperienceConfigurationUserIdentityConfiguration\"}", isOptional: true)]
        public aws.KendraExperience.IKendraExperienceConfigurationUserIdentityConfiguration? UserIdentityConfiguration
        {
            get;
            set;
        }
    }
}
