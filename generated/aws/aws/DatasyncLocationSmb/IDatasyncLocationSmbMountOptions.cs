using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationSmb
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationSmbMountOptions), fullyQualifiedName: "aws.datasyncLocationSmb.DatasyncLocationSmbMountOptions")]
    public interface IDatasyncLocationSmbMountOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#version DatasyncLocationSmb#version}.</summary>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationSmbMountOptions), fullyQualifiedName: "aws.datasyncLocationSmb.DatasyncLocationSmbMountOptions")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationSmb.IDatasyncLocationSmbMountOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_smb#version DatasyncLocationSmb#version}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Version
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
