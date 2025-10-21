using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationOptIn
{
    [JsiiInterface(nativeType: typeof(ILakeformationOptInResourceData), fullyQualifiedName: "aws.lakeformationOptIn.LakeformationOptInResourceData")]
    public interface ILakeformationOptInResourceData
    {
        /// <summary>catalog block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#catalog LakeformationOptIn#catalog}
        /// </remarks>
        [JsiiProperty(name: "catalog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataCatalog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Catalog
        {
            get
            {
                return null;
            }
        }

        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#database LakeformationOptIn#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_cells_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_cells_filter LakeformationOptIn#data_cells_filter}
        /// </remarks>
        [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataCellsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataCellsFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_location LakeformationOptIn#data_location}
        /// </remarks>
        [JsiiProperty(name: "dataLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DataLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>lf_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag LakeformationOptIn#lf_tag}
        /// </remarks>
        [JsiiProperty(name: "lfTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LfTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>lf_tag_expression block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag_expression LakeformationOptIn#lf_tag_expression}
        /// </remarks>
        [JsiiProperty(name: "lfTagExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LfTagExpression
        {
            get
            {
                return null;
            }
        }

        /// <summary>lf_tag_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag_policy LakeformationOptIn#lf_tag_policy}
        /// </remarks>
        [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? LfTagPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#table LakeformationOptIn#table}
        /// </remarks>
        [JsiiProperty(name: "table", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Table
        {
            get
            {
                return null;
            }
        }

        /// <summary>table_with_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#table_with_columns LakeformationOptIn#table_with_columns}
        /// </remarks>
        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TableWithColumns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationOptInResourceData), fullyQualifiedName: "aws.lakeformationOptIn.LakeformationOptInResourceData")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationOptIn.ILakeformationOptInResourceData
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>catalog block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#catalog LakeformationOptIn#catalog}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "catalog", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataCatalog\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Catalog
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#database LakeformationOptIn#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDatabase\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Database
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>data_cells_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_cells_filter LakeformationOptIn#data_cells_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataCellsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataCellsFilter
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>data_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#data_location LakeformationOptIn#data_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataLocation", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataDataLocation\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DataLocation
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lf_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag LakeformationOptIn#lf_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfTag", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LfTag
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lf_tag_expression block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag_expression LakeformationOptIn#lf_tag_expression}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfTagExpression", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagExpression\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LfTagExpression
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>lf_tag_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#lf_tag_policy LakeformationOptIn#lf_tag_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataLfTagPolicy\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? LfTagPolicy
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#table LakeformationOptIn#table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "table", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTable\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Table
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>table_with_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_opt_in#table_with_columns LakeformationOptIn#table_with_columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableWithColumns", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationOptIn.LakeformationOptInResourceDataTableWithColumns\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TableWithColumns
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
