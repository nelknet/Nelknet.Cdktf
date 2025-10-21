using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncGraphqlApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiLogConfig), fullyQualifiedName: "aws.appsyncGraphqlApi.AppsyncGraphqlApiLogConfig")]
    public interface IAppsyncGraphqlApiLogConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#cloudwatch_logs_role_arn AppsyncGraphqlApi#cloudwatch_logs_role_arn}.</summary>
        [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string CloudwatchLogsRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#field_log_level AppsyncGraphqlApi#field_log_level}.</summary>
        [JsiiProperty(name: "fieldLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        string FieldLogLevel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#exclude_verbose_content AppsyncGraphqlApi#exclude_verbose_content}.</summary>
        [JsiiProperty(name: "excludeVerboseContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ExcludeVerboseContent
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiLogConfig), fullyQualifiedName: "aws.appsyncGraphqlApi.AppsyncGraphqlApiLogConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncGraphqlApi.IAppsyncGraphqlApiLogConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#cloudwatch_logs_role_arn AppsyncGraphqlApi#cloudwatch_logs_role_arn}.</summary>
            [JsiiProperty(name: "cloudwatchLogsRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string CloudwatchLogsRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#field_log_level AppsyncGraphqlApi#field_log_level}.</summary>
            [JsiiProperty(name: "fieldLogLevel", typeJson: "{\"primitive\":\"string\"}")]
            public string FieldLogLevel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#exclude_verbose_content AppsyncGraphqlApi#exclude_verbose_content}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "excludeVerboseContent", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ExcludeVerboseContent
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
