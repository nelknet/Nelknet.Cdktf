using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeTargetGroup
{
    [JsiiInterface(nativeType: typeof(IVpclatticeTargetGroupConfigHealthCheckMatcher), fullyQualifiedName: "aws.vpclatticeTargetGroup.VpclatticeTargetGroupConfigHealthCheckMatcher")]
    public interface IVpclatticeTargetGroupConfigHealthCheckMatcher
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#value VpclatticeTargetGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeTargetGroupConfigHealthCheckMatcher), fullyQualifiedName: "aws.vpclatticeTargetGroup.VpclatticeTargetGroupConfigHealthCheckMatcher")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeTargetGroup.IVpclatticeTargetGroupConfigHealthCheckMatcher
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_target_group#value VpclatticeTargetGroup#value}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
