using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SecuritylakeCustomLogSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.securitylakeCustomLogSource.SecuritylakeCustomLogSourceConfigurationProviderIdentity")]
    public class SecuritylakeCustomLogSourceConfigurationProviderIdentity : aws.SecuritylakeCustomLogSource.ISecuritylakeCustomLogSourceConfigurationProviderIdentity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#external_id SecuritylakeCustomLogSource#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securitylake_custom_log_source#principal SecuritylakeCustomLogSource#principal}.</summary>
        [JsiiProperty(name: "principal", typeJson: "{\"primitive\":\"string\"}")]
        public string Principal
        {
            get;
            set;
        }
    }
}
