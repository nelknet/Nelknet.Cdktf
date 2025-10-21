using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2NetworkInsightsAnalysis
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dataAwsEc2NetworkInsightsAnalysis.DataAwsEc2NetworkInsightsAnalysisFilter")]
    public class DataAwsEc2NetworkInsightsAnalysisFilter : aws.DataAwsEc2NetworkInsightsAnalysis.IDataAwsEc2NetworkInsightsAnalysisFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_analysis#name DataAwsEc2NetworkInsightsAnalysis#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_network_insights_analysis#values DataAwsEc2NetworkInsightsAnalysis#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Values
        {
            get;
            set;
        }
    }
}
