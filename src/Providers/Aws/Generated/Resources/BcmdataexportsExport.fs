namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BcmdataexportsExportState = { assignments: ResizeArray<aws.BcmdataexportsExport.BcmdataexportsExportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export">aws_bcmdataexports_export</a>.
    /// </summary>
    type BcmdataexportsExportBuilder(logicalId: string) =
        member _.Yield(_: unit) : BcmdataexportsExportState =
            { assignments = ResizeArray() }

        member _.Zero(()) : BcmdataexportsExportState =
            { assignments = ResizeArray() }

        /// <summary>
        /// export block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#export-1">BcmdataexportsExport#export</a> Accepts: aws.IResolvable | aws.BcmdataexportsExport.BcmdataexportsExportExport[]
        /// </summary>
        [<CustomOperation "export">]
        member _.Export(state: BcmdataexportsExportState, value: HashiCorp.Cdktf.IResolvable) : BcmdataexportsExportState =
            state.assignments.Add(fun config -> config.Export <- value)
            state : BcmdataexportsExportState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#tags-1">BcmdataexportsExport#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BcmdataexportsExportState, value: seq<string * string>) : BcmdataexportsExportState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BcmdataexportsExportState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bcmdataexports_export#timeouts-1">BcmdataexportsExport#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BcmdataexportsExportState, value: aws.BcmdataexportsExport.BcmdataexportsExportTimeouts) : BcmdataexportsExportState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BcmdataexportsExportState

        member _.Run(state: BcmdataexportsExportState) : aws.BcmdataexportsExport.BcmdataexportsExport =
            let config = aws.BcmdataexportsExport.BcmdataexportsExportConfig()
            for setter in state.assignments do
                setter config
            aws.BcmdataexportsExport.BcmdataexportsExport(StackContext.get (), logicalId, config)
