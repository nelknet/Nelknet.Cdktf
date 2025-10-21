using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncResolver
{
    [JsiiByValue(fqn: "aws.appsyncResolver.AppsyncResolverPipelineConfig")]
    public class AppsyncResolverPipelineConfig : aws.AppsyncResolver.IAppsyncResolverPipelineConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#functions AppsyncResolver#functions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "functions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Functions
        {
            get;
            set;
        }
    }
}
