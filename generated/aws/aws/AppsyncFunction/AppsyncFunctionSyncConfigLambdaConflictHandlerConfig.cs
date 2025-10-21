using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncFunction
{
    [JsiiByValue(fqn: "aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig")]
    public class AppsyncFunctionSyncConfigLambdaConflictHandlerConfig : aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#lambda_conflict_handler_arn AppsyncFunction#lambda_conflict_handler_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConflictHandlerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LambdaConflictHandlerArn
        {
            get;
            set;
        }
    }
}
