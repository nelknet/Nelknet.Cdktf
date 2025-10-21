using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreGroup
{
    [JsiiByValue(fqn: "aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifier")]
    public class DataAwsIdentitystoreGroupAlternateIdentifier : aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifier
    {
        /// <summary>external_id block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#external_id DataAwsIdentitystoreGroup#external_id}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierExternalId\"}", isOptional: true)]
        public aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierExternalId? ExternalId
        {
            get;
            set;
        }

        /// <summary>unique_attribute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/identitystore_group#unique_attribute DataAwsIdentitystoreGroup#unique_attribute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uniqueAttribute", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute\"}", isOptional: true)]
        public aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupAlternateIdentifierUniqueAttribute? UniqueAttribute
        {
            get;
            set;
        }
    }
}
