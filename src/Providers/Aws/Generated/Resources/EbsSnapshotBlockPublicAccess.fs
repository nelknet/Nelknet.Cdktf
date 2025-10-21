namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EbsSnapshotBlockPublicAccessState<'State> = { assignments: ResizeArray<aws.EbsSnapshotBlockPublicAccess.EbsSnapshotBlockPublicAccessConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_block_public_access">aws_ebs_snapshot_block_public_access</a>.
    /// </summary>
    type EbsSnapshotBlockPublicAccessBuilder(logicalId: string) =
        member _.Yield(_: unit) : EbsSnapshotBlockPublicAccessState<Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotBlockPublicAccessState<Missing>)

        member _.Zero(()) : EbsSnapshotBlockPublicAccessState<Missing> =
            ({ assignments = ResizeArray() } : EbsSnapshotBlockPublicAccessState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_block_public_access#state-1">EbsSnapshotBlockPublicAccess#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: EbsSnapshotBlockPublicAccessState<Missing>, value: string) : EbsSnapshotBlockPublicAccessState<Present> =
            state.assignments.Add(fun config -> config.State <- value)
            ({ assignments = state.assignments } : EbsSnapshotBlockPublicAccessState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ebs_snapshot_block_public_access#id-1">EbsSnapshotBlockPublicAccess#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EbsSnapshotBlockPublicAccessState<'State>, value: string) : EbsSnapshotBlockPublicAccessState<'State> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EbsSnapshotBlockPublicAccessState<'State>

        member _.Run(state: EbsSnapshotBlockPublicAccessState<Present>) : aws.EbsSnapshotBlockPublicAccess.EbsSnapshotBlockPublicAccess =
            let config = aws.EbsSnapshotBlockPublicAccess.EbsSnapshotBlockPublicAccessConfig()
            for setter in state.assignments do
                setter config
            aws.EbsSnapshotBlockPublicAccess.EbsSnapshotBlockPublicAccess(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ebsSnapshotBlockPublicAccess: missing required arguments. Must call: state.", 9999, IsError = true)>]
        member _.Run(_: EbsSnapshotBlockPublicAccessState<_>) : aws.EbsSnapshotBlockPublicAccess.EbsSnapshotBlockPublicAccess =
            Unchecked.defaultof<aws.EbsSnapshotBlockPublicAccess.EbsSnapshotBlockPublicAccess>
