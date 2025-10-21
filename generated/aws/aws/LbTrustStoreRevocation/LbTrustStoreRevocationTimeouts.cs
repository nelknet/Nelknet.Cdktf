using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LbTrustStoreRevocation
{
    [JsiiByValue(fqn: "aws.lbTrustStoreRevocation.LbTrustStoreRevocationTimeouts")]
    public class LbTrustStoreRevocationTimeouts : aws.LbTrustStoreRevocation.ILbTrustStoreRevocationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#create LbTrustStoreRevocation#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
