using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiClass(nativeType: typeof(aws.QuicksightAnalysis.QuicksightAnalysisSourceEntityOutputReference), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntityOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightAnalysisSourceEntityOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightAnalysisSourceEntityOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightAnalysisSourceEntityOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightAnalysisSourceEntityOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSourceTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate\"}}]")]
        public virtual void PutSourceTemplate(aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSourceTemplate")]
        public virtual void ResetSourceTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sourceTemplate", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateOutputReference\"}")]
        public virtual aws.QuicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateOutputReference SourceTemplate
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTemplateInput", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate\"}", isOptional: true)]
        public virtual aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate? SourceTemplateInput
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntity\"}", isOptional: true)]
        public virtual aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntity? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntity?>();
            set => SetInstanceProperty(value);
        }
    }
}
