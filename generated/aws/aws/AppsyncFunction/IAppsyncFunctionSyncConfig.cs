using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncFunction
{
    [JsiiInterface(nativeType: typeof(IAppsyncFunctionSyncConfig), fullyQualifiedName: "aws.appsyncFunction.AppsyncFunctionSyncConfig")]
    public interface IAppsyncFunctionSyncConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#conflict_detection AppsyncFunction#conflict_detection}.</summary>
        [JsiiProperty(name: "conflictDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConflictDetection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#conflict_handler AppsyncFunction#conflict_handler}.</summary>
        [JsiiProperty(name: "conflictHandler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConflictHandler
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_conflict_handler_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#lambda_conflict_handler_config AppsyncFunction#lambda_conflict_handler_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConflictHandlerConfig", typeJson: "{\"fqn\":\"aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncFunctionSyncConfig), fullyQualifiedName: "aws.appsyncFunction.AppsyncFunctionSyncConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncFunction.IAppsyncFunctionSyncConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#conflict_detection AppsyncFunction#conflict_detection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictDetection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#conflict_handler AppsyncFunction#conflict_handler}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictHandler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictHandler
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_conflict_handler_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#lambda_conflict_handler_config AppsyncFunction#lambda_conflict_handler_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConflictHandlerConfig", typeJson: "{\"fqn\":\"aws.appsyncFunction.AppsyncFunctionSyncConfigLambdaConflictHandlerConfig\"}", isOptional: true)]
            public aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig
            {
                get => GetInstanceProperty<aws.AppsyncFunction.IAppsyncFunctionSyncConfigLambdaConflictHandlerConfig?>();
            }
        }
    }
}
