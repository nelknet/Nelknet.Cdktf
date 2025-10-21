using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncResolver
{
    [JsiiByValue(fqn: "aws.appsyncResolver.AppsyncResolverSyncConfig")]
    public class AppsyncResolverSyncConfig : aws.AppsyncResolver.IAppsyncResolverSyncConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#conflict_detection AppsyncResolver#conflict_detection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictDetection
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#conflict_handler AppsyncResolver#conflict_handler}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "conflictHandler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ConflictHandler
        {
            get;
            set;
        }

        /// <summary>lambda_conflict_handler_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#lambda_conflict_handler_config AppsyncResolver#lambda_conflict_handler_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConflictHandlerConfig", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverSyncConfigLambdaConflictHandlerConfig\"}", isOptional: true)]
        public aws.AppsyncResolver.IAppsyncResolverSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig
        {
            get;
            set;
        }
    }
}
