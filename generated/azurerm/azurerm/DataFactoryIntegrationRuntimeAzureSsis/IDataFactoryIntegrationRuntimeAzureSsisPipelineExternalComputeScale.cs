using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryIntegrationRuntimeAzureSsis
{
    [JsiiInterface(nativeType: typeof(IDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale), fullyQualifiedName: "azurerm.dataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale")]
    public interface IDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#number_of_external_nodes DataFactoryIntegrationRuntimeAzureSsis#number_of_external_nodes}.</summary>
        [JsiiProperty(name: "numberOfExternalNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfExternalNodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#number_of_pipeline_nodes DataFactoryIntegrationRuntimeAzureSsis#number_of_pipeline_nodes}.</summary>
        [JsiiProperty(name: "numberOfPipelineNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? NumberOfPipelineNodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#time_to_live DataFactoryIntegrationRuntimeAzureSsis#time_to_live}.</summary>
        [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeToLive
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale), fullyQualifiedName: "azurerm.dataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#number_of_external_nodes DataFactoryIntegrationRuntimeAzureSsis#number_of_external_nodes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfExternalNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfExternalNodes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#number_of_pipeline_nodes DataFactoryIntegrationRuntimeAzureSsis#number_of_pipeline_nodes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "numberOfPipelineNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? NumberOfPipelineNodes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#time_to_live DataFactoryIntegrationRuntimeAzureSsis#time_to_live}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeToLive
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
