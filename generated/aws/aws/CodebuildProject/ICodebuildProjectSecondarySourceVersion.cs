using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySourceVersion), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectSecondarySourceVersion")]
    public interface ICodebuildProjectSecondarySourceVersion
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#source_identifier CodebuildProject#source_identifier}.</summary>
        [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        string SourceIdentifier
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#source_version CodebuildProject#source_version}.</summary>
        [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}")]
        string SourceVersion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySourceVersion), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectSecondarySourceVersion")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildProject.ICodebuildProjectSecondarySourceVersion
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#source_identifier CodebuildProject#source_identifier}.</summary>
            [JsiiProperty(name: "sourceIdentifier", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceIdentifier
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#source_version CodebuildProject#source_version}.</summary>
            [JsiiProperty(name: "sourceVersion", typeJson: "{\"primitive\":\"string\"}")]
            public string SourceVersion
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
