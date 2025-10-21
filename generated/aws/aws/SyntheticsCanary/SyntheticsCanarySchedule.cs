using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SyntheticsCanary
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.syntheticsCanary.SyntheticsCanarySchedule")]
    public class SyntheticsCanarySchedule : aws.SyntheticsCanary.ISyntheticsCanarySchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#expression SyntheticsCanary#expression}.</summary>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/synthetics_canary#duration_in_seconds SyntheticsCanary#duration_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "durationInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DurationInSeconds
        {
            get;
            set;
        }
    }
}
