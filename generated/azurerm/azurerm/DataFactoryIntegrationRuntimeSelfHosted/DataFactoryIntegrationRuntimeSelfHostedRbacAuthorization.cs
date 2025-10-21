using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataFactoryIntegrationRuntimeSelfHosted
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.dataFactoryIntegrationRuntimeSelfHosted.DataFactoryIntegrationRuntimeSelfHostedRbacAuthorization")]
    public class DataFactoryIntegrationRuntimeSelfHostedRbacAuthorization : azurerm.DataFactoryIntegrationRuntimeSelfHosted.IDataFactoryIntegrationRuntimeSelfHostedRbacAuthorization
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_self_hosted#resource_id DataFactoryIntegrationRuntimeSelfHosted#resource_id}.</summary>
        [JsiiProperty(name: "resourceId", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceId
        {
            get;
            set;
        }
    }
}
