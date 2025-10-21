using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    [JsiiInterface(nativeType: typeof(IDevTestScheduleConfig), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleConfig")]
    public interface IDevTestScheduleConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#lab_name DevTestSchedule#lab_name}.</summary>
        [JsiiProperty(name: "labName", typeJson: "{\"primitive\":\"string\"}")]
        string LabName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#location DevTestSchedule#location}.</summary>
        [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
        string Location
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#name DevTestSchedule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>notification_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#notification_settings DevTestSchedule#notification_settings}
        /// </remarks>
        [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleNotificationSettings\"}")]
        azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings NotificationSettings
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#resource_group_name DevTestSchedule#resource_group_name}.</summary>
        [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceGroupName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#task_type DevTestSchedule#task_type}.</summary>
        [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
        string TaskType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time_zone_id DevTestSchedule#time_zone_id}.</summary>
        [JsiiProperty(name: "timeZoneId", typeJson: "{\"primitive\":\"string\"}")]
        string TimeZoneId
        {
            get;
        }

        /// <summary>daily_recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#daily_recurrence DevTestSchedule#daily_recurrence}
        /// </remarks>
        [JsiiProperty(name: "dailyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleDailyRecurrence\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence? DailyRecurrence
        {
            get
            {
                return null;
            }
        }

        /// <summary>hourly_recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#hourly_recurrence DevTestSchedule#hourly_recurrence}
        /// </remarks>
        [JsiiProperty(name: "hourlyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleHourlyRecurrence\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence? HourlyRecurrence
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#id DevTestSchedule#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#status DevTestSchedule#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Status
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#tags DevTestSchedule#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeouts block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#timeouts DevTestSchedule#timeouts}
        /// </remarks>
        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleTimeouts\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DevTestSchedule.IDevTestScheduleTimeouts? Timeouts
        {
            get
            {
                return null;
            }
        }

        /// <summary>weekly_recurrence block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#weekly_recurrence DevTestSchedule#weekly_recurrence}
        /// </remarks>
        [JsiiProperty(name: "weeklyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrence\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence? WeeklyRecurrence
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestScheduleConfig), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleConfig")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestSchedule.IDevTestScheduleConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#lab_name DevTestSchedule#lab_name}.</summary>
            [JsiiProperty(name: "labName", typeJson: "{\"primitive\":\"string\"}")]
            public string LabName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#location DevTestSchedule#location}.</summary>
            [JsiiProperty(name: "location", typeJson: "{\"primitive\":\"string\"}")]
            public string Location
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#name DevTestSchedule#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>notification_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#notification_settings DevTestSchedule#notification_settings}
            /// </remarks>
            [JsiiProperty(name: "notificationSettings", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleNotificationSettings\"}")]
            public azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings NotificationSettings
            {
                get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleNotificationSettings>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#resource_group_name DevTestSchedule#resource_group_name}.</summary>
            [JsiiProperty(name: "resourceGroupName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceGroupName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#task_type DevTestSchedule#task_type}.</summary>
            [JsiiProperty(name: "taskType", typeJson: "{\"primitive\":\"string\"}")]
            public string TaskType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time_zone_id DevTestSchedule#time_zone_id}.</summary>
            [JsiiProperty(name: "timeZoneId", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeZoneId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>daily_recurrence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#daily_recurrence DevTestSchedule#daily_recurrence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dailyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleDailyRecurrence\"}", isOptional: true)]
            public azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence? DailyRecurrence
            {
                get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence?>();
            }

            /// <summary>hourly_recurrence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#hourly_recurrence DevTestSchedule#hourly_recurrence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hourlyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleHourlyRecurrence\"}", isOptional: true)]
            public azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence? HourlyRecurrence
            {
                get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#id DevTestSchedule#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#status DevTestSchedule#status}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Status
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#tags DevTestSchedule#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>timeouts block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#timeouts DevTestSchedule#timeouts}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleTimeouts\"}", isOptional: true)]
            public azurerm.DevTestSchedule.IDevTestScheduleTimeouts? Timeouts
            {
                get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleTimeouts?>();
            }

            /// <summary>weekly_recurrence block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#weekly_recurrence DevTestSchedule#weekly_recurrence}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weeklyRecurrence", typeJson: "{\"fqn\":\"azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrence\"}", isOptional: true)]
            public azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence? WeeklyRecurrence
            {
                get => GetInstanceProperty<azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
