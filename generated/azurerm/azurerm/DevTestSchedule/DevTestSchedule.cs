using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule azurerm_dev_test_schedule}.</summary>
    [JsiiClass(nativeType: typeof(azurerm.DevTestSchedule.DevTestSchedule), fullyQualifiedName: "azurerm.devTestSchedule.DevTestSchedule", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleConfig\"}}]")]
    public class DevTestSchedule : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule azurerm_dev_test_schedule} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DevTestSchedule(Constructs.Construct scope, string id, azurerm.DevTestSchedule.IDevTestScheduleConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, azurerm.DevTestSchedule.IDevTestScheduleConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevTestSchedule(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DevTestSchedule(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a DevTestSchedule resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the DevTestSchedule to import.</param>
        /// <param name="importFromId">The id of the existing DevTestSchedule that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the DevTestSchedule to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the DevTestSchedule to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing DevTestSchedule that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the DevTestSchedule to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(azurerm.DevTestSchedule.DevTestSchedule), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDailyRecurrence", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleDailyRecurrence\"}}]")]
        public virtual void PutDailyRecurrence(azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHourlyRecurrence", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleHourlyRecurrence\"}}]")]
        public virtual void PutHourlyRecurrence(azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotificationSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleNotificationSettings\"}}]")]
        public virtual void PutNotificationSettings(azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleTimeouts\"}}]")]
        public virtual void PutTimeouts(azurerm.DevTestSchedule.IDevTestScheduleTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevTestSchedule.IDevTestScheduleTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWeeklyRecurrence", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrence\"}}]")]
        public virtual void PutWeeklyRecurrence(azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDailyRecurrence")]
        public virtual void ResetDailyRecurrence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHourlyRecurrence")]
        public virtual void ResetHourlyRecurrence()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStatus")]
        public virtual void ResetStatus()
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

        [JsiiMethod(name: "resetWeeklyRecurrence")]
        public virtual void ResetWeeklyRecurrence()
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
        = GetStaticProperty<string>(typeof(azurerm.DevTestSchedule.DevTestSchedule))!;

        [JsiiProperty(name: "dailyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleDailyRecurrenceOutputReference\"}")]
        public virtual azurerm.DevTestSchedule.DevTestScheduleDailyRecurrenceOutputReference DailyRecurrence
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.DevTestScheduleDailyRecurrenceOutputReference>()!;
        }

        [JsiiProperty(name: "hourlyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleHourlyRecurrenceOutputReference\"}")]
        public virtual azurerm.DevTestSchedule.DevTestScheduleHourlyRecurrenceOutputReference HourlyRecurrence
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.DevTestScheduleHourlyRecurrenceOutputReference>()!;
        }

        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleNotificationSettingsOutputReference\"}")]
        public virtual azurerm.DevTestSchedule.DevTestScheduleNotificationSettingsOutputReference NotificationSettings
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.DevTestScheduleNotificationSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleTimeoutsOutputReference\"}")]
        public virtual azurerm.DevTestSchedule.DevTestScheduleTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.DevTestScheduleTimeoutsOutputReference>()!;
        }

        [JsiiProperty(name: "weeklyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrenceOutputReference\"}")]
        public virtual azurerm.DevTestSchedule.DevTestScheduleWeeklyRecurrenceOutputReference WeeklyRecurrence
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.DevTestScheduleWeeklyRecurrenceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dailyRecurrenceInput", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleDailyRecurrence\"}", isOptional: true)]
        public virtual azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence? DailyRecurrenceInput
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hourlyRecurrenceInput", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleHourlyRecurrence\"}", isOptional: true)]
        public virtual azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence? HourlyRecurrenceInput
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LabNameInput
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
        [JsiiProperty(name: "notificationSettingsInput", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleNotificationSettings\"}", isOptional: true)]
        public virtual azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings? NotificationSettingsInput
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resourceGroupNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResourceGroupNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "statusInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? StatusInput
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
        [JsiiProperty(name: "taskTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TaskTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleTimeouts\"}]}}", isOptional: true)]
        public virtual object? TimeoutsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeZoneIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TimeZoneIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "weeklyRecurrenceInput", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrence\"}", isOptional: true)]
        public virtual azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence? WeeklyRecurrenceInput
        {
            get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence?>();
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "labName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LabName
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

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
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

        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TaskType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "timeZoneId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TimeZoneId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
