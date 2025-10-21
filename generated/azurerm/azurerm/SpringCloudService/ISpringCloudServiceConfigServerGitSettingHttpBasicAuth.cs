using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiInterface(nativeType: typeof(ISpringCloudServiceConfigServerGitSettingHttpBasicAuth), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuth")]
    public interface ISpringCloudServiceConfigServerGitSettingHttpBasicAuth
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#password SpringCloudService#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
        string Password
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#username SpringCloudService#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        string Username
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISpringCloudServiceConfigServerGitSettingHttpBasicAuth), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuth")]
        internal sealed class _Proxy : DeputyBase, azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingHttpBasicAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#password SpringCloudService#password}.</summary>
            [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}")]
            public string Password
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#username SpringCloudService#username}.</summary>
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
            public string Username
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
