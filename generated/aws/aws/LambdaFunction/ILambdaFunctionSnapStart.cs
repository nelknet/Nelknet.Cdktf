using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    [JsiiInterface(nativeType: typeof(ILambdaFunctionSnapStart), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionSnapStart")]
    public interface ILambdaFunctionSnapStart
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#apply_on LambdaFunction#apply_on}.</summary>
        [JsiiProperty(name: "applyOn", typeJson: "{\"primitive\":\"string\"}")]
        string ApplyOn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILambdaFunctionSnapStart), fullyQualifiedName: "aws.lambdaFunction.LambdaFunctionSnapStart")]
        internal sealed class _Proxy : DeputyBase, aws.LambdaFunction.ILambdaFunctionSnapStart
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#apply_on LambdaFunction#apply_on}.</summary>
            [JsiiProperty(name: "applyOn", typeJson: "{\"primitive\":\"string\"}")]
            public string ApplyOn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
