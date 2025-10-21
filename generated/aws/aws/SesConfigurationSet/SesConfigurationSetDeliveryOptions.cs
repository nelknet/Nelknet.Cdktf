using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesConfigurationSet
{
    [JsiiByValue(fqn: "aws.sesConfigurationSet.SesConfigurationSetDeliveryOptions")]
    public class SesConfigurationSetDeliveryOptions : aws.SesConfigurationSet.ISesConfigurationSetDeliveryOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_configuration_set#tls_policy SesConfigurationSet#tls_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsPolicy
        {
            get;
            set;
        }
    }
}
