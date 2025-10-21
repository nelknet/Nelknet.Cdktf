using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryCustomDataset
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryCustomDataset.DataFactoryCustomDatasetLinkedService")]
    public class DataFactoryCustomDatasetLinkedService : azurerm.DataFactoryCustomDataset.IDataFactoryCustomDatasetLinkedService
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#name DataFactoryCustomDataset#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_custom_dataset#parameters DataFactoryCustomDataset#parameters}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }
    }
}
