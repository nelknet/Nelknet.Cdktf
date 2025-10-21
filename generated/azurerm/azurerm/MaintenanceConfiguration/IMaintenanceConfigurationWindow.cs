using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceConfiguration
{
    [JsiiInterface(nativeType: typeof(IMaintenanceConfigurationWindow), fullyQualifiedName: "azurerm.maintenanceConfiguration.MaintenanceConfigurationWindow")]
    public interface IMaintenanceConfigurationWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#start_date_time MaintenanceConfiguration#start_date_time}.</summary>
        [JsiiProperty(name: "startDateTime", typeJson: "{\"primitive\":\"string\"}")]
        string StartDateTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#time_zone MaintenanceConfiguration#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        string TimeZone
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#duration MaintenanceConfiguration#duration}.</summary>
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Duration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#expiration_date_time MaintenanceConfiguration#expiration_date_time}.</summary>
        [JsiiProperty(name: "expirationDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ExpirationDateTime
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#recur_every MaintenanceConfiguration#recur_every}.</summary>
        [JsiiProperty(name: "recurEvery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecurEvery
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMaintenanceConfigurationWindow), fullyQualifiedName: "azurerm.maintenanceConfiguration.MaintenanceConfigurationWindow")]
        internal sealed class _Proxy : DeputyBase, azurerm.MaintenanceConfiguration.IMaintenanceConfigurationWindow
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#start_date_time MaintenanceConfiguration#start_date_time}.</summary>
            [JsiiProperty(name: "startDateTime", typeJson: "{\"primitive\":\"string\"}")]
            public string StartDateTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#time_zone MaintenanceConfiguration#time_zone}.</summary>
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeZone
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#duration MaintenanceConfiguration#duration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Duration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#expiration_date_time MaintenanceConfiguration#expiration_date_time}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "expirationDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ExpirationDateTime
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#recur_every MaintenanceConfiguration#recur_every}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "recurEvery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecurEvery
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
