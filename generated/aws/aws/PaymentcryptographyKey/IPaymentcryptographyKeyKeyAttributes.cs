using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PaymentcryptographyKey
{
    [JsiiInterface(nativeType: typeof(IPaymentcryptographyKeyKeyAttributes), fullyQualifiedName: "aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributes")]
    public interface IPaymentcryptographyKeyKeyAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_algorithm PaymentcryptographyKey#key_algorithm}.</summary>
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        string KeyAlgorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_class PaymentcryptographyKey#key_class}.</summary>
        [JsiiProperty(name: "keyClass", typeJson: "{\"primitive\":\"string\"}")]
        string KeyClass
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_usage PaymentcryptographyKey#key_usage}.</summary>
        [JsiiProperty(name: "keyUsage", typeJson: "{\"primitive\":\"string\"}")]
        string KeyUsage
        {
            get;
        }

        /// <summary>key_modes_of_use block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_modes_of_use PaymentcryptographyKey#key_modes_of_use}
        /// </remarks>
        [JsiiProperty(name: "keyModesOfUse", typeJson: "{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse? KeyModesOfUse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IPaymentcryptographyKeyKeyAttributes), fullyQualifiedName: "aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_algorithm PaymentcryptographyKey#key_algorithm}.</summary>
            [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyAlgorithm
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_class PaymentcryptographyKey#key_class}.</summary>
            [JsiiProperty(name: "keyClass", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyClass
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_usage PaymentcryptographyKey#key_usage}.</summary>
            [JsiiProperty(name: "keyUsage", typeJson: "{\"primitive\":\"string\"}")]
            public string KeyUsage
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>key_modes_of_use block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_modes_of_use PaymentcryptographyKey#key_modes_of_use}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "keyModesOfUse", typeJson: "{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUse\"}", isOptional: true)]
            public aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse? KeyModesOfUse
            {
                get => GetInstanceProperty<aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse?>();
            }
        }
    }
}
