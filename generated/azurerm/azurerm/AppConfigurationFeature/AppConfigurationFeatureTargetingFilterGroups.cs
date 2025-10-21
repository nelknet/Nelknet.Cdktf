using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfigurationFeature
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilterGroups")]
    public class AppConfigurationFeatureTargetingFilterGroups : azurerm.AppConfigurationFeature.IAppConfigurationFeatureTargetingFilterGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#name AppConfigurationFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#rollout_percentage AppConfigurationFeature#rollout_percentage}.</summary>
        [JsiiProperty(name: "rolloutPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double RolloutPercentage
        {
            get;
            set;
        }
    }
}
