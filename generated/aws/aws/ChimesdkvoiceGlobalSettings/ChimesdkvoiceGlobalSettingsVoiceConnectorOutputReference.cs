using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceGlobalSettings
{
    [JsiiClass(nativeType: typeof(aws.ChimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference), fullyQualifiedName: "aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimesdkvoiceGlobalSettingsVoiceConnectorOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCdrBucket")]
        public virtual void ResetCdrBucket()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "cdrBucketInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CdrBucketInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "cdrBucket", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CdrBucket
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.chimesdkvoiceGlobalSettings.ChimesdkvoiceGlobalSettingsVoiceConnector\"}", isOptional: true)]
        public virtual aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector? InternalValue
        {
            get => GetInstanceProperty<aws.ChimesdkvoiceGlobalSettings.IChimesdkvoiceGlobalSettingsVoiceConnector?>();
            set => SetInstanceProperty(value);
        }
    }
}
