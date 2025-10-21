using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiInterface(nativeType: typeof(IKeyspacesTableEncryptionSpecification), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableEncryptionSpecification")]
    public interface IKeyspacesTableEncryptionSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#kms_key_identifier KeyspacesTable#kms_key_identifier}.</summary>
        [JsiiProperty(name: "kmsKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyIdentifier
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#type KeyspacesTable#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyspacesTableEncryptionSpecification), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableEncryptionSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.KeyspacesTable.IKeyspacesTableEncryptionSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#kms_key_identifier KeyspacesTable#kms_key_identifier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyIdentifier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#type KeyspacesTable#type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
