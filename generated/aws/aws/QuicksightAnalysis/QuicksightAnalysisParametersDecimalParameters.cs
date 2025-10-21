using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightAnalysis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightAnalysis.QuicksightAnalysisParametersDecimalParameters")]
    public class QuicksightAnalysisParametersDecimalParameters : aws.QuicksightAnalysis.IQuicksightAnalysisParametersDecimalParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#name QuicksightAnalysis#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_analysis#values QuicksightAnalysis#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] Values
        {
            get;
            set;
        }
    }
}
