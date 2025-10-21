using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoBackupManualSchedule")]
    public class MssqlVirtualMachineAutoBackupManualSchedule : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoBackupManualSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_frequency MssqlVirtualMachine#full_backup_frequency}.</summary>
        [JsiiProperty(name: "fullBackupFrequency", typeJson: "{\"primitive\":\"string\"}")]
        public string FullBackupFrequency
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_start_hour MssqlVirtualMachine#full_backup_start_hour}.</summary>
        [JsiiProperty(name: "fullBackupStartHour", typeJson: "{\"primitive\":\"number\"}")]
        public double FullBackupStartHour
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#full_backup_window_in_hours MssqlVirtualMachine#full_backup_window_in_hours}.</summary>
        [JsiiProperty(name: "fullBackupWindowInHours", typeJson: "{\"primitive\":\"number\"}")]
        public double FullBackupWindowInHours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#log_backup_frequency_in_minutes MssqlVirtualMachine#log_backup_frequency_in_minutes}.</summary>
        [JsiiProperty(name: "logBackupFrequencyInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double LogBackupFrequencyInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#days_of_week MssqlVirtualMachine#days_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "daysOfWeek", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DaysOfWeek
        {
            get;
            set;
        }
    }
}
