using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionEventInvokeConfig
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunctionEventInvokeConfig.LambdaFunctionEventInvokeConfigDestinationConfigOnFailure")]
    public class LambdaFunctionEventInvokeConfigDestinationConfigOnFailure : aws.LambdaFunctionEventInvokeConfig.ILambdaFunctionEventInvokeConfigDestinationConfigOnFailure
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_event_invoke_config#destination LambdaFunctionEventInvokeConfig#destination}.</summary>
        [JsiiProperty(name: "destination", typeJson: "{\"primitive\":\"string\"}")]
        public string Destination
        {
            get;
            set;
        }
    }
}
