using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncDatasource.AppsyncDatasourceLambdaConfig")]
    public class AppsyncDatasourceLambdaConfig : aws.AppsyncDatasource.IAppsyncDatasourceLambdaConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#function_arn AppsyncDatasource#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        public string FunctionArn
        {
            get;
            set;
        }
    }
}
