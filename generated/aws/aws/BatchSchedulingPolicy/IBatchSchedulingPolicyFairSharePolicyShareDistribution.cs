using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchSchedulingPolicy
{
    [JsiiInterface(nativeType: typeof(IBatchSchedulingPolicyFairSharePolicyShareDistribution), fullyQualifiedName: "aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution")]
    public interface IBatchSchedulingPolicyFairSharePolicyShareDistribution
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_identifier BatchSchedulingPolicy#share_identifier}.</summary>
        [JsiiProperty(name: "shareIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string ShareIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#weight_factor BatchSchedulingPolicy#weight_factor}.</summary>
        [JsiiProperty(name: "weightFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? WeightFactor
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchSchedulingPolicyFairSharePolicyShareDistribution), fullyQualifiedName: "aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution")]
        internal sealed class _Proxy : DeputyBase, aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicyShareDistribution
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_identifier BatchSchedulingPolicy#share_identifier}.</summary>
            [JsiiProperty(name: "shareIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string ShareIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#weight_factor BatchSchedulingPolicy#weight_factor}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "weightFactor", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? WeightFactor
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
