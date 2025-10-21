using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTrustStoreRevocation
{
    [JsiiInterface(nativeType: typeof(ILbTrustStoreRevocationTimeouts), fullyQualifiedName: "aws.lbTrustStoreRevocation.LbTrustStoreRevocationTimeouts")]
    public interface ILbTrustStoreRevocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#create LbTrustStoreRevocation#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILbTrustStoreRevocationTimeouts), fullyQualifiedName: "aws.lbTrustStoreRevocation.LbTrustStoreRevocationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.LbTrustStoreRevocation.ILbTrustStoreRevocationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#create LbTrustStoreRevocation#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
