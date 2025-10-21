using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceHttpConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfig")]
    public interface IAppsyncDatasourceHttpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#endpoint AppsyncDatasource#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        string Endpoint
        {
            get;
        }

        /// <summary>authorization_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#authorization_config AppsyncDatasource#authorization_config}
        /// </remarks>
        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig? AuthorizationConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceHttpConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#endpoint AppsyncDatasource#endpoint}.</summary>
            [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
            public string Endpoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>authorization_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#authorization_config AppsyncDatasource#authorization_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig\"}", isOptional: true)]
            public aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig? AuthorizationConfig
            {
                get => GetInstanceProperty<aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig?>();
            }
        }
    }
}
