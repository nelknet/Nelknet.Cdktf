using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplate")]
    public class QuicksightDashboardSourceEntitySourceTemplate : aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#arn QuicksightDashboard#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        private object _dataSetReferences;

        /// <summary>data_set_references block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#data_set_references QuicksightDashboard#data_set_references}
        /// </remarks>
        [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightDashboard.QuicksightDashboardSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}")]
        public object DataSetReferences
        {
            get => _dataSetReferences;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightDashboard.IQuicksightDashboardSourceEntitySourceTemplateDataSetReferences).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataSetReferences = value;
            }
        }
    }
}
