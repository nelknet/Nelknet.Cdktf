using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration")]
    public class KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration : aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#group_attribute_field KendraIndex#group_attribute_field}.</summary>
        [JsiiProperty(name: "groupAttributeField", typeJson: "{\"primitive\":\"string\"}")]
        public string GroupAttributeField
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_name_attribute_field KendraIndex#user_name_attribute_field}.</summary>
        [JsiiProperty(name: "userNameAttributeField", typeJson: "{\"primitive\":\"string\"}")]
        public string UserNameAttributeField
        {
            get;
            set;
        }
    }
}
