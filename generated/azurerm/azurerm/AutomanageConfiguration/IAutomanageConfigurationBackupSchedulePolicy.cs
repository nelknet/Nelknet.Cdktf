using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutomanageConfigurationBackupSchedulePolicy), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy")]
    public interface IAutomanageConfigurationBackupSchedulePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_policy_type AutomanageConfiguration#schedule_policy_type}.</summary>
        [JsiiProperty(name: "schedulePolicyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SchedulePolicyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_days AutomanageConfiguration#schedule_run_days}.</summary>
        [JsiiProperty(name: "scheduleRunDays", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ScheduleRunDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_frequency AutomanageConfiguration#schedule_run_frequency}.</summary>
        [JsiiProperty(name: "scheduleRunFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ScheduleRunFrequency
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_times AutomanageConfiguration#schedule_run_times}.</summary>
        [JsiiProperty(name: "scheduleRunTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ScheduleRunTimes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomanageConfigurationBackupSchedulePolicy), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_policy_type AutomanageConfiguration#schedule_policy_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "schedulePolicyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SchedulePolicyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_days AutomanageConfiguration#schedule_run_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleRunDays", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ScheduleRunDays
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_frequency AutomanageConfiguration#schedule_run_frequency}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleRunFrequency", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ScheduleRunFrequency
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_run_times AutomanageConfiguration#schedule_run_times}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scheduleRunTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ScheduleRunTimes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
