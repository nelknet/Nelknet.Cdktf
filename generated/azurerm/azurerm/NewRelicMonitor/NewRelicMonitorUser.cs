using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.NewRelicMonitor
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.newRelicMonitor.NewRelicMonitorUser")]
    public class NewRelicMonitorUser : azurerm.NewRelicMonitor.INewRelicMonitorUser
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#email NewRelicMonitor#email}.</summary>
        [JsiiProperty(name: "email", typeJson: "{\"primitive\":\"string\"}")]
        public string Email
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#first_name NewRelicMonitor#first_name}.</summary>
        [JsiiProperty(name: "firstName", typeJson: "{\"primitive\":\"string\"}")]
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#last_name NewRelicMonitor#last_name}.</summary>
        [JsiiProperty(name: "lastName", typeJson: "{\"primitive\":\"string\"}")]
        public string LastName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/new_relic_monitor#phone_number NewRelicMonitor#phone_number}.</summary>
        [JsiiProperty(name: "phoneNumber", typeJson: "{\"primitive\":\"string\"}")]
        public string PhoneNumber
        {
            get;
            set;
        }
    }
}
