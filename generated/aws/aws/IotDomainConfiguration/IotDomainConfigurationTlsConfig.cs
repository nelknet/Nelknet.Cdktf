using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotDomainConfiguration
{
    [JsiiByValue(fqn: "aws.iotDomainConfiguration.IotDomainConfigurationTlsConfig")]
    public class IotDomainConfigurationTlsConfig : aws.IotDomainConfiguration.IIotDomainConfigurationTlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_domain_configuration#security_policy IotDomainConfiguration#security_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecurityPolicy
        {
            get;
            set;
        }
    }
}
