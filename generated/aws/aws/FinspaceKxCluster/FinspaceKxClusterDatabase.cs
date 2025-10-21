using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.finspaceKxCluster.FinspaceKxClusterDatabase")]
    public class FinspaceKxClusterDatabase : aws.FinspaceKxCluster.IFinspaceKxClusterDatabase
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#database_name FinspaceKxCluster#database_name}.</summary>
        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public string DatabaseName
        {
            get;
            set;
        }

        private object? _cacheConfigurations;

        /// <summary>cache_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#cache_configurations FinspaceKxCluster#cache_configurations}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cacheConfigurations", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.finspaceKxCluster.FinspaceKxClusterDatabaseCacheConfigurations\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CacheConfigurations
        {
            get => _cacheConfigurations;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.FinspaceKxCluster.IFinspaceKxClusterDatabaseCacheConfigurations[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.FinspaceKxCluster.IFinspaceKxClusterDatabaseCacheConfigurations).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _cacheConfigurations = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#changeset_id FinspaceKxCluster#changeset_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "changesetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ChangesetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_cluster#dataview_name FinspaceKxCluster#dataview_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataviewName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DataviewName
        {
            get;
            set;
        }
    }
}
