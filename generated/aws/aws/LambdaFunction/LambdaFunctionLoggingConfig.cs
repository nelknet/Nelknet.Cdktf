using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LambdaFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lambdaFunction.LambdaFunctionLoggingConfig")]
    public class LambdaFunctionLoggingConfig : aws.LambdaFunction.ILambdaFunctionLoggingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#log_format LambdaFunction#log_format}.</summary>
        [JsiiProperty(name: "logFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string LogFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#application_log_level LambdaFunction#application_log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "applicationLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApplicationLogLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#log_group LambdaFunction#log_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "logGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LogGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lambda_function#system_log_level LambdaFunction#system_log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "systemLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SystemLogLevel
        {
            get;
            set;
        }
    }
}
