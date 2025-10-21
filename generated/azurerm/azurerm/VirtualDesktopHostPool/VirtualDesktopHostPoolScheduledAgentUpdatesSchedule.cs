using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.VirtualDesktopHostPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.virtualDesktopHostPool.VirtualDesktopHostPoolScheduledAgentUpdatesSchedule")]
    public class VirtualDesktopHostPoolScheduledAgentUpdatesSchedule : azurerm.VirtualDesktopHostPool.IVirtualDesktopHostPoolScheduledAgentUpdatesSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#day_of_week VirtualDesktopHostPool#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/virtual_desktop_host_pool#hour_of_day VirtualDesktopHostPool#hour_of_day}.</summary>
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
        public double HourOfDay
        {
            get;
            set;
        }
    }
}
