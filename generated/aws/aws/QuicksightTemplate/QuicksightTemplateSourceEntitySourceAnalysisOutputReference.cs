using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightTemplate
{
    [JsiiClass(nativeType: typeof(aws.QuicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisOutputReference), fullyQualifiedName: "aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightTemplateSourceEntitySourceAnalysisOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightTemplateSourceEntitySourceAnalysisOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightTemplateSourceEntitySourceAnalysisOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightTemplateSourceEntitySourceAnalysisOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataSetReferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataSetReferences(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysisDataSetReferences).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "dataSetReferences", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferencesList\"}")]
        public virtual aws.QuicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferencesList DataSetReferences
        {
            get => GetInstanceProperty<aws.QuicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferencesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSetReferencesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysisDataSetReferences\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DataSetReferencesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightTemplate.QuicksightTemplateSourceEntitySourceAnalysis\"}", isOptional: true)]
        public virtual aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightTemplate.IQuicksightTemplateSourceEntitySourceAnalysis?>();
            set => SetInstanceProperty(value);
        }
    }
}
