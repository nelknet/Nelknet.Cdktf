namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> = { assignments: ResizeArray<aws.GuarddutyThreatintelset.GuarddutyThreatintelsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset">aws_guardduty_threatintelset</a>.
    /// </summary>
    type GuarddutyThreatintelsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyThreatintelsetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyThreatintelsetState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyThreatintelsetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyThreatintelsetState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#activate-1">GuarddutyThreatintelset#activate</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "activate">]
        member _.Activate(state: GuarddutyThreatintelsetState<Missing, 'DetectorId, 'Format, 'Location, 'Name>, value: bool) : GuarddutyThreatintelsetState<Present, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Activate <- value)
            ({ assignments = state.assignments } : GuarddutyThreatintelsetState<Present, 'DetectorId, 'Format, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#activate-1">GuarddutyThreatintelset#activate</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "activate">]
        member _.Activate(state: GuarddutyThreatintelsetState<Missing, 'DetectorId, 'Format, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyThreatintelsetState<Present, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Activate <- value)
            ({ assignments = state.assignments } : GuarddutyThreatintelsetState<Present, 'DetectorId, 'Format, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#detector_id-1">GuarddutyThreatintelset#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyThreatintelsetState<'Activate, Missing, 'Format, 'Location, 'Name>, value: string) : GuarddutyThreatintelsetState<'Activate, Present, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyThreatintelsetState<'Activate, Present, 'Format, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#format-1">GuarddutyThreatintelset#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: GuarddutyThreatintelsetState<'Activate, 'DetectorId, Missing, 'Location, 'Name>, value: string) : GuarddutyThreatintelsetState<'Activate, 'DetectorId, Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Format <- value)
            ({ assignments = state.assignments } : GuarddutyThreatintelsetState<'Activate, 'DetectorId, Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#location-1">GuarddutyThreatintelset#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, Missing, 'Name>, value: string) : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#name-1">GuarddutyThreatintelset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, Missing>, value: string) : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#id-1">GuarddutyThreatintelset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>, value: string) : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#tags-1">GuarddutyThreatintelset#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>, value: seq<string * string>) : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_threatintelset#tags_all-1">GuarddutyThreatintelset#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>, value: seq<string * string>) : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GuarddutyThreatintelsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>

        member _.Run(state: GuarddutyThreatintelsetState<Present, Present, Present, Present, Present>) : aws.GuarddutyThreatintelset.GuarddutyThreatintelset =
            let config = aws.GuarddutyThreatintelset.GuarddutyThreatintelsetConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyThreatintelset.GuarddutyThreatintelset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyThreatintelset: missing required arguments. Must call: activate, detector_id, format, location, name.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyThreatintelsetState<_, _, _, _, _>) : aws.GuarddutyThreatintelset.GuarddutyThreatintelset =
            Unchecked.defaultof<aws.GuarddutyThreatintelset.GuarddutyThreatintelset>
