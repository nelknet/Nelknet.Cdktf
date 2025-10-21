using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncResolver
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncResolver.AppsyncResolverRuntime")]
    public class AppsyncResolverRuntime : aws.AppsyncResolver.IAppsyncResolverRuntime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#name AppsyncResolver#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_resolver#runtime_version AppsyncResolver#runtime_version}.</summary>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string RuntimeVersion
        {
            get;
            set;
        }
    }
}
