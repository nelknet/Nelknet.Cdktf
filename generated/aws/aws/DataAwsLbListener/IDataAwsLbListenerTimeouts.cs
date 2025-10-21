using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListener
{
    [JsiiInterface(nativeType: typeof(IDataAwsLbListenerTimeouts), fullyQualifiedName: "aws.dataAwsLbListener.DataAwsLbListenerTimeouts")]
    public interface IDataAwsLbListenerTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#read DataAwsLbListener#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsLbListenerTimeouts), fullyQualifiedName: "aws.dataAwsLbListener.DataAwsLbListenerTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsLbListener.IDataAwsLbListenerTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/lb_listener#read DataAwsLbListener#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
