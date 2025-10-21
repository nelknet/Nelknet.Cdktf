using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MaintenanceConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.maintenanceConfiguration.MaintenanceConfigurationWindow")]
    public class MaintenanceConfigurationWindow : azurerm.MaintenanceConfiguration.IMaintenanceConfigurationWindow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#start_date_time MaintenanceConfiguration#start_date_time}.</summary>
        [JsiiProperty(name: "startDateTime", typeJson: "{\"primitive\":\"string\"}")]
        public string StartDateTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#time_zone MaintenanceConfiguration#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeZone
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#duration MaintenanceConfiguration#duration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "duration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Duration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#expiration_date_time MaintenanceConfiguration#expiration_date_time}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "expirationDateTime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExpirationDateTime
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/maintenance_configuration#recur_every MaintenanceConfiguration#recur_every}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recurEvery", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RecurEvery
        {
            get;
            set;
        }
    }
}
