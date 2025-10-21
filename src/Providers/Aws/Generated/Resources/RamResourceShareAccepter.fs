namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RamResourceShareAccepterState<'ShareArn> = { assignments: ResizeArray<aws.RamResourceShareAccepter.RamResourceShareAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share_accepter">aws_ram_resource_share_accepter</a>.
    /// </summary>
    type RamResourceShareAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : RamResourceShareAccepterState<Missing> =
            ({ assignments = ResizeArray() } : RamResourceShareAccepterState<Missing>)

        member _.Zero(()) : RamResourceShareAccepterState<Missing> =
            ({ assignments = ResizeArray() } : RamResourceShareAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share_accepter#share_arn-1">RamResourceShareAccepter#share_arn</a>.
        /// </summary>
        [<CustomOperation "share_arn">]
        member _.ShareArn(state: RamResourceShareAccepterState<Missing>, value: string) : RamResourceShareAccepterState<Present> =
            state.assignments.Add(fun config -> config.ShareArn <- value)
            ({ assignments = state.assignments } : RamResourceShareAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share_accepter#id-1">RamResourceShareAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RamResourceShareAccepterState<'ShareArn>, value: string) : RamResourceShareAccepterState<'ShareArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RamResourceShareAccepterState<'ShareArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_resource_share_accepter#timeouts-1">RamResourceShareAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RamResourceShareAccepterState<'ShareArn>, value: aws.RamResourceShareAccepter.RamResourceShareAccepterTimeouts) : RamResourceShareAccepterState<'ShareArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RamResourceShareAccepterState<'ShareArn>

        member _.Run(state: RamResourceShareAccepterState<Present>) : aws.RamResourceShareAccepter.RamResourceShareAccepter =
            let config = aws.RamResourceShareAccepter.RamResourceShareAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.RamResourceShareAccepter.RamResourceShareAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ramResourceShareAccepter: missing required arguments. Must call: share_arn.", 9999, IsError = true)>]
        member _.Run(_: RamResourceShareAccepterState<_>) : aws.RamResourceShareAccepter.RamResourceShareAccepter =
            Unchecked.defaultof<aws.RamResourceShareAccepter.RamResourceShareAccepter>
