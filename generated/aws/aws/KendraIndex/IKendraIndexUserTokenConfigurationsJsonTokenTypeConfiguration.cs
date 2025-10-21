using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiInterface(nativeType: typeof(IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration")]
    public interface IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#group_attribute_field KendraIndex#group_attribute_field}.</summary>
        [JsiiProperty(name: "groupAttributeField", typeJson: "{\"primitive\":\"string\"}")]
        string GroupAttributeField
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_name_attribute_field KendraIndex#user_name_attribute_field}.</summary>
        [JsiiProperty(name: "userNameAttributeField", typeJson: "{\"primitive\":\"string\"}")]
        string UserNameAttributeField
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration), fullyQualifiedName: "aws.kendraIndex.KendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraIndex.IKendraIndexUserTokenConfigurationsJsonTokenTypeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#group_attribute_field KendraIndex#group_attribute_field}.</summary>
            [JsiiProperty(name: "groupAttributeField", typeJson: "{\"primitive\":\"string\"}")]
            public string GroupAttributeField
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_index#user_name_attribute_field KendraIndex#user_name_attribute_field}.</summary>
            [JsiiProperty(name: "userNameAttributeField", typeJson: "{\"primitive\":\"string\"}")]
            public string UserNameAttributeField
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
