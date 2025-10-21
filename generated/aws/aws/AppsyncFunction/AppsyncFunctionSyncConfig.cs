using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncFunction
{
    [JsiiByValue(fqn: "aws.appsyncFunction.AppsyncFunctionSyncConfig")]
    public class AppsyncFunctionSyncConfig : aws.AppsyncFunction.IAppsyncFunctionSyncConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#conflict_detection AppsyncFunction#conflict_detection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictDetection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#conflict_handler AppsyncFunction#conflict_handler}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictHandler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictHandler
        {
            get;
            set;
        }

        /// <summary>lambda_conflict_handler_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#lambda_conflict_handler_config AppsyncFunction#lambda_conflict_handler_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConflictHandlerConfig", typeJson: "{\"fqn\":\"aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig\"}", isOptional: true)]
        public aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig
        {
            get;
            set;
        }
    }
}
