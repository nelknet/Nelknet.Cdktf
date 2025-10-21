using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ManagedLustreFileSystem
{
    [JsiiInterface(nativeType: typeof(IManagedLustreFileSystemMaintenanceWindow), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow")]
    public interface IManagedLustreFileSystemMaintenanceWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#day_of_week ManagedLustreFileSystem#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        string DayOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#time_of_day_in_utc ManagedLustreFileSystem#time_of_day_in_utc}.</summary>
        [JsiiProperty(name: "timeOfDayInUtc", typeJson: "{\"primitive\":\"string\"}")]
        string TimeOfDayInUtc
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IManagedLustreFileSystemMaintenanceWindow), fullyQualifiedName: "azurerm.managedLustreFileSystem.ManagedLustreFileSystemMaintenanceWindow")]
        internal sealed class _Proxy : DeputyBase, azurerm.ManagedLustreFileSystem.IManagedLustreFileSystemMaintenanceWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#day_of_week ManagedLustreFileSystem#day_of_week}.</summary>
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
            public string DayOfWeek
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/managed_lustre_file_system#time_of_day_in_utc ManagedLustreFileSystem#time_of_day_in_utc}.</summary>
            [JsiiProperty(name: "timeOfDayInUtc", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeOfDayInUtc
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
