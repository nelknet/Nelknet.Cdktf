using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine azurerm_mssql_virtual_machine}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MssqlVirtualMachine.MssqlVirtualMachine), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachine", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineConfig\"}}]")]
    public class MssqlVirtualMachine : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine azurerm_mssql_virtual_machine} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MssqlVirtualMachine(Constructs.Construct scope, string id, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlVirtualMachine(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MssqlVirtualMachine(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MssqlVirtualMachine resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MssqlVirtualMachine to import.</param>
        /// <param name="importFromId">The id of the existing MssqlVirtualMachine that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MssqlVirtualMachine to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MssqlVirtualMachine to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MssqlVirtualMachine that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MssqlVirtualMachine to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MssqlVirtualMachine.MssqlVirtualMachine), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAssessment", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessment\"}}]")]
        public virtual void PutAssessment(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoBackup", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackup\"}}]")]
        public virtual void PutAutoBackup(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackup @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackup)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAutoPatching", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatching\"}}]")]
        public virtual void PutAutoPatching(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKeyVaultCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential\"}}]")]
        public virtual void PutKeyVaultCredential(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqlInstance", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineSqlInstance\"}}]")]
        public virtual void PutSqlInstance(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorageConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration\"}}]")]
        public virtual void PutStorageConfiguration(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWsfcDomainCredential", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential\"}}]")]
        public virtual void PutWsfcDomainCredential(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAssessment")]
        public virtual void ResetAssessment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoBackup")]
        public virtual void ResetAutoBackup()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoPatching")]
        public virtual void ResetAutoPatching()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyVaultCredential")]
        public virtual void ResetKeyVaultCredential()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRServicesEnabled")]
        public virtual void ResetRServicesEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlConnectivityPort")]
        public virtual void ResetSqlConnectivityPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlConnectivityType")]
        public virtual void ResetSqlConnectivityType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlConnectivityUpdatePassword")]
        public virtual void ResetSqlConnectivityUpdatePassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlConnectivityUpdateUsername")]
        public virtual void ResetSqlConnectivityUpdateUsername()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlInstance")]
        public virtual void ResetSqlInstance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlLicenseType")]
        public virtual void ResetSqlLicenseType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqlVirtualMachineGroupId")]
        public virtual void ResetSqlVirtualMachineGroupId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageConfiguration")]
        public virtual void ResetStorageConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWsfcDomainCredential")]
        public virtual void ResetWsfcDomainCredential()
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
        = GetStaticProperty<string>(typeof(azurerm.MssqlVirtualMachine.MssqlVirtualMachine))!;

        [JsiiProperty(name: "assessment", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessmentOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineAssessmentOutputReference Assessment
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineAssessmentOutputReference>()!;
        }

        [JsiiProperty(name: "autoBackup", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackupOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineAutoBackupOutputReference AutoBackup
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineAutoBackupOutputReference>()!;
        }

        [JsiiProperty(name: "autoPatching", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatchingOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineAutoPatchingOutputReference AutoPatching
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineAutoPatchingOutputReference>()!;
        }

        [JsiiProperty(name: "keyVaultCredential", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredentialOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredentialOutputReference KeyVaultCredential
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredentialOutputReference>()!;
        }

        [JsiiProperty(name: "sqlInstance", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineSqlInstanceOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineSqlInstanceOutputReference SqlInstance
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineSqlInstanceOutputReference>()!;
        }

        [JsiiProperty(name: "storageConfiguration", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationOutputReference StorageConfiguration
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineStorageConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineTimeoutsOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "wsfcDomainCredential", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredentialOutputReference\"}")]
        public virtual azurerm.MssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredentialOutputReference WsfcDomainCredential
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredentialOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "assessmentInput", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAssessment\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment? AssessmentInput
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAssessment?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoBackupInput", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackup\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackup? AutoBackupInput
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackup?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoPatchingInput", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatching\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching? AutoPatchingInput
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyVaultCredentialInput", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineKeyVaultCredential\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential? KeyVaultCredentialInput
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineKeyVaultCredential?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rServicesEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RServicesEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlConnectivityPortInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SqlConnectivityPortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlConnectivityTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlConnectivityTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlConnectivityUpdatePasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlConnectivityUpdatePasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlConnectivityUpdateUsernameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlConnectivityUpdateUsernameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlInstanceInput", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineSqlInstance\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance? SqlInstanceInput
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineSqlInstance?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlLicenseTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlLicenseTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqlVirtualMachineGroupIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SqlVirtualMachineGroupIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageConfigurationInput", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineStorageConfiguration\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration? StorageConfigurationInput
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineStorageConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualMachineIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "wsfcDomainCredentialInput", typeJson: "{\"fqn\":\"azurerm.mssqlVirtualMachine.MssqlVirtualMachineWsfcDomainCredential\"}", isOptional: true)]
        public virtual azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential? WsfcDomainCredentialInput
        {
            get => GetInstanceProperty<azurerm.MssqlVirtualMachine.IMssqlVirtualMachineWsfcDomainCredential?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rServicesEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object RServicesEnabled
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

        [JsiiProperty(name: "sqlConnectivityPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SqlConnectivityPort
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlConnectivityType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlConnectivityType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlConnectivityUpdatePassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlConnectivityUpdatePassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlConnectivityUpdateUsername", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlConnectivityUpdateUsername
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlLicenseType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlLicenseType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sqlVirtualMachineGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SqlVirtualMachineGroupId
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

        [JsiiProperty(name: "virtualMachineId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualMachineId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
