using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsGlueScript
{
    [JsiiInterface(nativeType: typeof(IDataAwsGlueScriptDagEdge), fullyQualifiedName: "aws.dataAwsGlueScript.DataAwsGlueScriptDagEdge")]
    public interface IDataAwsGlueScriptDagEdge
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#source DataAwsGlueScript#source}.</summary>
        [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
        string Source
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#target DataAwsGlueScript#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
        string Target
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#target_parameter DataAwsGlueScript#target_parameter}.</summary>
        [JsiiProperty(name: "targetParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TargetParameter
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsGlueScriptDagEdge), fullyQualifiedName: "aws.dataAwsGlueScript.DataAwsGlueScriptDagEdge")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsGlueScript.IDataAwsGlueScriptDagEdge
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#source DataAwsGlueScript#source}.</summary>
            [JsiiProperty(name: "source", typeJson: "{\"primitive\":\"string\"}")]
            public string Source
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#target DataAwsGlueScript#target}.</summary>
            [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}")]
            public string Target
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/glue_script#target_parameter DataAwsGlueScript#target_parameter}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "targetParameter", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TargetParameter
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
