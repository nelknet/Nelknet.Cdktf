using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogLaunchPaths
{
    [JsiiByValue(fqn: "aws.dataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsTimeouts")]
    public class DataAwsServicecatalogLaunchPathsTimeouts : aws.DataAwsServicecatalogLaunchPaths.IDataAwsServicecatalogLaunchPathsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/servicecatalog_launch_paths#read DataAwsServicecatalogLaunchPaths#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
