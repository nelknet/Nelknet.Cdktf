using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncFunction
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncFunction.AppsyncFunctionRuntime")]
    public class AppsyncFunctionRuntime : aws.AppsyncFunction.IAppsyncFunctionRuntime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#name AppsyncFunction#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_function#runtime_version AppsyncFunction#runtime_version}.</summary>
        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string RuntimeVersion
        {
            get;
            set;
        }
    }
}
