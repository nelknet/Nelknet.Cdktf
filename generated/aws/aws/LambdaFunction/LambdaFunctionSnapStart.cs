using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionSnapStart")]
    public class LambdaFunctionSnapStart : aws.LambdaFunction.ILambdaFunctionSnapStart
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#apply_on LambdaFunction#apply_on}.</summary>
        [JsiiProperty(name: "applyOn", typeJson: "{\"primitive\":\"string\"}")]
        public string ApplyOn
        {
            get;
            set;
        }
    }
}
