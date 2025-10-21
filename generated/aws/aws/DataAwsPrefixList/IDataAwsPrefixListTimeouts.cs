using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsPrefixList
{
    [JsiiInterface(nativeType: typeof(IDataAwsPrefixListTimeouts), fullyQualifiedName: "aws.dataAwsPrefixList.DataAwsPrefixListTimeouts")]
    public interface IDataAwsPrefixListTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#read DataAwsPrefixList#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsPrefixListTimeouts), fullyQualifiedName: "aws.dataAwsPrefixList.DataAwsPrefixListTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsPrefixList.IDataAwsPrefixListTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#read DataAwsPrefixList#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
