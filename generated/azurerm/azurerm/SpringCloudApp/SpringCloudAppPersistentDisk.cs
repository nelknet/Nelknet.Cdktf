using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudApp
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudApp.SpringCloudAppPersistentDisk")]
    public class SpringCloudAppPersistentDisk : azurerm.SpringCloudApp.ISpringCloudAppPersistentDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#size_in_gb SpringCloudApp#size_in_gb}.</summary>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        public double SizeInGb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#mount_path SpringCloudApp#mount_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MountPath
        {
            get;
            set;
        }
    }
}
