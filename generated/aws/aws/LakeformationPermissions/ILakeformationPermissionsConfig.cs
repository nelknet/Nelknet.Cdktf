using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationPermissions
{
    [JsiiInterface(nativeType: typeof(ILakeformationPermissionsConfig), fullyQualifiedName: "aws.lakeformationPermissions.LakeformationPermissionsConfig")]
    public interface ILakeformationPermissionsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#permissions LakeformationPermissions#permissions}.</summary>
        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Permissions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#principal LakeformationPermissions#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        string Principal
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_id LakeformationPermissions#catalog_id}.</summary>
        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CatalogId
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_resource LakeformationPermissions#catalog_resource}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#database LakeformationPermissions#database}
        /// </remarks>
        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDatabase\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LakeformationPermissions.ILakeformationPermissionsDatabase? Database
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_cells_filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#data_cells_filter LakeformationPermissions#data_cells_filter}
        /// </remarks>
        [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataCellsFilter\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LakeformationPermissions.ILakeformationPermissionsDataCellsFilter? DataCellsFilter
        {
            get
            {
                return null;
            }
        }

        /// <summary>data_location block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#data_location LakeformationPermissions#data_location}
        /// </remarks>
        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataLocation\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LakeformationPermissions.ILakeformationPermissionsDataLocation? DataLocation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#id LakeformationPermissions#id}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#lf_tag LakeformationPermissions#lf_tag}
        /// </remarks>
        [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTag\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LakeformationPermissions.ILakeformationPermissionsLfTag? LfTag
        {
            get
            {
                return null;
            }
        }

        /// <summary>lf_tag_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#lf_tag_policy LakeformationPermissions#lf_tag_policy}
        /// </remarks>
        [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy? LfTagPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#permissions_with_grant_option LakeformationPermissions#permissions_with_grant_option}.</summary>
        [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PermissionsWithGrantOption
        {
            get
            {
                return null;
            }
        }

        /// <summary>table block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#table LakeformationPermissions#table}
        /// </remarks>
        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTable\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LakeformationPermissions.ILakeformationPermissionsTable? Table
        {
            get
            {
                return null;
            }
        }

        /// <summary>table_with_columns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#table_with_columns LakeformationPermissions#table_with_columns}
        /// </remarks>
        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.LakeformationPermissions.ILakeformationPermissionsTableWithColumns? TableWithColumns
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILakeformationPermissionsConfig), fullyQualifiedName: "aws.lakeformationPermissions.LakeformationPermissionsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.LakeformationPermissions.ILakeformationPermissionsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#permissions LakeformationPermissions#permissions}.</summary>
            [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Permissions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#principal LakeformationPermissions#principal}.</summary>
            [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
            public string Principal
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_id LakeformationPermissions#catalog_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CatalogId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#catalog_resource LakeformationPermissions#catalog_resource}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CatalogResource
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>database block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#database LakeformationPermissions#database}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDatabase\"}", isOptional: true)]
            public aws.LakeformationPermissions.ILakeformationPermissionsDatabase? Database
            {
                get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsDatabase?>();
            }

            /// <summary>data_cells_filter block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#data_cells_filter LakeformationPermissions#data_cells_filter}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataCellsFilter\"}", isOptional: true)]
            public aws.LakeformationPermissions.ILakeformationPermissionsDataCellsFilter? DataCellsFilter
            {
                get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsDataCellsFilter?>();
            }

            /// <summary>data_location block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#data_location LakeformationPermissions#data_location}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataLocation\"}", isOptional: true)]
            public aws.LakeformationPermissions.ILakeformationPermissionsDataLocation? DataLocation
            {
                get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsDataLocation?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#id LakeformationPermissions#id}.</summary>
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
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#lf_tag LakeformationPermissions#lf_tag}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTag\"}", isOptional: true)]
            public aws.LakeformationPermissions.ILakeformationPermissionsLfTag? LfTag
            {
                get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsLfTag?>();
            }

            /// <summary>lf_tag_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#lf_tag_policy LakeformationPermissions#lf_tag_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicy\"}", isOptional: true)]
            public aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy? LfTagPolicy
            {
                get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#permissions_with_grant_option LakeformationPermissions#permissions_with_grant_option}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PermissionsWithGrantOption
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>table block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#table LakeformationPermissions#table}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTable\"}", isOptional: true)]
            public aws.LakeformationPermissions.ILakeformationPermissionsTable? Table
            {
                get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsTable?>();
            }

            /// <summary>table_with_columns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#table_with_columns LakeformationPermissions#table_with_columns}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTableWithColumns\"}", isOptional: true)]
            public aws.LakeformationPermissions.ILakeformationPermissionsTableWithColumns? TableWithColumns
            {
                get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsTableWithColumns?>();
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
