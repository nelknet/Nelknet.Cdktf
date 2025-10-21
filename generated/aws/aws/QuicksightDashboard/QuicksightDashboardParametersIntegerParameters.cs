using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDashboard
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.quicksightDashboard.QuicksightDashboardParametersIntegerParameters")]
    public class QuicksightDashboardParametersIntegerParameters : aws.QuicksightDashboard.IQuicksightDashboardParametersIntegerParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#name QuicksightDashboard#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_dashboard#values QuicksightDashboard#values}.</summary>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] Values
        {
            get;
            set;
        }
    }
}
