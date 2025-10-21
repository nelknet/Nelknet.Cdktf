using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsRouteTables
{
    [JsiiInterface(nativeType: typeof(IDataAwsRouteTablesTimeouts), fullyQualifiedName: "aws.dataAwsRouteTables.DataAwsRouteTablesTimeouts")]
    public interface IDataAwsRouteTablesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables#read DataAwsRouteTables#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsRouteTablesTimeouts), fullyQualifiedName: "aws.dataAwsRouteTables.DataAwsRouteTablesTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsRouteTables.IDataAwsRouteTablesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/route_tables#read DataAwsRouteTables#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
