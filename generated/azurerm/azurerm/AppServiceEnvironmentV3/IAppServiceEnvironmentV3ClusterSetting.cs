using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceEnvironmentV3
{
    [JsiiInterface(nativeType: typeof(IAppServiceEnvironmentV3ClusterSetting), fullyQualifiedName: "azurerm.appServiceEnvironmentV3.AppServiceEnvironmentV3ClusterSetting")]
    public interface IAppServiceEnvironmentV3ClusterSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#name AppServiceEnvironmentV3#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#value AppServiceEnvironmentV3#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppServiceEnvironmentV3ClusterSetting), fullyQualifiedName: "azurerm.appServiceEnvironmentV3.AppServiceEnvironmentV3ClusterSetting")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppServiceEnvironmentV3.IAppServiceEnvironmentV3ClusterSetting
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#name AppServiceEnvironmentV3#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#value AppServiceEnvironmentV3#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
