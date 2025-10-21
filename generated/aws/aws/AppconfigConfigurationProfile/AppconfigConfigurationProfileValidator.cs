using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppconfigConfigurationProfile
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appconfigConfigurationProfile.AppconfigConfigurationProfileValidator")]
    public class AppconfigConfigurationProfileValidator : aws.AppconfigConfigurationProfile.IAppconfigConfigurationProfileValidator
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#type AppconfigConfigurationProfile#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appconfig_configuration_profile#content AppconfigConfigurationProfile#content}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "content", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Content
        {
            get;
            set;
        }
    }
}
