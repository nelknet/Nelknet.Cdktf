using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcPeeringConnection
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpcPeeringConnectionTimeouts), fullyQualifiedName: "aws.dataAwsVpcPeeringConnection.DataAwsVpcPeeringConnectionTimeouts")]
    public interface IDataAwsVpcPeeringConnectionTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#read DataAwsVpcPeeringConnection#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpcPeeringConnectionTimeouts), fullyQualifiedName: "aws.dataAwsVpcPeeringConnection.DataAwsVpcPeeringConnectionTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpcPeeringConnection.IDataAwsVpcPeeringConnectionTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_peering_connection#read DataAwsVpcPeeringConnection#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
