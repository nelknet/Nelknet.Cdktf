using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotProvisioningTemplate
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.iotProvisioningTemplate.IotProvisioningTemplatePreProvisioningHook")]
    public class IotProvisioningTemplatePreProvisioningHook : aws.IotProvisioningTemplate.IIotProvisioningTemplatePreProvisioningHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#target_arn IotProvisioningTemplate#target_arn}.</summary>
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#payload_version IotProvisioningTemplate#payload_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "payloadVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PayloadVersion
        {
            get;
            set;
        }
    }
}
