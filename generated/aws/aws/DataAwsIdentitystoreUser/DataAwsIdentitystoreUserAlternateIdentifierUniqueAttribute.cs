using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUser
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute")]
    public class DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute : aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#attribute_path DataAwsIdentitystoreUser#attribute_path}.</summary>
        [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#attribute_value DataAwsIdentitystoreUser#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeValue
        {
            get;
            set;
        }
    }
}
