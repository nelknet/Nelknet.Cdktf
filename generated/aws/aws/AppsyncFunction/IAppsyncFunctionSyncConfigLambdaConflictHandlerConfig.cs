using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncFunction
{
    [JsiiInterface(nativeType: typeof(IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig), fullyQualifiedName: "aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig")]
    public interface IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#lambda_conflict_handler_arn AppsyncFunction#lambda_conflict_handler_arn}.</summary>
        [JsiiProperty(name: "lambdaConflictHandlerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LambdaConflictHandlerArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig), fullyQualifiedName: "aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#lambda_conflict_handler_arn AppsyncFunction#lambda_conflict_handler_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConflictHandlerArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LambdaConflictHandlerArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
