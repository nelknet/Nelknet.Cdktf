using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.PaymentcryptographyKey
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributes")]
    public class PaymentcryptographyKeyKeyAttributes : aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_algorithm PaymentcryptographyKey#key_algorithm}.</summary>
        [JsiiProperty(name: "keyAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_class PaymentcryptographyKey#key_class}.</summary>
        [JsiiProperty(name: "keyClass", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyClass
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_usage PaymentcryptographyKey#key_usage}.</summary>
        [JsiiProperty(name: "keyUsage", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyUsage
        {
            get;
            set;
        }

        /// <summary>key_modes_of_use block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/paymentcryptography_key#key_modes_of_use PaymentcryptographyKey#key_modes_of_use}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "keyModesOfUse", typeJson: "{\"fqn\":\"aws.paymentcryptographyKey.PaymentcryptographyKeyKeyAttributesKeyModesOfUse\"}", isOptional: true)]
        public aws.PaymentcryptographyKey.IPaymentcryptographyKeyKeyAttributesKeyModesOfUse? KeyModesOfUse
        {
            get;
            set;
        }
    }
}
