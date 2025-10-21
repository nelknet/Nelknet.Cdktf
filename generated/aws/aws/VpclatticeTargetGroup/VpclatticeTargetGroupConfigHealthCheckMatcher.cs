using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeTargetGroup
{
    [JsiiByValue(fqn: "aws.vpclatticeTargetGroup.VpclatticeTargetGroupConfigHealthCheckMatcher")]
    public class VpclatticeTargetGroupConfigHealthCheckMatcher : aws.VpclatticeTargetGroup.IVpclatticeTargetGroupConfigHealthCheckMatcher
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#value VpclatticeTargetGroup#value}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
