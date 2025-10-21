using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IdentitystoreUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.identitystoreUser.IdentitystoreUserName")]
    public class IdentitystoreUserName : aws.IdentitystoreUser.IIdentitystoreUserName
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#family_name IdentitystoreUser#family_name}.</summary>
        [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}")]
        public string FamilyName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#given_name IdentitystoreUser#given_name}.</summary>
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
        public string GivenName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#formatted IdentitystoreUser#formatted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Formatted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#honorific_prefix IdentitystoreUser#honorific_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HonorificPrefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#honorific_suffix IdentitystoreUser#honorific_suffix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HonorificSuffix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#middle_name IdentitystoreUser#middle_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MiddleName
        {
            get;
            set;
        }
    }
}
