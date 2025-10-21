using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDatasetBinary
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary azurerm_data_factory_dataset_binary}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinary), fullyQualifiedName: "azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinary", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryConfig\"}}]")]
    public class DataFactoryDatasetBinary : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary azurerm_data_factory_dataset_binary} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataFactoryDatasetBinary(Constructs.Construct scope, string id, azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryDatasetBinary(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryDatasetBinary(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataFactoryDatasetBinary resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataFactoryDatasetBinary to import.</param>
        /// <param name="importFromId">The id of the existing DataFactoryDatasetBinary that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataFactoryDatasetBinary to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataFactoryDatasetBinary to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_dataset_binary#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataFactoryDatasetBinary that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataFactoryDatasetBinary to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinary), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAzureBlobStorageLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocation\"}}]")]
        public virtual void PutAzureBlobStorageLocation(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryAzureBlobStorageLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryAzureBlobStorageLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCompression", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryCompression\"}}]")]
        public virtual void PutCompression(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryCompression @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryCompression)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpServerLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocation\"}}]")]
        public virtual void PutHttpServerLocation(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryHttpServerLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryHttpServerLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSftpServerLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocation\"}}]")]
        public virtual void PutSftpServerLocation(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinarySftpServerLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinarySftpServerLocation)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetAzureBlobStorageLocation")]
        public virtual void ResetAzureBlobStorageLocation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCompression")]
        public virtual void ResetCompression()
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

        [JsiiMethod(name: "resetSftpServerLocation")]
        public virtual void ResetSftpServerLocation()
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
        = GetStaticProperty<string>(typeof(azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinary))!;

        [JsiiProperty(name: "azureBlobStorageLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocationOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocationOutputReference AzureBlobStorageLocation
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocationOutputReference>()!;
        }

        [JsiiProperty(name: "compression", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryCompressionOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryCompressionOutputReference Compression
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryCompressionOutputReference>()!;
        }

        [JsiiProperty(name: "httpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocationOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocationOutputReference HttpServerLocation
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocationOutputReference>()!;
        }

        [JsiiProperty(name: "sftpServerLocation", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocationOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocationOutputReference SftpServerLocation
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeoutsOutputReference\"}")]
        public virtual azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "azureBlobStorageLocationInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryAzureBlobStorageLocation\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryAzureBlobStorageLocation? AzureBlobStorageLocationInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryAzureBlobStorageLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "compressionInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryCompression\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryCompression? CompressionInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryCompression?>();
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
        [JsiiProperty(name: "httpServerLocationInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryHttpServerLocation\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryHttpServerLocation? HttpServerLocationInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinaryHttpServerLocation?>();
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
        [JsiiProperty(name: "sftpServerLocationInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinarySftpServerLocation\"}", isOptional: true)]
        public virtual azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinarySftpServerLocation? SftpServerLocationInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryDatasetBinary.IDataFactoryDatasetBinarySftpServerLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryDatasetBinary.DataFactoryDatasetBinaryTimeouts\"}]}}", isOptional: true)]
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
