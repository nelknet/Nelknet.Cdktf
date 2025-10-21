using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDataFlow
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowSource")]
    public class DataFactoryDataFlowSource : azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#name DataFactoryDataFlow#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#dataset DataFactoryDataFlow#dataset}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceDataset\"}", isOptional: true)]
        public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset? Dataset
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#description DataFactoryDataFlow#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }

        /// <summary>flowlet block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#flowlet DataFactoryDataFlow#flowlet}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceFlowlet\"}", isOptional: true)]
        public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet? Flowlet
        {
            get;
            set;
        }

        /// <summary>linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#linked_service DataFactoryDataFlow#linked_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceLinkedService\"}", isOptional: true)]
        public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService? LinkedService
        {
            get;
            set;
        }

        /// <summary>rejected_linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#rejected_linked_service DataFactoryDataFlow#rejected_linked_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedService\"}", isOptional: true)]
        public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService? RejectedLinkedService
        {
            get;
            set;
        }

        /// <summary>schema_linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#schema_linked_service DataFactoryDataFlow#schema_linked_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedService\"}", isOptional: true)]
        public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService? SchemaLinkedService
        {
            get;
            set;
        }
    }
}
