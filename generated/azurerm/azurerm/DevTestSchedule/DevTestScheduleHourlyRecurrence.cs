using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.devTestSchedule.DevTestScheduleHourlyRecurrence")]
    public class DevTestScheduleHourlyRecurrence : azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#minute DevTestSchedule#minute}.</summary>
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        public double Minute
        {
            get;
            set;
        }
    }
}
