using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchSchedulingPolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution")]
    public class BatchSchedulingPolicyFairSharePolicyShareDistribution : aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicyShareDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_identifier BatchSchedulingPolicy#share_identifier}.</summary>
        [JsiiProperty(name: "shareIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public string ShareIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#weight_factor BatchSchedulingPolicy#weight_factor}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weightFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? WeightFactor
        {
            get;
            set;
        }
    }
}
