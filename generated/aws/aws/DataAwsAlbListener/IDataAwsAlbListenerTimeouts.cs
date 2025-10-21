using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAlbListener
{
    [JsiiInterface(nativeType: typeof(IDataAwsAlbListenerTimeouts), fullyQualifiedName: "aws.dataAwsAlbListener.DataAwsAlbListenerTimeouts")]
    public interface IDataAwsAlbListenerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#read DataAwsAlbListener#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAlbListenerTimeouts), fullyQualifiedName: "aws.dataAwsAlbListener.DataAwsAlbListenerTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAlbListener.IDataAwsAlbListenerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/alb_listener#read DataAwsAlbListener#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
