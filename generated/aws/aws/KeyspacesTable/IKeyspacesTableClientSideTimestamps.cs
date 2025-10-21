using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KeyspacesTable
{
    [JsiiInterface(nativeType: typeof(IKeyspacesTableClientSideTimestamps), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableClientSideTimestamps")]
    public interface IKeyspacesTableClientSideTimestamps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#status KeyspacesTable#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKeyspacesTableClientSideTimestamps), fullyQualifiedName: "aws.keyspacesTable.KeyspacesTableClientSideTimestamps")]
        internal sealed class _Proxy : DeputyBase, aws.KeyspacesTable.IKeyspacesTableClientSideTimestamps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/keyspaces_table#status KeyspacesTable#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
