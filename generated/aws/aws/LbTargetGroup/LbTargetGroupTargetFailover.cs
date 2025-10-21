using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTargetGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lbTargetGroup.LbTargetGroupTargetFailover")]
    public class LbTargetGroupTargetFailover : aws.LbTargetGroup.ILbTargetGroupTargetFailover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#on_deregistration LbTargetGroup#on_deregistration}.</summary>
        [JsiiProperty(name: "onDeregistration", typeJson: "{\"primitive\":\"string\"}")]
        public string OnDeregistration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_target_group#on_unhealthy LbTargetGroup#on_unhealthy}.</summary>
        [JsiiProperty(name: "onUnhealthy", typeJson: "{\"primitive\":\"string\"}")]
        public string OnUnhealthy
        {
            get;
            set;
        }
    }
}
