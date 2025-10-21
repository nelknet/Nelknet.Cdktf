using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DevTestSchedule
{
    [JsiiInterface(nativeType: typeof(IDevTestScheduleDailyRecurrence), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleDailyRecurrence")]
    public interface IDevTestScheduleDailyRecurrence
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_test_schedule#time DevTestSchedule#time}.</summary>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"string\"}")]
        string Time
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDevTestScheduleDailyRecurrence), fullyQualifiedName: "azurerm.devTestSchedule.DevTestScheduleDailyRecurrence")]
        internal sealed class _Proxy : DeputyBase, azurerm.DevTestSchedule.IDevTestScheduleDailyRecurrence
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
        }
    }
}
