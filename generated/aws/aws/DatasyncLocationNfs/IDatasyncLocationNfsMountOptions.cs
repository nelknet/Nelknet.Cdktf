using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationNfs
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationNfsMountOptions), fullyQualifiedName: "aws.datasyncLocationNfs.DatasyncLocationNfsMountOptions")]
    public interface IDatasyncLocationNfsMountOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#version DatasyncLocationNfs#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationNfsMountOptions), fullyQualifiedName: "aws.datasyncLocationNfs.DatasyncLocationNfsMountOptions")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationNfs.IDatasyncLocationNfsMountOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#version DatasyncLocationNfs#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
