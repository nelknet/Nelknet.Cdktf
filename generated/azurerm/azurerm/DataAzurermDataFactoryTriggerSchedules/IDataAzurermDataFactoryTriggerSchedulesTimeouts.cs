using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermDataFactoryTriggerSchedules
{
    [JsiiInterface(nativeType: typeof(IDataAzurermDataFactoryTriggerSchedulesTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedulesTimeouts")]
    public interface IDataAzurermDataFactoryTriggerSchedulesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedules#read DataAzurermDataFactoryTriggerSchedules#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermDataFactoryTriggerSchedulesTimeouts), fullyQualifiedName: "azurerm.dataAzurermDataFactoryTriggerSchedules.DataAzurermDataFactoryTriggerSchedulesTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermDataFactoryTriggerSchedules.IDataAzurermDataFactoryTriggerSchedulesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_factory_trigger_schedules#read DataAzurermDataFactoryTriggerSchedules#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
