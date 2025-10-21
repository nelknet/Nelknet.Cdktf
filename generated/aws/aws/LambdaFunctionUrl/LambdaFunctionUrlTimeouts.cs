using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunctionUrl
{
    [JsiiByValue(fqn: "aws.lambdaFunctionUrl.LambdaFunctionUrlTimeouts")]
    public class LambdaFunctionUrlTimeouts : aws.LambdaFunctionUrl.ILambdaFunctionUrlTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function_url#create LambdaFunctionUrl#create}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Create
        {
            get;
            set;
        }
    }
}
