using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermStorageAccountSas
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas azurerm_storage_account_sas}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSas), fullyQualifiedName: "azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSas", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasConfig\"}}]")]
    public class DataAzurermStorageAccountSas : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas azurerm_storage_account_sas} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAzurermStorageAccountSas(Constructs.Construct scope, string id, azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStorageAccountSas(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAzurermStorageAccountSas(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DataAzurermStorageAccountSas resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DataAzurermStorageAccountSas to import.</param>
        /// <param name="importFromId">The id of the existing DataAzurermStorageAccountSas that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DataAzurermStorageAccountSas to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DataAzurermStorageAccountSas to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DataAzurermStorageAccountSas that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DataAzurermStorageAccountSas to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSas), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putPermissions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissions\"}}]")]
        public virtual void PutPermissions(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasPermissions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasPermissions)}, new object[]{@value});
        }

        [JsiiMethod(name: "putResourceTypes", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypes\"}}]")]
        public virtual void PutResourceTypes(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes)}, new object[]{@value});
        }

        [JsiiMethod(name: "putServices", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasServices\"}}]")]
        public virtual void PutServices(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpsOnly")]
        public virtual void ResetHttpsOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpAddresses")]
        public virtual void ResetIpAddresses()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignedVersion")]
        public virtual void ResetSignedVersion()
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
        = GetStaticProperty<string>(typeof(azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSas))!;

        [JsiiProperty(name: "permissions", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissionsOutputReference\"}")]
        public virtual azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissionsOutputReference Permissions
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissionsOutputReference>()!;
        }

        [JsiiProperty(name: "resourceTypes", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypesOutputReference\"}")]
        public virtual azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypesOutputReference ResourceTypes
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypesOutputReference>()!;
        }

        [JsiiProperty(name: "sas", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sas
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "services", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasServicesOutputReference\"}")]
        public virtual azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasServicesOutputReference Services
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasServicesOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeoutsOutputReference\"}")]
        public virtual azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "expiryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExpiryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpsOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? HttpsOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipAddressesInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IpAddressesInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "permissionsInput", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissions\"}", isOptional: true)]
        public virtual azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasPermissions? PermissionsInput
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasPermissions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceTypesInput", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypes\"}", isOptional: true)]
        public virtual azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes? ResourceTypesInput
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasResourceTypes?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicesInput", typeJson: "{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasServices\"}", isOptional: true)]
        public virtual azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices? ServicesInput
        {
            get => GetInstanceProperty<azurerm.DataAzurermStorageAccountSas.IDataAzurermStorageAccountSasServices?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signedVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SignedVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "startInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StartInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.dataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "expiry", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Expiry
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "httpsOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object HttpsOnly
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

        [JsiiProperty(name: "ipAddresses", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IpAddresses
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "signedVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SignedVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Start
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
