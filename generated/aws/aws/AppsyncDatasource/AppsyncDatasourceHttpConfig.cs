using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncDatasource.AppsyncDatasourceHttpConfig")]
    public class AppsyncDatasourceHttpConfig : aws.AppsyncDatasource.IAppsyncDatasourceHttpConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#endpoint AppsyncDatasource#endpoint}.</summary>
        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public string Endpoint
        {
            get;
            set;
        }

        /// <summary>authorization_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#authorization_config AppsyncDatasource#authorization_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig\"}", isOptional: true)]
        public aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig? AuthorizationConfig
        {
            get;
            set;
        }
    }
}
