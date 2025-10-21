using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplate")]
    public class QuicksightAnalysisSourceEntitySourceTemplate : aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#arn QuicksightAnalysis#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        private object _dataSetReferences;

        /// <summary>data_set_references block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#data_set_references QuicksightAnalysis#data_set_references}
        /// </remarks>
        [JsiiProperty(name: "dataSetReferences", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.quicksightAnalysis.QuicksightAnalysisSourceEntitySourceTemplateDataSetReferences\"},\"kind\":\"array\"}}]}}")]
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
                        case aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.QuicksightAnalysis.IQuicksightAnalysisSourceEntitySourceTemplateDataSetReferences).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _dataSetReferences = value;
            }
        }
    }
}
