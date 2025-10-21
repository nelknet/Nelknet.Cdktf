namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name> = { assignments: ResizeArray<aws.SesEventDestination.SesEventDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination">aws_ses_event_destination</a>.
    /// </summary>
    type SesEventDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SesEventDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SesEventDestinationState<Missing, Missing, Missing>)

        member _.Zero(()) : SesEventDestinationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SesEventDestinationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#configuration_set_name-1">SesEventDestination#configuration_set_name</a>.
        /// </summary>
        [<CustomOperation "configuration_set_name">]
        member _.ConfigurationSetName(state: SesEventDestinationState<Missing, 'MatchingTypes, 'Name>, value: string) : SesEventDestinationState<Present, 'MatchingTypes, 'Name> =
            state.assignments.Add(fun config -> config.ConfigurationSetName <- value)
            ({ assignments = state.assignments } : SesEventDestinationState<Present, 'MatchingTypes, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#matching_types-1">SesEventDestination#matching_types</a>.
        /// </summary>
        [<CustomOperation "matching_types">]
        member _.MatchingTypes(state: SesEventDestinationState<'ConfigurationSetName, Missing, 'Name>, value: seq<string>) : SesEventDestinationState<'ConfigurationSetName, Present, 'Name> =
            state.assignments.Add(fun config -> config.MatchingTypes <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SesEventDestinationState<'ConfigurationSetName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#name-1">SesEventDestination#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, Missing>, value: string) : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, Present>)

        /// <summary>
        /// cloudwatch_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#cloudwatch_destination-1">SesEventDestination#cloudwatch_destination</a> Accepts: aws.IResolvable | aws.SesEventDestination.SesEventDestinationCloudwatchDestination[]
        /// </summary>
        [<CustomOperation "cloudwatch_destination">]
        member _.CloudwatchDestination(state: SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name> =
            state.assignments.Add(fun config -> config.CloudwatchDestination <- value)
            state : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#enabled-1">SesEventDestination#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>, value: bool) : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#enabled-1">SesEventDestination#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>, value: HashiCorp.Cdktf.IResolvable) : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#id-1">SesEventDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>, value: string) : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>

        /// <summary>
        /// kinesis_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#kinesis_destination-1">SesEventDestination#kinesis_destination</a>
        /// </summary>
        [<CustomOperation "kinesis_destination">]
        member _.KinesisDestination(state: SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>, value: aws.SesEventDestination.SesEventDestinationKinesisDestination) : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name> =
            state.assignments.Add(fun config -> config.KinesisDestination <- value)
            state : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>

        /// <summary>
        /// sns_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ses_event_destination#sns_destination-1">SesEventDestination#sns_destination</a>
        /// </summary>
        [<CustomOperation "sns_destination">]
        member _.SnsDestination(state: SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>, value: aws.SesEventDestination.SesEventDestinationSnsDestination) : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name> =
            state.assignments.Add(fun config -> config.SnsDestination <- value)
            state : SesEventDestinationState<'ConfigurationSetName, 'MatchingTypes, 'Name>

        member _.Run(state: SesEventDestinationState<Present, Present, Present>) : aws.SesEventDestination.SesEventDestination =
            let config = aws.SesEventDestination.SesEventDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.SesEventDestination.SesEventDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sesEventDestination: missing required arguments. Must call: configuration_set_name, matching_types, name.", 9999, IsError = true)>]
        member _.Run(_: SesEventDestinationState<_, _, _>) : aws.SesEventDestination.SesEventDestination =
            Unchecked.defaultof<aws.SesEventDestination.SesEventDestination>
