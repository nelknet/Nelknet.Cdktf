using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IamServerCertificate
{
    [JsiiInterface(nativeType: typeof(IIamServerCertificateTimeouts), fullyQualifiedName: "aws.iamServerCertificate.IamServerCertificateTimeouts")]
    public interface IIamServerCertificateTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#delete IamServerCertificate#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IIamServerCertificateTimeouts), fullyQualifiedName: "aws.iamServerCertificate.IamServerCertificateTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.IamServerCertificate.IIamServerCertificateTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_server_certificate#delete IamServerCertificate#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
