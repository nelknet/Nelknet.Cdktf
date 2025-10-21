using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2DomainName
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2DomainName.Apigatewayv2DomainNameMutualTlsAuthentication")]
    public class Apigatewayv2DomainNameMutualTlsAuthentication : aws.Apigatewayv2DomainName.IApigatewayv2DomainNameMutualTlsAuthentication
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#truststore_uri Apigatewayv2DomainName#truststore_uri}.</summary>
        [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
        public string TruststoreUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_domain_name#truststore_version Apigatewayv2DomainName#truststore_version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? TruststoreVersion
        {
            get;
            set;
        }
    }
}
