using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudCustomizedAccelerator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositoryBasicAuth")]
    public class SpringCloudCustomizedAcceleratorGitRepositoryBasicAuth : azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositoryBasicAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#password SpringCloudCustomizedAccelerator#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#username SpringCloudCustomizedAccelerator#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
