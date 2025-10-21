using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IvschatRoom
{
    [JsiiInterface(nativeType: typeof(IIvschatRoomMessageReviewHandler), fullyQualifiedName: "aws.ivschatRoom.IvschatRoomMessageReviewHandler")]
    public interface IIvschatRoomMessageReviewHandler
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#fallback_result IvschatRoom#fallback_result}.</summary>
        [JsiiProperty(name: "fallbackResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FallbackResult
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#uri IvschatRoom#uri}.</summary>
        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uri
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIvschatRoomMessageReviewHandler), fullyQualifiedName: "aws.ivschatRoom.IvschatRoomMessageReviewHandler")]
        internal sealed class _Proxy : DeputyBase, aws.IvschatRoom.IIvschatRoomMessageReviewHandler
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#fallback_result IvschatRoom#fallback_result}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fallbackResult", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FallbackResult
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#uri IvschatRoom#uri}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uri
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
