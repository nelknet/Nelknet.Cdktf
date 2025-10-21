using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesConfigurationSet
{
    [JsiiByValue(fqn: "aws.sesConfigurationSet.SesConfigurationSetTrackingOptions")]
    public class SesConfigurationSetTrackingOptions : aws.SesConfigurationSet.ISesConfigurationSetTrackingOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#custom_redirect_domain SesConfigurationSet#custom_redirect_domain}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customRedirectDomain", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CustomRedirectDomain
        {
            get;
            set;
        }
    }
}
