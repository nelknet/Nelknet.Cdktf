using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryTriggerSchedule
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryTriggerSchedule.DataFactoryTriggerScheduleScheduleMonthly")]
    public class DataFactoryTriggerScheduleScheduleMonthly : azurerm.DataFactoryTriggerSchedule.IDataFactoryTriggerScheduleScheduleMonthly
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#weekday DataFactoryTriggerSchedule#weekday}.</summary>
        [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}")]
        public string Weekday
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#week DataFactoryTriggerSchedule#week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "week", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Week
        {
            get;
            set;
        }
    }
}
