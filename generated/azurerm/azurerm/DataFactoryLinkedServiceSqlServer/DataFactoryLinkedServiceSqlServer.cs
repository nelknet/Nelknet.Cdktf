using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceSqlServer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server azurerm_data_factory_linked_service_sql_server}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer), fullyQualifiedName: "azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerConfig\"}}]")]
    public class DataFactoryLinkedServiceSqlServer : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server azurerm_data_factory_linked_service_sql_server} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataFactoryLinkedServiceSqlServer(Constructs.Construct scope, string id, azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryLinkedServiceSqlServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataFactoryLinkedServiceSqlServer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataFactoryLinkedServiceSqlServer resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataFactoryLinkedServiceSqlServer to import.</param>
        /// <param name="importFromId">The id of the existing DataFactoryLinkedServiceSqlServer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataFactoryLinkedServiceSqlServer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataFactoryLinkedServiceSqlServer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_sql_server#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataFactoryLinkedServiceSqlServer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataFactoryLinkedServiceSqlServer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putKeyVaultConnectionString", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultConnectionString\"}}]")]
        public virtual void PutKeyVaultConnectionString(azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultConnectionString @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultConnectionString)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyVaultPassword", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultPassword\"}}]")]
        public virtual void PutKeyVaultPassword(azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultPassword @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultPassword)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerTimeouts)}, new object[]{@value});
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

        [JsiiMethod(name: "resetConnectionString")]
        public virtual void ResetConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntegrationRuntimeName")]
        public virtual void ResetIntegrationRuntimeName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultConnectionString")]
        public virtual void ResetKeyVaultConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultPassword")]
        public virtual void ResetKeyVaultPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetParameters")]
        public virtual void ResetParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserName")]
        public virtual void ResetUserName()
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
        = GetStaticProperty<string>(typeof(azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServer))!;

        [JsiiProperty(name: "keyVaultConnectionString", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultConnectionStringOutputReference\"}")]
        public virtual azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultConnectionStringOutputReference KeyVaultConnectionString
        {
            get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultConnectionStringOutputReference>()!;
        }

        [JsiiProperty(name: "keyVaultPassword", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultPasswordOutputReference\"}")]
        public virtual azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultPasswordOutputReference KeyVaultPassword
        {
            get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultPasswordOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerTimeoutsOutputReference\"}")]
        public virtual azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerTimeoutsOutputReference>()!;
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
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionStringInput
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
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integrationRuntimeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntegrationRuntimeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultConnectionStringInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultConnectionString\"}", isOptional: true)]
        public virtual azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultConnectionString? KeyVaultConnectionStringInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultConnectionString?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultPasswordInput", typeJson: "{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerKeyVaultPassword\"}", isOptional: true)]
        public virtual azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultPassword? KeyVaultPasswordInput
        {
            get => GetInstanceProperty<azurerm.DataFactoryLinkedServiceSqlServer.IDataFactoryLinkedServiceSqlServerKeyVaultPassword?>();
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
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataFactoryLinkedServiceSqlServer.DataFactoryLinkedServiceSqlServerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserNameInput
        {
            get => GetInstanceProperty<string?>();
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

        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionString
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

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "integrationRuntimeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntegrationRuntimeName
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

        [JsiiProperty(name: "userName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
