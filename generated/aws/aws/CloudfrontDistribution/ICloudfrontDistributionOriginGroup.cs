using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionOriginGroup), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginGroup")]
    public interface ICloudfrontDistributionOriginGroup
    {
        /// <summary>failover_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#failover_criteria CloudfrontDistribution#failover_criteria}
        /// </remarks>
        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteria\"}")]
        aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria FailoverCriteria
        {
            get;
        }

        /// <summary>member block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#member CloudfrontDistribution#member}
        /// </remarks>
        [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}")]
        object Member
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        string OriginId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionOriginGroup), fullyQualifiedName: "aws.cloudfrontDistribution.CloudfrontDistributionOriginGroup")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroup
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>failover_criteria block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#failover_criteria CloudfrontDistribution#failover_criteria}
            /// </remarks>
            [JsiiProperty(name: "failoverCriteria", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteria\"}")]
            public aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria FailoverCriteria
            {
                get => GetInstanceProperty<aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria>()!;
            }

            /// <summary>member block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#member CloudfrontDistribution#member}
            /// </remarks>
            [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}")]
            public object Member
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
            [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
            public string OriginId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
