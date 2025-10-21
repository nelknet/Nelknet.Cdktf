using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AlbTargetGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.albTargetGroup.AlbTargetGroupTargetFailover")]
    public class AlbTargetGroupTargetFailover : aws.AlbTargetGroup.IAlbTargetGroupTargetFailover
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#on_deregistration AlbTargetGroup#on_deregistration}.</summary>
        [JsiiProperty(name: "onDeregistration", typeJson: "{\"primitive\":\"string\"}")]
        public string OnDeregistration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/alb_target_group#on_unhealthy AlbTargetGroup#on_unhealthy}.</summary>
        [JsiiProperty(name: "onUnhealthy", typeJson: "{\"primitive\":\"string\"}")]
        public string OnUnhealthy
        {
            get;
            set;
        }
    }
}
