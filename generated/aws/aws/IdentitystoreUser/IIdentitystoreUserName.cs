using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IdentitystoreUser
{
    [JsiiInterface(nativeType: typeof(IIdentitystoreUserName), fullyQualifiedName: "aws.identitystoreUser.IdentitystoreUserName")]
    public interface IIdentitystoreUserName
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#family_name IdentitystoreUser#family_name}.</summary>
        [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}")]
        string FamilyName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#given_name IdentitystoreUser#given_name}.</summary>
        [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
        string GivenName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#formatted IdentitystoreUser#formatted}.</summary>
        [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Formatted
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#honorific_prefix IdentitystoreUser#honorific_prefix}.</summary>
        [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HonorificPrefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#honorific_suffix IdentitystoreUser#honorific_suffix}.</summary>
        [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? HonorificSuffix
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#middle_name IdentitystoreUser#middle_name}.</summary>
        [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MiddleName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIdentitystoreUserName), fullyQualifiedName: "aws.identitystoreUser.IdentitystoreUserName")]
        internal sealed class _Proxy : DeputyBase, aws.IdentitystoreUser.IIdentitystoreUserName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#family_name IdentitystoreUser#family_name}.</summary>
            [JsiiProperty(name: "familyName", typeJson: "{\"primitive\":\"string\"}")]
            public string FamilyName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#given_name IdentitystoreUser#given_name}.</summary>
            [JsiiProperty(name: "givenName", typeJson: "{\"primitive\":\"string\"}")]
            public string GivenName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#formatted IdentitystoreUser#formatted}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "formatted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Formatted
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#honorific_prefix IdentitystoreUser#honorific_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "honorificPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HonorificPrefix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#honorific_suffix IdentitystoreUser#honorific_suffix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "honorificSuffix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? HonorificSuffix
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/identitystore_user#middle_name IdentitystoreUser#middle_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "middleName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MiddleName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
