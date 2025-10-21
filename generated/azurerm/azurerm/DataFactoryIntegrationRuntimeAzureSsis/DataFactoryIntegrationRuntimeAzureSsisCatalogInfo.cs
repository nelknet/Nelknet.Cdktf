using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryIntegrationRuntimeAzureSsis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisCatalogInfo")]
    public class DataFactoryIntegrationRuntimeAzureSsisCatalogInfo : azurerm.DataFactoryIntegrationRuntimeAzureSsis.IDataFactoryIntegrationRuntimeAzureSsisCatalogInfo
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#server_endpoint DataFactoryIntegrationRuntimeAzureSsis#server_endpoint}.</summary>
        [JsiiProperty(name: "serverEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string ServerEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#administrator_login DataFactoryIntegrationRuntimeAzureSsis#administrator_login}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "administratorLogin", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdministratorLogin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#administrator_password DataFactoryIntegrationRuntimeAzureSsis#administrator_password}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "administratorPassword", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AdministratorPassword
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#dual_standby_pair_name DataFactoryIntegrationRuntimeAzureSsis#dual_standby_pair_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dualStandbyPairName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DualStandbyPairName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#elastic_pool_name DataFactoryIntegrationRuntimeAzureSsis#elastic_pool_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "elasticPoolName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ElasticPoolName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#pricing_tier DataFactoryIntegrationRuntimeAzureSsis#pricing_tier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "pricingTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PricingTier
        {
            get;
            set;
        }
    }
}
