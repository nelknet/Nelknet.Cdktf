using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotBillingGroup
{
    [JsiiInterface(nativeType: typeof(IIotBillingGroupProperties), fullyQualifiedName: "aws.iotBillingGroup.IotBillingGroupProperties")]
    public interface IIotBillingGroupProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_billing_group#description IotBillingGroup#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotBillingGroupProperties), fullyQualifiedName: "aws.iotBillingGroup.IotBillingGroupProperties")]
        internal sealed class _Proxy : DeputyBase, aws.IotBillingGroup.IIotBillingGroupProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_billing_group#description IotBillingGroup#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
