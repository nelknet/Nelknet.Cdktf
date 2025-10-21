using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiByValue(fqn: "aws.keyspacesTable.KeyspacesTableEncryptionSpecification")]
    public class KeyspacesTableEncryptionSpecification : aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#kms_key_identifier KeyspacesTable#kms_key_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KmsKeyIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#type KeyspacesTable#type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
