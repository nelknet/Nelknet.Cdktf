using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodeartifactRepository
{
    [JsiiInterface(nativeType: typeof(ICodeartifactRepositoryExternalConnections), fullyQualifiedName: "aws.codeartifactRepository.CodeartifactRepositoryExternalConnections")]
    public interface ICodeartifactRepositoryExternalConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#external_connection_name CodeartifactRepository#external_connection_name}.</summary>
        [JsiiProperty(name: "externalConnectionName", typeJson: "{\"primitive\":\"string\"}")]
        string ExternalConnectionName
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICodeartifactRepositoryExternalConnections), fullyQualifiedName: "aws.codeartifactRepository.CodeartifactRepositoryExternalConnections")]
        internal sealed class _Proxy : DeputyBase, aws.CodeartifactRepository.ICodeartifactRepositoryExternalConnections
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#external_connection_name CodeartifactRepository#external_connection_name}.</summary>
            [JsiiProperty(name: "externalConnectionName", typeJson: "{\"primitive\":\"string\"}")]
            public string ExternalConnectionName
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
