using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudApp
{
    [JsiiInterface(nativeType: typeof(ISpringCloudAppPersistentDisk), fullyQualifiedName: "azurerm.springCloudApp.SpringCloudAppPersistentDisk")]
    public interface ISpringCloudAppPersistentDisk
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#size_in_gb SpringCloudApp#size_in_gb}.</summary>
        [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
        double SizeInGb
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#mount_path SpringCloudApp#mount_path}.</summary>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudAppPersistentDisk), fullyQualifiedName: "azurerm.springCloudApp.SpringCloudAppPersistentDisk")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudApp.ISpringCloudAppPersistentDisk
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#size_in_gb SpringCloudApp#size_in_gb}.</summary>
            [JsiiProperty(name: "sizeInGb", typeJson: "{\"primitive\":\"number\"}")]
            public double SizeInGb
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#mount_path SpringCloudApp#mount_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
