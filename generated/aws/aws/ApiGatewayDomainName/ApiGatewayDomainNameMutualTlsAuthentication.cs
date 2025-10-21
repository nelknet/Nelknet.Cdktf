using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ApiGatewayDomainName
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apiGatewayDomainName.ApiGatewayDomainNameMutualTlsAuthentication")]
    public class ApiGatewayDomainNameMutualTlsAuthentication : aws.ApiGatewayDomainName.IApiGatewayDomainNameMutualTlsAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#truststore_uri ApiGatewayDomainName#truststore_uri}.</summary>
        [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
        public string TruststoreUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_domain_name#truststore_version ApiGatewayDomainName#truststore_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TruststoreVersion
        {
            get;
            set;
        }
    }
}
