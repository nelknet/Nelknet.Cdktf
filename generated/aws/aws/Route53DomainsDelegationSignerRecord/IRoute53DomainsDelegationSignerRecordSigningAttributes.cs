using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53DomainsDelegationSignerRecord
{
    [JsiiInterface(nativeType: typeof(IRoute53DomainsDelegationSignerRecordSigningAttributes), fullyQualifiedName: "aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes")]
    public interface IRoute53DomainsDelegationSignerRecordSigningAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#algorithm Route53DomainsDelegationSignerRecord#algorithm}.</summary>
        [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"number\"}")]
        double Algorithm
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#flags Route53DomainsDelegationSignerRecord#flags}.</summary>
        [JsiiProperty(name: "flags", typeJson: "{\"primitive\":\"number\"}")]
        double Flags
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#public_key Route53DomainsDelegationSignerRecord#public_key}.</summary>
        [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
        string PublicKey
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53DomainsDelegationSignerRecordSigningAttributes), fullyQualifiedName: "aws.route53DomainsDelegationSignerRecord.Route53DomainsDelegationSignerRecordSigningAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.Route53DomainsDelegationSignerRecord.IRoute53DomainsDelegationSignerRecordSigningAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#algorithm Route53DomainsDelegationSignerRecord#algorithm}.</summary>
            [JsiiProperty(name: "algorithm", typeJson: "{\"primitive\":\"number\"}")]
            public double Algorithm
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#flags Route53DomainsDelegationSignerRecord#flags}.</summary>
            [JsiiProperty(name: "flags", typeJson: "{\"primitive\":\"number\"}")]
            public double Flags
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53domains_delegation_signer_record#public_key Route53DomainsDelegationSignerRecord#public_key}.</summary>
            [JsiiProperty(name: "publicKey", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicKey
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
