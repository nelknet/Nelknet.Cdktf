using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudBuildDeployment
{
    [JsiiByValue(fqn: "azurerm.springCloudBuildDeployment.SpringCloudBuildDeploymentQuota")]
    public class SpringCloudBuildDeploymentQuota : azurerm.SpringCloudBuildDeployment.ISpringCloudBuildDeploymentQuota
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#cpu SpringCloudBuildDeployment#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_build_deployment#memory SpringCloudBuildDeployment#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Memory
        {
            get;
            set;
        }
    }
}
