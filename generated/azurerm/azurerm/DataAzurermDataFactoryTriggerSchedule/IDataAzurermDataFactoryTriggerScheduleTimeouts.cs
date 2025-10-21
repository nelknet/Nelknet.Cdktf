using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataFactoryTriggerSchedule
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataFactoryTriggerScheduleTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleTimeouts")]
    public interface IDataAzurermDataFactoryTriggerScheduleTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedule#read DataAzurermDataFactoryTriggerSchedule#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataFactoryTriggerScheduleTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataFactoryTriggerSchedule.DataAzurermDataFactoryTriggerScheduleTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataFactoryTriggerSchedule.IDataAzurermDataFactoryTriggerScheduleTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedule#read DataAzurermDataFactoryTriggerSchedule#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
