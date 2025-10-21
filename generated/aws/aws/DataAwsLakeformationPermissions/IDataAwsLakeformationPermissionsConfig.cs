using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLakeformationPermissions
{
    [JsiiInterface(nativeType: typeof(IDataAwsLakeformationPermissionsConfig), fullyQualifiedName: "aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsConfig")]
    public interface IDataAwsLakeformationPermissionsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#principal DataAwsLakeformationPermissions#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#catalog_id DataAwsLakeformationPermissions#catalog_id}.</summary>
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#catalog_resource DataAwsLakeformationPermissions#catalog_resource}.</summary>
        [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CatalogResource
        {
            get
            {
                return null;
            }
        }

        /// <summary>database block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#database DataAwsLakeformationPermissions#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabase\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDatabase? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_cells_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#data_cells_filter DataAwsLakeformationPermissions#data_cells_filter}
        /// </remarks>
        [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataCellsFilter? DataCellsFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#data_location DataAwsLakeformationPermissions#data_location}
        /// </remarks>
        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataLocation? DataLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#id DataAwsLakeformationPermissions#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>lf_tag block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#lf_tag DataAwsLakeformationPermissions#lf_tag}
        /// </remarks>
        [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTag\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTag? LfTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>lf_tag_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#lf_tag_policy DataAwsLakeformationPermissions#lf_tag_policy}
        /// </remarks>
        [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTagPolicy? LfTagPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#table DataAwsLakeformationPermissions#table}
        /// </remarks>
        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTable? Table
        {
            get
            {
                return null;
            }
        }

        /// <summary>table_with_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#table_with_columns DataAwsLakeformationPermissions#table_with_columns}
        /// </remarks>
        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTableWithColumns? TableWithColumns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLakeformationPermissionsConfig), fullyQualifiedName: "aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#principal DataAwsLakeformationPermissions#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#catalog_id DataAwsLakeformationPermissions#catalog_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#catalog_resource DataAwsLakeformationPermissions#catalog_resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CatalogResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#database DataAwsLakeformationPermissions#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabase\"}", isOptional: true)]
            public aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDatabase? Database
            {
                get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDatabase?>();
            }

            /// <summary>data_cells_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#data_cells_filter DataAwsLakeformationPermissions#data_cells_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilter\"}", isOptional: true)]
            public aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataCellsFilter? DataCellsFilter
            {
                get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataCellsFilter?>();
            }

            /// <summary>data_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#data_location DataAwsLakeformationPermissions#data_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocation\"}", isOptional: true)]
            public aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataLocation? DataLocation
            {
                get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataLocation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#id DataAwsLakeformationPermissions#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lf_tag block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#lf_tag DataAwsLakeformationPermissions#lf_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTag\"}", isOptional: true)]
            public aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTag? LfTag
            {
                get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTag?>();
            }

            /// <summary>lf_tag_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#lf_tag_policy DataAwsLakeformationPermissions#lf_tag_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicy\"}", isOptional: true)]
            public aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTagPolicy? LfTagPolicy
            {
                get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTagPolicy?>();
            }

            /// <summary>table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#table DataAwsLakeformationPermissions#table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTable\"}", isOptional: true)]
            public aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTable? Table
            {
                get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTable?>();
            }

            /// <summary>table_with_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#table_with_columns DataAwsLakeformationPermissions#table_with_columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumns\"}", isOptional: true)]
            public aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTableWithColumns? TableWithColumns
            {
                get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTableWithColumns?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
