using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryTriggerTumblingWindow
{
    [JsiiByValue(fqn: "azurerm.dataFactoryTriggerTumblingWindow.DataFactoryTriggerTumblingWindowTriggerDependency")]
    public class DataFactoryTriggerTumblingWindowTriggerDependency : azurerm.DataFactoryTriggerTumblingWindow.IDataFactoryTriggerTumblingWindowTriggerDependency
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#offset DataFactoryTriggerTumblingWindow#offset}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "offset", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Offset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#size DataFactoryTriggerTumblingWindow#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Size
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_trigger_tumbling_window#trigger_name DataFactoryTriggerTumblingWindow#trigger_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "triggerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TriggerName
        {
            get;
            set;
        }
    }
}
