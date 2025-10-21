using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MysqlFlexibleServer
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server azurerm_mysql_flexible_server}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.MysqlFlexibleServer.MysqlFlexibleServer), fullyQualifiedName: "azurerm.mysqlFlexibleServer.MysqlFlexibleServer", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerConfig\"}}]")]
    public class MysqlFlexibleServer : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server azurerm_mysql_flexible_server} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public MysqlFlexibleServer(Constructs.Construct scope, string id, azurerm.MysqlFlexibleServer.IMysqlFlexibleServerConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.MysqlFlexibleServer.IMysqlFlexibleServerConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlFlexibleServer(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MysqlFlexibleServer(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a MysqlFlexibleServer resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the MysqlFlexibleServer to import.</param>
        /// <param name="importFromId">The id of the existing MysqlFlexibleServer that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the MysqlFlexibleServer to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the MysqlFlexibleServer to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mysql_flexible_server#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing MysqlFlexibleServer that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the MysqlFlexibleServer to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.MysqlFlexibleServer.MysqlFlexibleServer), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putCustomerManagedKey", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerCustomerManagedKey\"}}]")]
        public virtual void PutCustomerManagedKey(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerCustomerManagedKey @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerCustomerManagedKey)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHighAvailability", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerHighAvailability\"}}]")]
        public virtual void PutHighAvailability(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerHighAvailability @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerHighAvailability)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMaintenanceWindow", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindow\"}}]")]
        public virtual void PutMaintenanceWindow(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerMaintenanceWindow @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerMaintenanceWindow)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStorage", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerStorage\"}}]")]
        public virtual void PutStorage(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerStorage @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerStorage)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.MysqlFlexibleServer.IMysqlFlexibleServerTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdministratorLogin")]
        public virtual void ResetAdministratorLogin()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdministratorPassword")]
        public virtual void ResetAdministratorPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBackupRetentionDays")]
        public virtual void ResetBackupRetentionDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCreateMode")]
        public virtual void ResetCreateMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomerManagedKey")]
        public virtual void ResetCustomerManagedKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDelegatedSubnetId")]
        public virtual void ResetDelegatedSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoRedundantBackupEnabled")]
        public virtual void ResetGeoRedundantBackupEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHighAvailability")]
        public virtual void ResetHighAvailability()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdentity")]
        public virtual void ResetIdentity()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMaintenanceWindow")]
        public virtual void ResetMaintenanceWindow()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPointInTimeRestoreTimeInUtc")]
        public virtual void ResetPointInTimeRestoreTimeInUtc()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrivateDnsZoneId")]
        public virtual void ResetPrivateDnsZoneId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationRole")]
        public virtual void ResetReplicationRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSkuName")]
        public virtual void ResetSkuName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceServerId")]
        public virtual void ResetSourceServerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorage")]
        public virtual void ResetStorage()
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

        [JsiiMethod(name: "resetVersion")]
        public virtual void ResetVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetZone")]
        public virtual void ResetZone()
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
        = GetStaticProperty<string>(typeof(azurerm.MysqlFlexibleServer.MysqlFlexibleServer))!;

        [JsiiProperty(name: "customerManagedKey", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerCustomerManagedKeyOutputReference\"}")]
        public virtual azurerm.MysqlFlexibleServer.MysqlFlexibleServerCustomerManagedKeyOutputReference CustomerManagedKey
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.MysqlFlexibleServerCustomerManagedKeyOutputReference>()!;
        }

        [JsiiProperty(name: "fqdn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Fqdn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "highAvailability", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerHighAvailabilityOutputReference\"}")]
        public virtual azurerm.MysqlFlexibleServer.MysqlFlexibleServerHighAvailabilityOutputReference HighAvailability
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.MysqlFlexibleServerHighAvailabilityOutputReference>()!;
        }

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerIdentityOutputReference\"}")]
        public virtual azurerm.MysqlFlexibleServer.MysqlFlexibleServerIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.MysqlFlexibleServerIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindowOutputReference\"}")]
        public virtual azurerm.MysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindowOutputReference MaintenanceWindow
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindowOutputReference>()!;
        }

        [JsiiProperty(name: "publicNetworkAccessEnabled", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable PublicNetworkAccessEnabled
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "replicaCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicaCapacity
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "storage", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerStorageOutputReference\"}")]
        public virtual azurerm.MysqlFlexibleServer.MysqlFlexibleServerStorageOutputReference Storage
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.MysqlFlexibleServerStorageOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerTimeoutsOutputReference\"}")]
        public virtual azurerm.MysqlFlexibleServer.MysqlFlexibleServerTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.MysqlFlexibleServerTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorLoginInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorLoginInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "backupRetentionDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BackupRetentionDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "createModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customerManagedKeyInput", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerCustomerManagedKey\"}", isOptional: true)]
        public virtual azurerm.MysqlFlexibleServer.IMysqlFlexibleServerCustomerManagedKey? CustomerManagedKeyInput
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.IMysqlFlexibleServerCustomerManagedKey?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "delegatedSubnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DelegatedSubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoRedundantBackupEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? GeoRedundantBackupEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "highAvailabilityInput", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerHighAvailability\"}", isOptional: true)]
        public virtual azurerm.MysqlFlexibleServer.IMysqlFlexibleServerHighAvailability? HighAvailabilityInput
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.IMysqlFlexibleServerHighAvailability?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerIdentity\"}", isOptional: true)]
        public virtual azurerm.MysqlFlexibleServer.IMysqlFlexibleServerIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.IMysqlFlexibleServerIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindowInput", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerMaintenanceWindow\"}", isOptional: true)]
        public virtual azurerm.MysqlFlexibleServer.IMysqlFlexibleServerMaintenanceWindow? MaintenanceWindowInput
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.IMysqlFlexibleServerMaintenanceWindow?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pointInTimeRestoreTimeInUtcInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PointInTimeRestoreTimeInUtcInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "privateDnsZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PrivateDnsZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ReplicationRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceServerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceServerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageInput", typeJson: "{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerStorage\"}", isOptional: true)]
        public virtual azurerm.MysqlFlexibleServer.IMysqlFlexibleServerStorage? StorageInput
        {
            get => GetInstanceProperty<azurerm.MysqlFlexibleServer.IMysqlFlexibleServerStorage?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.mysqlFlexibleServer.MysqlFlexibleServerTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "versionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "zoneInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ZoneInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "administratorLogin", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorLogin
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "administratorPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "backupRetentionDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BackupRetentionDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "createMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreateMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "delegatedSubnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DelegatedSubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "geoRedundantBackupEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object GeoRedundantBackupEnabled
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

        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Location
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

        [JsiiProperty(name: "pointInTimeRestoreTimeInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PointInTimeRestoreTimeInUtc
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "privateDnsZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateDnsZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ReplicationRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "skuName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SkuName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sourceServerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceServerId
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

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Version
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Zone
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
