using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryTriggerSchedule
{
    [JsiiInterface(nativeType: typeof(IDataFactoryTriggerScheduleScheduleMonthly), fullyQualifiedName: "azurerm.dataFactoryTriggerSchedule.DataFactoryTriggerScheduleScheduleMonthly")]
    public interface IDataFactoryTriggerScheduleScheduleMonthly
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#weekday DataFactoryTriggerSchedule#weekday}.</summary>
        [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}")]
        string Weekday
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#week DataFactoryTriggerSchedule#week}.</summary>
        [JsiiProperty(name: "week", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Week
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryTriggerScheduleScheduleMonthly), fullyQualifiedName: "azurerm.dataFactoryTriggerSchedule.DataFactoryTriggerScheduleScheduleMonthly")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryTriggerSchedule.IDataFactoryTriggerScheduleScheduleMonthly
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#weekday DataFactoryTriggerSchedule#weekday}.</summary>
            [JsiiProperty(name: "weekday", typeJson: "{\"primitive\":\"string\"}")]
            public string Weekday
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_schedule#week DataFactoryTriggerSchedule#week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "week", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Week
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
