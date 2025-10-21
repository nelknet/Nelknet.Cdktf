using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotThingGroup
{
    [JsiiByValue(fqn: "aws.iotThingGroup.IotThingGroupPropertiesAttributePayload")]
    public class IotThingGroupPropertiesAttributePayload : aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#attributes IotThingGroup#attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Attributes
        {
            get;
            set;
        }
    }
}
