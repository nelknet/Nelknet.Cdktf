using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftFleet
{
    [JsiiByValue(fqn: "aws.gameliftFleet.GameliftFleetCertificateConfiguration")]
    public class GameliftFleetCertificateConfiguration : aws.GameliftFleet.IGameliftFleetCertificateConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#certificate_type GameliftFleet#certificate_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "certificateType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CertificateType
        {
            get;
            set;
        }
    }
}
