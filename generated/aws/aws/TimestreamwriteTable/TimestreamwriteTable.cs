using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.TimestreamwriteTable
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table aws_timestreamwrite_table}.</summary>
    [JsiiClass(nativeType: typeof(aws.TimestreamwriteTable.TimestreamwriteTable), fullyQualifiedName: "aws.timestreamwriteTable.TimestreamwriteTable", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableConfig\"}}]")]
    public class TimestreamwriteTable : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table aws_timestreamwrite_table} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public TimestreamwriteTable(Constructs.Construct scope, string id, aws.TimestreamwriteTable.ITimestreamwriteTableConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.TimestreamwriteTable.ITimestreamwriteTableConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTable(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected TimestreamwriteTable(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a TimestreamwriteTable resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the TimestreamwriteTable to import.</param>
        /// <param name="importFromId">The id of the existing TimestreamwriteTable that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the TimestreamwriteTable to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the TimestreamwriteTable to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/timestreamwrite_table#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing TimestreamwriteTable that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the TimestreamwriteTable to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.TimestreamwriteTable.TimestreamwriteTable), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putMagneticStoreWriteProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableMagneticStoreWriteProperties\"}}]")]
        public virtual void PutMagneticStoreWriteProperties(aws.TimestreamwriteTable.ITimestreamwriteTableMagneticStoreWriteProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TimestreamwriteTable.ITimestreamwriteTableMagneticStoreWriteProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRetentionProperties", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableRetentionProperties\"}}]")]
        public virtual void PutRetentionProperties(aws.TimestreamwriteTable.ITimestreamwriteTableRetentionProperties @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TimestreamwriteTable.ITimestreamwriteTableRetentionProperties)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchema\"}}]")]
        public virtual void PutSchema(aws.TimestreamwriteTable.ITimestreamwriteTableSchema @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.TimestreamwriteTable.ITimestreamwriteTableSchema)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMagneticStoreWriteProperties")]
        public virtual void ResetMagneticStoreWriteProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRetentionProperties")]
        public virtual void ResetRetentionProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchema")]
        public virtual void ResetSchema()
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
        = GetStaticProperty<string>(typeof(aws.TimestreamwriteTable.TimestreamwriteTable))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "magneticStoreWriteProperties", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference\"}")]
        public virtual aws.TimestreamwriteTable.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference MagneticStoreWriteProperties
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.TimestreamwriteTableMagneticStoreWritePropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "retentionProperties", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableRetentionPropertiesOutputReference\"}")]
        public virtual aws.TimestreamwriteTable.TimestreamwriteTableRetentionPropertiesOutputReference RetentionProperties
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.TimestreamwriteTableRetentionPropertiesOutputReference>()!;
        }

        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchemaOutputReference\"}")]
        public virtual aws.TimestreamwriteTable.TimestreamwriteTableSchemaOutputReference Schema
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.TimestreamwriteTableSchemaOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "databaseNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DatabaseNameInput
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
        [JsiiProperty(name: "magneticStoreWritePropertiesInput", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableMagneticStoreWriteProperties\"}", isOptional: true)]
        public virtual aws.TimestreamwriteTable.ITimestreamwriteTableMagneticStoreWriteProperties? MagneticStoreWritePropertiesInput
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.ITimestreamwriteTableMagneticStoreWriteProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "retentionPropertiesInput", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableRetentionProperties\"}", isOptional: true)]
        public virtual aws.TimestreamwriteTable.ITimestreamwriteTableRetentionProperties? RetentionPropertiesInput
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.ITimestreamwriteTableRetentionProperties?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"fqn\":\"aws.timestreamwriteTable.TimestreamwriteTableSchema\"}", isOptional: true)]
        public virtual aws.TimestreamwriteTable.ITimestreamwriteTableSchema? SchemaInput
        {
            get => GetInstanceProperty<aws.TimestreamwriteTable.ITimestreamwriteTableSchema?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tableNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TableNameInput
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

        [JsiiProperty(name: "databaseName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DatabaseName
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

        [JsiiProperty(name: "tableName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TableName
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
