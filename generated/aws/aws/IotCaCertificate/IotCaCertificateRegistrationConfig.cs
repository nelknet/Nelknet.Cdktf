using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotCaCertificate
{
    [JsiiByValue(fqn: "aws.iotCaCertificate.IotCaCertificateRegistrationConfig")]
    public class IotCaCertificateRegistrationConfig : aws.IotCaCertificate.IIotCaCertificateRegistrationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#role_arn IotCaCertificate#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#template_body IotCaCertificate#template_body}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateBody
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#template_name IotCaCertificate#template_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "templateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TemplateName
        {
            get;
            set;
        }
    }
}
