using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2ConfigurationSet
{
    [JsiiByValue(fqn: "aws.sesv2ConfigurationSet.Sesv2ConfigurationSetDeliveryOptions")]
    public class Sesv2ConfigurationSetDeliveryOptions : aws.Sesv2ConfigurationSet.ISesv2ConfigurationSetDeliveryOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#max_delivery_seconds Sesv2ConfigurationSet#max_delivery_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDeliverySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDeliverySeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#sending_pool_name Sesv2ConfigurationSet#sending_pool_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sendingPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SendingPoolName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_configuration_set#tls_policy Sesv2ConfigurationSet#tls_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TlsPolicy
        {
            get;
            set;
        }
    }
}
