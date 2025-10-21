namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId> = { assignments: ResizeArray<aws.SsmcontactsRotation.SsmcontactsRotationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation">aws_ssmcontacts_rotation</a>.
    /// </summary>
    type SsmcontactsRotationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmcontactsRotationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsRotationState<Missing, Missing, Missing>)

        member _.Zero(()) : SsmcontactsRotationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsmcontactsRotationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#contact_ids-1">SsmcontactsRotation#contact_ids</a>.
        /// </summary>
        [<CustomOperation "contact_ids">]
        member _.ContactIds(state: SsmcontactsRotationState<Missing, 'Name, 'TimeZoneId>, value: seq<string>) : SsmcontactsRotationState<Present, 'Name, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.ContactIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : SsmcontactsRotationState<Present, 'Name, 'TimeZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#name-1">SsmcontactsRotation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmcontactsRotationState<'ContactIds, Missing, 'TimeZoneId>, value: string) : SsmcontactsRotationState<'ContactIds, Present, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SsmcontactsRotationState<'ContactIds, Present, 'TimeZoneId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#time_zone_id-1">SsmcontactsRotation#time_zone_id</a>.
        /// </summary>
        [<CustomOperation "time_zone_id">]
        member _.TimeZoneId(state: SsmcontactsRotationState<'ContactIds, 'Name, Missing>, value: string) : SsmcontactsRotationState<'ContactIds, 'Name, Present> =
            state.assignments.Add(fun config -> config.TimeZoneId <- value)
            ({ assignments = state.assignments } : SsmcontactsRotationState<'ContactIds, 'Name, Present>)

        /// <summary>
        /// recurrence block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#recurrence-1">SsmcontactsRotation#recurrence</a> Accepts: aws.IResolvable | aws.SsmcontactsRotation.SsmcontactsRotationRecurrence[]
        /// </summary>
        [<CustomOperation "recurrence">]
        member _.Recurrence(state: SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId>, value: HashiCorp.Cdktf.IResolvable) : SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Recurrence <- value)
            state : SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#start_time-1">SsmcontactsRotation#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId>, value: string) : SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#tags-1">SsmcontactsRotation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId>, value: seq<string * string>) : SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmcontactsRotationState<'ContactIds, 'Name, 'TimeZoneId>

        member _.Run(state: SsmcontactsRotationState<Present, Present, Present>) : aws.SsmcontactsRotation.SsmcontactsRotation =
            let config = aws.SsmcontactsRotation.SsmcontactsRotationConfig()
            for setter in state.assignments do
                setter config
            aws.SsmcontactsRotation.SsmcontactsRotation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmcontactsRotation: missing required arguments. Must call: contact_ids, name, time_zone_id.", 9999, IsError = true)>]
        member _.Run(_: SsmcontactsRotationState<_, _, _>) : aws.SsmcontactsRotation.SsmcontactsRotation =
            Unchecked.defaultof<aws.SsmcontactsRotation.SsmcontactsRotation>
