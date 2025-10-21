using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudCustomizedAccelerator
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudCustomizedAccelerator.SpringCloudCustomizedAcceleratorGitRepositorySshAuth")]
    public class SpringCloudCustomizedAcceleratorGitRepositorySshAuth : azurerm.SpringCloudCustomizedAccelerator.ISpringCloudCustomizedAcceleratorGitRepositorySshAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#private_key SpringCloudCustomizedAccelerator#private_key}.</summary>
        [JsiiProperty(name: "privateKey", typeJson: "{\"primitive\":\"string\"}")]
        public string PrivateKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#host_key SpringCloudCustomizedAccelerator#host_key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostKey
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_customized_accelerator#host_key_algorithm SpringCloudCustomizedAccelerator#host_key_algorithm}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "hostKeyAlgorithm", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? HostKeyAlgorithm
        {
            get;
            set;
        }
    }
}
