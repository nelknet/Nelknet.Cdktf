using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsQuicksightDataSet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set aws_quicksight_data_set}.</summary>
    [JsiiClass(nativeType: typeof(aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSet), fullyQualifiedName: "aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetConfig\"}}]")]
    public class DataAwsQuicksightDataSet : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set aws_quicksight_data_set} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsQuicksightDataSet(Constructs.Construct scope, string id, aws.DataAwsQuicksightDataSet.IDataAwsQuicksightDataSetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.DataAwsQuicksightDataSet.IDataAwsQuicksightDataSetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsQuicksightDataSet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsQuicksightDataSet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAwsQuicksightDataSet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAwsQuicksightDataSet to import.</param>
        /// <param name="importFromId">The id of the existing DataAwsQuicksightDataSet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAwsQuicksightDataSet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAwsQuicksightDataSet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAwsQuicksightDataSet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAwsQuicksightDataSet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "resetAwsAccountId")]
        public virtual void ResetAwsAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
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
        = GetStaticProperty<string>(typeof(aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSet))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "columnGroups", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetColumnGroupsList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetColumnGroupsList ColumnGroups
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetColumnGroupsList>()!;
        }

        [JsiiProperty(name: "columnLevelPermissionRules", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetColumnLevelPermissionRulesList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetColumnLevelPermissionRulesList ColumnLevelPermissionRules
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetColumnLevelPermissionRulesList>()!;
        }

        [JsiiProperty(name: "dataSetUsageConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetDataSetUsageConfigurationList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetDataSetUsageConfigurationList DataSetUsageConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetDataSetUsageConfigurationList>()!;
        }

        [JsiiProperty(name: "fieldFolders", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetFieldFoldersList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetFieldFoldersList FieldFolders
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetFieldFoldersList>()!;
        }

        [JsiiProperty(name: "importMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ImportMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "logicalTableMap", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetLogicalTableMapList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetLogicalTableMapList LogicalTableMap
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetLogicalTableMapList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetPermissionsList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPermissionsList Permissions
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPermissionsList>()!;
        }

        [JsiiProperty(name: "physicalTableMap", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapList PhysicalTableMap
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetPhysicalTableMapList>()!;
        }

        [JsiiProperty(name: "rowLevelPermissionDataSet", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetRowLevelPermissionDataSetList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetRowLevelPermissionDataSetList RowLevelPermissionDataSet
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetRowLevelPermissionDataSetList>()!;
        }

        [JsiiProperty(name: "rowLevelPermissionTagConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsQuicksightDataSet.DataAwsQuicksightDataSetRowLevelPermissionTagConfigurationList\"}")]
        public virtual aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetRowLevelPermissionTagConfigurationList RowLevelPermissionTagConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetRowLevelPermissionTagConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "awsAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AwsAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiProperty(name: "awsAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AwsAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataSetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSetId
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
