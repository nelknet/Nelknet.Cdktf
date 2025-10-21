using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CodeartifactRepository
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.codeartifactRepository.CodeartifactRepositoryExternalConnections")]
    public class CodeartifactRepositoryExternalConnections : aws.CodeartifactRepository.ICodeartifactRepositoryExternalConnections
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codeartifact_repository#external_connection_name CodeartifactRepository#external_connection_name}.</summary>
        [JsiiProperty(name: "externalConnectionName", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalConnectionName
        {
            get;
            set;
        }
    }
}
