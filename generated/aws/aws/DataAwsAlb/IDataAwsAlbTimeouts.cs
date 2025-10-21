using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAlb
{
    [JsiiInterface(nativeType: typeof(IDataAwsAlbTimeouts), fullyQualifiedName: "aws.dataAwsAlb.DataAwsAlbTimeouts")]
    public interface IDataAwsAlbTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#read DataAwsAlb#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAlbTimeouts), fullyQualifiedName: "aws.dataAwsAlb.DataAwsAlbTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAlb.IDataAwsAlbTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb#read DataAwsAlb#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
