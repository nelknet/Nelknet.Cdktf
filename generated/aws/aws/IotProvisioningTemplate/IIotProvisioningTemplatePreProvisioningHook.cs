using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotProvisioningTemplate
{
    [JsiiInterface(nativeType: typeof(IIotProvisioningTemplatePreProvisioningHook), fullyQualifiedName: "aws.iotProvisioningTemplate.IotProvisioningTemplatePreProvisioningHook")]
    public interface IIotProvisioningTemplatePreProvisioningHook
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#target_arn IotProvisioningTemplate#target_arn}.</summary>
        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        string TargetArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#payload_version IotProvisioningTemplate#payload_version}.</summary>
        [JsiiProperty(name: "payloadVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PayloadVersion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotProvisioningTemplatePreProvisioningHook), fullyQualifiedName: "aws.iotProvisioningTemplate.IotProvisioningTemplatePreProvisioningHook")]
        internal sealed class _Proxy : DeputyBase, aws.IotProvisioningTemplate.IIotProvisioningTemplatePreProvisioningHook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#target_arn IotProvisioningTemplate#target_arn}.</summary>
            [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string TargetArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_provisioning_template#payload_version IotProvisioningTemplate#payload_version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "payloadVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PayloadVersion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
