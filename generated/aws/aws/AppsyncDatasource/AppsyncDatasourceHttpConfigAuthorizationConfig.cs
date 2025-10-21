using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiByValue(fqn: "aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfig")]
    public class AppsyncDatasourceHttpConfigAuthorizationConfig : aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#authorization_type AppsyncDatasource#authorization_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizationType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AuthorizationType
        {
            get;
            set;
        }

        /// <summary>aws_iam_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#aws_iam_config AppsyncDatasource#aws_iam_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "awsIamConfig", typeJson: "{\"fqn\":\"aws.appsyncDatasource.AppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig\"}", isOptional: true)]
        public aws.AppsyncDatasource.IAppsyncDatasourceHttpConfigAuthorizationConfigAwsIamConfig? AwsIamConfig
        {
            get;
            set;
        }
    }
}
