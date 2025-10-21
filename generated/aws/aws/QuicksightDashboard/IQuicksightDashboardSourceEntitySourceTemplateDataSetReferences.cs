using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    [JsiiInterface(nativeType: typeof(IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateDataSetReferences")]
    public interface IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_arn QuicksightDashboard#data_set_arn}.</summary>
        [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_placeholder QuicksightDashboard#data_set_placeholder}.</summary>
        [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
        string DataSetPlaceholder
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences), fullyQualifiedName: "aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateDataSetReferences")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_arn QuicksightDashboard#data_set_arn}.</summary>
            [JsiiProperty(name: "dataSetArn", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_placeholder QuicksightDashboard#data_set_placeholder}.</summary>
            [JsiiProperty(name: "dataSetPlaceholder", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSetPlaceholder
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
