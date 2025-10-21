using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatching")]
    public class MssqlVirtualMachineAutoPatching : azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#day_of_week MssqlVirtualMachine#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#maintenance_window_duration_in_minutes MssqlVirtualMachine#maintenance_window_duration_in_minutes}.</summary>
        [JsiiProperty(name: "maintenanceWindowDurationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double MaintenanceWindowDurationInMinutes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#maintenance_window_starting_hour MssqlVirtualMachine#maintenance_window_starting_hour}.</summary>
        [JsiiProperty(name: "maintenanceWindowStartingHour", typeJson: "{\"primitive\":\"number\"}")]
        public double MaintenanceWindowStartingHour
        {
            get;
            set;
        }
    }
}
