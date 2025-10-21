using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotThingGroup
{
    [JsiiClass(nativeType: typeof(aws.IotThingGroup.IotThingGroupPropertiesOutputReference), fullyQualifiedName: "aws.iotThingGroup.IotThingGroupPropertiesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotThingGroupPropertiesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotThingGroupPropertiesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingGroupPropertiesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotThingGroupPropertiesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAttributePayload", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotThingGroup.IotThingGroupPropertiesAttributePayload\"}}]")]
        public virtual void PutAttributePayload(aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAttributePayload")]
        public virtual void ResetAttributePayload()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "attributePayload", typeJson: "{\"fqn\":\"aws.iotThingGroup.IotThingGroupPropertiesAttributePayloadOutputReference\"}")]
        public virtual aws.IotThingGroup.IotThingGroupPropertiesAttributePayloadOutputReference AttributePayload
        {
            get => GetInstanceProperty<aws.IotThingGroup.IotThingGroupPropertiesAttributePayloadOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributePayloadInput", typeJson: "{\"fqn\":\"aws.iotThingGroup.IotThingGroupPropertiesAttributePayload\"}", isOptional: true)]
        public virtual aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload? AttributePayloadInput
        {
            get => GetInstanceProperty<aws.IotThingGroup.IIotThingGroupPropertiesAttributePayload?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iotThingGroup.IotThingGroupProperties\"}", isOptional: true)]
        public virtual aws.IotThingGroup.IIotThingGroupProperties? InternalValue
        {
            get => GetInstanceProperty<aws.IotThingGroup.IIotThingGroupProperties?>();
            set => SetInstanceProperty(value);
        }
    }
}
