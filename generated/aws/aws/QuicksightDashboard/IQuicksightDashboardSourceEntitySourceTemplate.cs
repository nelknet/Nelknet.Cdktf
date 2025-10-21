using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiInterface(nativeType: typeof(IQuicksightDashboardSourceEntitySourceTemplate), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate")]
    public interface IQuicksightDashboardSourceEntitySourceTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#arn QuicksightDashboard#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        string Arn
        {
            get;
        }

        /// <summary>data_set_references block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_references QuicksightDashboard#data_set_references}
        /// </remarks>
        [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}")]
        object DataSetReferences
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDashboardSourceEntitySourceTemplate), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#arn QuicksightDashboard#arn}.</summary>
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
            public string Arn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>data_set_references block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_references QuicksightDashboard#data_set_references}
            /// </remarks>
            [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}")]
            public object DataSetReferences
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
