using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheServerlessCache
{
    [JsiiInterface(nativeType: typeof(IElasticacheServerlessCacheCacheUsageLimits), fullyQualifiedName: "aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimits")]
    public interface IElasticacheServerlessCacheCacheUsageLimits
    {
        /// <summary>data_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#data_storage ElasticacheServerlessCache#data_storage}
        /// </remarks>
        [JsiiProperty(name: "dataStorage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimitsDataStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataStorage
        {
            get
            {
                return null;
            }
        }

        /// <summary>ecpu_per_second block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#ecpu_per_second ElasticacheServerlessCache#ecpu_per_second}
        /// </remarks>
        [JsiiProperty(name: "ecpuPerSecond", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EcpuPerSecond
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IElasticacheServerlessCacheCacheUsageLimits), fullyQualifiedName: "aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimits")]
        internal sealed class _Proxy : DeputyBase, aws.ElasticacheServerlessCache.IElasticacheServerlessCacheCacheUsageLimits
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>data_storage block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#data_storage ElasticacheServerlessCache#data_storage}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataStorage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimitsDataStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataStorage
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>ecpu_per_second block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#ecpu_per_second ElasticacheServerlessCache#ecpu_per_second}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ecpuPerSecond", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? EcpuPerSecond
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
