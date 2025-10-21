using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryFlowletDataFlow
{
    [JsiiInterface(nativeType: typeof(IDataFactoryFlowletDataFlowSink), fullyQualifiedName: "azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSink")]
    public interface IDataFactoryFlowletDataFlowSink
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#name DataFactoryFlowletDataFlow#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#dataset DataFactoryFlowletDataFlow#dataset}
        /// </remarks>
        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkDataset\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkDataset? Dataset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#description DataFactoryFlowletDataFlow#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>flowlet block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#flowlet DataFactoryFlowletDataFlow#flowlet}
        /// </remarks>
        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkFlowlet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkFlowlet? Flowlet
        {
            get
            {
                return null;
            }
        }

        /// <summary>linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#linked_service DataFactoryFlowletDataFlow#linked_service}
        /// </remarks>
        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkLinkedService? LinkedService
        {
            get
            {
                return null;
            }
        }

        /// <summary>rejected_linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#rejected_linked_service DataFactoryFlowletDataFlow#rejected_linked_service}
        /// </remarks>
        [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkRejectedLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkRejectedLinkedService? RejectedLinkedService
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema_linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#schema_linked_service DataFactoryFlowletDataFlow#schema_linked_service}
        /// </remarks>
        [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkSchemaLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkSchemaLinkedService? SchemaLinkedService
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryFlowletDataFlowSink), fullyQualifiedName: "azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSink")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSink
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#name DataFactoryFlowletDataFlow#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dataset block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#dataset DataFactoryFlowletDataFlow#dataset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkDataset\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkDataset? Dataset
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkDataset?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#description DataFactoryFlowletDataFlow#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>flowlet block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#flowlet DataFactoryFlowletDataFlow#flowlet}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkFlowlet\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkFlowlet? Flowlet
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkFlowlet?>();
            }

            /// <summary>linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#linked_service DataFactoryFlowletDataFlow#linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkLinkedService? LinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkLinkedService?>();
            }

            /// <summary>rejected_linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#rejected_linked_service DataFactoryFlowletDataFlow#rejected_linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkRejectedLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkRejectedLinkedService? RejectedLinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkRejectedLinkedService?>();
            }

            /// <summary>schema_linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#schema_linked_service DataFactoryFlowletDataFlow#schema_linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSinkSchemaLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkSchemaLinkedService? SchemaLinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSinkSchemaLinkedService?>();
            }
        }
    }
}
