using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfigurationFeature
{
    [JsiiInterface(nativeType: typeof(IAppConfigurationFeatureTargetingFilter), fullyQualifiedName: "azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilter")]
    public interface IAppConfigurationFeatureTargetingFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#default_rollout_percentage AppConfigurationFeature#default_rollout_percentage}.</summary>
        [JsiiProperty(name: "defaultRolloutPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double DefaultRolloutPercentage
        {
            get;
        }

        /// <summary>groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#groups AppConfigurationFeature#groups}
        /// </remarks>
        [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilterGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Groups
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#users AppConfigurationFeature#users}.</summary>
        [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Users
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppConfigurationFeatureTargetingFilter), fullyQualifiedName: "azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilter")]
        internal sealed class _Proxy : DeputyBase, azurerm.AppConfigurationFeature.IAppConfigurationFeatureTargetingFilter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#default_rollout_percentage AppConfigurationFeature#default_rollout_percentage}.</summary>
            [JsiiProperty(name: "defaultRolloutPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double DefaultRolloutPercentage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#groups AppConfigurationFeature#groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.appConfigurationFeature.AppConfigurationFeatureTargetingFilterGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Groups
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#users AppConfigurationFeature#users}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "users", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Users
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
