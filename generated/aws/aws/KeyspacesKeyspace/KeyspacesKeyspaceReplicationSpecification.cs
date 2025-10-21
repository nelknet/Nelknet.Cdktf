using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesKeyspace
{
    [JsiiByValue(fqn: "aws.keyspacesKeyspace.KeyspacesKeyspaceReplicationSpecification")]
    public class KeyspacesKeyspaceReplicationSpecification : aws.KeyspacesKeyspace.IKeyspacesKeyspaceReplicationSpecification
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#region_list KeyspacesKeyspace#region_list}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "regionList", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? RegionList
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_keyspace#replication_strategy KeyspacesKeyspace#replication_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "replicationStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReplicationStrategy
        {
            get;
            set;
        }
    }
}
