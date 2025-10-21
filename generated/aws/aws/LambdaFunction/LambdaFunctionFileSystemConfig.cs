using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionFileSystemConfig")]
    public class LambdaFunctionFileSystemConfig : aws.LambdaFunction.ILambdaFunctionFileSystemConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#arn LambdaFunction#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public string Arn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#local_mount_path LambdaFunction#local_mount_path}.</summary>
        [JsiiProperty(name: "localMountPath", typeJson: "{\"primitive\":\"string\"}")]
        public string LocalMountPath
        {
            get;
            set;
        }
    }
}
