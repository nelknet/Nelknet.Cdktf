using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutomanageConfigurationBackupRetentionPolicy), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy")]
    public interface IAutomanageConfigurationBackupRetentionPolicy
    {
        /// <summary>daily_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#daily_schedule AutomanageConfiguration#daily_schedule}
        /// </remarks>
        [JsiiProperty(name: "dailySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailySchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule? DailySchedule
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_policy_type AutomanageConfiguration#retention_policy_type}.</summary>
        [JsiiProperty(name: "retentionPolicyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RetentionPolicyType
        {
            get
            {
                return null;
            }
        }

        /// <summary>weekly_schedule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#weekly_schedule AutomanageConfiguration#weekly_schedule}
        /// </remarks>
        [JsiiProperty(name: "weeklySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklySchedule\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule? WeeklySchedule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomanageConfigurationBackupRetentionPolicy), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>daily_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#daily_schedule AutomanageConfiguration#daily_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dailySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyDailySchedule\"}", isOptional: true)]
            public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule? DailySchedule
            {
                get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyDailySchedule?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_policy_type AutomanageConfiguration#retention_policy_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPolicyType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RetentionPolicyType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>weekly_schedule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#weekly_schedule AutomanageConfiguration#weekly_schedule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "weeklySchedule", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklySchedule\"}", isOptional: true)]
            public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule? WeeklySchedule
            {
                get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule?>();
            }
        }
    }
}
