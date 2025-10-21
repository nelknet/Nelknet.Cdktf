using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEbsVolumes
{
    [JsiiInterface(nativeType: typeof(IDataAwsEbsVolumesTimeouts), fullyQualifiedName: "aws.dataAwsEbsVolumes.DataAwsEbsVolumesTimeouts")]
    public interface IDataAwsEbsVolumesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#read DataAwsEbsVolumes#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEbsVolumesTimeouts), fullyQualifiedName: "aws.dataAwsEbsVolumes.DataAwsEbsVolumesTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEbsVolumes.IDataAwsEbsVolumesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ebs_volumes#read DataAwsEbsVolumes#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
