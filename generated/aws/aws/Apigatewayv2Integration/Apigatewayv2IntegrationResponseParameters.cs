using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Integration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2Integration.Apigatewayv2IntegrationResponseParameters")]
    public class Apigatewayv2IntegrationResponseParameters : aws.Apigatewayv2Integration.IApigatewayv2IntegrationResponseParameters
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#mappings Apigatewayv2Integration#mappings}.</summary>
        [JsiiProperty(name: "mappings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public System.Collections.Generic.IDictionary<string, string> Mappings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_integration#status_code Apigatewayv2Integration#status_code}.</summary>
        [JsiiProperty(name: "statusCode", typeJson: "{\"primitive\":\"string\"}")]
        public string StatusCode
        {
            get;
            set;
        }
    }
}
