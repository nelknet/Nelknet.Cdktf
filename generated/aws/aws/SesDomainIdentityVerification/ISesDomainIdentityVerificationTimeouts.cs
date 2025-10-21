using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SesDomainIdentityVerification
{
    [JsiiInterface(nativeType: typeof(ISesDomainIdentityVerificationTimeouts), fullyQualifiedName: "aws.sesDomainIdentityVerification.SesDomainIdentityVerificationTimeouts")]
    public interface ISesDomainIdentityVerificationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity_verification#create SesDomainIdentityVerification#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesDomainIdentityVerificationTimeouts), fullyQualifiedName: "aws.sesDomainIdentityVerification.SesDomainIdentityVerificationTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.SesDomainIdentityVerification.ISesDomainIdentityVerificationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_domain_identity_verification#create SesDomainIdentityVerification#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
