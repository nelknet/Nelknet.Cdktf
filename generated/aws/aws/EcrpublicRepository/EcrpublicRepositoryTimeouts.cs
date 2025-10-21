using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrpublicRepository
{
    [JsiiByValue(fqn: "aws.ecrpublicRepository.EcrpublicRepositoryTimeouts")]
    public class EcrpublicRepositoryTimeouts : aws.EcrpublicRepository.IEcrpublicRepositoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#delete EcrpublicRepository#delete}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Delete
        {
            get;
            set;
        }
    }
}
