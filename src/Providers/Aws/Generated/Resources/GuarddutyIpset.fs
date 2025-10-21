namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> = { assignments: ResizeArray<aws.GuarddutyIpset.GuarddutyIpsetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset">aws_guardduty_ipset</a>.
    /// </summary>
    type GuarddutyIpsetBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyIpsetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyIpsetState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyIpsetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyIpsetState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#activate-1">GuarddutyIpset#activate</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "activate">]
        member _.Activate(state: GuarddutyIpsetState<Missing, 'DetectorId, 'Format, 'Location, 'Name>, value: bool) : GuarddutyIpsetState<Present, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Activate <- value)
            ({ assignments = state.assignments } : GuarddutyIpsetState<Present, 'DetectorId, 'Format, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#activate-1">GuarddutyIpset#activate</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "activate">]
        member _.Activate(state: GuarddutyIpsetState<Missing, 'DetectorId, 'Format, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyIpsetState<Present, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Activate <- value)
            ({ assignments = state.assignments } : GuarddutyIpsetState<Present, 'DetectorId, 'Format, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#detector_id-1">GuarddutyIpset#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyIpsetState<'Activate, Missing, 'Format, 'Location, 'Name>, value: string) : GuarddutyIpsetState<'Activate, Present, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyIpsetState<'Activate, Present, 'Format, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#format-1">GuarddutyIpset#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: GuarddutyIpsetState<'Activate, 'DetectorId, Missing, 'Location, 'Name>, value: string) : GuarddutyIpsetState<'Activate, 'DetectorId, Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Format <- value)
            ({ assignments = state.assignments } : GuarddutyIpsetState<'Activate, 'DetectorId, Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#location-1">GuarddutyIpset#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, Missing, 'Name>, value: string) : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#name-1">GuarddutyIpset#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, Missing>, value: string) : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#id-1">GuarddutyIpset#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>, value: string) : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#tags-1">GuarddutyIpset#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>, value: seq<string * string>) : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_ipset#tags_all-1">GuarddutyIpset#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>, value: seq<string * string>) : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GuarddutyIpsetState<'Activate, 'DetectorId, 'Format, 'Location, 'Name>

        member _.Run(state: GuarddutyIpsetState<Present, Present, Present, Present, Present>) : aws.GuarddutyIpset.GuarddutyIpset =
            let config = aws.GuarddutyIpset.GuarddutyIpsetConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyIpset.GuarddutyIpset(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyIpset: missing required arguments. Must call: activate, detector_id, format, location, name.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyIpsetState<_, _, _, _, _>) : aws.GuarddutyIpset.GuarddutyIpset =
            Unchecked.defaultof<aws.GuarddutyIpset.GuarddutyIpset>
