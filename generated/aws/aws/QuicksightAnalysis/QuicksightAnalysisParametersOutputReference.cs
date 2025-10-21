using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiClass(nativeType: typeof(aws.QuicksightAnalysis.QuicksightAnalysisParametersOutputReference), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightAnalysisParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightAnalysisParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightAnalysisParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightAnalysisParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDateTimeParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDateTimeParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightAnalysis.IQuicksightAnalysisParametersDateTimeParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersDateTimeParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersDateTimeParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDecimalParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDecimalParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDecimalParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightAnalysis.IQuicksightAnalysisParametersDecimalParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersDecimalParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersDecimalParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIntegerParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIntegerParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightAnalysis.IQuicksightAnalysisParametersIntegerParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersIntegerParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersIntegerParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersStringParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightAnalysis.IQuicksightAnalysisParametersStringParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersStringParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersStringParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDateTimeParameters")]
        public virtual void ResetDateTimeParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDecimalParameters")]
        public virtual void ResetDecimalParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIntegerParameters")]
        public virtual void ResetIntegerParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStringParameters")]
        public virtual void ResetStringParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDateTimeParametersList\"}")]
        public virtual aws.QuicksightAnalysis.QuicksightAnalysisParametersDateTimeParametersList DateTimeParameters
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.QuicksightAnalysisParametersDateTimeParametersList>()!;
        }

        [JsiiProperty(name: "decimalParameters", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDecimalParametersList\"}")]
        public virtual aws.QuicksightAnalysis.QuicksightAnalysisParametersDecimalParametersList DecimalParameters
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.QuicksightAnalysisParametersDecimalParametersList>()!;
        }

        [JsiiProperty(name: "integerParameters", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParametersList\"}")]
        public virtual aws.QuicksightAnalysis.QuicksightAnalysisParametersIntegerParametersList IntegerParameters
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.QuicksightAnalysisParametersIntegerParametersList>()!;
        }

        [JsiiProperty(name: "stringParameters", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersStringParametersList\"}")]
        public virtual aws.QuicksightAnalysis.QuicksightAnalysisParametersStringParametersList StringParameters
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.QuicksightAnalysisParametersStringParametersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateTimeParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DateTimeParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "decimalParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DecimalParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integerParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IntegerParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParameters\"}", isOptional: true)]
        public virtual aws.QuicksightAnalysis.IQuicksightAnalysisParameters? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightAnalysis.IQuicksightAnalysisParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
