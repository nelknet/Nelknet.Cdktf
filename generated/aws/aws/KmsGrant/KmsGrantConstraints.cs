using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KmsGrant
{
    [JsiiByValue(fqn: "aws.kmsGrant.KmsGrantConstraints")]
    public class KmsGrantConstraints : aws.KmsGrant.IKmsGrantConstraints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#encryption_context_equals KmsGrant#encryption_context_equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionContextEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EncryptionContextEquals
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kms_grant#encryption_context_subset KmsGrant#encryption_context_subset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionContextSubset", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? EncryptionContextSubset
        {
            get;
            set;
        }
    }
}
