using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionEphemeralStorage")]
    public class LambdaFunctionEphemeralStorage : aws.LambdaFunction.ILambdaFunctionEphemeralStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#size LambdaFunction#size}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Size
        {
            get;
            set;
        }
    }
}
