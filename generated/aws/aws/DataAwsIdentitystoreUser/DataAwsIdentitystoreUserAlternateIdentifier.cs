using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreUser
{
    [JsiiByValue(fqn: "aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifier")]
    public class DataAwsIdentitystoreUserAlternateIdentifier : aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifier
    {
        /// <summary>external_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#external_id DataAwsIdentitystoreUser#external_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierExternalId\"}", isOptional: true)]
        public aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierExternalId? ExternalId
        {
            get;
            set;
        }

        /// <summary>unique_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_user#unique_attribute DataAwsIdentitystoreUser#unique_attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreUser.DataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
        public aws.DataAwsIdentitystoreUser.IDataAwsIdentitystoreUserAlternateIdentifierUniqueAttribute? UniqueAttribute
        {
            get;
            set;
        }
    }
}
