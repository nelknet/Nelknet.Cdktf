using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUser
{
    [JsiiInterface(nativeType: typeof(IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute), fullyQualifiedName: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute")]
    public interface IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#attribute_path DataAwsIdentitystoreUser#attribute_path}.</summary>
        [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
        string AttributePath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#attribute_value DataAwsIdentitystoreUser#attribute_value}.</summary>
        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        string AttributeValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute), fullyQualifiedName: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#attribute_path DataAwsIdentitystoreUser#attribute_path}.</summary>
            [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#attribute_value DataAwsIdentitystoreUser#attribute_value}.</summary>
            [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
            public string AttributeValue
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
