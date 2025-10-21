using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerDefaultActionForward), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultActionForward")]
    public interface IVpclatticeListenerDefaultActionForward
    {
        /// <summary>target_groups block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#target_groups VpclatticeListener#target_groups}
        /// </remarks>
        [JsiiProperty(name: "targetGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForwardTargetGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? TargetGroups
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerDefaultActionForward), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultActionForward")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListener.IVpclatticeListenerDefaultActionForward
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target_groups block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#target_groups VpclatticeListener#target_groups}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "targetGroups", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForwardTargetGroups\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? TargetGroups
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
