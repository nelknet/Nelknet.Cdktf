using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Authorizer
{
    [JsiiByValue(fqn: "aws.apigatewayv2Authorizer.Apigatewayv2AuthorizerTimeouts")]
    public class Apigatewayv2AuthorizerTimeouts : aws.Apigatewayv2Authorizer.IApigatewayv2AuthorizerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_authorizer#delete Apigatewayv2Authorizer#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
