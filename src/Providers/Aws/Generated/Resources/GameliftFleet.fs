namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GameliftFleetState<'Ec2InstanceType, 'Name> = { assignments: ResizeArray<aws.GameliftFleet.GameliftFleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet">aws_gamelift_fleet</a>.
    /// </summary>
    type GameliftFleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : GameliftFleetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftFleetState<Missing, Missing>)

        member _.Zero(()) : GameliftFleetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftFleetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#ec2_instance_type-1">GameliftFleet#ec2_instance_type</a>.
        /// </summary>
        [<CustomOperation "ec2_instance_type">]
        member _.Ec2InstanceType(state: GameliftFleetState<Missing, 'Name>, value: string) : GameliftFleetState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Ec2InstanceType <- value)
            ({ assignments = state.assignments } : GameliftFleetState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#name-1">GameliftFleet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GameliftFleetState<'Ec2InstanceType, Missing>, value: string) : GameliftFleetState<'Ec2InstanceType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GameliftFleetState<'Ec2InstanceType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#build_id-1">GameliftFleet#build_id</a>.
        /// </summary>
        [<CustomOperation "build_id">]
        member _.BuildId(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: string) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.BuildId <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// certificate_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#certificate_configuration-1">GameliftFleet#certificate_configuration</a>
        /// </summary>
        [<CustomOperation "certificate_configuration">]
        member _.CertificateConfiguration(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: aws.GameliftFleet.GameliftFleetCertificateConfiguration) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.CertificateConfiguration <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#description-1">GameliftFleet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: string) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// ec2_inbound_permission block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#ec2_inbound_permission-1">GameliftFleet#ec2_inbound_permission</a> Accepts: aws.IResolvable | aws.GameliftFleet.GameliftFleetEc2InboundPermission[]
        /// </summary>
        [<CustomOperation "ec2_inbound_permission">]
        member _.Ec2InboundPermission(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Ec2InboundPermission <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#fleet_type-1">GameliftFleet#fleet_type</a>.
        /// </summary>
        [<CustomOperation "fleet_type">]
        member _.FleetType(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: string) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.FleetType <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#id-1">GameliftFleet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: string) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#instance_role_arn-1">GameliftFleet#instance_role_arn</a>.
        /// </summary>
        [<CustomOperation "instance_role_arn">]
        member _.InstanceRoleArn(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: string) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.InstanceRoleArn <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#metric_groups-1">GameliftFleet#metric_groups</a>.
        /// </summary>
        [<CustomOperation "metric_groups">]
        member _.MetricGroups(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: seq<string>) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.MetricGroups <- (value |> Seq.toArray))
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#new_game_session_protection_policy-1">GameliftFleet#new_game_session_protection_policy</a>.
        /// </summary>
        [<CustomOperation "new_game_session_protection_policy">]
        member _.NewGameSessionProtectionPolicy(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: string) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.NewGameSessionProtectionPolicy <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// resource_creation_limit_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#resource_creation_limit_policy-1">GameliftFleet#resource_creation_limit_policy</a>
        /// </summary>
        [<CustomOperation "resource_creation_limit_policy">]
        member _.ResourceCreationLimitPolicy(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: aws.GameliftFleet.GameliftFleetResourceCreationLimitPolicy) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ResourceCreationLimitPolicy <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// runtime_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#runtime_configuration-1">GameliftFleet#runtime_configuration</a>
        /// </summary>
        [<CustomOperation "runtime_configuration">]
        member _.RuntimeConfiguration(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: aws.GameliftFleet.GameliftFleetRuntimeConfiguration) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.RuntimeConfiguration <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#script_id-1">GameliftFleet#script_id</a>.
        /// </summary>
        [<CustomOperation "script_id">]
        member _.ScriptId(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: string) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.ScriptId <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#tags-1">GameliftFleet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: seq<string * string>) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#tags_all-1">GameliftFleet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: seq<string * string>) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_fleet#timeouts-1">GameliftFleet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GameliftFleetState<'Ec2InstanceType, 'Name>, value: aws.GameliftFleet.GameliftFleetTimeouts) : GameliftFleetState<'Ec2InstanceType, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GameliftFleetState<'Ec2InstanceType, 'Name>

        member _.Run(state: GameliftFleetState<Present, Present>) : aws.GameliftFleet.GameliftFleet =
            let config = aws.GameliftFleet.GameliftFleetConfig()
            for setter in state.assignments do
                setter config
            aws.GameliftFleet.GameliftFleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gameliftFleet: missing required arguments. Must call: ec2_instance_type, name.", 9999, IsError = true)>]
        member _.Run(_: GameliftFleetState<_, _>) : aws.GameliftFleet.GameliftFleet =
            Unchecked.defaultof<aws.GameliftFleet.GameliftFleet>
