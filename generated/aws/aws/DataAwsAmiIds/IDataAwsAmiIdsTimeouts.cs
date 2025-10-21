using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAmiIds
{
    [JsiiInterface(nativeType: typeof(IDataAwsAmiIdsTimeouts), fullyQualifiedName: "aws.dataAwsAmiIds.DataAwsAmiIdsTimeouts")]
    public interface IDataAwsAmiIdsTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#read DataAwsAmiIds#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAmiIdsTimeouts), fullyQualifiedName: "aws.dataAwsAmiIds.DataAwsAmiIdsTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAmiIds.IDataAwsAmiIdsTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ami_ids#read DataAwsAmiIds#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
