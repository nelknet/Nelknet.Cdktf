using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryFlowletDataFlow
{
    [JsiiInterface(nativeType: typeof(IDataFactoryFlowletDataFlowSource), fullyQualifiedName: "azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSource")]
    public interface IDataFactoryFlowletDataFlowSource
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
        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceDataset\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceDataset? Dataset
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
        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceFlowlet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceFlowlet? Flowlet
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
        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceLinkedService? LinkedService
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
        [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceRejectedLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceRejectedLinkedService? RejectedLinkedService
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
        [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceSchemaLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceSchemaLinkedService? SchemaLinkedService
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryFlowletDataFlowSource), fullyQualifiedName: "azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSource")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSource
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
            [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceDataset\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceDataset? Dataset
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceDataset?>();
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
            [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceFlowlet\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceFlowlet? Flowlet
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceFlowlet?>();
            }

            /// <summary>linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#linked_service DataFactoryFlowletDataFlow#linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceLinkedService? LinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceLinkedService?>();
            }

            /// <summary>rejected_linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#rejected_linked_service DataFactoryFlowletDataFlow#rejected_linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rejectedLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceRejectedLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceRejectedLinkedService? RejectedLinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceRejectedLinkedService?>();
            }

            /// <summary>schema_linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_flowlet_data_flow#schema_linked_service DataFactoryFlowletDataFlow#schema_linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schemaLinkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryFlowletDataFlow.DataFactoryFlowletDataFlowSourceSchemaLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceSchemaLinkedService? SchemaLinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryFlowletDataFlow.IDataFactoryFlowletDataFlowSourceSchemaLinkedService?>();
            }
        }
    }
}
