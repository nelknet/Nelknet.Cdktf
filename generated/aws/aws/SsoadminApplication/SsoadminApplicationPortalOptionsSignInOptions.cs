using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsoadminApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssoadminApplication.SsoadminApplicationPortalOptionsSignInOptions")]
    public class SsoadminApplicationPortalOptionsSignInOptions : aws.SsoadminApplication.ISsoadminApplicationPortalOptionsSignInOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#origin SsoadminApplication#origin}.</summary>
        [JsiiProperty(name: "origin", typeJson: "{\"primitive\":\"string\"}")]
        public string Origin
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application#application_url SsoadminApplication#application_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationUrl
        {
            get;
            set;
        }
    }
}
