using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftFleet
{
    [JsiiInterface(nativeType: typeof(IGameliftFleetCertificateConfiguration), fullyQualifiedName: "aws.gameliftFleet.GameliftFleetCertificateConfiguration")]
    public interface IGameliftFleetCertificateConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#certificate_type GameliftFleet#certificate_type}.</summary>
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CertificateType
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IGameliftFleetCertificateConfiguration), fullyQualifiedName: "aws.gameliftFleet.GameliftFleetCertificateConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.GameliftFleet.IGameliftFleetCertificateConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#certificate_type GameliftFleet#certificate_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CertificateType
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
