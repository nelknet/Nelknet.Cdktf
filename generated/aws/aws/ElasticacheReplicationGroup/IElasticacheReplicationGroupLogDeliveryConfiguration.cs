using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheReplicationGroup
{
    [JsiiInterface(nativeType: typeof(IElasticacheReplicationGroupLogDeliveryConfiguration), fullyQualifiedName: "aws.elasticacheReplicationGroup.ElasticacheReplicationGroupLogDeliveryConfiguration")]
    public interface IElasticacheReplicationGroupLogDeliveryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#destination ElasticacheReplicationGroup#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#destination_type ElasticacheReplicationGroup#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#log_format ElasticacheReplicationGroup#log_format}.</summary>
        [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}")]
        string LogFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#log_type ElasticacheReplicationGroup#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        string LogType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticacheReplicationGroupLogDeliveryConfiguration), fullyQualifiedName: "aws.elasticacheReplicationGroup.ElasticacheReplicationGroupLogDeliveryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticacheReplicationGroup.IElasticacheReplicationGroupLogDeliveryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#destination ElasticacheReplicationGroup#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#destination_type ElasticacheReplicationGroup#destination_type}.</summary>
            [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#log_format ElasticacheReplicationGroup#log_format}.</summary>
            [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string LogFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_replication_group#log_type ElasticacheReplicationGroup#log_type}.</summary>
            [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
            public string LogType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
