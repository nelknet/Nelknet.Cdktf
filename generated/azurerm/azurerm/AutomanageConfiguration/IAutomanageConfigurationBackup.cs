using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutomanageConfigurationBackup), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackup")]
    public interface IAutomanageConfigurationBackup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#instant_rp_retention_range_in_days AutomanageConfiguration#instant_rp_retention_range_in_days}.</summary>
        [JsiiProperty(name: "instantRpRetentionRangeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? InstantRpRetentionRangeInDays
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#policy_name AutomanageConfiguration#policy_name}.</summary>
        [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PolicyName
        {
            get
            {
                return null;
            }
        }

        /// <summary>retention_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_policy AutomanageConfiguration#retention_policy}
        /// </remarks>
        [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy? RetentionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>schedule_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_policy AutomanageConfiguration#schedule_policy}
        /// </remarks>
        [JsiiProperty(name: "schedulePolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy? SchedulePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#time_zone AutomanageConfiguration#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeZone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomanageConfigurationBackup), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackup")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomanageConfiguration.IAutomanageConfigurationBackup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#instant_rp_retention_range_in_days AutomanageConfiguration#instant_rp_retention_range_in_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "instantRpRetentionRangeInDays", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? InstantRpRetentionRangeInDays
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#policy_name AutomanageConfiguration#policy_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "policyName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PolicyName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>retention_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_policy AutomanageConfiguration#retention_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionPolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicy\"}", isOptional: true)]
            public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy? RetentionPolicy
            {
                get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicy?>();
            }

            /// <summary>schedule_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#schedule_policy AutomanageConfiguration#schedule_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schedulePolicy", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupSchedulePolicy\"}", isOptional: true)]
            public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy? SchedulePolicy
            {
                get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupSchedulePolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#time_zone AutomanageConfiguration#time_zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
