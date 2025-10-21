using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceHttpConfigAuthorizationConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig")]
    public interface IAppsyncDatasourceHttpConfigAuthorizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#authorization_type AppsyncDatasource#authorization_type}.</summary>
        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AuthorizationType
        {
            get
            {
                return null;
            }
        }

        /// <summary>aws_iam_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#aws_iam_config AppsyncDatasource#aws_iam_config}
        /// </remarks>
        [JsiiProperty(name: "awsIamConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig? AwsIamConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceHttpConfigAuthorizationConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#authorization_type AppsyncDatasource#authorization_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AuthorizationType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>aws_iam_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#aws_iam_config AppsyncDatasource#aws_iam_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsIamConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig? AwsIamConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig?>();
            }
        }
    }
}
