using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncResolver
{
    [JsiiByValue(fqn: "aws.appsyncResolver.AppsyncResolverSyncConfigLambdaConflictHandlerConfig")]
    public class AppsyncResolverSyncConfigLambdaConflictHandlerConfig : aws.AppsyncResolver.IAppsyncResolverSyncConfigLambdaConflictHandlerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#lambda_conflict_handler_arn AppsyncResolver#lambda_conflict_handler_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConflictHandlerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LambdaConflictHandlerArn
        {
            get;
            set;
        }
    }
}
