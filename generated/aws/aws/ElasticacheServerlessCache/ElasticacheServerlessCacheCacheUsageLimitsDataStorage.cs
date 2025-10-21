using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ElasticacheServerlessCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elasticacheServerlessCache.ElasticacheServerlessCacheCacheUsageLimitsDataStorage")]
    public class ElasticacheServerlessCacheCacheUsageLimitsDataStorage : aws.ElasticacheServerlessCache.IElasticacheServerlessCacheCacheUsageLimitsDataStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#unit ElasticacheServerlessCache#unit}.</summary>
        [JsiiProperty(name: "unit", typeJson: "{\"primitive\":\"string\"}")]
        public string Unit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#maximum ElasticacheServerlessCache#maximum}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Maximum
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elasticache_serverless_cache#minimum ElasticacheServerlessCache#minimum}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minimum", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Minimum
        {
            get;
            set;
        }
    }
}
