using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiInterface(nativeType: typeof(IQuicksightDashboardParameters), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardParameters")]
    public interface IQuicksightDashboardParameters
    {
        /// <summary>date_time_parameters block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#date_time_parameters QuicksightDashboard#date_time_parameters}
        /// </remarks>
        [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#decimal_parameters QuicksightDashboard#decimal_parameters}
        /// </remarks>
        [JsiiProperty(name: "decimalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#integer_parameters QuicksightDashboard#integer_parameters}
        /// </remarks>
        [JsiiProperty(name: "integerParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#string_parameters QuicksightDashboard#string_parameters}
        /// </remarks>
        [JsiiProperty(name: "stringParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? StringParameters
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDashboardParameters), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardParameters")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDashboard.IQuicksightDashboardParameters
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>date_time_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#date_time_parameters QuicksightDashboard#date_time_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dateTimeParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDateTimeParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DateTimeParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>decimal_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#decimal_parameters QuicksightDashboard#decimal_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "decimalParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersDecimalParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? DecimalParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>integer_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#integer_parameters QuicksightDashboard#integer_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "integerParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersIntegerParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? IntegerParameters
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>string_parameters block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#string_parameters QuicksightDashboard#string_parameters}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "stringParameters", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardParametersStringParameters\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? StringParameters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
