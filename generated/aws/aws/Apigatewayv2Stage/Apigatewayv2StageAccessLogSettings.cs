using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2Stage
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.apigatewayv2Stage.Apigatewayv2StageAccessLogSettings")]
    public class Apigatewayv2StageAccessLogSettings : aws.Apigatewayv2Stage.IApigatewayv2StageAccessLogSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#destination_arn Apigatewayv2Stage#destination_arn}.</summary>
        [JsiiProperty(name: "destinationArn", typeJson: "{\"primitive\":\"string\"}")]
        public string DestinationArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_stage#format Apigatewayv2Stage#format}.</summary>
        [JsiiProperty(name: "format", typeJson: "{\"primitive\":\"string\"}")]
        public string Format
        {
            get;
            set;
        }
    }
}
