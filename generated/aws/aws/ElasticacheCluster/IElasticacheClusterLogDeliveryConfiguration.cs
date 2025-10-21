using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheCluster
{
    [JsiiInterface(nativeType: typeof(IElasticacheClusterLogDeliveryConfiguration), fullyQualifiedName: "aws.elasticacheCluster.ElasticacheClusterLogDeliveryConfiguration")]
    public interface IElasticacheClusterLogDeliveryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#destination ElasticacheCluster#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        string Destination
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#destination_type ElasticacheCluster#destination_type}.</summary>
        [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#log_format ElasticacheCluster#log_format}.</summary>
        [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}")]
        string LogFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#log_type ElasticacheCluster#log_type}.</summary>
        [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
        string LogType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticacheClusterLogDeliveryConfiguration), fullyQualifiedName: "aws.elasticacheCluster.ElasticacheClusterLogDeliveryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticacheCluster.IElasticacheClusterLogDeliveryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#destination ElasticacheCluster#destination}.</summary>
            [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
            public string Destination
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#destination_type ElasticacheCluster#destination_type}.</summary>
            [JsiiProperty(name: "destinationType", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#log_format ElasticacheCluster#log_format}.</summary>
            [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string LogFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_cluster#log_type ElasticacheCluster#log_type}.</summary>
            [JsiiProperty(name: "logType", typeJson: "{\"primitive\":\"string\"}")]
            public string LogType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
