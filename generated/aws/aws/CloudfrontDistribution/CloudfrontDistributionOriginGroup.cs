using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontDistribution
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontDistribution.CloudfrontDistributionOriginGroup")]
    public class CloudfrontDistributionOriginGroup : aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroup
    {
        /// <summary>failover_criteria block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#failover_criteria CloudfrontDistribution#failover_criteria}
        /// </remarks>
        [JsiiProperty(name: "failoverCriteria", typeJson: "{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupFailoverCriteria\"}")]
        public aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupFailoverCriteria FailoverCriteria
        {
            get;
            set;
        }

        private object _member;

        /// <summary>member block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#member CloudfrontDistribution#member}
        /// </remarks>
        [JsiiProperty(name: "member", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfrontDistribution.CloudfrontDistributionOriginGroupMember\"},\"kind\":\"array\"}}]}}")]
        public object Member
        {
            get => _member;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupMember[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupMember).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CloudfrontDistribution.ICloudfrontDistributionOriginGroupMember).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _member = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}")]
        public string OriginId
        {
            get;
            set;
        }
    }
}
