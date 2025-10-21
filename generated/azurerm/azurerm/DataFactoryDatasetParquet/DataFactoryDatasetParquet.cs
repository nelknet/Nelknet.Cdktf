using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDatasetParquet
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet azurerm_data_factory_dataset_parquet}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquet), fullyQualifiedName: "azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquet", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetConfig\"}}]")]
    public class DataFactoryDatasetParquet : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet azurerm_data_factory_dataset_parquet} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataFactoryDatasetParquet(Constructs.Construct scope, string id, azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryDatasetParquet(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryDatasetParquet(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataFactoryDatasetParquet resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataFactoryDatasetParquet to import.</param>
        /// <param name="importFromId">The id of the existing DataFactoryDatasetParquet that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataFactoryDatasetParquet to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataFactoryDatasetParquet to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_parquet#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataFactoryDatasetParquet that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataFactoryDatasetParquet to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquet), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureBlobFsLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobFsLocation\"}}]")]
        public virtual void PutAzureBlobFsLocation(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobFsLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobFsLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAzureBlobStorageLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobStorageLocation\"}}]")]
        public virtual void PutAzureBlobStorageLocation(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobStorageLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobStorageLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpServerLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetHttpServerLocation\"}}]")]
        public virtual void PutHttpServerLocation(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetHttpServerLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetHttpServerLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchemaColumn", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetSchemaColumn\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchemaColumn(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetSchemaColumn[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetSchemaColumn).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetSchemaColumn).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalProperties")]
        public virtual void ResetAdditionalProperties()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAnnotations")]
        public virtual void ResetAnnotations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureBlobFsLocation")]
        public virtual void ResetAzureBlobFsLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAzureBlobStorageLocation")]
        public virtual void ResetAzureBlobStorageLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompressionCodec")]
        public virtual void ResetCompressionCodec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompressionLevel")]
        public virtual void ResetCompressionLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFolder")]
        public virtual void ResetFolder()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpServerLocation")]
        public virtual void ResetHttpServerLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchemaColumn")]
        public virtual void ResetSchemaColumn()
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
        = GetStaticProperty<string>(typeof(azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquet))!;

        [JsiiProperty(name: "azureBlobFsLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobFsLocationOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobFsLocationOutputReference AzureBlobFsLocation
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobFsLocationOutputReference>()!;
        }

        [JsiiProperty(name: "azureBlobStorageLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobStorageLocationOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobStorageLocationOutputReference AzureBlobStorageLocation
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobStorageLocationOutputReference>()!;
        }

        [JsiiProperty(name: "httpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetHttpServerLocationOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetHttpServerLocationOutputReference HttpServerLocation
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetHttpServerLocationOutputReference>()!;
        }

        [JsiiProperty(name: "schemaColumn", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetSchemaColumnList\"}")]
        public virtual azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetSchemaColumnList SchemaColumn
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetSchemaColumnList>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetTimeoutsOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.DataFactoryDatasetParquetTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalPropertiesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdditionalPropertiesInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "annotationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AnnotationsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobFsLocationInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobFsLocation\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobFsLocation? AzureBlobFsLocationInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobFsLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "azureBlobStorageLocationInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetAzureBlobStorageLocation\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobStorageLocation? AzureBlobStorageLocationInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetAzureBlobStorageLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionCodecInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompressionCodecInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CompressionLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataFactoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataFactoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "folderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FolderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpServerLocationInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetHttpServerLocation\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetHttpServerLocation? HttpServerLocationInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetParquet.IDataFactoryDatasetParquetHttpServerLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "linkedServiceNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LinkedServiceNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "parametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? ParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaColumnInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetSchemaColumn\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SchemaColumnInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryDatasetParquet.DataFactoryDatasetParquetTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "additionalProperties", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalProperties
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Annotations
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compressionCodec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompressionCodec
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "compressionLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CompressionLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "dataFactoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataFactoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "folder", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Folder
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

        [JsiiProperty(name: "linkedServiceName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LinkedServiceName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Parameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
