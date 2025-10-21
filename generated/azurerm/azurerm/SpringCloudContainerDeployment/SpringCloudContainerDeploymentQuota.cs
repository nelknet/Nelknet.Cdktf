using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudContainerDeployment
{
    [JsiiByValue(fqn: "azurerm.springCloudContainerDeployment.SpringCloudContainerDeploymentQuota")]
    public class SpringCloudContainerDeploymentQuota : azurerm.SpringCloudContainerDeployment.ISpringCloudContainerDeploymentQuota
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#cpu SpringCloudContainerDeployment#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_container_deployment#memory SpringCloudContainerDeployment#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Memory
        {
            get;
            set;
        }
    }
}
