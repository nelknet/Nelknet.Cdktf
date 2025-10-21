using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryDataFlow
{
    [JsiiInterface(nativeType: typeof(IDataFactoryDataFlowTransformation), fullyQualifiedName: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformation")]
    public interface IDataFactoryDataFlowTransformation
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
        [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationDataset\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationDataset? Dataset
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
        [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationFlowlet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationFlowlet? Flowlet
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
        [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationLinkedService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationLinkedService? LinkedService
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryDataFlowTransformation), fullyQualifiedName: "azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformation")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformation
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
            [JsiiProperty(name: "dataset", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationDataset\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationDataset? Dataset
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationDataset?>();
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
            [JsiiProperty(name: "flowlet", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationFlowlet\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationFlowlet? Flowlet
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationFlowlet?>();
            }

            /// <summary>linked_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_data_flow#linked_service DataFactoryDataFlow#linked_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linkedService", typeJson: "{\"fqn\":\"azurerm.dataFactoryDataFlow.DataFactoryDataFlowTransformationLinkedService\"}", isOptional: true)]
            public azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationLinkedService? LinkedService
            {
                get => GetInstanceProperty<azurerm.DataFactoryDataFlow.IDataFactoryDataFlowTransformationLinkedService?>();
            }
        }
    }
}
