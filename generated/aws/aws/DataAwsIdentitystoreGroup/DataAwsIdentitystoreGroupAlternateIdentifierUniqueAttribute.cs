using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute")]
    public class DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute : aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#attribute_path DataAwsIdentitystoreGroup#attribute_path}.</summary>
        [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributePath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#attribute_value DataAwsIdentitystoreGroup#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        public string AttributeValue
        {
            get;
            set;
        }
    }
}
