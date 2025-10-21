using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxClusterDatabaseCacheConfigurations), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterDatabaseCacheConfigurations")]
    public interface IFinspaceKxClusterDatabaseCacheConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cache_type FinspaceKxCluster#cache_type}.</summary>
        [JsiiProperty(name: "cacheType", typeJson: "{\"primitive\":\"string\"}")]
        string CacheType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#db_paths FinspaceKxCluster#db_paths}.</summary>
        [JsiiProperty(name: "dbPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DbPaths
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxClusterDatabaseCacheConfigurations), fullyQualifiedName: "aws.finspaceKxCluster.FinspaceKxClusterDatabaseCacheConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxCluster.IFinspaceKxClusterDatabaseCacheConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cache_type FinspaceKxCluster#cache_type}.</summary>
            [JsiiProperty(name: "cacheType", typeJson: "{\"primitive\":\"string\"}")]
            public string CacheType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#db_paths FinspaceKxCluster#db_paths}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dbPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DbPaths
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
