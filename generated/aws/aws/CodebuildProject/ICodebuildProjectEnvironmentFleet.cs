using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodebuildProject
{
    [JsiiInterface(nativeType: typeof(ICodebuildProjectEnvironmentFleet), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectEnvironmentFleet")]
    public interface ICodebuildProjectEnvironmentFleet
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#fleet_arn CodebuildProject#fleet_arn}.</summary>
        [JsiiProperty(name: "fleetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FleetArn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICodebuildProjectEnvironmentFleet), fullyQualifiedName: "aws.codebuildProject.CodebuildProjectEnvironmentFleet")]
        internal sealed class _Proxy : DeputyBase, aws.CodebuildProject.ICodebuildProjectEnvironmentFleet
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codebuild_project#fleet_arn CodebuildProject#fleet_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "fleetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FleetArn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
