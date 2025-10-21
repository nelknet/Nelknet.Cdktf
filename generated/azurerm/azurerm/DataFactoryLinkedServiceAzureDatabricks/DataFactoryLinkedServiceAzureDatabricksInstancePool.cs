using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryLinkedServiceAzureDatabricks
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryLinkedServiceAzureDatabricks.DataFactoryLinkedServiceAzureDatabricksInstancePool")]
    public class DataFactoryLinkedServiceAzureDatabricksInstancePool : azurerm.DataFactoryLinkedServiceAzureDatabricks.IDataFactoryLinkedServiceAzureDatabricksInstancePool
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#cluster_version DataFactoryLinkedServiceAzureDatabricks#cluster_version}.</summary>
        [JsiiProperty(name: "clusterVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string ClusterVersion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#instance_pool_id DataFactoryLinkedServiceAzureDatabricks#instance_pool_id}.</summary>
        [JsiiProperty(name: "instancePoolId", typeJson: "{\"primitive\":\"string\"}")]
        public string InstancePoolId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#max_number_of_workers DataFactoryLinkedServiceAzureDatabricks#max_number_of_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxNumberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MaxNumberOfWorkers
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_databricks#min_number_of_workers DataFactoryLinkedServiceAzureDatabricks#min_number_of_workers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minNumberOfWorkers", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinNumberOfWorkers
        {
            get;
            set;
        }
    }
}
