using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    [JsiiInterface(nativeType: typeof(IDevTestScheduleHourlyRecurrence), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleHourlyRecurrence")]
    public interface IDevTestScheduleHourlyRecurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#minute DevTestSchedule#minute}.</summary>
        [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
        double Minute
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestScheduleHourlyRecurrence), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleHourlyRecurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestSchedule.IDevTestScheduleHourlyRecurrence
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#minute DevTestSchedule#minute}.</summary>
            [JsiiProperty(name: "minute", typeJson: "{\"primitive\":\"number\"}")]
            public double Minute
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
