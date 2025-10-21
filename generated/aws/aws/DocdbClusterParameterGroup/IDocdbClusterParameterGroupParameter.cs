using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DocdbClusterParameterGroup
{
    [JsiiInterface(nativeType: typeof(IDocdbClusterParameterGroupParameter), fullyQualifiedName: "aws.docdbClusterParameterGroup.DocdbClusterParameterGroupParameter")]
    public interface IDocdbClusterParameterGroupParameter
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#name DocdbClusterParameterGroup#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#value DocdbClusterParameterGroup#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#apply_method DocdbClusterParameterGroup#apply_method}.</summary>
        [JsiiProperty(name: "applyMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApplyMethod
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDocdbClusterParameterGroupParameter), fullyQualifiedName: "aws.docdbClusterParameterGroup.DocdbClusterParameterGroupParameter")]
        internal sealed class _Proxy : DeputyBase, aws.DocdbClusterParameterGroup.IDocdbClusterParameterGroupParameter
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#name DocdbClusterParameterGroup#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#value DocdbClusterParameterGroup#value}.</summary>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/docdb_cluster_parameter_group#apply_method DocdbClusterParameterGroup#apply_method}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "applyMethod", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApplyMethod
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
