using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.FinspaceKxDataview
{
    [JsiiInterface(nativeType: typeof(IFinspaceKxDataviewSegmentConfigurations), fullyQualifiedName: "aws.finspaceKxDataview.FinspaceKxDataviewSegmentConfigurations")]
    public interface IFinspaceKxDataviewSegmentConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#db_paths FinspaceKxDataview#db_paths}.</summary>
        [JsiiProperty(name: "dbPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] DbPaths
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#volume_name FinspaceKxDataview#volume_name}.</summary>
        [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}")]
        string VolumeName
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#on_demand FinspaceKxDataview#on_demand}.</summary>
        [JsiiProperty(name: "onDemand", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? OnDemand
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFinspaceKxDataviewSegmentConfigurations), fullyQualifiedName: "aws.finspaceKxDataview.FinspaceKxDataviewSegmentConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.FinspaceKxDataview.IFinspaceKxDataviewSegmentConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#db_paths FinspaceKxDataview#db_paths}.</summary>
            [JsiiProperty(name: "dbPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] DbPaths
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#volume_name FinspaceKxDataview#volume_name}.</summary>
            [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}")]
            public string VolumeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_dataview#on_demand FinspaceKxDataview#on_demand}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onDemand", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? OnDemand
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
