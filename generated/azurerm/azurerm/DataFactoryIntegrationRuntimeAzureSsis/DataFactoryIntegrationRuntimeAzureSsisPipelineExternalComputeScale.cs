using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryIntegrationRuntimeAzureSsis
{
    [JsiiByValue(fqn: "azurerm.dataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale")]
    public class DataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale : azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#number_of_external_nodes DataFactoryIntegrationRuntimeAzureSsis#number_of_external_nodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfExternalNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfExternalNodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#number_of_pipeline_nodes DataFactoryIntegrationRuntimeAzureSsis#number_of_pipeline_nodes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "numberOfPipelineNodes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NumberOfPipelineNodes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#time_to_live DataFactoryIntegrationRuntimeAzureSsis#time_to_live}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "timeToLive", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeToLive
        {
            get;
            set;
        }
    }
}
