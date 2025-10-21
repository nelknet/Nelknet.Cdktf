using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontFieldLevelEncryptionProfile
{
    [JsiiInterface(nativeType: typeof(ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems), fullyQualifiedName: "aws.cloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems")]
    public interface ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems
    {
        /// <summary>field_patterns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#field_patterns CloudfrontFieldLevelEncryptionProfile#field_patterns}
        /// </remarks>
        [JsiiProperty(name: "fieldPatterns", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns\"}")]
        aws.CloudfrontFieldLevelEncryptionProfile.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns FieldPatterns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#provider_id CloudfrontFieldLevelEncryptionProfile#provider_id}.</summary>
        [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#public_key_id CloudfrontFieldLevelEncryptionProfile#public_key_id}.</summary>
        [JsiiProperty(name: "publicKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string PublicKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems), fullyQualifiedName: "aws.cloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontFieldLevelEncryptionProfile.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_patterns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#field_patterns CloudfrontFieldLevelEncryptionProfile#field_patterns}
            /// </remarks>
            [JsiiProperty(name: "fieldPatterns", typeJson: "{\"fqn\":\"aws.cloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns\"}")]
            public aws.CloudfrontFieldLevelEncryptionProfile.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns FieldPatterns
            {
                get => GetInstanceProperty<aws.CloudfrontFieldLevelEncryptionProfile.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#provider_id CloudfrontFieldLevelEncryptionProfile#provider_id}.</summary>
            [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#public_key_id CloudfrontFieldLevelEncryptionProfile#public_key_id}.</summary>
            [JsiiProperty(name: "publicKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
