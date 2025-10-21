using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontFieldLevelEncryptionConfig
{
    [JsiiInterface(nativeType: typeof(ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems), fullyQualifiedName: "aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems")]
    public interface ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#profile_id CloudfrontFieldLevelEncryptionConfig#profile_id}.</summary>
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}")]
        string ProfileId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#query_arg CloudfrontFieldLevelEncryptionConfig#query_arg}.</summary>
        [JsiiProperty(name: "queryArg", typeJson: "{\"primitive\":\"string\"}")]
        string QueryArg
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems), fullyQualifiedName: "aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#profile_id CloudfrontFieldLevelEncryptionConfig#profile_id}.</summary>
            [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProfileId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#query_arg CloudfrontFieldLevelEncryptionConfig#query_arg}.</summary>
            [JsiiProperty(name: "queryArg", typeJson: "{\"primitive\":\"string\"}")]
            public string QueryArg
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
