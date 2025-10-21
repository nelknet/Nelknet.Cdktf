using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUser
{
    [JsiiInterface(nativeType: typeof(IDataAwsIdentitystoreUserAlternateIdentifier), fullyQualifiedName: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifier")]
    public interface IDataAwsIdentitystoreUserAlternateIdentifier
    {
        /// <summary>external_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#external_id DataAwsIdentitystoreUser#external_id}
        /// </remarks>
        [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalId\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>unique_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#unique_attribute DataAwsIdentitystoreUser#unique_attribute}
        /// </remarks>
        [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute? UniqueAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIdentitystoreUserAlternateIdentifier), fullyQualifiedName: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifier")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>external_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#external_id DataAwsIdentitystoreUser#external_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalId\"}", isOptional: true)]
            public aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId? ExternalId
            {
                get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId?>();
            }

            /// <summary>unique_attribute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#unique_attribute DataAwsIdentitystoreUser#unique_attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
            public aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute? UniqueAttribute
            {
                get => GetInstanceProperty<aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute?>();
            }
        }
    }
}
