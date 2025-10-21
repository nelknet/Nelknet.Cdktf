using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiByValue(fqn: "aws.quicksightAnalysis.QuicksightAnalysisParameters")]
    public class QuicksightAnalysisParameters : aws.QuicksightAnalysis.IQuicksightAnalysisParameters
    {
        private object? _dateTimeParameters;

        /// <summary>date_time_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#date_time_parameters QuicksightAnalysis#date_time_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DateTimeParameters
        {
            get => _dateTimeParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightAnalysis.IQuicksightAnalysisParametersDateTimeParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersDateTimeParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dateTimeParameters = value;
            }
        }

        private object? _decimalParameters;

        /// <summary>decimal_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#decimal_parameters QuicksightAnalysis#decimal_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "decimalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? DecimalParameters
        {
            get => _decimalParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightAnalysis.IQuicksightAnalysisParametersDecimalParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersDecimalParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _decimalParameters = value;
            }
        }

        private object? _integerParameters;

        /// <summary>integer_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#integer_parameters QuicksightAnalysis#integer_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "integerParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IntegerParameters
        {
            get => _integerParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightAnalysis.IQuicksightAnalysisParametersIntegerParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersIntegerParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _integerParameters = value;
            }
        }

        private object? _stringParameters;

        /// <summary>string_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#string_parameters QuicksightAnalysis#string_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? StringParameters
        {
            get => _stringParameters;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightAnalysis.IQuicksightAnalysisParametersStringParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisParametersStringParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringParameters = value;
            }
        }
    }
}
