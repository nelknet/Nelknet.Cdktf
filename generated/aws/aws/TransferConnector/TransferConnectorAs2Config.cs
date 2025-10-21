using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TransferConnector
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.transferConnector.TransferConnectorAs2Config")]
    public class TransferConnectorAs2Config : aws.TransferConnector.ITransferConnectorAs2Config
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#compression TransferConnector#compression}.</summary>
        [JsiiProperty(name: "compression", typeJson: "{\"primitive\":\"string\"}")]
        public string Compression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#encryption_algorithm TransferConnector#encryption_algorithm}.</summary>
        [JsiiProperty(name: "encryptionAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string EncryptionAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#local_profile_id TransferConnector#local_profile_id}.</summary>
        [JsiiProperty(name: "localProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public string LocalProfileId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#mdn_response TransferConnector#mdn_response}.</summary>
        [JsiiProperty(name: "mdnResponse", typeJson: "{\"primitive\":\"string\"}")]
        public string MdnResponse
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#partner_profile_id TransferConnector#partner_profile_id}.</summary>
        [JsiiProperty(name: "partnerProfileId", typeJson: "{\"primitive\":\"string\"}")]
        public string PartnerProfileId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#signing_algorithm TransferConnector#signing_algorithm}.</summary>
        [JsiiProperty(name: "signingAlgorithm", typeJson: "{\"primitive\":\"string\"}")]
        public string SigningAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#mdn_signing_algorithm TransferConnector#mdn_signing_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mdnSigningAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MdnSigningAlgorithm
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/transfer_connector#message_subject TransferConnector#message_subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "messageSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageSubject
        {
            get;
            set;
        }
    }
}
