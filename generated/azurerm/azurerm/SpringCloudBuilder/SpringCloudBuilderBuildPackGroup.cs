using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudBuilder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.springCloudBuilder.SpringCloudBuilderBuildPackGroup")]
    public class SpringCloudBuilderBuildPackGroup : azurerm.SpringCloudBuilder.ISpringCloudBuilderBuildPackGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#name SpringCloudBuilder#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_builder#build_pack_ids SpringCloudBuilder#build_pack_ids}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "buildPackIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? BuildPackIds
        {
            get;
            set;
        }
    }
}
