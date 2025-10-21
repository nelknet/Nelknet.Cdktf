using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodepipelineCustomActionType
{
    [JsiiClass(nativeType: typeof(aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeSettingsOutputReference), fullyQualifiedName: "aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CodepipelineCustomActionTypeSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CodepipelineCustomActionTypeSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CodepipelineCustomActionTypeSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CodepipelineCustomActionTypeSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetEntityUrlTemplate")]
        public virtual void ResetEntityUrlTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetExecutionUrlTemplate")]
        public virtual void ResetExecutionUrlTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevisionUrlTemplate")]
        public virtual void ResetRevisionUrlTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThirdPartyConfigurationUrl")]
        public virtual void ResetThirdPartyConfigurationUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "entityUrlTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EntityUrlTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionUrlTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionUrlTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revisionUrlTemplateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RevisionUrlTemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thirdPartyConfigurationUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ThirdPartyConfigurationUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "entityUrlTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EntityUrlTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionUrlTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionUrlTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "revisionUrlTemplate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevisionUrlTemplate
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thirdPartyConfigurationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThirdPartyConfigurationUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.codepipelineCustomActionType.CodepipelineCustomActionTypeSettings\"}", isOptional: true)]
        public virtual aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings? InternalValue
        {
            get => GetInstanceProperty<aws.CodepipelineCustomActionType.ICodepipelineCustomActionTypeSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
