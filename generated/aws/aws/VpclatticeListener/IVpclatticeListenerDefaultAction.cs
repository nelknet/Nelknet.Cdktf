using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListener
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerDefaultAction), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultAction")]
    public interface IVpclatticeListenerDefaultAction
    {
        /// <summary>fixed_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#fixed_response VpclatticeListener#fixed_response}
        /// </remarks>
        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse? FixedResponse
        {
            get
            {
                return null;
            }
        }

        /// <summary>forward block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#forward VpclatticeListener#forward}
        /// </remarks>
        [JsiiProperty(name: "forward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Forward
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerDefaultAction), fullyQualifiedName: "aws.vpclatticeListener.VpclatticeListenerDefaultAction")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListener.IVpclatticeListenerDefaultAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>fixed_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#fixed_response VpclatticeListener#fixed_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionFixedResponse\"}", isOptional: true)]
            public aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse? FixedResponse
            {
                get => GetInstanceProperty<aws.VpclatticeListener.IVpclatticeListenerDefaultActionFixedResponse?>();
            }

            /// <summary>forward block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener#forward VpclatticeListener#forward}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forward", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.vpclatticeListener.VpclatticeListenerDefaultActionForward\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Forward
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
