using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodecatalystDevEnvironment
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorage")]
    public class CodecatalystDevEnvironmentPersistentStorage : aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentPersistentStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#size CodecatalystDevEnvironment#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        public double Size
        {
            get;
            set;
        }
    }
}
