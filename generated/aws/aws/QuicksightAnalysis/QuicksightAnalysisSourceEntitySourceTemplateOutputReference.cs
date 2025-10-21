using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiClass(nativeType: typeof(aws.QuicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateOutputReference), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightAnalysisSourceEntitySourceTemplateOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightAnalysisSourceEntitySourceTemplateOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightAnalysisSourceEntitySourceTemplateOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightAnalysisSourceEntitySourceTemplateOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDataSetReferences", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDataSetReferences(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiProperty(name: "dataSetReferences", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferencesList\"}")]
        public virtual aws.QuicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferencesList DataSetReferences
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferencesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "arnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSetReferencesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate\"}", isOptional: true)]
        public virtual aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate?>();
            set => SetInstanceProperty(value);
        }
    }
}
