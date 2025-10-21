using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlVirtualMachine
{
    [JsiiInterface(nativeType: typeof(IMssqlVirtualMachineAutoPatching), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatching")]
    public interface IMssqlVirtualMachineAutoPatching
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#day_of_week MssqlVirtualMachine#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        string DayOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#maintenance_window_duration_in_minutes MssqlVirtualMachine#maintenance_window_duration_in_minutes}.</summary>
        [JsiiProperty(name: "maintenanceWindowDurationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        double MaintenanceWindowDurationInMinutes
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#maintenance_window_starting_hour MssqlVirtualMachine#maintenance_window_starting_hour}.</summary>
        [JsiiProperty(name: "maintenanceWindowStartingHour", typeJson: "{\"primitive\":\"number\"}")]
        double MaintenanceWindowStartingHour
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlVirtualMachineAutoPatching), fullyQualifiedName: "azurerm.mssqlVirtualMachine.MssqlVirtualMachineAutoPatching")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlVirtualMachine.IMssqlVirtualMachineAutoPatching
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#day_of_week MssqlVirtualMachine#day_of_week}.</summary>
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
            public string DayOfWeek
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#maintenance_window_duration_in_minutes MssqlVirtualMachine#maintenance_window_duration_in_minutes}.</summary>
            [JsiiProperty(name: "maintenanceWindowDurationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
            public double MaintenanceWindowDurationInMinutes
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine#maintenance_window_starting_hour MssqlVirtualMachine#maintenance_window_starting_hour}.</summary>
            [JsiiProperty(name: "maintenanceWindowStartingHour", typeJson: "{\"primitive\":\"number\"}")]
            public double MaintenanceWindowStartingHour
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
