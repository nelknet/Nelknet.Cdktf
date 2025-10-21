using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontFieldLevelEncryptionConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontFieldLevelEncryptionConfig.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems")]
    public class CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems : aws.CloudfrontFieldLevelEncryptionConfig.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#profile_id CloudfrontFieldLevelEncryptionConfig#profile_id}.</summary>
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}")]
        public string ProfileId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_config#query_arg CloudfrontFieldLevelEncryptionConfig#query_arg}.</summary>
        [JsiiProperty(name: "queryArg", typeJson: "{\"primitive\":\"string\"}")]
        public string QueryArg
        {
            get;
            set;
        }
    }
}
