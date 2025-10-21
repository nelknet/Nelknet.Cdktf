using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    [JsiiByValue(fqn: "aws.lakeformationOptIn.LakeformationOptInResourceData")]
    public class LakeformationOptInResourceData : aws.LakeformationOptIn.ILakeformationOptInResourceData
    {
        private object? _catalog;

        /// <summary>catalog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#catalog LakeformationOptIn#catalog}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "catalog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataCatalog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Catalog
        {
            get => _catalog;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataCatalog[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataCatalog).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _catalog = value;
            }
        }

        private object? _database;

        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#database LakeformationOptIn#database}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "database", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Database
        {
            get => _database;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataDatabase[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDatabase).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _database = value;
            }
        }

        private object? _dataCellsFilter;

        /// <summary>data_cells_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_cells_filter LakeformationOptIn#data_cells_filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataCellsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataCellsFilter
        {
            get => _dataCellsFilter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataDataCellsFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDataCellsFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataCellsFilter = value;
            }
        }

        private object? _dataLocation;

        /// <summary>data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_location LakeformationOptIn#data_location}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DataLocation
        {
            get => _dataLocation;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataDataLocation[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataDataLocation).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataLocation = value;
            }
        }

        private object? _lfTag;

        /// <summary>lf_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag LakeformationOptIn#lf_tag}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lfTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LfTag
        {
            get => _lfTag;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTag[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTag).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lfTag = value;
            }
        }

        private object? _lfTagExpression;

        /// <summary>lf_tag_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag_expression LakeformationOptIn#lf_tag_expression}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lfTagExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LfTagExpression
        {
            get => _lfTagExpression;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagExpression[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagExpression).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lfTagExpression = value;
            }
        }

        private object? _lfTagPolicy;

        /// <summary>lf_tag_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag_policy LakeformationOptIn#lf_tag_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? LfTagPolicy
        {
            get => _lfTagPolicy;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagPolicy[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataLfTagPolicy).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _lfTagPolicy = value;
            }
        }

        private object? _table;

        /// <summary>table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#table LakeformationOptIn#table}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "table", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Table
        {
            get => _table;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataTable[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataTable).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _table = value;
            }
        }

        private object? _tableWithColumns;

        /// <summary>table_with_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#table_with_columns LakeformationOptIn#table_with_columns}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? TableWithColumns
        {
            get => _tableWithColumns;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.LakeformationOptIn.ILakeformationOptInResourceDataTableWithColumns[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationOptIn.ILakeformationOptInResourceDataTableWithColumns).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _tableWithColumns = value;
            }
        }
    }
}
