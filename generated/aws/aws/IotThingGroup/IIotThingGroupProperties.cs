using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotThingGroup
{
    [JsiiInterface(nativeType: typeof(IIotThingGroupProperties), fullyQualifiedName: "aws.iotThingGroup.IotThingGroupProperties")]
    public interface IIotThingGroupProperties
    {
        /// <summary>attribute_payload block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#attribute_payload IotThingGroup#attribute_payload}
        /// </remarks>
        [JsiiProperty(name: "attributePayload", typeJson: "{\"fqn\":\"aws.iotThingGroup.IotThingGroupPropertiesAttributePayload\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload? AttributePayload
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#description IotThingGroup#description}.</summary>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotThingGroupProperties), fullyQualifiedName: "aws.iotThingGroup.IotThingGroupProperties")]
        internal sealed class _Proxy : DeputyBase, aws.IotThingGroup.IIotThingGroupProperties
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>attribute_payload block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#attribute_payload IotThingGroup#attribute_payload}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "attributePayload", typeJson: "{\"fqn\":\"aws.iotThingGroup.IotThingGroupPropertiesAttributePayload\"}", isOptional: true)]
            public aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload? AttributePayload
            {
                get => GetInstanceProperty<aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#description IotThingGroup#description}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
