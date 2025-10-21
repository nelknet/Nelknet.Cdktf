using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LakeformationResourceLfTags
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags aws_lakeformation_resource_lf_tags}.</summary>
    [JsiiClass(nativeType: typeof(aws.LakeformationResourceLfTags.LakeformationResourceLfTags), fullyQualifiedName: "aws.lakeformationResourceLfTags.LakeformationResourceLfTags", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsConfig\"}}]")]
    public class LakeformationResourceLfTags : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags aws_lakeformation_resource_lf_tags} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LakeformationResourceLfTags(Constructs.Construct scope, string id, aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationResourceLfTags(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LakeformationResourceLfTags(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a LakeformationResourceLfTags resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the LakeformationResourceLfTags to import.</param>
        /// <param name="importFromId">The id of the existing LakeformationResourceLfTags that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the LakeformationResourceLfTags to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the LakeformationResourceLfTags to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lakeformation_resource_lf_tags#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing LakeformationResourceLfTags that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the LakeformationResourceLfTags to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.LakeformationResourceLfTags.LakeformationResourceLfTags), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDatabase", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsDatabase\"}}]")]
        public virtual void PutDatabase(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsDatabase @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsDatabase)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLfTag", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsLfTag\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutLfTag(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsLfTag[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsLfTag).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsLfTag).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTable", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTable\"}}]")]
        public virtual void PutTable(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTable @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTable)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTableWithColumns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTableWithColumns\"}}]")]
        public virtual void PutTableWithColumns(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTableWithColumns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTableWithColumns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCatalogId")]
        public virtual void ResetCatalogId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDatabase")]
        public virtual void ResetDatabase()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
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

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.LakeformationResourceLfTags.LakeformationResourceLfTags))!;

        [JsiiProperty(name: "database", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsDatabaseOutputReference\"}")]
        public virtual aws.LakeformationResourceLfTags.LakeformationResourceLfTagsDatabaseOutputReference Database
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.LakeformationResourceLfTagsDatabaseOutputReference>()!;
        }

        [JsiiProperty(name: "lfTag", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsLfTagList\"}")]
        public virtual aws.LakeformationResourceLfTags.LakeformationResourceLfTagsLfTagList LfTag
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.LakeformationResourceLfTagsLfTagList>()!;
        }

        [JsiiProperty(name: "table", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTableOutputReference\"}")]
        public virtual aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTableOutputReference Table
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTableOutputReference>()!;
        }

        [JsiiProperty(name: "tableWithColumns", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTableWithColumnsOutputReference\"}")]
        public virtual aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTableWithColumnsOutputReference TableWithColumns
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTableWithColumnsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTimeoutsOutputReference\"}")]
        public virtual aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.LakeformationResourceLfTagsTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "catalogIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CatalogIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseInput", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsDatabase\"}", isOptional: true)]
        public virtual aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsDatabase? DatabaseInput
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsDatabase?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lfTagInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsLfTag\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? LfTagInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableInput", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTable\"}", isOptional: true)]
        public virtual aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTable? TableInput
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTable?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableWithColumnsInput", typeJson: "{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTableWithColumns\"}", isOptional: true)]
        public virtual aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTableWithColumns? TableWithColumnsInput
        {
            get => GetInstanceProperty<aws.LakeformationResourceLfTags.ILakeformationResourceLfTagsTableWithColumns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.lakeformationResourceLfTags.LakeformationResourceLfTagsTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "catalogId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CatalogId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
