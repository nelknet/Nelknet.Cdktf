using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardParameters")]
    public class QuicksightDashboardParameters : aws.QuicksightDashboard.IQuicksightDashboardParameters
    {
        private object? _dateTimeParameters;

        /// <summary>date_time_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#date_time_parameters QuicksightDashboard#date_time_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.QuicksightDashboard.IQuicksightDashboardParametersDateTimeParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersDateTimeParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dateTimeParameters = value;
            }
        }

        private object? _decimalParameters;

        /// <summary>decimal_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#decimal_parameters QuicksightDashboard#decimal_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "decimalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.QuicksightDashboard.IQuicksightDashboardParametersDecimalParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersDecimalParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _decimalParameters = value;
            }
        }

        private object? _integerParameters;

        /// <summary>integer_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#integer_parameters QuicksightDashboard#integer_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "integerParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.QuicksightDashboard.IQuicksightDashboardParametersIntegerParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersIntegerParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _integerParameters = value;
            }
        }

        private object? _stringParameters;

        /// <summary>string_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#string_parameters QuicksightDashboard#string_parameters}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case aws.QuicksightDashboard.IQuicksightDashboardParametersStringParameters[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardParametersStringParameters).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _stringParameters = value;
            }
        }
    }
}
