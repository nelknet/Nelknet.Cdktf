using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheServerlessCache
{
    [JsiiByValue(fqn: "aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimits")]
    public class ElasticacheServerlessCacheCacheUsageLimits : aws.ElasticacheServerlessCache.IElasticacheServerlessCacheCacheUsageLimits
    {
        private object? _dataStorage;

        /// <summary>data_storage block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#data_storage ElasticacheServerlessCache#data_storage}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataStorage", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimitsDataStorage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataStorage
        {
            get => _dataStorage;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ElasticacheServerlessCache.IElasticacheServerlessCacheCacheUsageLimitsDataStorage[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElasticacheServerlessCache.IElasticacheServerlessCacheCacheUsageLimitsDataStorage).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataStorage = value;
            }
        }

        private object? _ecpuPerSecond;

        /// <summary>ecpu_per_second block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#ecpu_per_second ElasticacheServerlessCache#ecpu_per_second}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ecpuPerSecond", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? EcpuPerSecond
        {
            get => _ecpuPerSecond;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ElasticacheServerlessCache.IElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ElasticacheServerlessCache.IElasticacheServerlessCacheCacheUsageLimitsEcpuPerSecond).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _ecpuPerSecond = value;
            }
        }
    }
}
