using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLakeformationPermissions
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions aws_lakeformation_permissions}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissions), fullyQualifiedName: "aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsConfig\"}}]")]
    public class DataAwsLakeformationPermissions : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions aws_lakeformation_permissions} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsLakeformationPermissions(Constructs.Construct scope, string id, aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLakeformationPermissions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLakeformationPermissions(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsLakeformationPermissions resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsLakeformationPermissions to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsLakeformationPermissions that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsLakeformationPermissions to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsLakeformationPermissions to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lakeformation_permissions#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsLakeformationPermissions that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsLakeformationPermissions to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissions), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabase\"}}]")]
        public virtual void PutDatabase(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDatabase)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataCellsFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilter\"}}]")]
        public virtual void PutDataCellsFilter(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataCellsFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataCellsFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocation\"}}]")]
        public virtual void PutDataLocation(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTag\"}}]")]
        public virtual void PutLfTag(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTag @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTag)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTagPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicy\"}}]")]
        public virtual void PutLfTagPolicy(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTagPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTagPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTable\"}}]")]
        public virtual void PutTable(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTableWithColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumns\"}}]")]
        public virtual void PutTableWithColumns(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTableWithColumns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTableWithColumns)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCatalogResource")]
        public virtual void ResetCatalogResource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataCellsFilter")]
        public virtual void ResetDataCellsFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDataLocation")]
        public virtual void ResetDataLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLfTag")]
        public virtual void ResetLfTag()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLfTagPolicy")]
        public virtual void ResetLfTagPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTable")]
        public virtual void ResetTable()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTableWithColumns")]
        public virtual void ResetTableWithColumns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissions))!;

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabaseOutputReference\"}")]
        public virtual aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabaseOutputReference Database
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabaseOutputReference>()!;
        }

        [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilterOutputReference\"}")]
        public virtual aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilterOutputReference DataCellsFilter
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilterOutputReference>()!;
        }

        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocationOutputReference\"}")]
        public virtual aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocationOutputReference DataLocation
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocationOutputReference>()!;
        }

        [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagOutputReference\"}")]
        public virtual aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagOutputReference LfTag
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagOutputReference>()!;
        }

        [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicyOutputReference\"}")]
        public virtual aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicyOutputReference LfTagPolicy
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Permissions
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PermissionsWithGrantOption
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableOutputReference\"}")]
        public virtual aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableOutputReference Table
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableOutputReference>()!;
        }

        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumnsOutputReference\"}")]
        public virtual aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumnsOutputReference TableWithColumns
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumnsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogResourceInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CatalogResourceInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDatabase\"}", isOptional: true)]
        public virtual aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDatabase? DatabaseInput
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCellsFilterInput", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataCellsFilter\"}", isOptional: true)]
        public virtual aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataCellsFilter? DataCellsFilterInput
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataCellsFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataLocationInput", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsDataLocation\"}", isOptional: true)]
        public virtual aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataLocation? DataLocationInput
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsDataLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagInput", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTag\"}", isOptional: true)]
        public virtual aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTag? LfTagInput
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTag?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagPolicyInput", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsLfTagPolicy\"}", isOptional: true)]
        public virtual aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTagPolicy? LfTagPolicyInput
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsLfTagPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableInput", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTable\"}", isOptional: true)]
        public virtual aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTable? TableInput
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumnsInput", typeJson: "{\"fqn\":\"aws.dataAwsLakeformationPermissions.DataAwsLakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        public virtual aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTableWithColumns? TableWithColumnsInput
        {
            get => GetInstanceProperty<aws.DataAwsLakeformationPermissions.IDataAwsLakeformationPermissionsTableWithColumns?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "catalogResource", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CatalogResource
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Principal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
