using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAlbTargetGroup
{
    [JsiiInterface(nativeType: typeof(IDataAwsAlbTargetGroupTimeouts), fullyQualifiedName: "aws.dataAwsAlbTargetGroup.DataAwsAlbTargetGroupTimeouts")]
    public interface IDataAwsAlbTargetGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#read DataAwsAlbTargetGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAlbTargetGroupTimeouts), fullyQualifiedName: "aws.dataAwsAlbTargetGroup.DataAwsAlbTargetGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAlbTargetGroup.IDataAwsAlbTargetGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_target_group#read DataAwsAlbTargetGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
