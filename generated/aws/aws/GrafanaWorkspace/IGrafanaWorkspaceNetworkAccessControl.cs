using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GrafanaWorkspace
{
    [JsiiInterface(nativeType: typeof(IGrafanaWorkspaceNetworkAccessControl), fullyQualifiedName: "aws.grafanaWorkspace.GrafanaWorkspaceNetworkAccessControl")]
    public interface IGrafanaWorkspaceNetworkAccessControl
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#prefix_list_ids GrafanaWorkspace#prefix_list_ids}.</summary>
        [JsiiProperty(name: "prefixListIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] PrefixListIds
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#vpce_ids GrafanaWorkspace#vpce_ids}.</summary>
        [JsiiProperty(name: "vpceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] VpceIds
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGrafanaWorkspaceNetworkAccessControl), fullyQualifiedName: "aws.grafanaWorkspace.GrafanaWorkspaceNetworkAccessControl")]
        internal sealed class _Proxy : DeputyBase, aws.GrafanaWorkspace.IGrafanaWorkspaceNetworkAccessControl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#prefix_list_ids GrafanaWorkspace#prefix_list_ids}.</summary>
            [JsiiProperty(name: "prefixListIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] PrefixListIds
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/grafana_workspace#vpce_ids GrafanaWorkspace#vpce_ids}.</summary>
            [JsiiProperty(name: "vpceIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] VpceIds
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
