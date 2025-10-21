using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchSchedulingPolicy
{
    [JsiiByValue(fqn: "aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicy")]
    public class BatchSchedulingPolicyFairSharePolicy : aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#compute_reservation BatchSchedulingPolicy#compute_reservation}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "computeReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ComputeReservation
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_decay_seconds BatchSchedulingPolicy#share_decay_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "shareDecaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ShareDecaySeconds
        {
            get;
            set;
        }

        private object? _shareDistribution;

        /// <summary>share_distribution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_distribution BatchSchedulingPolicy#share_distribution}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shareDistribution", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ShareDistribution
        {
            get => _shareDistribution;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicyShareDistribution[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicyShareDistribution).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _shareDistribution = value;
            }
        }
    }
}
