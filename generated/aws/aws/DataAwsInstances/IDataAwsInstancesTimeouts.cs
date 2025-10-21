using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsInstances
{
    [JsiiInterface(nativeType: typeof(IDataAwsInstancesTimeouts), fullyQualifiedName: "aws.dataAwsInstances.DataAwsInstancesTimeouts")]
    public interface IDataAwsInstancesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances#read DataAwsInstances#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsInstancesTimeouts), fullyQualifiedName: "aws.dataAwsInstances.DataAwsInstancesTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsInstances.IDataAwsInstancesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/instances#read DataAwsInstances#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
