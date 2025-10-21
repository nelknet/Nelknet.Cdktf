using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfigurationFeature
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilter")]
    public class AppConfigurationFeatureTargetingFilter : azurerm.AppConfigurationFeature.IAppConfigurationFeatureTargetingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#default_rollout_percentage AppConfigurationFeature#default_rollout_percentage}.</summary>
        [JsiiProperty(name: "defaultRolloutPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public double DefaultRolloutPercentage
        {
            get;
            set;
        }

        private object? _groups;

        /// <summary>groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#groups AppConfigurationFeature#groups}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilterGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Groups
        {
            get => _groups;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.AppConfigurationFeature.IAppConfigurationFeatureTargetingFilterGroups[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.AppConfigurationFeature.IAppConfigurationFeatureTargetingFilterGroups).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _groups = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#users AppConfigurationFeature#users}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Users
        {
            get;
            set;
        }
    }
}
