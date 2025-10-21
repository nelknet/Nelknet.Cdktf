using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatRoom
{
    [JsiiByValue(fqn: "aws.ivschatRoom.IvschatRoomMessageReviewHandler")]
    public class IvschatRoomMessageReviewHandler : aws.IvschatRoom.IIvschatRoomMessageReviewHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#fallback_result IvschatRoom#fallback_result}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fallbackResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FallbackResult
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#uri IvschatRoom#uri}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uri
        {
            get;
            set;
        }
    }
}
