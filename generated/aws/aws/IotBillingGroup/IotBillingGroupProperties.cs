using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotBillingGroup
{
    [JsiiByValue(fqn: "aws.iotBillingGroup.IotBillingGroupProperties")]
    public class IotBillingGroupProperties : aws.IotBillingGroup.IIotBillingGroupProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_billing_group#description IotBillingGroup#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
