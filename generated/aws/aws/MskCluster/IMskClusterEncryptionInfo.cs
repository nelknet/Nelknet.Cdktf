using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskCluster
{
    [JsiiInterface(nativeType: typeof(IMskClusterEncryptionInfo), fullyQualifiedName: "aws.mskCluster.MskClusterEncryptionInfo")]
    public interface IMskClusterEncryptionInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#encryption_at_rest_kms_key_arn MskCluster#encryption_at_rest_kms_key_arn}.</summary>
        [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EncryptionAtRestKmsKeyArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>encryption_in_transit block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#encryption_in_transit MskCluster#encryption_in_transit}
        /// </remarks>
        [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit? EncryptionInTransit
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterEncryptionInfo), fullyQualifiedName: "aws.mskCluster.MskClusterEncryptionInfo")]
        internal sealed class _Proxy : DeputyBase, aws.MskCluster.IMskClusterEncryptionInfo
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#encryption_at_rest_kms_key_arn MskCluster#encryption_at_rest_kms_key_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionAtRestKmsKeyArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EncryptionAtRestKmsKeyArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>encryption_in_transit block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/msk_cluster#encryption_in_transit MskCluster#encryption_in_transit}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "encryptionInTransit", typeJson: "{\"fqn\":\"aws.mskCluster.MskClusterEncryptionInfoEncryptionInTransit\"}", isOptional: true)]
            public aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit? EncryptionInTransit
            {
                get => GetInstanceProperty<aws.MskCluster.IMskClusterEncryptionInfoEncryptionInTransit?>();
            }
        }
    }
}
