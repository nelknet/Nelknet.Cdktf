using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotThingGroup
{
    [JsiiByValue(fqn: "aws.iotThingGroup.IotThingGroupProperties")]
    public class IotThingGroupProperties : aws.IotThingGroup.IIotThingGroupProperties
    {
        /// <summary>attribute_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#attribute_payload IotThingGroup#attribute_payload}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributePayload", typeJson: "{\"fqn\":\"aws.iotThingGroup.IotThingGroupPropertiesAttributePayload\"}", isOptional: true)]
        public aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload? AttributePayload
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#description IotThingGroup#description}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
        }
    }
}
