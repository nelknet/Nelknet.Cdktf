using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Kinesisanalyticsv2Application
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup")]
    public class Kinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup : aws.Kinesisanalyticsv2Application.IKinesisanalyticsv2ApplicationApplicationConfigurationEnvironmentPropertiesPropertyGroup
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#property_group_id Kinesisanalyticsv2Application#property_group_id}.</summary>
        [JsiiProperty(name: "propertyGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public string PropertyGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#property_map Kinesisanalyticsv2Application#property_map}.</summary>
        [JsiiProperty(name: "propertyMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> PropertyMap
        {
            get;
            set;
        }
    }
}
