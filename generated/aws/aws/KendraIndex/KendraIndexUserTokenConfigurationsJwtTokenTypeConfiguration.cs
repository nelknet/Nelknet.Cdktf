using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraIndex.KendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration")]
    public class KendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration : aws.KendraIndex.IKendraIndexUserTokenConfigurationsJwtTokenTypeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#key_location KendraIndex#key_location}.</summary>
        [JsiiProperty(name: "keyLocation", typeJson: "{\"primitive\":\"string\"}")]
        public string KeyLocation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#claim_regex KendraIndex#claim_regex}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "claimRegex", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ClaimRegex
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#group_attribute_field KendraIndex#group_attribute_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "groupAttributeField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? GroupAttributeField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#issuer KendraIndex#issuer}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#secrets_manager_arn KendraIndex#secrets_manager_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "secretsManagerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretsManagerArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#url KendraIndex#url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_name_attribute_field KendraIndex#user_name_attribute_field}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userNameAttributeField", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserNameAttributeField
        {
            get;
            set;
        }
    }
}
