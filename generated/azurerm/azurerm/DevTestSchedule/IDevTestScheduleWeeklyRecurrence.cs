using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    [JsiiInterface(nativeType: typeof(IDevTestScheduleWeeklyRecurrence), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrence")]
    public interface IDevTestScheduleWeeklyRecurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time DevTestSchedule#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        string Time
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#week_days DevTestSchedule#week_days}.</summary>
        [JsiiProperty(name: "weekDays", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? WeekDays
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestScheduleWeeklyRecurrence), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleWeeklyRecurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestSchedule.IDevTestScheduleWeeklyRecurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time DevTestSchedule#time}.</summary>
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
            public string Time
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#week_days DevTestSchedule#week_days}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weekDays", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? WeekDays
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
