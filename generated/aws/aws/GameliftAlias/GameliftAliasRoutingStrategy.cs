using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftAlias
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.gameliftAlias.GameliftAliasRoutingStrategy")]
    public class GameliftAliasRoutingStrategy : aws.GameliftAlias.IGameliftAliasRoutingStrategy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#type GameliftAlias#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#fleet_id GameliftAlias#fleet_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fleetId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FleetId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#message GameliftAlias#message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }
    }
}
