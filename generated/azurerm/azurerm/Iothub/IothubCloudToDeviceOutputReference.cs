using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.Iothub
{
    [JsiiClass(nativeType: typeof(azurerm.Iothub.IothubCloudToDeviceOutputReference), fullyQualifiedName: "azurerm.iothub.IothubCloudToDeviceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IothubCloudToDeviceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IothubCloudToDeviceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IothubCloudToDeviceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IothubCloudToDeviceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFeedback", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubCloudToDeviceFeedback\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutFeedback(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.Iothub.IIothubCloudToDeviceFeedback[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubCloudToDeviceFeedback).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.Iothub.IIothubCloudToDeviceFeedback).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultTtl")]
        public virtual void ResetDefaultTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFeedback")]
        public virtual void ResetFeedback()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaxDeliveryCount")]
        public virtual void ResetMaxDeliveryCount()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "feedback", typeJson: "{\"fqn\":\"azurerm.iothub.IothubCloudToDeviceFeedbackList\"}")]
        public virtual azurerm.Iothub.IothubCloudToDeviceFeedbackList Feedback
        {
            get => GetInstanceProperty<azurerm.Iothub.IothubCloudToDeviceFeedbackList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultTtlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultTtlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "feedbackInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.iothub.IothubCloudToDeviceFeedback\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? FeedbackInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxDeliveryCountInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxDeliveryCountInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "defaultTtl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultTtl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "maxDeliveryCount", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxDeliveryCount
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.iothub.IothubCloudToDevice\"}", isOptional: true)]
        public virtual azurerm.Iothub.IIothubCloudToDevice? InternalValue
        {
            get => GetInstanceProperty<azurerm.Iothub.IIothubCloudToDevice?>();
            set => SetInstanceProperty(value);
        }
    }
}
