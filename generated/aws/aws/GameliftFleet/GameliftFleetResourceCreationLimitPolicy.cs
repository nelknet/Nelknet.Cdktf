using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GameliftFleet
{
    [JsiiByValue(fqn: "aws.gameliftFleet.GameliftFleetResourceCreationLimitPolicy")]
    public class GameliftFleetResourceCreationLimitPolicy : aws.GameliftFleet.IGameliftFleetResourceCreationLimitPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#new_game_sessions_per_creator GameliftFleet#new_game_sessions_per_creator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "newGameSessionsPerCreator", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? NewGameSessionsPerCreator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#policy_period_in_minutes GameliftFleet#policy_period_in_minutes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "policyPeriodInMinutes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? PolicyPeriodInMinutes
        {
            get;
            set;
        }
    }
}
