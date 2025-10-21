using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncResolver
{
    [JsiiInterface(nativeType: typeof(IAppsyncResolverSyncConfig), fullyQualifiedName: "aws.appsyncResolver.AppsyncResolverSyncConfig")]
    public interface IAppsyncResolverSyncConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#conflict_detection AppsyncResolver#conflict_detection}.</summary>
        [JsiiProperty(name: "conflictDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConflictDetection
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#conflict_handler AppsyncResolver#conflict_handler}.</summary>
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
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#lambda_conflict_handler_config AppsyncResolver#lambda_conflict_handler_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConflictHandlerConfig", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverSyncConfigLambdaConflictHandlerConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncResolver.IAppsyncResolverSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncResolverSyncConfig), fullyQualifiedName: "aws.appsyncResolver.AppsyncResolverSyncConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncResolver.IAppsyncResolverSyncConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#conflict_detection AppsyncResolver#conflict_detection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictDetection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictDetection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#conflict_handler AppsyncResolver#conflict_handler}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "conflictHandler", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConflictHandler
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_conflict_handler_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#lambda_conflict_handler_config AppsyncResolver#lambda_conflict_handler_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConflictHandlerConfig", typeJson: "{\"fqn\":\"aws.appsyncResolver.AppsyncResolverSyncConfigLambdaConflictHandlerConfig\"}", isOptional: true)]
            public aws.AppsyncResolver.IAppsyncResolverSyncConfigLambdaConflictHandlerConfig? LambdaConflictHandlerConfig
            {
                get => GetInstanceProperty<aws.AppsyncResolver.IAppsyncResolverSyncConfigLambdaConflictHandlerConfig?>();
            }
        }
    }
}
