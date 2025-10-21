using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.CosmosdbSqlContainer
{
    [JsiiByValue(fqn: "azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicy")]
    public class CosmosdbSqlContainerIndexingPolicy : azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicy
    {
        private object? _compositeIndex;

        /// <summary>composite_index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#composite_index CosmosdbSqlContainer#composite_index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "compositeIndex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyCompositeIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? CompositeIndex
        {
            get => _compositeIndex;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndex[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyCompositeIndex).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _compositeIndex = value;
            }
        }

        private object? _excludedPath;

        /// <summary>excluded_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#excluded_path CosmosdbSqlContainer#excluded_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyExcludedPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExcludedPath
        {
            get => _excludedPath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyExcludedPath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyExcludedPath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _excludedPath = value;
            }
        }

        private object? _includedPath;

        /// <summary>included_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#included_path CosmosdbSqlContainer#included_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includedPath", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicyIncludedPath\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IncludedPath
        {
            get => _includedPath;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyIncludedPath[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicyIncludedPath).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includedPath = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#indexing_mode CosmosdbSqlContainer#indexing_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "indexingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IndexingMode
        {
            get;
            set;
        }

        private object? _spatialIndex;

        /// <summary>spatial_index block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_sql_container#spatial_index CosmosdbSqlContainer#spatial_index}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spatialIndex", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.cosmosdbSqlContainer.CosmosdbSqlContainerIndexingPolicySpatialIndex\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? SpatialIndex
        {
            get => _spatialIndex;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicySpatialIndex[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.CosmosdbSqlContainer.ICosmosdbSqlContainerIndexingPolicySpatialIndex).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _spatialIndex = value;
            }
        }
    }
}
