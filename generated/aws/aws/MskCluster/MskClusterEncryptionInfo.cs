using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiByValue(fqn: "aws.mskCluster.MskClusterEncryptionInfo")]
    public class MskClusterEncryptionInfo : aws.MskCluster.IMskClusterEncryptionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#encryption_at_rest_kms_key_arn MskCluster#encryption_at_rest_kms_key_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EncryptionAtRestKmsKeyArn
        {
            get;
            set;
        }

        /// <summary>encryption_in_transit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#encryption_in_transit MskCluster#encryption_in_transit}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
        public aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit? EncryptionInTransit
        {
            get;
            set;
        }
    }
}
