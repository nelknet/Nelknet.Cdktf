using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AutomanageConfiguration
{
    [JsiiInterface(nativeType: typeof(IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklySchedule")]
    public interface IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule
    {
        /// <summary>retention_duration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_duration AutomanageConfiguration#retention_duration}
        /// </remarks>
        [JsiiProperty(name: "retentionDuration", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration? RetentionDuration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_times AutomanageConfiguration#retention_times}.</summary>
        [JsiiProperty(name: "retentionTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? RetentionTimes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule), fullyQualifiedName: "azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklySchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklySchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>retention_duration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_duration AutomanageConfiguration#retention_duration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retentionDuration", typeJson: "{\"fqn\":\"azurerm.automanageConfiguration.AutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration\"}", isOptional: true)]
            public azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration? RetentionDuration
            {
                get => GetInstanceProperty<azurerm.AutomanageConfiguration.IAutomanageConfigurationBackupRetentionPolicyWeeklyScheduleRetentionDuration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automanage_configuration#retention_times AutomanageConfiguration#retention_times}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "retentionTimes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? RetentionTimes
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
