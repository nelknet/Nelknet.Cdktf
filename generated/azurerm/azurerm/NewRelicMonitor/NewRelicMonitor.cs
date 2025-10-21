using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor azurerm_new_relic_monitor}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NewRelicMonitor.NewRelicMonitor), fullyQualifiedName: "azurerm.newRelicMonitor.NewRelicMonitor", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorConfig\"}}]")]
    public class NewRelicMonitor : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor azurerm_new_relic_monitor} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NewRelicMonitor(Constructs.Construct scope, string id, azurerm.NewRelicMonitor.INewRelicMonitorConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NewRelicMonitor.INewRelicMonitorConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NewRelicMonitor(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NewRelicMonitor(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a NewRelicMonitor resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NewRelicMonitor to import.</param>
        /// <param name="importFromId">The id of the existing NewRelicMonitor that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NewRelicMonitor to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NewRelicMonitor to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NewRelicMonitor that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NewRelicMonitor to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.NewRelicMonitor.NewRelicMonitor), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putIdentity", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorIdentity\"}}]")]
        public virtual void PutIdentity(azurerm.NewRelicMonitor.INewRelicMonitorIdentity @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NewRelicMonitor.INewRelicMonitorIdentity)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPlan", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorPlan\"}}]")]
        public virtual void PutPlan(azurerm.NewRelicMonitor.INewRelicMonitorPlan @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NewRelicMonitor.INewRelicMonitorPlan)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NewRelicMonitor.INewRelicMonitorTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NewRelicMonitor.INewRelicMonitorTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUser", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorUser\"}}]")]
        public virtual void PutUser(azurerm.NewRelicMonitor.INewRelicMonitorUser @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NewRelicMonitor.INewRelicMonitorUser)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountCreationSource")]
        public virtual void ResetAccountCreationSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
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

        [JsiiMethod(name: "resetIngestionKey")]
        public virtual void ResetIngestionKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrganizationId")]
        public virtual void ResetOrganizationId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrgCreationSource")]
        public virtual void ResetOrgCreationSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserId")]
        public virtual void ResetUserId()
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
        = GetStaticProperty<string>(typeof(azurerm.NewRelicMonitor.NewRelicMonitor))!;

        [JsiiProperty(name: "identity", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorIdentityOutputReference\"}")]
        public virtual azurerm.NewRelicMonitor.NewRelicMonitorIdentityOutputReference Identity
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.NewRelicMonitorIdentityOutputReference>()!;
        }

        [JsiiProperty(name: "plan", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorPlanOutputReference\"}")]
        public virtual azurerm.NewRelicMonitor.NewRelicMonitorPlanOutputReference Plan
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.NewRelicMonitorPlanOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorTimeoutsOutputReference\"}")]
        public virtual azurerm.NewRelicMonitor.NewRelicMonitorTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.NewRelicMonitorTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorUserOutputReference\"}")]
        public virtual azurerm.NewRelicMonitor.NewRelicMonitorUserOutputReference User
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.NewRelicMonitorUserOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountCreationSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountCreationSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityInput", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorIdentity\"}", isOptional: true)]
        public virtual azurerm.NewRelicMonitor.INewRelicMonitorIdentity? IdentityInput
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.INewRelicMonitorIdentity?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ingestionKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IngestionKeyInput
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
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "organizationIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrganizationIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orgCreationSourceInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OrgCreationSourceInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "planInput", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorPlan\"}", isOptional: true)]
        public virtual azurerm.NewRelicMonitor.INewRelicMonitorPlan? PlanInput
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.INewRelicMonitorPlan?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userInput", typeJson: "{\"fqn\":\"azurerm.newRelicMonitor.NewRelicMonitorUser\"}", isOptional: true)]
        public virtual azurerm.NewRelicMonitor.INewRelicMonitorUser? UserInput
        {
            get => GetInstanceProperty<azurerm.NewRelicMonitor.INewRelicMonitorUser?>();
        }

        [JsiiProperty(name: "accountCreationSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountCreationSource
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
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

        [JsiiProperty(name: "ingestionKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IngestionKey
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

        [JsiiProperty(name: "organizationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrganizationId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "orgCreationSource", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OrgCreationSource
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

        [JsiiProperty(name: "userId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
