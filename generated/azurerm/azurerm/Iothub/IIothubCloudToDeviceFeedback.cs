using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    [JsiiInterface(nativeType: typeof(IIothubCloudToDeviceFeedback), fullyQualifiedName: "azurerm.iothub.IothubCloudToDeviceFeedback")]
    public interface IIothubCloudToDeviceFeedback
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#lock_duration Iothub#lock_duration}.</summary>
        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LockDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#max_delivery_count Iothub#max_delivery_count}.</summary>
        [JsiiProperty(name: "maxDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxDeliveryCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#time_to_live Iothub#time_to_live}.</summary>
        [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeToLive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIothubCloudToDeviceFeedback), fullyQualifiedName: "azurerm.iothub.IothubCloudToDeviceFeedback")]
        internal sealed class _Proxy : DeputyBase, azurerm.Iothub.IIothubCloudToDeviceFeedback
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#lock_duration Iothub#lock_duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LockDuration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#max_delivery_count Iothub#max_delivery_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDeliveryCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#time_to_live Iothub#time_to_live}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeToLive
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
