using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    [JsiiByValue(fqn: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter")]
    public class IotIndexingConfigurationThingIndexingConfigurationFilter : aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_indexing_configuration#named_shadow_names IotIndexingConfiguration#named_shadow_names}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "namedShadowNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? NamedShadowNames
        {
            get;
            set;
        }
    }
}
