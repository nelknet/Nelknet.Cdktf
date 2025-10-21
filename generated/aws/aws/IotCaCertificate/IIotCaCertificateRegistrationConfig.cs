using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotCaCertificate
{
    [JsiiInterface(nativeType: typeof(IIotCaCertificateRegistrationConfig), fullyQualifiedName: "aws.iotCaCertificate.IotCaCertificateRegistrationConfig")]
    public interface IIotCaCertificateRegistrationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#role_arn IotCaCertificate#role_arn}.</summary>
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RoleArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#template_body IotCaCertificate#template_body}.</summary>
        [JsiiProperty(name: "templateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemplateBody
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#template_name IotCaCertificate#template_name}.</summary>
        [JsiiProperty(name: "templateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TemplateName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotCaCertificateRegistrationConfig), fullyQualifiedName: "aws.iotCaCertificate.IotCaCertificateRegistrationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.IotCaCertificate.IIotCaCertificateRegistrationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#role_arn IotCaCertificate#role_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RoleArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#template_body IotCaCertificate#template_body}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "templateBody", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemplateBody
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_ca_certificate#template_name IotCaCertificate#template_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "templateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TemplateName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
