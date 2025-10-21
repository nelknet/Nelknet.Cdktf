using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudJavaDeployment
{
    [JsiiByValue(fqn: "azurerm.springCloudJavaDeployment.SpringCloudJavaDeploymentQuota")]
    public class SpringCloudJavaDeploymentQuota : azurerm.SpringCloudJavaDeployment.ISpringCloudJavaDeploymentQuota
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#cpu SpringCloudJavaDeployment#cpu}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cpu", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Cpu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_java_deployment#memory SpringCloudJavaDeployment#memory}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "memory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Memory
        {
            get;
            set;
        }
    }
}
