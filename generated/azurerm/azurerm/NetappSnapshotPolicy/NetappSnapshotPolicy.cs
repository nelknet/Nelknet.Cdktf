using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NetappSnapshotPolicy
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy azurerm_netapp_snapshot_policy}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.NetappSnapshotPolicy.NetappSnapshotPolicy), fullyQualifiedName: "azurerm.netappSnapshotPolicy.NetappSnapshotPolicy", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyConfig\"}}]")]
    public class NetappSnapshotPolicy : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy azurerm_netapp_snapshot_policy} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public NetappSnapshotPolicy(Constructs.Construct scope, string id, azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappSnapshotPolicy(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected NetappSnapshotPolicy(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a NetappSnapshotPolicy resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the NetappSnapshotPolicy to import.</param>
        /// <param name="importFromId">The id of the existing NetappSnapshotPolicy that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the NetappSnapshotPolicy to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the NetappSnapshotPolicy to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/netapp_snapshot_policy#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing NetappSnapshotPolicy that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the NetappSnapshotPolicy to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.NetappSnapshotPolicy.NetappSnapshotPolicy), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDailySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyDailySchedule\"}}]")]
        public virtual void PutDailySchedule(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHourlySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule\"}}]")]
        public virtual void PutHourlySchedule(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonthlySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyMonthlySchedule\"}}]")]
        public virtual void PutMonthlySchedule(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWeeklySchedule", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyWeeklySchedule\"}}]")]
        public virtual void PutWeeklySchedule(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDailySchedule")]
        public virtual void ResetDailySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHourlySchedule")]
        public virtual void ResetHourlySchedule()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonthlySchedule")]
        public virtual void ResetMonthlySchedule()
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

        [JsiiMethod(name: "resetWeeklySchedule")]
        public virtual void ResetWeeklySchedule()
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
        = GetStaticProperty<string>(typeof(azurerm.NetappSnapshotPolicy.NetappSnapshotPolicy))!;

        [JsiiProperty(name: "dailySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyDailyScheduleOutputReference\"}")]
        public virtual azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyDailyScheduleOutputReference DailySchedule
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyDailyScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "hourlySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlyScheduleOutputReference\"}")]
        public virtual azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyHourlyScheduleOutputReference HourlySchedule
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyHourlyScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "monthlySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyMonthlyScheduleOutputReference\"}")]
        public virtual azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyMonthlyScheduleOutputReference MonthlySchedule
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyMonthlyScheduleOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyTimeoutsOutputReference\"}")]
        public virtual azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyWeeklyScheduleOutputReference\"}")]
        public virtual azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyWeeklyScheduleOutputReference WeeklySchedule
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.NetappSnapshotPolicyWeeklyScheduleOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailyScheduleInput", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyDailySchedule\"}", isOptional: true)]
        public virtual azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule? DailyScheduleInput
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyDailySchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourlyScheduleInput", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyHourlySchedule\"}", isOptional: true)]
        public virtual azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule? HourlyScheduleInput
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyHourlySchedule?>();
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
        [JsiiProperty(name: "monthlyScheduleInput", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyMonthlySchedule\"}", isOptional: true)]
        public virtual azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule? MonthlyScheduleInput
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyMonthlySchedule?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
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
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyScheduleInput", typeJson: "{\"fqn\":\"azurerm.netappSnapshotPolicy.NetappSnapshotPolicyWeeklySchedule\"}", isOptional: true)]
        public virtual azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule? WeeklyScheduleInput
        {
            get => GetInstanceProperty<azurerm.NetappSnapshotPolicy.INetappSnapshotPolicyWeeklySchedule?>();
        }

        [JsiiProperty(name: "accountName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
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

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }
    }
}
