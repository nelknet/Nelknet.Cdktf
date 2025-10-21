using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfigurationFeature
{
    [JsiiInterface(nativeType: typeof(IAppConfigurationFeatureTargetingFilterGroups), fullyQualifiedName: "azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilterGroups")]
    public interface IAppConfigurationFeatureTargetingFilterGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#name AppConfigurationFeature#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#rollout_percentage AppConfigurationFeature#rollout_percentage}.</summary>
        [JsiiProperty(name: "rolloutPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double RolloutPercentage
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppConfigurationFeatureTargetingFilterGroups), fullyQualifiedName: "azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilterGroups")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppConfigurationFeature.IAppConfigurationFeatureTargetingFilterGroups
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#name AppConfigurationFeature#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#rollout_percentage AppConfigurationFeature#rollout_percentage}.</summary>
            [JsiiProperty(name: "rolloutPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double RolloutPercentage
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
