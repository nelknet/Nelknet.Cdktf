using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotProvisioningTemplate
{
    [JsiiClass(nativeType: typeof(aws.IotProvisioningTemplate.IotProvisioningTemplatePreProvisioningHookOutputReference), fullyQualifiedName: "aws.iotProvisioningTemplate.IotProvisioningTemplatePreProvisioningHookOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotProvisioningTemplatePreProvisioningHookOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotProvisioningTemplatePreProvisioningHookOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotProvisioningTemplatePreProvisioningHookOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotProvisioningTemplatePreProvisioningHookOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetPayloadVersion")]
        public virtual void ResetPayloadVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "payloadVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PayloadVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "targetArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TargetArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "payloadVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PayloadVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "targetArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iotProvisioningTemplate.IotProvisioningTemplatePreProvisioningHook\"}", isOptional: true)]
        public virtual aws.IotProvisioningTemplate.IIotProvisioningTemplatePreProvisioningHook? InternalValue
        {
            get => GetInstanceProperty<aws.IotProvisioningTemplate.IIotProvisioningTemplatePreProvisioningHook?>();
            set => SetInstanceProperty(value);
        }
    }
}
