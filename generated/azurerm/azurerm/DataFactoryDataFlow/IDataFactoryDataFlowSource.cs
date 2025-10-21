using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDataFlow
{
    [JsiiInterface(nativeType: typeof(IDataFactoryDataFlowSource), fullyQualifiedName: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowSource")]
    public interface IDataFactoryDataFlowSource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#name DataFactoryDataFlow#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>dataset block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#dataset DataFactoryDataFlow#dataset}
        /// </remarks>
        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceDataset\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset? Dataset
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#description DataFactoryDataFlow#description}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#flowlet DataFactoryDataFlow#flowlet}
        /// </remarks>
        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceFlowlet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet? Flowlet
        {
            get
            {
                return null;
            }
        }

        /// <summary>linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#linked_service DataFactoryDataFlow#linked_service}
        /// </remarks>
        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService? LinkedService
        {
            get
            {
                return null;
            }
        }

        /// <summary>rejected_linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#rejected_linked_service DataFactoryDataFlow#rejected_linked_service}
        /// </remarks>
        [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService? RejectedLinkedService
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema_linked_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#schema_linked_service DataFactoryDataFlow#schema_linked_service}
        /// </remarks>
        [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService? SchemaLinkedService
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryDataFlowSource), fullyQualifiedName: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#name DataFactoryDataFlow#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>dataset block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#dataset DataFactoryDataFlow#dataset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceDataset\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset? Dataset
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceDataset?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#description DataFactoryDataFlow#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>flowlet block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#flowlet DataFactoryDataFlow#flowlet}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceFlowlet\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet? Flowlet
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceFlowlet?>();
            }

            /// <summary>linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#linked_service DataFactoryDataFlow#linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService? LinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceLinkedService?>();
            }

            /// <summary>rejected_linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#rejected_linked_service DataFactoryDataFlow#rejected_linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceRejectedLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService? RejectedLinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceRejectedLinkedService?>();
            }

            /// <summary>schema_linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#schema_linked_service DataFactoryDataFlow#schema_linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowSourceSchemaLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService? SchemaLinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowSourceSchemaLinkedService?>();
            }
        }
    }
}
