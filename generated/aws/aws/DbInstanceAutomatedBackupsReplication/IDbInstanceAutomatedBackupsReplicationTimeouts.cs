using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DbInstanceAutomatedBackupsReplication
{
    [JsiiInterface(nativeType: typeof(IDbInstanceAutomatedBackupsReplicationTimeouts), fullyQualifiedName: "aws.dbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplicationTimeouts")]
    public interface IDbInstanceAutomatedBackupsReplicationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#create DbInstanceAutomatedBackupsReplication#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#delete DbInstanceAutomatedBackupsReplication#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDbInstanceAutomatedBackupsReplicationTimeouts), fullyQualifiedName: "aws.dbInstanceAutomatedBackupsReplication.DbInstanceAutomatedBackupsReplicationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DbInstanceAutomatedBackupsReplication.IDbInstanceAutomatedBackupsReplicationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#create DbInstanceAutomatedBackupsReplication#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/db_instance_automated_backups_replication#delete DbInstanceAutomatedBackupsReplication#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
