using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiClass(nativeType: typeof(aws.QuicksightDashboard.QuicksightDashboardParametersOutputReference), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class QuicksightDashboardParametersOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public QuicksightDashboardParametersOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected QuicksightDashboardParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDashboardParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDateTimeParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDateTimeParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDashboard.IQuicksightDashboardParametersDateTimeParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersDateTimeParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersDateTimeParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDecimalParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDecimalParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDecimalParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDashboard.IQuicksightDashboardParametersDecimalParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersDecimalParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersDecimalParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIntegerParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersIntegerParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutIntegerParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDashboard.IQuicksightDashboardParametersIntegerParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersIntegerParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersIntegerParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putStringParameters", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersStringParameters\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutStringParameters(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.QuicksightDashboard.IQuicksightDashboardParametersStringParameters[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersStringParameters).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersStringParameters).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
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

        [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDateTimeParametersList\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardParametersDateTimeParametersList DateTimeParameters
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardParametersDateTimeParametersList>()!;
        }

        [JsiiProperty(name: "decimalParameters", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDecimalParametersList\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardParametersDecimalParametersList DecimalParameters
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardParametersDecimalParametersList>()!;
        }

        [JsiiProperty(name: "integerParameters", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersIntegerParametersList\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardParametersIntegerParametersList IntegerParameters
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardParametersIntegerParametersList>()!;
        }

        [JsiiProperty(name: "stringParameters", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersStringParametersList\"}")]
        public virtual aws.QuicksightDashboard.QuicksightDashboardParametersStringParametersList StringParameters
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.QuicksightDashboardParametersStringParametersList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "dateTimeParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DateTimeParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "decimalParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DecimalParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "integerParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? IntegerParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "stringParametersInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? StringParametersInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParameters\"}", isOptional: true)]
        public virtual aws.QuicksightDashboard.IQuicksightDashboardParameters? InternalValue
        {
            get => GetInstanceProperty<aws.QuicksightDashboard.IQuicksightDashboardParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
