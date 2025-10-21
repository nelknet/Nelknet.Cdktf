using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DatasyncLocationNfs
{
    [JsiiInterface(nativeType: typeof(IDatasyncLocationNfsOnPremConfig), fullyQualifiedName: "aws.datasyncLocationNfs.DatasyncLocationNfsOnPremConfig")]
    public interface IDatasyncLocationNfsOnPremConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#agent_arns DatasyncLocationNfs#agent_arns}.</summary>
        [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AgentArns
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDatasyncLocationNfsOnPremConfig), fullyQualifiedName: "aws.datasyncLocationNfs.DatasyncLocationNfsOnPremConfig")]
        internal sealed class _Proxy : DeputyBase, aws.DatasyncLocationNfs.IDatasyncLocationNfsOnPremConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_nfs#agent_arns DatasyncLocationNfs#agent_arns}.</summary>
            [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AgentArns
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
