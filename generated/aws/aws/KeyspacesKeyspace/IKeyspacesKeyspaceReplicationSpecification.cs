using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesKeyspace
{
    [JsiiInterface(nativeType: typeof(IKeyspacesKeyspaceReplicationSpecification), fullyQualifiedName: "aws.keyspacesKeyspace.KeyspacesKeyspaceReplicationSpecification")]
    public interface IKeyspacesKeyspaceReplicationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#region_list KeyspacesKeyspace#region_list}.</summary>
        [JsiiProperty(name: "regionList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RegionList
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#replication_strategy KeyspacesKeyspace#replication_strategy}.</summary>
        [JsiiProperty(name: "replicationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReplicationStrategy
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyspacesKeyspaceReplicationSpecification), fullyQualifiedName: "aws.keyspacesKeyspace.KeyspacesKeyspaceReplicationSpecification")]
        internal sealed class _Proxy : DeputyBase, aws.KeyspacesKeyspace.IKeyspacesKeyspaceReplicationSpecification
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#region_list KeyspacesKeyspace#region_list}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "regionList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RegionList
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#replication_strategy KeyspacesKeyspace#replication_strategy}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "replicationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReplicationStrategy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
