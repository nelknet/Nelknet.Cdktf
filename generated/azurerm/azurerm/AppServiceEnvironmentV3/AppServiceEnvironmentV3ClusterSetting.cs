using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceEnvironmentV3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appServiceEnvironmentV3.AppServiceEnvironmentV3ClusterSetting")]
    public class AppServiceEnvironmentV3ClusterSetting : azurerm.AppServiceEnvironmentV3.IAppServiceEnvironmentV3ClusterSetting
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#name AppServiceEnvironmentV3#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_environment_v3#value AppServiceEnvironmentV3#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
