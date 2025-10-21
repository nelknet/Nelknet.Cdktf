using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrence")]
    public class DevTestScheduleWeeklyRecurrence : azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time DevTestSchedule#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        public string Time
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#week_days DevTestSchedule#week_days}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weekDays", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? WeekDays
        {
            get;
            set;
        }
    }
}
