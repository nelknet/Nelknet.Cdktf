using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PaymentcryptographyKey
{
    [JsiiClass(nativeType: typeof(aws.PaymentcryptographyKey.PaymentcryptographyKeyKeyAttributesOutputReference), fullyQualifiedName: "aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class PaymentcryptographyKeyKeyAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public PaymentcryptographyKeyKeyAttributesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected PaymentcryptographyKeyKeyAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected PaymentcryptographyKeyKeyAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putKeyModesOfUse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUse\"}}]")]
        public virtual void PutKeyModesOfUse(aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetKeyModesOfUse")]
        public virtual void ResetKeyModesOfUse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "keyModesOfUse", typeJson: "{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUseOutputReference\"}")]
        public virtual aws.PaymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUseOutputReference KeyModesOfUse
        {
            get => GetInstanceProperty<aws.PaymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyAlgorithmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyAlgorithmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyClassInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyClassInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyModesOfUseInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUse\"}]}}", isOptional: true)]
        public virtual object? KeyModesOfUseInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyUsageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyUsageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyAlgorithm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyClass", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyClass
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyUsage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyUsage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributes\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributes cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributes).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
