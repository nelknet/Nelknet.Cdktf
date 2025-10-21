using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig")]
    public interface IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#signing_region AppsyncDatasource#signing_region}.</summary>
        [JsiiProperty(name: "signingRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SigningRegion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#signing_service_name AppsyncDatasource#signing_service_name}.</summary>
        [JsiiProperty(name: "signingServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SigningServiceName
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#signing_region AppsyncDatasource#signing_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signingRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SigningRegion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#signing_service_name AppsyncDatasource#signing_service_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "signingServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SigningServiceName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
