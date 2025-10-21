using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncResolver
{
    [JsiiInterface(nativeType: typeof(IAppsyncResolverSyncConfigLambdaConflictHandlerConfig), fullyQualifiedName: "aws.appsyncResolver.AppsyncResolverSyncConfigLambdaConflictHandlerConfig")]
    public interface IAppsyncResolverSyncConfigLambdaConflictHandlerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#lambda_conflict_handler_arn AppsyncResolver#lambda_conflict_handler_arn}.</summary>
        [JsiiProperty(name: "lambdaConflictHandlerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaConflictHandlerArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncResolverSyncConfigLambdaConflictHandlerConfig), fullyQualifiedName: "aws.appsyncResolver.AppsyncResolverSyncConfigLambdaConflictHandlerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncResolver.IAppsyncResolverSyncConfigLambdaConflictHandlerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#lambda_conflict_handler_arn AppsyncResolver#lambda_conflict_handler_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConflictHandlerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaConflictHandlerArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
