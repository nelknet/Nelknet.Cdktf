using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationPermissions
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions aws_lakeformation_permissions}.</summary>
    [JsiiClass(nativeType: typeof(aws.LakeformationPermissions.LakeformationPermissions), fullyQualifiedName: "aws.lakeformationPermissions.LakeformationPermissions", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsConfig\"}}]")]
    public class LakeformationPermissions : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions aws_lakeformation_permissions} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LakeformationPermissions(Constructs.Construct scope, string id, aws.LakeformationPermissions.ILakeformationPermissionsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LakeformationPermissions.ILakeformationPermissionsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationPermissions(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationPermissions(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LakeformationPermissions resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LakeformationPermissions to import.</param>
        /// <param name="importFromId">The id of the existing LakeformationPermissions that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LakeformationPermissions to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LakeformationPermissions to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_permissions#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LakeformationPermissions that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LakeformationPermissions to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.LakeformationPermissions.LakeformationPermissions), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDatabase\"}}]")]
        public virtual void PutDatabase(aws.LakeformationPermissions.ILakeformationPermissionsDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationPermissions.ILakeformationPermissionsDatabase)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataCellsFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataCellsFilter\"}}]")]
        public virtual void PutDataCellsFilter(aws.LakeformationPermissions.ILakeformationPermissionsDataCellsFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationPermissions.ILakeformationPermissionsDataCellsFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDataLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataLocation\"}}]")]
        public virtual void PutDataLocation(aws.LakeformationPermissions.ILakeformationPermissionsDataLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationPermissions.ILakeformationPermissionsDataLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTag\"}}]")]
        public virtual void PutLfTag(aws.LakeformationPermissions.ILakeformationPermissionsLfTag @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationPermissions.ILakeformationPermissionsLfTag)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTagPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicy\"}}]")]
        public virtual void PutLfTagPolicy(aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTable\"}}]")]
        public virtual void PutTable(aws.LakeformationPermissions.ILakeformationPermissionsTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationPermissions.ILakeformationPermissionsTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTableWithColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTableWithColumns\"}}]")]
        public virtual void PutTableWithColumns(aws.LakeformationPermissions.ILakeformationPermissionsTableWithColumns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationPermissions.ILakeformationPermissionsTableWithColumns)}, new object[]{@value});
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

        [JsiiMethod(name: "resetPermissionsWithGrantOption")]
        public virtual void ResetPermissionsWithGrantOption()
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
        = GetStaticProperty<string>(typeof(aws.LakeformationPermissions.LakeformationPermissions))!;

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDatabaseOutputReference\"}")]
        public virtual aws.LakeformationPermissions.LakeformationPermissionsDatabaseOutputReference Database
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.LakeformationPermissionsDatabaseOutputReference>()!;
        }

        [JsiiProperty(name: "dataCellsFilter", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataCellsFilterOutputReference\"}")]
        public virtual aws.LakeformationPermissions.LakeformationPermissionsDataCellsFilterOutputReference DataCellsFilter
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.LakeformationPermissionsDataCellsFilterOutputReference>()!;
        }

        [JsiiProperty(name: "dataLocation", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataLocationOutputReference\"}")]
        public virtual aws.LakeformationPermissions.LakeformationPermissionsDataLocationOutputReference DataLocation
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.LakeformationPermissionsDataLocationOutputReference>()!;
        }

        [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagOutputReference\"}")]
        public virtual aws.LakeformationPermissions.LakeformationPermissionsLfTagOutputReference LfTag
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.LakeformationPermissionsLfTagOutputReference>()!;
        }

        [JsiiProperty(name: "lfTagPolicy", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicyOutputReference\"}")]
        public virtual aws.LakeformationPermissions.LakeformationPermissionsLfTagPolicyOutputReference LfTagPolicy
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.LakeformationPermissionsLfTagPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTableOutputReference\"}")]
        public virtual aws.LakeformationPermissions.LakeformationPermissionsTableOutputReference Table
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.LakeformationPermissionsTableOutputReference>()!;
        }

        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTableWithColumnsOutputReference\"}")]
        public virtual aws.LakeformationPermissions.LakeformationPermissionsTableWithColumnsOutputReference TableWithColumns
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.LakeformationPermissionsTableWithColumnsOutputReference>()!;
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
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDatabase\"}", isOptional: true)]
        public virtual aws.LakeformationPermissions.ILakeformationPermissionsDatabase? DatabaseInput
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataCellsFilterInput", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataCellsFilter\"}", isOptional: true)]
        public virtual aws.LakeformationPermissions.ILakeformationPermissionsDataCellsFilter? DataCellsFilterInput
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsDataCellsFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataLocationInput", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsDataLocation\"}", isOptional: true)]
        public virtual aws.LakeformationPermissions.ILakeformationPermissionsDataLocation? DataLocationInput
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsDataLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagInput", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTag\"}", isOptional: true)]
        public virtual aws.LakeformationPermissions.ILakeformationPermissionsLfTag? LfTagInput
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsLfTag?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagPolicyInput", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsLfTagPolicy\"}", isOptional: true)]
        public virtual aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy? LfTagPolicyInput
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsLfTagPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PermissionsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsWithGrantOptionInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PermissionsWithGrantOptionInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "principalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableInput", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTable\"}", isOptional: true)]
        public virtual aws.LakeformationPermissions.ILakeformationPermissionsTable? TableInput
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumnsInput", typeJson: "{\"fqn\":\"aws.lakeformationPermissions.LakeformationPermissionsTableWithColumns\"}", isOptional: true)]
        public virtual aws.LakeformationPermissions.ILakeformationPermissionsTableWithColumns? TableWithColumnsInput
        {
            get => GetInstanceProperty<aws.LakeformationPermissions.ILakeformationPermissionsTableWithColumns?>();
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

        [JsiiProperty(name: "permissions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Permissions
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "permissionsWithGrantOption", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] PermissionsWithGrantOption
        {
            get => GetInstanceProperty<string[]>()!;
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
