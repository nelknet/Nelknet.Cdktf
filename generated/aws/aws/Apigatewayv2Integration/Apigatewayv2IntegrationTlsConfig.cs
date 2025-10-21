using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Integration
{
    [JsiiByValue(fqn: "aws.apigatewayv2Integration.Apigatewayv2IntegrationTlsConfig")]
    public class Apigatewayv2IntegrationTlsConfig : aws.Apigatewayv2Integration.IApigatewayv2IntegrationTlsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#server_name_to_verify Apigatewayv2Integration#server_name_to_verify}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "serverNameToVerify", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ServerNameToVerify
        {
            get;
            set;
        }
    }
}
