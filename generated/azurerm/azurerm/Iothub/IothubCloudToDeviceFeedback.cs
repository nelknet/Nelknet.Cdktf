using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    [JsiiByValue(fqn: "azurerm.iothub.IothubCloudToDeviceFeedback")]
    public class IothubCloudToDeviceFeedback : azurerm.Iothub.IIothubCloudToDeviceFeedback
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#lock_duration Iothub#lock_duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lockDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LockDuration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#max_delivery_count Iothub#max_delivery_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDeliveryCount
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#time_to_live Iothub#time_to_live}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TimeToLive
        {
            get;
            set;
        }
    }
}
