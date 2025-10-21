using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    [JsiiByValue(fqn: "azurerm.iothub.IothubCloudToDevice")]
    public class IothubCloudToDevice : azurerm.Iothub.IIothubCloudToDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#default_ttl Iothub#default_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DefaultTtl
        {
            get;
            set;
        }

        private object? _feedback;

        /// <summary>feedback block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#feedback Iothub#feedback}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "feedback", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubCloudToDeviceFeedback\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Feedback
        {
            get => _feedback;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.Iothub.IIothubCloudToDeviceFeedback[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubCloudToDeviceFeedback).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _feedback = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#max_delivery_count Iothub#max_delivery_count}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxDeliveryCount
        {
            get;
            set;
        }
    }
}
