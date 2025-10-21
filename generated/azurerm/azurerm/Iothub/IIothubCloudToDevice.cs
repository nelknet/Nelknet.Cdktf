using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    [JsiiInterface(nativeType: typeof(IIothubCloudToDevice), fullyQualifiedName: "azurerm.iothub.IothubCloudToDevice")]
    public interface IIothubCloudToDevice
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#default_ttl Iothub#default_ttl}.</summary>
        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DefaultTtl
        {
            get
            {
                return null;
            }
        }

        /// <summary>feedback block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#feedback Iothub#feedback}
        /// </remarks>
        [JsiiProperty(name: "feedback", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubCloudToDeviceFeedback\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Feedback
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

        [JsiiTypeProxy(nativeType: typeof(IIothubCloudToDevice), fullyQualifiedName: "azurerm.iothub.IothubCloudToDevice")]
        internal sealed class _Proxy : DeputyBase, azurerm.Iothub.IIothubCloudToDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#default_ttl Iothub#default_ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DefaultTtl
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>feedback block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#feedback Iothub#feedback}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "feedback", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubCloudToDeviceFeedback\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Feedback
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub#max_delivery_count Iothub#max_delivery_count}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxDeliveryCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxDeliveryCount
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
