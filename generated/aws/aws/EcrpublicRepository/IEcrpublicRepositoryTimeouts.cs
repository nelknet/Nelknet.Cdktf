using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcrpublicRepository
{
    [JsiiInterface(nativeType: typeof(IEcrpublicRepositoryTimeouts), fullyQualifiedName: "aws.ecrpublicRepository.EcrpublicRepositoryTimeouts")]
    public interface IEcrpublicRepositoryTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#delete EcrpublicRepository#delete}.</summary>
        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Delete
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEcrpublicRepositoryTimeouts), fullyQualifiedName: "aws.ecrpublicRepository.EcrpublicRepositoryTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.EcrpublicRepository.IEcrpublicRepositoryTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecrpublic_repository#delete EcrpublicRepository#delete}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Delete
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
