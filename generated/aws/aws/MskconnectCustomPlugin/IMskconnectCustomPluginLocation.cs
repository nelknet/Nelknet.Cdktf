using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MskconnectCustomPlugin
{
    [JsiiInterface(nativeType: typeof(IMskconnectCustomPluginLocation), fullyQualifiedName: "aws.mskconnectCustomPlugin.MskconnectCustomPluginLocation")]
    public interface IMskconnectCustomPluginLocation
    {
        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#s3 MskconnectCustomPlugin#s3}
        /// </remarks>
        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskconnectCustomPlugin.MskconnectCustomPluginLocationS3\"}")]
        aws.MskconnectCustomPlugin.IMskconnectCustomPluginLocationS3 S3
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMskconnectCustomPluginLocation), fullyQualifiedName: "aws.mskconnectCustomPlugin.MskconnectCustomPluginLocation")]
        internal sealed class _Proxy : DeputyBase, aws.MskconnectCustomPlugin.IMskconnectCustomPluginLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3 block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mskconnect_custom_plugin#s3 MskconnectCustomPlugin#s3}
            /// </remarks>
            [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.mskconnectCustomPlugin.MskconnectCustomPluginLocationS3\"}")]
            public aws.MskconnectCustomPlugin.IMskconnectCustomPluginLocationS3 S3
            {
                get => GetInstanceProperty<aws.MskconnectCustomPlugin.IMskconnectCustomPluginLocationS3>()!;
            }
        }
    }
}
