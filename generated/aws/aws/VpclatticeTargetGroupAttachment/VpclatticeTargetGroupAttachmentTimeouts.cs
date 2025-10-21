using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeTargetGroupAttachment
{
    [JsiiByValue(fqn: "aws.vpclatticeTargetGroupAttachment.VpclatticeTargetGroupAttachmentTimeouts")]
    public class VpclatticeTargetGroupAttachmentTimeouts : aws.VpclatticeTargetGroupAttachment.IVpclatticeTargetGroupAttachmentTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment#create VpclatticeTargetGroupAttachment#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group_attachment#delete VpclatticeTargetGroupAttachment#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
