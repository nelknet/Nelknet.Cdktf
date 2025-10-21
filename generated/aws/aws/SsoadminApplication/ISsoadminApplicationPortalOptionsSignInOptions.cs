using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminApplication
{
    [JsiiInterface(nativeType: typeof(ISsoadminApplicationPortalOptionsSignInOptions), fullyQualifiedName: "aws.ssoadminApplication.SsoadminApplicationPortalOptionsSignInOptions")]
    public interface ISsoadminApplicationPortalOptionsSignInOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#origin SsoadminApplication#origin}.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
        string Origin
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#application_url SsoadminApplication#application_url}.</summary>
        [JsiiProperty(name: "applicationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplicationUrl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISsoadminApplicationPortalOptionsSignInOptions), fullyQualifiedName: "aws.ssoadminApplication.SsoadminApplicationPortalOptionsSignInOptions")]
        internal sealed class _Proxy : DeputyBase, aws.SsoadminApplication.ISsoadminApplicationPortalOptionsSignInOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#origin SsoadminApplication#origin}.</summary>
            [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
            public string Origin
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#application_url SsoadminApplication#application_url}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applicationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplicationUrl
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
