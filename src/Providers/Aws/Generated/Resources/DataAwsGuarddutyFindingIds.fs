namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsGuarddutyFindingIdsState<'DetectorId> = { assignments: ResizeArray<aws.DataAwsGuarddutyFindingIds.DataAwsGuarddutyFindingIdsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/guardduty_finding_ids">aws_guardduty_finding_ids</a>.
    /// </summary>
    type DataAwsGuarddutyFindingIdsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsGuarddutyFindingIdsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGuarddutyFindingIdsState<Missing>)

        member _.Zero(()) : DataAwsGuarddutyFindingIdsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsGuarddutyFindingIdsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/guardduty_finding_ids#detector_id-1">DataAwsGuarddutyFindingIds#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: DataAwsGuarddutyFindingIdsState<Missing>, value: string) : DataAwsGuarddutyFindingIdsState<Present> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : DataAwsGuarddutyFindingIdsState<Present>)

        member _.Run(state: DataAwsGuarddutyFindingIdsState<Present>) : aws.DataAwsGuarddutyFindingIds.DataAwsGuarddutyFindingIds =
            let config = aws.DataAwsGuarddutyFindingIds.DataAwsGuarddutyFindingIdsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsGuarddutyFindingIds.DataAwsGuarddutyFindingIds(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsGuarddutyFindingIds: missing required arguments. Must call: detector_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsGuarddutyFindingIdsState<_>) : aws.DataAwsGuarddutyFindingIds.DataAwsGuarddutyFindingIds =
            Unchecked.defaultof<aws.DataAwsGuarddutyFindingIds.DataAwsGuarddutyFindingIds>
