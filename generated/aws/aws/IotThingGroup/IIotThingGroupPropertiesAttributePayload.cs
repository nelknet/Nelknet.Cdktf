using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotThingGroup
{
    [JsiiInterface(nativeType: typeof(IIotThingGroupPropertiesAttributePayload), fullyQualifiedName: "aws.iotThingGroup.IotThingGroupPropertiesAttributePayload")]
    public interface IIotThingGroupPropertiesAttributePayload
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#attributes IotThingGroup#attributes}.</summary>
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Attributes
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIotThingGroupPropertiesAttributePayload), fullyQualifiedName: "aws.iotThingGroup.IotThingGroupPropertiesAttributePayload")]
        internal sealed class _Proxy : DeputyBase, aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iot_thing_group#attributes IotThingGroup#attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Attributes
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
