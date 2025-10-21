using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRouteTable
{
    [JsiiInterface(nativeType: typeof(IDataAwsRouteTableTimeouts), fullyQualifiedName: "aws.dataAwsRouteTable.DataAwsRouteTableTimeouts")]
    public interface IDataAwsRouteTableTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#read DataAwsRouteTable#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsRouteTableTimeouts), fullyQualifiedName: "aws.dataAwsRouteTable.DataAwsRouteTableTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsRouteTable.IDataAwsRouteTableTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_table#read DataAwsRouteTable#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
