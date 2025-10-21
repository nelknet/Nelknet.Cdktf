using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ActiveDirectoryDomainService
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service azurerm_active_directory_domain_service}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainService), fullyQualifiedName: "azurerm.activeDirectoryDomainService.ActiveDirectoryDomainService", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceConfig\"}}]")]
    public class ActiveDirectoryDomainService : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service azurerm_active_directory_domain_service} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ActiveDirectoryDomainService(Constructs.Construct scope, string id, azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActiveDirectoryDomainService(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ActiveDirectoryDomainService(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a ActiveDirectoryDomainService resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the ActiveDirectoryDomainService to import.</param>
        /// <param name="importFromId">The id of the existing ActiveDirectoryDomainService that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the ActiveDirectoryDomainService to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the ActiveDirectoryDomainService to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/active_directory_domain_service#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing ActiveDirectoryDomainService that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the ActiveDirectoryDomainService to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainService), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putInitialReplicaSet", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSet\"}}]")]
        public virtual void PutInitialReplicaSet(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotifications", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceNotifications\"}}]")]
        public virtual void PutNotifications(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceNotifications @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceNotifications)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecureLdap", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdap\"}}]")]
        public virtual void PutSecureLdap(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecureLdap @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecureLdap)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSecurity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecurity\"}}]")]
        public virtual void PutSecurity(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecurity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecurity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDomainConfigurationType")]
        public virtual void ResetDomainConfigurationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilteredSyncEnabled")]
        public virtual void ResetFilteredSyncEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotifications")]
        public virtual void ResetNotifications()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecureLdap")]
        public virtual void ResetSecureLdap()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurity")]
        public virtual void ResetSecurity()
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
        = GetStaticProperty<string>(typeof(azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainService))!;

        [JsiiProperty(name: "deploymentId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "initialReplicaSet", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSetOutputReference\"}")]
        public virtual azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSetOutputReference InitialReplicaSet
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSetOutputReference>()!;
        }

        [JsiiProperty(name: "notifications", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceNotificationsOutputReference\"}")]
        public virtual azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceNotificationsOutputReference Notifications
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceNotificationsOutputReference>()!;
        }

        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "secureLdap", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdapOutputReference\"}")]
        public virtual azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdapOutputReference SecureLdap
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdapOutputReference>()!;
        }

        [JsiiProperty(name: "security", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecurityOutputReference\"}")]
        public virtual azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceSecurityOutputReference Security
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceSecurityOutputReference>()!;
        }

        [JsiiProperty(name: "syncOwner", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SyncOwner
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tenantId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TenantId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceTimeoutsOutputReference\"}")]
        public virtual azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.ActiveDirectoryDomainServiceTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Version
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainConfigurationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainConfigurationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "domainNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DomainNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filteredSyncEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? FilteredSyncEnabledInput
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
        [JsiiProperty(name: "initialReplicaSetInput", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceInitialReplicaSet\"}", isOptional: true)]
        public virtual azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet? InitialReplicaSetInput
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceInitialReplicaSet?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "locationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LocationInput
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
        [JsiiProperty(name: "notificationsInput", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceNotifications\"}", isOptional: true)]
        public virtual azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceNotifications? NotificationsInput
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceNotifications?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secureLdapInput", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecureLdap\"}", isOptional: true)]
        public virtual azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecureLdap? SecureLdapInput
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecureLdap?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityInput", typeJson: "{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceSecurity\"}", isOptional: true)]
        public virtual azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecurity? SecurityInput
        {
            get => GetInstanceProperty<azurerm.ActiveDirectoryDomainService.IActiveDirectoryDomainServiceSecurity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "skuInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SkuInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.activeDirectoryDomainService.ActiveDirectoryDomainServiceTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "domainConfigurationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainConfigurationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DomainName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "filteredSyncEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object FilteredSyncEnabled
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

        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResourceGroupName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sku", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Sku
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
    }
}
