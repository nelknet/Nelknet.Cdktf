using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermResourceGroupTemplateDeployment
{
    [JsiiByValue(fqn: "azurerm.dataAzurermResourceGroupTemplateDeployment.DataAzurermResourceGroupTemplateDeploymentTimeouts")]
    public class DataAzurermResourceGroupTemplateDeploymentTimeouts : azurerm.DataAzurermResourceGroupTemplateDeployment.IDataAzurermResourceGroupTemplateDeploymentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/resource_group_template_deployment#read DataAzurermResourceGroupTemplateDeployment#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
