using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiByValue(fqn: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig")]
    public class AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig : aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#signing_region AppsyncDatasource#signing_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signingRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SigningRegion
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#signing_service_name AppsyncDatasource#signing_service_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "signingServiceName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SigningServiceName
        {
            get;
            set;
        }
    }
}
