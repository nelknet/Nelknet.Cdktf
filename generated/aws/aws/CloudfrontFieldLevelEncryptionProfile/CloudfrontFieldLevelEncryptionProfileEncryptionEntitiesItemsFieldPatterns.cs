using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontFieldLevelEncryptionProfile
{
    [JsiiByValue(fqn: "aws.cloudfrontFieldLevelEncryptionProfile.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns")]
    public class CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns : aws.CloudfrontFieldLevelEncryptionProfile.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_field_level_encryption_profile#items CloudfrontFieldLevelEncryptionProfile#items}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Items
        {
            get;
            set;
        }
    }
}
