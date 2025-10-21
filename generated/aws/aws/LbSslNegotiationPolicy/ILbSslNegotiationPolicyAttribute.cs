using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbSslNegotiationPolicy
{
    [JsiiInterface(nativeType: typeof(ILbSslNegotiationPolicyAttribute), fullyQualifiedName: "aws.lbSslNegotiationPolicy.LbSslNegotiationPolicyAttribute")]
    public interface ILbSslNegotiationPolicyAttribute
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#name LbSslNegotiationPolicy#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#value LbSslNegotiationPolicy#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILbSslNegotiationPolicyAttribute), fullyQualifiedName: "aws.lbSslNegotiationPolicy.LbSslNegotiationPolicyAttribute")]
        internal sealed class _Proxy : DeputyBase, aws.LbSslNegotiationPolicy.ILbSslNegotiationPolicyAttribute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#name LbSslNegotiationPolicy#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#value LbSslNegotiationPolicy#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
