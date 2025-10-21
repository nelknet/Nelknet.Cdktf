using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MemorydbUser
{
    [JsiiInterface(nativeType: typeof(IMemorydbUserAuthenticationMode), fullyQualifiedName: "aws.memorydbUser.MemorydbUserAuthenticationMode")]
    public interface IMemorydbUserAuthenticationMode
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#type MemorydbUser#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#passwords MemorydbUser#passwords}.</summary>
        [JsiiProperty(name: "passwords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Passwords
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMemorydbUserAuthenticationMode), fullyQualifiedName: "aws.memorydbUser.MemorydbUserAuthenticationMode")]
        internal sealed class _Proxy : DeputyBase, aws.MemorydbUser.IMemorydbUserAuthenticationMode
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#type MemorydbUser#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/memorydb_user#passwords MemorydbUser#passwords}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "passwords", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Passwords
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
