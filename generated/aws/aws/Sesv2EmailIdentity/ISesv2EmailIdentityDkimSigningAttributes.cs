using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sesv2EmailIdentity
{
    [JsiiInterface(nativeType: typeof(ISesv2EmailIdentityDkimSigningAttributes), fullyQualifiedName: "aws.sesv2EmailIdentity.Sesv2EmailIdentityDkimSigningAttributes")]
    public interface ISesv2EmailIdentityDkimSigningAttributes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#domain_signing_private_key Sesv2EmailIdentity#domain_signing_private_key}.</summary>
        [JsiiProperty(name: "domainSigningPrivateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainSigningPrivateKey
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#domain_signing_selector Sesv2EmailIdentity#domain_signing_selector}.</summary>
        [JsiiProperty(name: "domainSigningSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DomainSigningSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#next_signing_key_length Sesv2EmailIdentity#next_signing_key_length}.</summary>
        [JsiiProperty(name: "nextSigningKeyLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NextSigningKeyLength
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISesv2EmailIdentityDkimSigningAttributes), fullyQualifiedName: "aws.sesv2EmailIdentity.Sesv2EmailIdentityDkimSigningAttributes")]
        internal sealed class _Proxy : DeputyBase, aws.Sesv2EmailIdentity.ISesv2EmailIdentityDkimSigningAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#domain_signing_private_key Sesv2EmailIdentity#domain_signing_private_key}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainSigningPrivateKey", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainSigningPrivateKey
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#domain_signing_selector Sesv2EmailIdentity#domain_signing_selector}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "domainSigningSelector", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DomainSigningSelector
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sesv2_email_identity#next_signing_key_length Sesv2EmailIdentity#next_signing_key_length}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "nextSigningKeyLength", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NextSigningKeyLength
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
