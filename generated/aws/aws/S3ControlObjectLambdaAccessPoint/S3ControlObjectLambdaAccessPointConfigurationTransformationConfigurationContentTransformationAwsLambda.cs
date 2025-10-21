using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3ControlObjectLambdaAccessPoint
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3ControlObjectLambdaAccessPoint.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda")]
    public class S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda : aws.S3ControlObjectLambdaAccessPoint.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#function_arn S3ControlObjectLambdaAccessPoint#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3control_object_lambda_access_point#function_payload S3ControlObjectLambdaAccessPoint#function_payload}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functionPayload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FunctionPayload
        {
            get;
            set;
        }
    }
}
