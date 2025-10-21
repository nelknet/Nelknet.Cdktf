using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodecatalystDevEnvironment
{
    [JsiiInterface(nativeType: typeof(ICodecatalystDevEnvironmentPersistentStorage), fullyQualifiedName: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorage")]
    public interface ICodecatalystDevEnvironmentPersistentStorage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#size CodecatalystDevEnvironment#size}.</summary>
        [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
        double Size
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodecatalystDevEnvironmentPersistentStorage), fullyQualifiedName: "aws.codecatalystDevEnvironment.CodecatalystDevEnvironmentPersistentStorage")]
        internal sealed class _Proxy : DeputyBase, aws.CodecatalystDevEnvironment.ICodecatalystDevEnvironmentPersistentStorage
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codecatalyst_dev_environment#size CodecatalystDevEnvironment#size}.</summary>
            [JsiiProperty(name: "size", typeJson: "{\"primitive\":\"number\"}")]
            public double Size
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
