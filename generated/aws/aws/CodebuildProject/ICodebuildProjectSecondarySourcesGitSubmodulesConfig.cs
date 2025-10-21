using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectSecondarySourcesGitSubmodulesConfig), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
    public interface ICodebuildProjectSecondarySourcesGitSubmodulesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#fetch_submodules CodebuildProject#fetch_submodules}.</summary>
        [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object FetchSubmodules
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectSecondarySourcesGitSubmodulesConfig), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectSecondarySourcesGitSubmodulesConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildProject.ICodebuildProjectSecondarySourcesGitSubmodulesConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#fetch_submodules CodebuildProject#fetch_submodules}.</summary>
            [JsiiProperty(name: "fetchSubmodules", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object FetchSubmodules
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
