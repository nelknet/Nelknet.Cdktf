using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeListenerRule
{
    [JsiiInterface(nativeType: typeof(IVpclatticeListenerRuleActionFixedResponse), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse")]
    public interface IVpclatticeListenerRuleActionFixedResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#status_code VpclatticeListenerRule#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
        double StatusCode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVpclatticeListenerRuleActionFixedResponse), fullyQualifiedName: "aws.vpclatticeListenerRule.VpclatticeListenerRuleActionFixedResponse")]
        internal sealed class _Proxy : DeputyBase, aws.VpclatticeListenerRule.IVpclatticeListenerRuleActionFixedResponse
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_listener_rule#status_code VpclatticeListenerRule#status_code}.</summary>
            [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"number\"}")]
            public double StatusCode
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
