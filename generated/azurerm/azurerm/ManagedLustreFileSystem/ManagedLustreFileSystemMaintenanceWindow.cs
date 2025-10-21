using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow")]
    public class ManagedLustreFileSystemMaintenanceWindow : azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#day_of_week ManagedLustreFileSystem#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#time_of_day_in_utc ManagedLustreFileSystem#time_of_day_in_utc}.</summary>
        [JsiiProperty(name: "timeOfDayInUtc", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeOfDayInUtc
        {
            get;
            set;
        }
    }
}
