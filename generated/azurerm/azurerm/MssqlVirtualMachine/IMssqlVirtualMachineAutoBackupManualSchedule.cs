using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineAutoBackupManualSchedule), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackupManualSchedule")]
    public interface IMssqlVirtualMachineAutoBackupManualSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_frequency MssqlVirtualMachine#full_backup_frequency}.</summary>
        [JsiiProperty(name: "fullBackupFrequency", typeJson: "{\"primitive\":\"string\"}")]
        string FullBackupFrequency
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_start_hour MssqlVirtualMachine#full_backup_start_hour}.</summary>
        [JsiiProperty(name: "fullBackupStartHour", typeJson: "{\"primitive\":\"number\"}")]
        double FullBackupStartHour
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_window_in_hours MssqlVirtualMachine#full_backup_window_in_hours}.</summary>
        [JsiiProperty(name: "fullBackupWindowInHours", typeJson: "{\"primitive\":\"number\"}")]
        double FullBackupWindowInHours
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_backup_frequency_in_minutes MssqlVirtualMachine#log_backup_frequency_in_minutes}.</summary>
        [JsiiProperty(name: "logBackupFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double LogBackupFrequencyInMinutes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#days_of_week MssqlVirtualMachine#days_of_week}.</summary>
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? DaysOfWeek
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineAutoBackupManualSchedule), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackupManualSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackupManualSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_frequency MssqlVirtualMachine#full_backup_frequency}.</summary>
            [JsiiProperty(name: "fullBackupFrequency", typeJson: "{\"primitive\":\"string\"}")]
            public string FullBackupFrequency
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_start_hour MssqlVirtualMachine#full_backup_start_hour}.</summary>
            [JsiiProperty(name: "fullBackupStartHour", typeJson: "{\"primitive\":\"number\"}")]
            public double FullBackupStartHour
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_window_in_hours MssqlVirtualMachine#full_backup_window_in_hours}.</summary>
            [JsiiProperty(name: "fullBackupWindowInHours", typeJson: "{\"primitive\":\"number\"}")]
            public double FullBackupWindowInHours
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_backup_frequency_in_minutes MssqlVirtualMachine#log_backup_frequency_in_minutes}.</summary>
            [JsiiProperty(name: "logBackupFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double LogBackupFrequencyInMinutes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#days_of_week MssqlVirtualMachine#days_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? DaysOfWeek
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
