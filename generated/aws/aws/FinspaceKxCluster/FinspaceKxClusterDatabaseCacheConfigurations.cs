using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxCluster.FinspaceKxClusterDatabaseCacheConfigurations")]
    public class FinspaceKxClusterDatabaseCacheConfigurations : aws.FinspaceKxCluster.IFinspaceKxClusterDatabaseCacheConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cache_type FinspaceKxCluster#cache_type}.</summary>
        [JsiiProperty(name: "cacheType", typeJson: "{\"primitive\":\"string\"}")]
        public string CacheType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#db_paths FinspaceKxCluster#db_paths}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dbPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DbPaths
        {
            get;
            set;
        }
    }
}
