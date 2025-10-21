using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodecatalystDevEnvironment
{
    [JsiiByValue(fqn: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentIdes")]
    public class CodecatalystDevEnvironmentIdes : aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentIdes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#name CodecatalystDevEnvironment#name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#runtime CodecatalystDevEnvironment#runtime}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Runtime
        {
            get;
            set;
        }
    }
}
