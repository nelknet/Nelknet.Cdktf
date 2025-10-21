using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppConfigurationFeature
{
    [JsiiByValue(fqn: "azurerm.appConfigurationFeature.AppConfigurationFeatureTimewindowFilter")]
    public class AppConfigurationFeatureTimewindowFilter : azurerm.AppConfigurationFeature.IAppConfigurationFeatureTimewindowFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#end AppConfigurationFeature#end}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "end", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? End
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_configuration_feature#start AppConfigurationFeature#start}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Start
        {
            get;
            set;
        }
    }
}
