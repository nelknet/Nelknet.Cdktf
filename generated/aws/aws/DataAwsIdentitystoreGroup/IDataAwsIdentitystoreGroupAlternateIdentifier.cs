using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreGroup
{
    [JsiiInterface(nativeType: typeof(IDataAwsIdentitystoreGroupAlternateIdentifier), fullyQualifiedName: "aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifier")]
    public interface IDataAwsIdentitystoreGroupAlternateIdentifier
    {
        /// <summary>external_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#external_id DataAwsIdentitystoreGroup#external_id}
        /// </remarks>
        [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalId\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId? ExternalId
        {
            get
            {
                return null;
            }
        }

        /// <summary>unique_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#unique_attribute DataAwsIdentitystoreGroup#unique_attribute}
        /// </remarks>
        [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute? UniqueAttribute
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsIdentitystoreGroupAlternateIdentifier), fullyQualifiedName: "aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifier")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>external_id block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#external_id DataAwsIdentitystoreGroup#external_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalId\"}", isOptional: true)]
            public aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId? ExternalId
            {
                get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId?>();
            }

            /// <summary>unique_attribute block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#unique_attribute DataAwsIdentitystoreGroup#unique_attribute}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
            public aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute? UniqueAttribute
            {
                get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute?>();
            }
        }
    }
}
