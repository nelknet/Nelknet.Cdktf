using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiByValue(fqn: "aws.vpclatticeListener.VpclatticeListenerDefaultActionForwardTargetGroups")]
    public class VpclatticeListenerDefaultActionForwardTargetGroups : aws.VpclatticeListener.IVpclatticeListenerDefaultActionForwardTargetGroups
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#target_group_identifier VpclatticeListener#target_group_identifier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "targetGroupIdentifier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TargetGroupIdentifier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#weight VpclatticeListener#weight}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Weight
        {
            get;
            set;
        }
    }
}
