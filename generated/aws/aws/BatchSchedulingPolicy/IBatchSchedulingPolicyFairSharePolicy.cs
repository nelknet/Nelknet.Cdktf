using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BatchSchedulingPolicy
{
    [JsiiInterface(nativeType: typeof(IBatchSchedulingPolicyFairSharePolicy), fullyQualifiedName: "aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicy")]
    public interface IBatchSchedulingPolicyFairSharePolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#compute_reservation BatchSchedulingPolicy#compute_reservation}.</summary>
        [JsiiProperty(name: "computeReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ComputeReservation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_decay_seconds BatchSchedulingPolicy#share_decay_seconds}.</summary>
        [JsiiProperty(name: "shareDecaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ShareDecaySeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>share_distribution block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_distribution BatchSchedulingPolicy#share_distribution}
        /// </remarks>
        [JsiiProperty(name: "shareDistribution", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ShareDistribution
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchSchedulingPolicyFairSharePolicy), fullyQualifiedName: "aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.BatchSchedulingPolicy.IBatchSchedulingPolicyFairSharePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#compute_reservation BatchSchedulingPolicy#compute_reservation}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "computeReservation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ComputeReservation
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_decay_seconds BatchSchedulingPolicy#share_decay_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "shareDecaySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ShareDecaySeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>share_distribution block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_scheduling_policy#share_distribution BatchSchedulingPolicy#share_distribution}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "shareDistribution", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.batchSchedulingPolicy.BatchSchedulingPolicyFairSharePolicyShareDistribution\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? ShareDistribution
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
