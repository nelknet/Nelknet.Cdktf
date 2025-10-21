using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTemplate
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTemplate.QuicksightTemplateSourceEntityOutputReference), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightTemplateSourceEntityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightTemplateSourceEntityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightTemplateSourceEntityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightTemplateSourceEntityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSourceAnalysis", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysis\"}}]")]
        public virtual void PutSourceAnalysis(aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSourceTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceTemplate\"}}]")]
        public virtual void PutSourceTemplate(aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSourceAnalysis")]
        public virtual void ResetSourceAnalysis()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSourceTemplate")]
        public virtual void ResetSourceTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sourceAnalysis", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisOutputReference\"}")]
        public virtual aws.QuicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisOutputReference SourceAnalysis
        {
            get => GetInstanceProperty<aws.QuicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisOutputReference>()!;
        }

        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceTemplateOutputReference\"}")]
        public virtual aws.QuicksightTemplate.QuicksightTemplateSourceEntitySourceTemplateOutputReference SourceTemplate
        {
            get => GetInstanceProperty<aws.QuicksightTemplate.QuicksightTemplateSourceEntitySourceTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceAnalysisInput", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysis\"}", isOptional: true)]
        public virtual aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis? SourceAnalysisInput
        {
            get => GetInstanceProperty<aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTemplateInput", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceTemplate\"}", isOptional: true)]
        public virtual aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceTemplate? SourceTemplateInput
        {
            get => GetInstanceProperty<aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntity\"}", isOptional: true)]
        public virtual aws.QuicksightTemplate.IQuicksightTemplateSourceEntity? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTemplate.IQuicksightTemplateSourceEntity?>();
            set => SetInstanceProperty(value);
        }
    }
}
