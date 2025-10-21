using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    [JsiiInterface(nativeType: typeof(IQuicksightAnalysisParameters), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisParameters")]
    public interface IQuicksightAnalysisParameters
    {
        /// <summary>date_time_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#date_time_parameters QuicksightAnalysis#date_time_parameters}
        /// </remarks>
        [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DateTimeParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>decimal_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#decimal_parameters QuicksightAnalysis#decimal_parameters}
        /// </remarks>
        [JsiiProperty(name: "decimalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? DecimalParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>integer_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#integer_parameters QuicksightAnalysis#integer_parameters}
        /// </remarks>
        [JsiiProperty(name: "integerParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IntegerParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>string_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#string_parameters QuicksightAnalysis#string_parameters}
        /// </remarks>
        [JsiiProperty(name: "stringParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightAnalysisParameters), fullyQualifiedName: "aws.quicksightAnalysis.QuicksightAnalysisParameters")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightAnalysis.IQuicksightAnalysisParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>date_time_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#date_time_parameters QuicksightAnalysis#date_time_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DateTimeParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>decimal_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#decimal_parameters QuicksightAnalysis#decimal_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "decimalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DecimalParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>integer_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#integer_parameters QuicksightAnalysis#integer_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "integerParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IntegerParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#string_parameters QuicksightAnalysis#string_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringParameters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
