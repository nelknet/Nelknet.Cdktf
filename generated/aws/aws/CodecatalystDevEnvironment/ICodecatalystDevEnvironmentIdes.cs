using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodecatalystDevEnvironment
{
    [JsiiInterface(nativeType: typeof(ICodecatalystDevEnvironmentIdes), fullyQualifiedName: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentIdes")]
    public interface ICodecatalystDevEnvironmentIdes
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#name CodecatalystDevEnvironment#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#runtime CodecatalystDevEnvironment#runtime}.</summary>
        [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Runtime
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodecatalystDevEnvironmentIdes), fullyQualifiedName: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentIdes")]
        internal sealed class _Proxy : DeputyBase, aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentIdes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#name CodecatalystDevEnvironment#name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#runtime CodecatalystDevEnvironment#runtime}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "runtime", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Runtime
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
