using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbTargetGroup
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbTargetGroupTimeouts), fullyQualifiedName: "aws.dataAwsLbTargetGroup.DataAwsLbTargetGroupTimeouts")]
    public interface IDataAwsLbTargetGroupTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#read DataAwsLbTargetGroup#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbTargetGroupTimeouts), fullyQualifiedName: "aws.dataAwsLbTargetGroup.DataAwsLbTargetGroupTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbTargetGroup.IDataAwsLbTargetGroupTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_target_group#read DataAwsLbTargetGroup#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
