using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MonitorActionGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.monitorActionGroup.MonitorActionGroupVoiceReceiver")]
    public class MonitorActionGroupVoiceReceiver : azurerm.MonitorActionGroup.IMonitorActionGroupVoiceReceiver
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#country_code MonitorActionGroup#country_code}.</summary>
        [JsiiProperty(name: "countryCode", typeJson: "{\"primitive\":\"string\"}")]
        public string CountryCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#name MonitorActionGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_action_group#phone_number MonitorActionGroup#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
